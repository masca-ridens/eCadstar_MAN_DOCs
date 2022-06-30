
namespace eCadstar_MAN_DOCs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tbSchematicPath = new System.Windows.Forms.TextBox();
            this.bSchematic = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPcbaNo = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPCBA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bLibrary = new System.Windows.Forms.Button();
            this.tbLibraryFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbXypFile = new System.Windows.Forms.TextBox();
            this.bMpns = new System.Windows.Forms.Button();
            this.bPCB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPcbPath = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPcbaNo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SCM Design File";
            // 
            // tbSchematicPath
            // 
            this.tbSchematicPath.Location = new System.Drawing.Point(92, 43);
            this.tbSchematicPath.Name = "tbSchematicPath";
            this.tbSchematicPath.Size = new System.Drawing.Size(523, 20);
            this.tbSchematicPath.TabIndex = 5;
            this.tbSchematicPath.Text = "C:\\Users\\mike.jones\\Documents\\eCadstar\\DESIGNS_local\\A000268-2\\A000268-2.sdes";
            // 
            // bSchematic
            // 
            this.bSchematic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSchematic.Location = new System.Drawing.Point(621, 43);
            this.bSchematic.Name = "bSchematic";
            this.bSchematic.Size = new System.Drawing.Size(31, 22);
            this.bSchematic.TabIndex = 17;
            this.bSchematic.Tag = "Schematic";
            this.bSchematic.Text = "...";
            this.bSchematic.UseVisualStyleBackColor = true;
            this.bSchematic.Click += new System.EventHandler(this.bLibrary_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Create BOM",
            "Create XYP",
            "Create ADR",
            "Create GBR",
            "Create DRILL",
            "Create CDR",
            "Zip CAD docs"});
            this.checkedListBox1.Location = new System.Drawing.Point(92, 186);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 109);
            this.checkedListBox1.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\";
            // 
            // bRun
            // 
            this.bRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRun.Location = new System.Drawing.Point(273, 161);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(321, 143);
            this.bRun.TabIndex = 20;
            this.bRun.Text = "Run";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbOutputFolder);
            this.groupBox1.Location = new System.Drawing.Point(9, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 58);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send generated Manufacturing files to folder...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(535, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 22);
            this.button1.TabIndex = 23;
            this.button1.Tag = "Output";
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Location = new System.Drawing.Point(6, 32);
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(523, 20);
            this.tbOutputFolder.TabIndex = 22;
            this.tbOutputFolder.Text = "C:\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Issue #";
            // 
            // numPcbaNo
            // 
            this.numPcbaNo.Location = new System.Drawing.Point(171, 19);
            this.numPcbaNo.Name = "numPcbaNo";
            this.numPcbaNo.Size = new System.Drawing.Size(50, 20);
            this.numPcbaNo.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPCBA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numPcbaNo);
            this.groupBox2.Location = new System.Drawing.Point(92, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 57);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assembled PCB";
            // 
            // tbPCBA
            // 
            this.tbPCBA.Location = new System.Drawing.Point(16, 19);
            this.tbPCBA.Name = "tbPCBA";
            this.tbPCBA.Size = new System.Drawing.Size(100, 20);
            this.tbPCBA.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPCB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Location = new System.Drawing.Point(355, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 57);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bare PCB";
            // 
            // tbPCB
            // 
            this.tbPCB.Location = new System.Drawing.Point(6, 18);
            this.tbPCB.Name = "tbPCB";
            this.tbPCB.Size = new System.Drawing.Size(100, 20);
            this.tbPCB.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Issue #";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(171, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 25;
            // 
            // bLibrary
            // 
            this.bLibrary.Enabled = false;
            this.bLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLibrary.Location = new System.Drawing.Point(621, 15);
            this.bLibrary.Name = "bLibrary";
            this.bLibrary.Size = new System.Drawing.Size(31, 22);
            this.bLibrary.TabIndex = 15;
            this.bLibrary.Tag = "Library";
            this.bLibrary.Text = "...";
            this.bLibrary.UseVisualStyleBackColor = true;
            this.bLibrary.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLibraryFolder
            // 
            this.tbLibraryFolder.Enabled = false;
            this.tbLibraryFolder.Location = new System.Drawing.Point(92, 15);
            this.tbLibraryFolder.Name = "tbLibraryFolder";
            this.tbLibraryFolder.Size = new System.Drawing.Size(523, 20);
            this.tbLibraryFolder.TabIndex = 0;
            this.tbLibraryFolder.Text = "\\\\server-fs\\eCadstar\\Library\\GI_Library";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts Library";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.tbXypFile);
            this.groupBox4.Controls.Add(this.bMpns);
            this.groupBox4.Location = new System.Drawing.Point(13, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 51);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Manufacurer\'s part numbers to XYP";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(531, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 22);
            this.button3.TabIndex = 34;
            this.button3.Tag = "MPN";
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bLibrary_Click);
            // 
            // tbXypFile
            // 
            this.tbXypFile.Location = new System.Drawing.Point(88, 22);
            this.tbXypFile.Name = "tbXypFile";
            this.tbXypFile.Size = new System.Drawing.Size(437, 20);
            this.tbXypFile.TabIndex = 1;
            this.tbXypFile.Text = "C:\\";
            // 
            // bMpns
            // 
            this.bMpns.Location = new System.Drawing.Point(7, 20);
            this.bMpns.Name = "bMpns";
            this.bMpns.Size = new System.Drawing.Size(75, 23);
            this.bMpns.TabIndex = 0;
            this.bMpns.Text = "+ MPNs";
            this.bMpns.UseVisualStyleBackColor = true;
            this.bMpns.Click += new System.EventHandler(this.bMpns_Click);
            // 
            // bPCB
            // 
            this.bPCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPCB.Location = new System.Drawing.Point(621, 72);
            this.bPCB.Name = "bPCB";
            this.bPCB.Size = new System.Drawing.Size(31, 22);
            this.bPCB.TabIndex = 36;
            this.bPCB.Tag = "PCB";
            this.bPCB.Text = "...";
            this.bPCB.UseVisualStyleBackColor = true;
            this.bPCB.Click += new System.EventHandler(this.bLibrary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "PCB Design File";
            // 
            // tbPcbPath
            // 
            this.tbPcbPath.Location = new System.Drawing.Point(92, 72);
            this.tbPcbPath.Name = "tbPcbPath";
            this.tbPcbPath.Size = new System.Drawing.Size(523, 20);
            this.tbPcbPath.TabIndex = 34;
            this.tbPcbPath.Text = "C:\\Users\\mike.jones\\Documents\\eCadstar\\DESIGNS_local\\PCB\\A000268-2.pdes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.bPCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPcbPath);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.bSchematic);
            this.Controls.Add(this.bLibrary);
            this.Controls.Add(this.tbSchematicPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLibraryFolder);
            this.Name = "Form1";
            this.Text = "Generate Manufacturing files from eCadstar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPcbaNo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSchematicPath;
        private System.Windows.Forms.Button bSchematic;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOutputFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPcbaNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbPCBA;
        private System.Windows.Forms.TextBox tbPCB;
        private System.Windows.Forms.Button bLibrary;
        private System.Windows.Forms.TextBox tbLibraryFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bMpns;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbXypFile;
        private System.Windows.Forms.Button bPCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPcbPath;
    }
}

