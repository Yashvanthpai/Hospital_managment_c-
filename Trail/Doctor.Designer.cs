namespace Trail
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.did = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.datalabel = new System.Windows.Forms.Label();
            this.dpl = new System.Windows.Forms.Label();
            this.dpid = new System.Windows.Forms.TextBox();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(195, 311);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(423, 30);
            this.label.TabIndex = 30;
            this.label.Text = "Welcome City Hospital to Doctor Portal...";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doctor_Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Doctor-Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dname
            // 
            this.dname.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.Location = new System.Drawing.Point(573, 165);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(164, 25);
            this.dname.TabIndex = 24;
            this.dname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // did
            // 
            this.did.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.did.Location = new System.Drawing.Point(206, 167);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(164, 25);
            this.did.TabIndex = 23;
            this.did.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(45, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 4);
            this.label1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(45, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(700, 4);
            this.label3.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.appointmentRequestToolStripMenuItem,
            this.treatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.AutoSize = false;
            this.backToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.backToolStripMenuItem.Text = "LOG-OUT";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.AutoSize = false;
            this.profileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.profileToolStripMenuItem.Text = "profile update";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // appointmentRequestToolStripMenuItem
            // 
            this.appointmentRequestToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.appointmentRequestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.appointmentRequestToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.appointmentRequestToolStripMenuItem.Name = "appointmentRequestToolStripMenuItem";
            this.appointmentRequestToolStripMenuItem.Size = new System.Drawing.Size(155, 21);
            this.appointmentRequestToolStripMenuItem.Text = "Appointment-Request";
            this.appointmentRequestToolStripMenuItem.Click += new System.EventHandler(this.appointmentRequestToolStripMenuItem_Click);
            // 
            // treatToolStripMenuItem
            // 
            this.treatToolStripMenuItem.AutoSize = false;
            this.treatToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.treatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.treatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.treatToolStripMenuItem.Name = "treatToolStripMenuItem";
            this.treatToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.treatToolStripMenuItem.Text = "Treat";
            this.treatToolStripMenuItem.Click += new System.EventHandler(this.treatToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(652, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Want info about Patient ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(608, 178);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(46, 35);
            this.next.TabIndex = 64;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // datalabel
            // 
            this.datalabel.BackColor = System.Drawing.Color.Transparent;
            this.datalabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalabel.ForeColor = System.Drawing.Color.Black;
            this.datalabel.Location = new System.Drawing.Point(202, 85);
            this.datalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(418, 32);
            this.datalabel.TabIndex = 63;
            this.datalabel.Text = "Patient Information";
            this.datalabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpl
            // 
            this.dpl.BackColor = System.Drawing.Color.White;
            this.dpl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpl.ForeColor = System.Drawing.Color.Blue;
            this.dpl.Location = new System.Drawing.Point(163, 178);
            this.dpl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dpl.Name = "dpl";
            this.dpl.Size = new System.Drawing.Size(165, 32);
            this.dpl.TabIndex = 62;
            this.dpl.Text = "Enter PatientId:";
            this.dpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpid
            // 
            this.dpid.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dpid.Location = new System.Drawing.Point(346, 178);
            this.dpid.Name = "dpid";
            this.dpid.Size = new System.Drawing.Size(221, 29);
            this.dpid.TabIndex = 61;
            this.dpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(79, 120);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(658, 173);
            this.dataview.TabIndex = 59;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.next);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.dpl);
            this.Controls.Add(this.dpid);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.did);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Doctor";
            this.Size = new System.Drawing.Size(847, 497);
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentRequestToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem treatToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Label dpl;
        private System.Windows.Forms.TextBox dpid;
        private System.Windows.Forms.DataGridView dataview;
    }
}
