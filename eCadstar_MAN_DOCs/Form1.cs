﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using eCSPCBCOM;
using eCSSCHCOM;
using System.IO;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace eCadstar_MAN_DOCs
{
    public partial class Form1 : Form
    {
        readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOutputFolder.Text = desktopPath;

            //---------------------------------------------------------------------------//
            //------------------Fetch previously used paths from the Registry-----------//
            //---------------------------------------------------------------------------//

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MySettings");
            if (key != null)
            {
                if (key.GetValueNames().Contains("Library path"))
                {
                    string libraryPath = key.GetValue("Library path").ToString();
                    tbLibraryFolder.Text = libraryPath;
                }

                if (key.GetValueNames().Contains("PCB path"))
                {
                    string pcbPath = key.GetValue("PCB path").ToString();
                    tbPcbPath.Text = pcbPath;
                }

                if (key.GetValueNames().Contains("Schematic path"))
                {
                    string schematicPath = key.GetValue("Schematic path").ToString();
                    tbSchematicPath.Text = schematicPath;
                }

                if (key.GetValueNames().Contains("Output path"))
                {
                    string outputPath = key.GetValue("Output path").ToString();
                    tbOutputFolder.Text = outputPath;
                }

                if (key.GetValueNames().Contains("PCBA"))
                {
                    string pcba = key.GetValue("PCBA").ToString();
                    tbPCBA.Text = pcba;
                }

                if (key.GetValueNames().Contains("PCB"))
                {
                    string pcb = key.GetValue("PCB").ToString();
                    tbPCB.Text = pcb;
                }

                if (key.GetValueNames().Contains("PCBA issue"))
                {
                    string issue_a = key.GetValue("PCBA issue").ToString();
                    if (decimal.TryParse(issue_a, out decimal result))
                    {
                        numericUpDown1.Value = result;
                    }
                }

                if (key.GetValueNames().Contains("PCB issue"))
                {
                    string issue_p = key.GetValue("PCB issue").ToString();
                    if (decimal.TryParse(issue_p, out decimal result))
                    {
                        numericUpDown2.Value = result;
                    }
                }
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------------//
            //----------------------------- Pre-flight checks ----------------------------//
            //----------------------------------------------------------------------------//

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Nothing selected");
                return;
            }
            if (!File.Exists(tbPcbPath.Text))
            {
                MessageBox.Show("PCB design file not found");
                return;
            }

            if (!File.Exists(tbSchematicPath.Text))
            {
                MessageBox.Show("Schematic design file not found");
                return;
            }

            if (!Directory.Exists(tbLibraryFolder.Text))
            {
                MessageBox.Show("Library not found");
                return;
            }
            bRun.Enabled = false;

            // Create datatables for the PARTs and COMPONENT data...

            DataTable dtParts = new DataTable();
            DataTable dtComponents = new DataTable();
            DataTable dtSymbols = new DataTable();

            dtComponents.Columns.Add("Reference_designator");
            dtComponents.Columns.Add("Part_name");
            dtComponents.Columns.Add("x_coordinate");
            dtComponents.Columns.Add("y_coordinate");
            dtComponents.Columns.Add("Angle");
            dtComponents.Columns.Add("Placement_side");
            dtComponents.Columns.Add("isJumper");
            dtComponents.Columns.Add("isStarpoint");

            //-----------------------------------------------------------------------------//
            //---------------------- Open the eCadstar PCB --------------------------------//
            //-----------------------------------------------------------------------------//

            PCBApplication pcbEditor = null;
            bool alreadyOpenPCB = false;
            try
            {
                pcbEditor = Marshal.GetActiveObject("eCADSTAR.PCBEditor.Application") as PCBApplication;
                alreadyOpenPCB = true;
            }
            catch (COMException ex)
            {
                pcbEditor = new PCBApplication();
                pcbEditor.OpenDesign(tbPcbPath.Text);
            }

            //-----------------------------------------------------------------------------//
            //---------------------- Fetch all COMPONENTS ---------------------------------//
            //-----------------------------------------------------------------------------//
            //   (A COMPONENT is an instance of a PART, so it has a reference designator)  //
            //-----------------------------------------------------------------------------//

            toolStripStatusLabel1.Text = "There are " + pcbEditor.CurrentDesign.Components.Count.ToString() + " PCB components.";

            // Scan every part so that a column exists in the datatable when required...

            foreach (PCBComponent component in pcbEditor.CurrentDesign.Components)
            {
                var properties = component.Properties.Cast<eCSPCBCOM.IProperty>().ToDictionary(x => x.Name, x => x.Value);

                foreach (KeyValuePair<string, string> prop in properties)
                {
                    if (!dtComponents.Columns.Contains(prop.Key))
                    {
                        dtComponents.Columns.Add(prop.Key);
                    }
                }
                // (Must be very robust and use the long-winded way!)

                DataRow dr = dtComponents.NewRow();

                dr["Reference_designator"] = component.ReferenceDesignator;
                dr["Part_Name"] = component.PartName;
                dr["x_coordinate"] = component.CoordinateX.ToString();
                dr["y_coordinate"] = component.CoordinateY.ToString();
                dr["Angle"] = component.Angle.ToString();
                dr["Placement_side"] = component.PlacementSide;
                dr["isJumper"] = component.IsJumper.ToString();
                dr["isStarpoint"] = component.IsStarpoint.ToString();

                foreach (KeyValuePair<string, string> prop in properties)
                {
                    dr[prop.Key] = prop.Value;
                }

                dtComponents.Rows.Add(dr);
            }
            if (!alreadyOpenPCB)
            {
                pcbEditor.Quit();
            }

            //-----------------------------------------------------------------------------//
            //---------------------- Open the eCadstar SCM --------------------------------//
            //-----------------------------------------------------------------------------//

            SchApplication scmEditor = null;
            bool alreadyOpenSchematic = false;

            try
            {
                scmEditor = Marshal.GetActiveObject("eCADSTAR.SchematicEditor.Application") as SchApplication;
                alreadyOpenSchematic = true;
            }
            catch (COMException ex)
            {
                scmEditor = new SchApplication();
                scmEditor.OpenDesign(tbSchematicPath.Text);
            }

            //-----------------------------------------------------------------------------//
            //------------------------- Fetch all SYMBOLS ---------------------------------//
            //-----------------------------------------------------------------------------//

            foreach (SchComponent component in scmEditor.Design.Components)
            {
                if (string.IsNullOrEmpty(component.ReferenceDesignator)) continue;      // reject GND symbols etc.

                var properties = component.Properties.Cast<eCSSCHCOM.IProperty>().ToDictionary(x => x.Name, x => x.Value);

                foreach (KeyValuePair<string, string> prop in properties)
                {
                    if (!dtSymbols.Columns.Contains(prop.Key))
                    {
                        dtSymbols.Columns.Add(prop.Key);
                    }
                }

                DataRow dr = dtSymbols.NewRow();

                foreach (KeyValuePair<string, string> prop in properties)
                {
                    dr[prop.Key] = prop.Value;
                }

                dtSymbols.Rows.Add(dr);
            }

            if (!alreadyOpenSchematic)
            {
                scmEditor.Quit();
            }

            toolStripStatusLabel1.Text += " and " + dtSymbols.Rows.Count + " schematic symbols.";

            //---------------------------------------------------------------------------------//
            //------------------- Check SCM and PCB are mutually consistent--------------------//
            //---------------------------------------------------------------------------------//

            IEnumerable<string> idsInPCB = dtComponents.AsEnumerable().Select(row => (string)row["Reference_designator"]);
            IEnumerable<string> idsInSchematic = dtSymbols.AsEnumerable().Select(row => (string)row["Reference Designator"]);
            List<string> sNotP = idsInSchematic.Except(idsInPCB).ToList();
            List<string> pNotS = idsInPCB.Except(idsInSchematic).ToList();

            // If there's FIDs then ignore; if not then flag as a problem
            List<int> indices = FindAllIndices(ref pNotS, "FID");
            if (indices.Count < 2)
            {
                MessageBox.Show("No Fiducial pair found while searching the PCB for \"FIDxy\". Abandoning.", "Problem found...");
                Application.Exit();
            }
            if (sNotP.Count > 0 || pNotS.Count > 0)
            {
                MessageBox.Show("PCB only: " + string.Join(",", pNotS) + Environment.NewLine +
                    "SCM only: " + string.Join(",", sNotP + Environment.NewLine +
                    "CONTINUE ANYWAY?"), "Inconsistencies found...", MessageBoxButtons.YesNo);
            }

            //------------------------------------------------------------------------------------//
            //                      Create an XYP file?                                           //
            //------------------------------------------------------------------------------------//

            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {

                //---------------------------------------------------------------------------------//
                //------------------- Stitch together the required data for each XYROT item--------//
                //---------------------------------------------------------------------------------//

                List<string> lines = new List<string>();
                string assemblyNo = tbPCBA.Text;

                foreach (DataRow row in dtComponents.Rows)
                {
                    // Reject non-DDM parts, except the FID's...
                    if (!row["Reference_designator"].ToString().StartsWith("FID"))
                    {
                        if (row["Ddm_Part"].ToString() == "No") continue;

                        // Reject NO-FIT parts...

                        string refDes = row["Reference_designator"].ToString();

                        DataRow symbolRow = dtSymbols.AsEnumerable()
                       .First(r => r.Field<string>("Reference Designator") == refDes);

                        bool notFitted = symbolRow["Fitted"].ToString() == "No";
                        if (notFitted)
                        {
                            continue;
                        }
                    }

                    List<string> temporaryList = new List<string>()
                {
                    row["Reference_designator"].ToString().PadRight(20, ' '),
                    row["Part_name"].ToString().PadRight(20, ' '),
                    row["X_coordinate"].ToString().PadRight(20, ' '),
                    row["Y_coordinate"].ToString().PadRight(20, ' '),
                    row["Angle"].ToString().PadRight(20, ' '),
                    row["Placement_side"].ToString()
                };

                    lines.Add(string.Join("", temporaryList.ToArray()));
                }

                // Order the data alphanumerically (properly!)...
                List<string> result = lines.OrderBy(x => PadNumbers(x)).ToList();

                // Move the Fiducials to the top...
                // (quite complicated!)
                int index1 = result.FindIndex(x => x.StartsWith("FID"));
                if (index1 > 0)
                {
                    var observable = new ObservableCollection<string>(result);
                    observable.Move(index1, 0);
                    result = observable.ToList();

                    int index2 = result.FindLastIndex(x => x.StartsWith("FID"));
                    if (index2 > 0)
                    {
                        observable = new ObservableCollection<string>(result);
                        observable.Move(index2, 0);
                        result = observable.ToList();
                    }
                }
                result.Insert(2, string.Empty);

                // Create a header...
                List<string> header = new List<string>()
            {
                "DESIGN: " + assemblyNo + "   " + DateTime.Now,
                string.Empty,
                "Reference".PadRight(20, ' ') + "Part".PadRight(20, ' ') + "x".PadRight(20, ' ') + "y".PadRight(20, ' ') + "Angle".PadRight(20, ' ') + "Side",
                string.Empty
            };

                File.WriteAllLines(Path.Combine(tbOutputFolder.Text, assemblyNo + "-" + numericUpDown1.Value.ToString() + "-XYP.txt"), header);
                File.AppendAllLines(Path.Combine(tbOutputFolder.Text, assemblyNo + "-" + numericUpDown1.Value.ToString() + "-XYP.txt"), result);
            }

            //------------------------------------------------------------------------------------//
            //                      Create a DDM BOM file?                                        //
            //------------------------------------------------------------------------------------//

            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                List<string> lines = new List<string>();
                string assemblyNo = tbPCBA.Text;
                string pcbNumber = tbPCB.Text;

                lines.Add(assemblyNo);
                lines.Add(DateTime.Now.ToShortDateString());
                lines.Add(string.Empty);
                lines.Add("Part Name");
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                lines.Add(string.Empty);
                lines.Add(string.Empty);

                foreach (DataRow row in dtComponents.Rows)
                {
                    // Reject non-DDM parts, except the FID's...
                    if (!row["Reference_designator"].ToString().StartsWith("FID"))
                    {
                        if (row["Ddm_Part"].ToString() == "No") continue;

                        // Reject NO-FIT parts...

                        string refDes = row["Reference_designator"].ToString();

                        DataRow symbolRow = dtSymbols.AsEnumerable()
                       .First(r => r.Field<string>("Reference Designator") == refDes);

                        bool notFitted = symbolRow["Fitted"].ToString() == "No";
                        if (notFitted)
                        {
                            continue;
                        }
                        lines.Add(row["Part_name"].ToString());
                        lines.Add(string.Empty);
                        lines.Add(row["Reference_designator"].ToString());
                        lines.Add("SMT");
                        lines.Add(string.Empty);
                        lines.Add(string.Empty);
                    }
                }

                File.AppendAllLines(Path.Combine(tbOutputFolder.Text, assemblyNo + "-" + numericUpDown1.Value.ToString() + "-BOM.txt"), lines);
            }
            bRun.Enabled = true;
        }

        public static List<int> FindAllIndices(ref List<string> myList, string match, int maxNumber = 2)
        {
            // Return all indices strarting with a given substring...
            List<int> indices = new List<int>();
            int index = 999;

            for (int i = 0; i < maxNumber; i++)
            {
                index = myList.FindIndex(a => a.StartsWith(match));
                if (index > -1)
                {
                    myList.RemoveAt(index);
                    indices.Add(index + i);
                }
                else return indices;
            }
            return indices;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //access the CurrentUser root element  
            //and add "MySettings" subkey to the "SOFTWARE" subkey  
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MySettings");

            //storing the values  
            key.SetValue("Library path", tbLibraryFolder.Text);
            key.SetValue("PCB path", tbPcbPath.Text);
            key.SetValue("Schematic path", tbSchematicPath.Text);
            key.SetValue("Output path", tbOutputFolder.Text);
            key.SetValue("PCBA", tbPCBA.Text);
            key.SetValue("PCB", tbPCB.Text);
            key.SetValue("PCBA issue", numericUpDown1.Value.ToString());
            key.SetValue("PCB issue", numericUpDown2.Value.ToString());
            key.Close();
        }

        private void bLibrary_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            {
                switch (b.Tag.ToString())
                {
                    case "Schematic":
                        {
                            openFileDialog1.Filter = "Schematic files (*.sdes)|*.sdes";
                            break;
                        }
                    case "PCB":
                        {
                            openFileDialog1.Filter = "PCB files (*.pdes)|*.pdes";
                            break;
                        }
                }

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (b.Tag.ToString() == "Schematic") tbSchematicPath.Text = openFileDialog1.FileName;
                    else tbPcbPath.Text = openFileDialog1.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                switch (b.Tag.ToString())
                {
                    case "Library":
                        {
                            tbLibraryFolder.Text = folderBrowserDialog1.SelectedPath;
                            break;
                        }
                    case "Output":
                        {
                            tbOutputFolder.Text = folderBrowserDialog1.SelectedPath;
                            break;
                        }
                }

            }
        }
        private static string PadNumbers(string input)
        {
            return Regex.Replace(input, "[0-9]+", match => match.Value.PadLeft(10, '0'));
        }
    }
}
