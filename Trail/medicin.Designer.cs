namespace Trail
{
    partial class medicin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicin));
            this.med = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pid = new System.Windows.Forms.ComboBox();
            this.pidl = new System.Windows.Forms.Label();
            this.coast = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.med)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // med
            // 
            this.med.BackgroundColor = System.Drawing.Color.White;
            this.med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.med.Location = new System.Drawing.Point(1, 124);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(844, 230);
            this.med.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 30);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.AutoSize = false;
            this.backToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // pid
            // 
            this.pid.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pid.FormattingEnabled = true;
            this.pid.Location = new System.Drawing.Point(334, 63);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(247, 29);
            this.pid.TabIndex = 56;
            this.pid.SelectedIndexChanged += new System.EventHandler(this.pid_SelectedIndexChanged);
            // 
            // pidl
            // 
            this.pidl.BackColor = System.Drawing.Color.Transparent;
            this.pidl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.pidl.Location = new System.Drawing.Point(180, 66);
            this.pidl.Name = "pidl";
            this.pidl.Size = new System.Drawing.Size(136, 23);
            this.pidl.TabIndex = 57;
            this.pidl.Text = "Select Patient-Id";
            // 
            // coast
            // 
            this.coast.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.coast.Location = new System.Drawing.Point(367, 380);
            this.coast.Name = "coast";
            this.coast.Size = new System.Drawing.Size(171, 29);
            this.coast.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(396, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 59;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cl
            // 
            this.cl.BackColor = System.Drawing.Color.Transparent;
            this.cl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cl.Location = new System.Drawing.Point(180, 380);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(136, 23);
            this.cl.TabIndex = 60;
            this.cl.Text = "Enter Total Coast";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(391, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 34);
            this.button2.TabIndex = 61;
            this.button2.Text = "updateMedicin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "Medicin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medicin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coast);
            this.Controls.Add(this.pidl);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.med);
            this.Name = "medicin";
            this.Size = new System.Drawing.Size(847, 497);
            ((System.ComponentModel.ISupportInitialize)(this.med)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView med;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ComboBox pid;
        private System.Windows.Forms.Label pidl;
        private System.Windows.Forms.TextBox coast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
