namespace Cinema_Project
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.v_Panel_Main = new System.Windows.Forms.Panel();
            this.vACTION = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.v_Panel_Banner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.v_Account_Label = new System.Windows.Forms.Label();
            this.v_Tickets_Label = new System.Windows.Forms.Label();
            this.v_Movies_Label = new System.Windows.Forms.Label();
            this.v_Panel_Main.SuspendLayout();
            this.v_Panel_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // v_Panel_Main
            // 
            this.v_Panel_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("v_Panel_Main.BackgroundImage")));
            this.v_Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v_Panel_Main.Controls.Add(this.vACTION);
            this.v_Panel_Main.Controls.Add(this.panel1);
            this.v_Panel_Main.Controls.Add(this.v_Panel_Banner);
            this.v_Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.v_Panel_Main.Name = "v_Panel_Main";
            this.v_Panel_Main.Size = new System.Drawing.Size(1384, 911);
            this.v_Panel_Main.TabIndex = 0;
            this.v_Panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.v_Panel_Main_Paint);
            // 
            // vACTION
            // 
            this.vACTION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vACTION.AutoSize = true;
            this.vACTION.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vACTION.ForeColor = System.Drawing.Color.OrangeRed;
            this.vACTION.Location = new System.Drawing.Point(875, 152);
            this.vACTION.Name = "vACTION";
            this.vACTION.Size = new System.Drawing.Size(116, 37);
            this.vACTION.TabIndex = 3;
            this.vACTION.Text = "ACTION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 811);
            this.panel1.TabIndex = 1;
            // 
            // v_Panel_Banner
            // 
            this.v_Panel_Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.v_Panel_Banner.Controls.Add(this.pictureBox1);
            this.v_Panel_Banner.Controls.Add(this.v_Account_Label);
            this.v_Panel_Banner.Controls.Add(this.v_Tickets_Label);
            this.v_Panel_Banner.Controls.Add(this.v_Movies_Label);
            this.v_Panel_Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_Panel_Banner.Location = new System.Drawing.Point(0, 0);
            this.v_Panel_Banner.Name = "v_Panel_Banner";
            this.v_Panel_Banner.Size = new System.Drawing.Size(1384, 100);
            this.v_Panel_Banner.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // v_Account_Label
            // 
            this.v_Account_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v_Account_Label.AutoSize = true;
            this.v_Account_Label.BackColor = System.Drawing.Color.Transparent;
            this.v_Account_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.v_Account_Label.ForeColor = System.Drawing.Color.White;
            this.v_Account_Label.Location = new System.Drawing.Point(1213, 22);
            this.v_Account_Label.Name = "v_Account_Label";
            this.v_Account_Label.Padding = new System.Windows.Forms.Padding(10);
            this.v_Account_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.v_Account_Label.Size = new System.Drawing.Size(151, 61);
            this.v_Account_Label.TabIndex = 2;
            this.v_Account_Label.Text = "Account";
            this.v_Account_Label.Click += new System.EventHandler(this.v_Account_Label_Click);
            // 
            // v_Tickets_Label
            // 
            this.v_Tickets_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v_Tickets_Label.AutoSize = true;
            this.v_Tickets_Label.BackColor = System.Drawing.Color.Transparent;
            this.v_Tickets_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.v_Tickets_Label.ForeColor = System.Drawing.Color.White;
            this.v_Tickets_Label.Location = new System.Drawing.Point(879, 22);
            this.v_Tickets_Label.Name = "v_Tickets_Label";
            this.v_Tickets_Label.Padding = new System.Windows.Forms.Padding(10);
            this.v_Tickets_Label.Size = new System.Drawing.Size(132, 61);
            this.v_Tickets_Label.TabIndex = 1;
            this.v_Tickets_Label.Text = "Tickets";
            this.v_Tickets_Label.Click += new System.EventHandler(this.v_Tickets_Label_Click);
            // 
            // v_Movies_Label
            // 
            this.v_Movies_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.v_Movies_Label.AutoSize = true;
            this.v_Movies_Label.BackColor = System.Drawing.Color.Transparent;
            this.v_Movies_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.v_Movies_Label.ForeColor = System.Drawing.Color.White;
            this.v_Movies_Label.Location = new System.Drawing.Point(1044, 22);
            this.v_Movies_Label.Name = "v_Movies_Label";
            this.v_Movies_Label.Padding = new System.Windows.Forms.Padding(10);
            this.v_Movies_Label.Size = new System.Drawing.Size(136, 61);
            this.v_Movies_Label.TabIndex = 0;
            this.v_Movies_Label.Text = "Movies";
            this.v_Movies_Label.Click += new System.EventHandler(this.v_Movies_Label_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1384, 911);
            this.Controls.Add(this.v_Panel_Main);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 475);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Now";
            this.v_Panel_Main.ResumeLayout(false);
            this.v_Panel_Main.PerformLayout();
            this.v_Panel_Banner.ResumeLayout(false);
            this.v_Panel_Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel v_Panel_Main;
        private System.Windows.Forms.Panel v_Panel_Banner;
        private System.Windows.Forms.Label v_Account_Label;
        private System.Windows.Forms.Label v_Tickets_Label;
        private System.Windows.Forms.Label v_Movies_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vACTION;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
