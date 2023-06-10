
namespace prjcr
{
    partial class loadingfrm
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

      
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingfrm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgbr = new System.Windows.Forms.ProgressBar();
            this.lblpro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgbr
            // 
            this.prgbr.Location = new System.Drawing.Point(0, 480);
            this.prgbr.Name = "prgbr";
            this.prgbr.Size = new System.Drawing.Size(820, 15);
            this.prgbr.TabIndex = 5;
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.BackColor = System.Drawing.Color.Transparent;
            this.lblpro.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblpro.Location = new System.Drawing.Point(16, 440);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(0, 32);
            this.lblpro.TabIndex = 6;
            // 
            // loadingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.prgbr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loadingfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgbr;
        private System.Windows.Forms.Label lblpro;
    }
}

