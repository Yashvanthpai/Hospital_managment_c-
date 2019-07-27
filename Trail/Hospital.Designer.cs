namespace Trail
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataview = new System.Windows.Forms.DataGridView();
            this.datarefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpid = new System.Windows.Forms.TextBox();
            this.dpl = new System.Windows.Forms.Label();
            this.datalabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.allocateRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(797, 4);
            this.label3.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 4);
            this.label1.TabIndex = 43;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(533, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = " City Hospital Managment ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.allocateRoomToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.dischargeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 32);
            this.menuStrip1.TabIndex = 44;
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
            this.backToolStripMenuItem.Text = "Log-Out";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.AutoSize = false;
            this.roomsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.roomsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.roomsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // dischargeToolStripMenuItem
            // 
            this.dischargeToolStripMenuItem.AutoSize = false;
            this.dischargeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.dischargeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dischargeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dischargeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dischargeToolStripMenuItem.Name = "dischargeToolStripMenuItem";
            this.dischargeToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.dischargeToolStripMenuItem.Text = "Discharge";
            this.dischargeToolStripMenuItem.Click += new System.EventHandler(this.dischargeToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DimGray;
            this.label.Location = new System.Drawing.Point(3, 474);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(388, 23);
            this.label.TabIndex = 46;
            this.label.Text = "Welcome to";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.DimGray;
            this.time.Location = new System.Drawing.Point(408, 474);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(209, 23);
            this.time.TabIndex = 47;
            this.time.Text = "Welcome to";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.Location = new System.Drawing.Point(623, 474);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(213, 23);
            this.date.TabIndex = 48;
            this.date.Text = "Welcome to";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(72, 153);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(665, 237);
            this.dataview.TabIndex = 49;
            this.dataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataview_CellContentClick);
            // 
            // datarefresh
            // 
            this.datarefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("datarefresh.BackgroundImage")));
            this.datarefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datarefresh.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datarefresh.Location = new System.Drawing.Point(691, 112);
            this.datarefresh.Name = "datarefresh";
            this.datarefresh.Size = new System.Drawing.Size(46, 35);
            this.datarefresh.TabIndex = 52;
            this.datarefresh.UseVisualStyleBackColor = true;
            this.datarefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(647, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "Want info about Doc ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(659, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Want info about Patient ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dpid
            // 
            this.dpid.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dpid.Location = new System.Drawing.Point(313, 234);
            this.dpid.Name = "dpid";
            this.dpid.Size = new System.Drawing.Size(221, 29);
            this.dpid.TabIndex = 55;
            this.dpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dpl
            // 
            this.dpl.BackColor = System.Drawing.Color.White;
            this.dpl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpl.Location = new System.Drawing.Point(122, 231);
            this.dpl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dpl.Name = "dpl";
            this.dpl.Size = new System.Drawing.Size(165, 32);
            this.dpl.TabIndex = 56;
            this.dpl.Text = "H";
            this.dpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datalabel
            // 
            this.datalabel.BackColor = System.Drawing.Color.Transparent;
            this.datalabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalabel.ForeColor = System.Drawing.Color.Black;
            this.datalabel.Location = new System.Drawing.Point(211, 113);
            this.datalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(418, 32);
            this.datalabel.TabIndex = 57;
            this.datalabel.Text = "Hospital data";
            this.datalabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(539, 231);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(46, 35);
            this.next.TabIndex = 58;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // allocateRoomToolStripMenuItem
            // 
            this.allocateRoomToolStripMenuItem.AutoSize = false;
            this.allocateRoomToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.allocateRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.allocateRoomToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.allocateRoomToolStripMenuItem.Name = "allocateRoomToolStripMenuItem";
            this.allocateRoomToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.allocateRoomToolStripMenuItem.Text = "Allocate Room";
            this.allocateRoomToolStripMenuItem.Click += new System.EventHandler(this.allocateRoomToolStripMenuItem_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.next);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.dpl);
            this.Controls.Add(this.dpid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datarefresh);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Hospital";
            this.Size = new System.Drawing.Size(847, 497);
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Button datarefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dpid;
        private System.Windows.Forms.Label dpl;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ToolStripMenuItem dischargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateRoomToolStripMenuItem;
    }
}
