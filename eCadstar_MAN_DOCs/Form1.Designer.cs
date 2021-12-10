
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
            this.tbLibraryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPcbPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSchematicPath = new System.Windows.Forms.TextBox();
            this.bLibrary = new System.Windows.Forms.Button();
            this.bPCB = new System.Windows.Forms.Button();
            this.bSchematic = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Run = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLibraryPath
            // 
            this.tbLibraryPath.Location = new System.Drawing.Point(92, 15);
            this.tbLibraryPath.Name = "tbLibraryPath";
            this.tbLibraryPath.Size = new System.Drawing.Size(523, 20);
            this.tbLibraryPath.TabIndex = 0;
            this.tbLibraryPath.Text = "\\\\server-fs\\eCadstar\\Library\\GI_Library";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PCB Design File";
            // 
            // tbPcbPath
            // 
            this.tbPcbPath.Location = new System.Drawing.Point(92, 41);
            this.tbPcbPath.Name = "tbPcbPath";
            this.tbPcbPath.Size = new System.Drawing.Size(523, 20);
            this.tbPcbPath.TabIndex = 2;
            this.tbPcbPath.Text = "C:\\Users\\mike.jones\\Documents\\eCadstar designs\\DPH34\\_PCB\\DPH34_3DEC\\DPH34_3Dec.p" +
    "des";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SCM Design File";
            // 
            // tbSchematicPath
            // 
            this.tbSchematicPath.Location = new System.Drawing.Point(92, 67);
            this.tbSchematicPath.Name = "tbSchematicPath";
            this.tbSchematicPath.Size = new System.Drawing.Size(523, 20);
            this.tbSchematicPath.TabIndex = 5;
            this.tbSchematicPath.Text = "\\\\server-fs\\eCadstar\\Library\\GI_Library";
            // 
            // bLibrary
            // 
            this.bLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLibrary.Location = new System.Drawing.Point(621, 15);
            this.bLibrary.Name = "bLibrary";
            this.bLibrary.Size = new System.Drawing.Size(31, 22);
            this.bLibrary.TabIndex = 15;
            this.bLibrary.Text = "...";
            this.bLibrary.UseVisualStyleBackColor = true;
            // 
            // bPCB
            // 
            this.bPCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPCB.Location = new System.Drawing.Point(621, 41);
            this.bPCB.Name = "bPCB";
            this.bPCB.Size = new System.Drawing.Size(31, 22);
            this.bPCB.TabIndex = 16;
            this.bPCB.Text = "...";
            this.bPCB.UseVisualStyleBackColor = true;
            // 
            // bSchematic
            // 
            this.bSchematic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSchematic.Location = new System.Drawing.Point(621, 67);
            this.bSchematic.Name = "bSchematic";
            this.bSchematic.Size = new System.Drawing.Size(31, 22);
            this.bSchematic.TabIndex = 17;
            this.bSchematic.Text = "...";
            this.bSchematic.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Create XYP file",
            "Create DDM BOM"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 107);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 79);
            this.checkedListBox1.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.Location = new System.Drawing.Point(600, 107);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(200, 318);
            this.Run.TabIndex = 20;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.bSchematic);
            this.Controls.Add(this.bPCB);
            this.Controls.Add(this.bLibrary);
            this.Controls.Add(this.tbSchematicPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPcbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLibraryPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibraryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPcbPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSchematicPath;
        private System.Windows.Forms.Button bLibrary;
        private System.Windows.Forms.Button bPCB;
        private System.Windows.Forms.Button bSchematic;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Run;
    }
}

