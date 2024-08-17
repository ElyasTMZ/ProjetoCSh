
namespace cantina
{
    partial class FrmSpash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpash));
            this.pcdSplash = new System.Windows.Forms.PictureBox();
            this.pgbsplash = new System.Windows.Forms.ProgressBar();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcdSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pcdSplash
            // 
            this.pcdSplash.Image = ((System.Drawing.Image)(resources.GetObject("pcdSplash.Image")));
            this.pcdSplash.Location = new System.Drawing.Point(276, 71);
            this.pcdSplash.Name = "pcdSplash";
            this.pcdSplash.Size = new System.Drawing.Size(291, 240);
            this.pcdSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcdSplash.TabIndex = 0;
            this.pcdSplash.TabStop = false;
            this.pcdSplash.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pgbsplash
            // 
            this.pgbsplash.Location = new System.Drawing.Point(276, 339);
            this.pgbsplash.Name = "pgbsplash";
            this.pgbsplash.Size = new System.Drawing.Size(291, 23);
            this.pgbsplash.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(385, 365);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(18, 20);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "0";
            this.lblValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(409, 365);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lblPorcentagem.TabIndex = 4;
            this.lblPorcentagem.Text = "%";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSpash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pgbsplash);
            this.Controls.Add(this.pcdSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSpash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantina - Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pcdSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcdSplash;
        private System.Windows.Forms.ProgressBar pgbsplash;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Timer tmrSplash;
    }
}