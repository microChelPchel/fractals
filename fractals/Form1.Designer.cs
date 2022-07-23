namespace fractals
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("FractalTree");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("FractalTriangle");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Fractal figurs", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNameSetting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "SlavesFractalTree";
            treeNode1.Text = "FractalTree";
            treeNode2.Name = "SlavesFractalTriangle";
            treeNode2.Text = "FractalTriangle";
            treeNode3.Name = "MasterFractal";
            treeNode3.Text = "Fractal figurs";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(319, 311);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNameSetting);
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 409);
            this.panel1.TabIndex = 2;
            // 
            // labelNameSetting
            // 
            this.labelNameSetting.AutoSize = true;
            this.labelNameSetting.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSetting.Location = new System.Drawing.Point(97, 3);
            this.labelNameSetting.Name = "labelNameSetting";
            this.labelNameSetting.Size = new System.Drawing.Size(89, 28);
            this.labelNameSetting.TabIndex = 0;
            this.labelNameSetting.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(325, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 777);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 777);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNameSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

