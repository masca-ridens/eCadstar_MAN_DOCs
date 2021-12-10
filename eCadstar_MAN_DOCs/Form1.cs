using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eCSPCBCOM;

namespace eCadstar_MAN_DOCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Run_Click(object sender, EventArgs e)
        {
            // Create datatables for the PARTs and COMPONENT data...

            DataTable dtParts = new DataTable();
            DataTable dtComponents = new DataTable();
            //        dtParts.Columns.AddRange(new[]
            //{
            //    new DataColumn("Name", typeof(string)),
            //    new DataColumn("Reference", typeof(string)),
            //});

            PCBApplication pcbEditor = null;
            try
            {
                pcbEditor = Marshal.GetActiveObject("eCADSTAR.PCBEditor.Application") as PCBApplication;
            }
            catch (COMException ex)
            {
                pcbEditor = new PCBApplication();
                pcbEditor.OpenDesign(tbPcbPath.Text);
            }

            //-----------------------------------------------------------------------------//
            //---------------------- Fetch all COMPONENTS --------------------------------------//
            //-----------------------------------------------------------------------------//

            // (A COMPONENT is an instance of a PART, so it has a reference designator)

            //MessageBox.Show("There are " + pcbEditor.CurrentDesign.Components.Count.ToString() + " components.");

            foreach (PCBComponent component in pcbEditor.CurrentDesign.Components)
            {
                var properties = component.Properties.Cast<IProperty>().ToDictionary(x => x.Name, x => x.Value);

                foreach (KeyValuePair<string, string> prop in properties)
                {
                    if (!dtComponents.Columns.Contains(prop.Key))
                    {
                        dtComponents.Columns.Add(prop.Key);
                    }
                }

                dtComponents.Rows.Add(properties.Values.ToArray());
                //foreach (eCSPCBCOM.IProperty property in component.Properties)
                //{
                //    Console.WriteLine(property.Name + " : " + property.Value);
                //}
            }

            //-----------------------------------------------------------------------------//
            //---------------------- Fetch all PARTS --------------------------------------//
            //-----------------------------------------------------------------------------//

            //MessageBox.Show("There are " + pcbEditor.CurrentDesign.Parts.Count.ToString() + " parts.");
            //foreach (PCBPart part in pcbEditor.CurrentDesign.Parts)
            //{
            //    dtParts.Rows.Add(part);
            //    //foreach (eCSPCBCOM.IProperty property in component.Properties)
            //    //{
            //    //    Console.WriteLine(property.Name + " : " + property.Value);
            //    //}
            //    var properties = part.Properties.Cast<IProperty>().ToDictionary(x => x.Name, x => x.Value);
            //}
            pcbEditor.Quit();
        }
    }
}
