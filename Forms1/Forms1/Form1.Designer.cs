namespace Forms1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisney = new System.Windows.Forms.Button();
            this.pcbUp = new System.Windows.Forms.PictureBox();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnMarvel = new System.Windows.Forms.Button();
            this.btnPixar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnDisney
            // 
            this.btnDisney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisney.BackgroundImage")));
            this.btnDisney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisney.Location = new System.Drawing.Point(158, 439);
            this.btnDisney.Name = "btnDisney";
            this.btnDisney.Size = new System.Drawing.Size(229, 90);
            this.btnDisney.TabIndex = 0;
            this.btnDisney.UseVisualStyleBackColor = true;
            this.btnDisney.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pcbUp
            // 
            this.pcbUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUp.Image = ((System.Drawing.Image)(resources.GetObject("pcbUp.Image")));
            this.pcbUp.Location = new System.Drawing.Point(102, 22);
            this.pcbUp.Name = "pcbUp";
            this.pcbUp.Size = new System.Drawing.Size(1260, 400);
            this.pcbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUp.TabIndex = 5;
            this.pcbUp.TabStop = false;
            // 
            // btnStar
            // 
            this.btnStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStar.BackgroundImage")));
            this.btnStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStar.Location = new System.Drawing.Point(1087, 439);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(229, 90);
            this.btnStar.TabIndex = 4;
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.BtnStar_Click);
            // 
            // btnMarvel
            // 
            this.btnMarvel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarvel.BackgroundImage")));
            this.btnMarvel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarvel.Location = new System.Drawing.Point(769, 439);
            this.btnMarvel.Name = "btnMarvel";
            this.btnMarvel.Size = new System.Drawing.Size(229, 90);
            this.btnMarvel.TabIndex = 3;
            this.btnMarvel.UseVisualStyleBackColor = true;
            this.btnMarvel.Click += new System.EventHandler(this.BtnMarvel_Click);
            // 
            // btnPixar
            // 
            this.btnPixar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPixar.BackgroundImage")));
            this.btnPixar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPixar.Location = new System.Drawing.Point(462, 439);
            this.btnPixar.Name = "btnPixar";
            this.btnPixar.Size = new System.Drawing.Size(229, 90);
            this.btnPixar.TabIndex = 2;
            this.btnPixar.UseVisualStyleBackColor = true;
            this.btnPixar.Click += new System.EventHandler(this.BtnPixar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1463, 831);
            this.Controls.Add(this.btnDisney);
            this.Controls.Add(this.pcbUp);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btnMarvel);
            this.Controls.Add(this.btnPixar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPixar;
        private System.Windows.Forms.Button btnMarvel;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.PictureBox pcbUp;
    }
}

