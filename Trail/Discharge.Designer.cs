namespace Trail
{
    partial class Discharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discharge));
            this.next = new System.Windows.Forms.Button();
            this.dpl = new System.Windows.Forms.Label();
            this.dpid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datarefresh = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dl = new System.Windows.Forms.Label();
            this.dlc = new System.Windows.Forms.ComboBox();
            this.buttond = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.TextBox();
            this.c31 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.c32 = new System.Windows.Forms.TextBox();
            this.c33 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datalabel = new System.Windows.Forms.Label();
            this.buttonp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(422, 223);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(46, 35);
            this.next.TabIndex = 71;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // dpl
            // 
            this.dpl.BackColor = System.Drawing.Color.White;
            this.dpl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpl.Location = new System.Drawing.Point(39, 224);
            this.dpl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dpl.Name = "dpl";
            this.dpl.Size = new System.Drawing.Size(158, 32);
            this.dpl.TabIndex = 70;
            this.dpl.Text = "H";
            this.dpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpid
            // 
            this.dpid.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dpid.Location = new System.Drawing.Point(227, 227);
            this.dpid.Name = "dpid";
            this.dpid.Size = new System.Drawing.Size(164, 29);
            this.dpid.TabIndex = 69;
            this.dpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dpid.TextChanged += new System.EventHandler(this.dpid_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(670, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "Want info about Patient ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(659, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Want info about Doc ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // datarefresh
            // 
            this.datarefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("datarefresh.BackgroundImage")));
            this.datarefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datarefresh.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datarefresh.Location = new System.Drawing.Point(495, 76);
            this.datarefresh.Name = "datarefresh";
            this.datarefresh.Size = new System.Drawing.Size(46, 35);
            this.datarefresh.TabIndex = 66;
            this.datarefresh.UseVisualStyleBackColor = true;
            this.datarefresh.Click += new System.EventHandler(this.datarefresh_Click);
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(7, 112);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(534, 332);
            this.dataview.TabIndex = 65;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Location = new System.Drawing.Point(623, 474);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(213, 23);
            this.date.TabIndex = 64;
            this.date.Text = "Welcome to";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.DimGray;
            this.time.Location = new System.Drawing.Point(408, 474);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(209, 23);
            this.time.TabIndex = 63;
            this.time.Text = "Welcome to";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(797, 4);
            this.label3.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 4);
            this.label1.TabIndex = 59;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 32);
            this.menuStrip1.TabIndex = 60;
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // dl
            // 
            this.dl.BackColor = System.Drawing.Color.Transparent;
            this.dl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dl.Location = new System.Drawing.Point(548, 112);
            this.dl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dl.Name = "dl";
            this.dl.Size = new System.Drawing.Size(116, 32);
            this.dl.TabIndex = 72;
            this.dl.Text = "Select Patient-Id";
            this.dl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlc
            // 
            this.dlc.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dlc.FormattingEnabled = true;
            this.dlc.Location = new System.Drawing.Point(673, 119);
            this.dlc.Name = "dlc";
            this.dlc.Size = new System.Drawing.Size(140, 25);
            this.dlc.TabIndex = 73;
            this.dlc.SelectedIndexChanged += new System.EventHandler(this.dlc_SelectedIndexChanged);
            // 
            // buttond
            // 
            this.buttond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttond.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttond.Location = new System.Drawing.Point(697, 394);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(104, 35);
            this.buttond.TabIndex = 74;
            this.buttond.Text = "Discharge";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.button1_Click);
            // 
            // c4
            // 
            this.c4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c4.Location = new System.Drawing.Point(671, 169);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(140, 29);
            this.c4.TabIndex = 75;
            this.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c31
            // 
            this.c31.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c31.Location = new System.Drawing.Point(671, 213);
            this.c31.Name = "c31";
            this.c31.Size = new System.Drawing.Size(59, 29);
            this.c31.TabIndex = 76;
            this.c31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c2.Location = new System.Drawing.Point(671, 289);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(140, 29);
            this.c2.TabIndex = 77;
            this.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c32
            // 
            this.c32.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c32.Location = new System.Drawing.Point(671, 248);
            this.c32.Name = "c32";
            this.c32.Size = new System.Drawing.Size(59, 29);
            this.c32.TabIndex = 78;
            this.c32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c33
            // 
            this.c33.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c33.Location = new System.Drawing.Point(736, 227);
            this.c33.Name = "c33";
            this.c33.Size = new System.Drawing.Size(75, 29);
            this.c33.TabIndex = 79;
            this.c33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.c1.Location = new System.Drawing.Point(671, 342);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(140, 29);
            this.c1.TabIndex = 80;
            this.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 32);
            this.label6.TabIndex = 81;
            this.label6.Text = "Doc charge";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 32);
            this.label7.TabIndex = 82;
            this.label7.Text = "Room Stay";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 248);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 32);
            this.label8.TabIndex = 83;
            this.label8.Text = "Charge perday";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(548, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 84;
            this.label9.Text = "Drug charge";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(548, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 32);
            this.label10.TabIndex = 85;
            this.label10.Text = "Total Charge";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datalabel
            // 
            this.datalabel.BackColor = System.Drawing.Color.Transparent;
            this.datalabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalabel.ForeColor = System.Drawing.Color.Black;
            this.datalabel.Location = new System.Drawing.Point(111, 77);
            this.datalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(280, 32);
            this.datalabel.TabIndex = 86;
            this.datalabel.Text = "Hospital data";
            this.datalabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.datalabel.Click += new System.EventHandler(this.datalabel_Click);
            // 
            // buttonp
            // 
            this.buttonp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonp.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonp.Location = new System.Drawing.Point(591, 394);
            this.buttonp.Name = "buttonp";
            this.buttonp.Size = new System.Drawing.Size(78, 35);
            this.buttonp.TabIndex = 87;
            this.buttonp.Text = "Paid";
            this.buttonp.UseVisualStyleBackColor = true;
            this.buttonp.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Discharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonp);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c33);
            this.Controls.Add(this.c32);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c31);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.dlc);
            this.Controls.Add(this.dl);
            this.Controls.Add(this.next);
            this.Controls.Add(this.dpl);
            this.Controls.Add(this.dpid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datarefresh);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Discharge";
            this.Size = new System.Drawing.Size(847, 497);
            this.Load += new System.EventHandler(this.Discharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label dpl;
        private System.Windows.Forms.TextBox dpid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button datarefresh;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label dl;
        private System.Windows.Forms.ComboBox dlc;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.TextBox c4;
        private System.Windows.Forms.TextBox c31;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox c32;
        private System.Windows.Forms.TextBox c33;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Button buttonp;
        private System.Windows.Forms.Timer timer1;
    }
}
