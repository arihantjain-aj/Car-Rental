
namespace prjcr
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btncust = new System.Windows.Forms.Button();
            this.btnrent = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnaddcars = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btncust.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.ForeColor = System.Drawing.Color.Black;
            this.btncust.Location = new System.Drawing.Point(48, 264);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(224, 35);
            this.btncust.TabIndex = 109;
            this.btncust.Text = "ADD CUSTOMER";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // btnrent
            // 
            this.btnrent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnrent.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrent.Location = new System.Drawing.Point(448, 136);
            this.btnrent.Name = "btnrent";
            this.btnrent.Size = new System.Drawing.Size(280, 35);
            this.btnrent.TabIndex = 108;
            this.btnrent.Text = "GIVE CAR ON RENT";
            this.btnrent.UseVisualStyleBackColor = false;
            this.btnrent.Click += new System.EventHandler(this.btnrent_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnexit.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(616, 336);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(136, 35);
            this.btnexit.TabIndex = 105;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnaddcars
            // 
            this.btnaddcars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnaddcars.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcars.ForeColor = System.Drawing.Color.Black;
            this.btnaddcars.Location = new System.Drawing.Point(48, 136);
            this.btnaddcars.Name = "btnaddcars";
            this.btnaddcars.Size = new System.Drawing.Size(224, 35);
            this.btnaddcars.TabIndex = 104;
            this.btnaddcars.Text = "ADD CARS";
            this.btnaddcars.UseVisualStyleBackColor = false;
            this.btnaddcars.Click += new System.EventHandler(this.btnaddcars_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlogout.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(616, 280);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(136, 35);
            this.btnlogout.TabIndex = 103;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnadmin.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.Black;
            this.btnadmin.Location = new System.Drawing.Point(48, 200);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(224, 35);
            this.btnadmin.TabIndex = 102;
            this.btnadmin.Text = "ADD ADMIN";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Algerian", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label2.Location = new System.Drawing.Point(168, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(458, 75);
            this.Label2.TabIndex = 110;
            this.Label2.Text = "Royal Rides";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::prjcr.Properties.Resources.logo_mail;
            this.pictureBox3.Location = new System.Drawing.Point(16, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjcr.Properties.Resources.car;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.btnrent);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnaddcars);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnadmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.Button btnrent;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnaddcars;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnadmin;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}