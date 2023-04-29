namespace görsel3ajanda
{
    partial class yntcsayfa
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kllncekle = new System.Windows.Forms.Button();
            this.kllncılar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(244, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "YÖNETİCİ SAYFA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::görsel3ajanda.Properties.Resources.external_24px;
            this.pictureBox3.Location = new System.Drawing.Point(21, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3ajanda.Properties.Resources.close_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(738, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kllncekle
            // 
            this.kllncekle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kllncekle.Image = global::görsel3ajanda.Properties.Resources.musteri_ekle;
            this.kllncekle.Location = new System.Drawing.Point(126, 149);
            this.kllncekle.Name = "kllncekle";
            this.kllncekle.Size = new System.Drawing.Size(161, 160);
            this.kllncekle.TabIndex = 33;
            this.kllncekle.Text = "Kullanıcı Ekle";
            this.kllncekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kllncekle.UseVisualStyleBackColor = true;
            this.kllncekle.Click += new System.EventHandler(this.kllncekle_Click);
            // 
            // kllncılar
            // 
            this.kllncılar.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kllncılar.Image = global::görsel3ajanda.Properties.Resources.musteri2;
            this.kllncılar.Location = new System.Drawing.Point(513, 150);
            this.kllncılar.Name = "kllncılar";
            this.kllncılar.Size = new System.Drawing.Size(161, 160);
            this.kllncılar.TabIndex = 34;
            this.kllncılar.Text = "Kullanıcılar";
            this.kllncılar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kllncılar.UseVisualStyleBackColor = true;
            this.kllncılar.Click += new System.EventHandler(this.kllncılar_Click);
            // 
            // yntcsayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kllncılar);
            this.Controls.Add(this.kllncekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yntcsayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yntcsayfa";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.yntcsayfa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yntcsayfa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.yntcsayfa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kllncekle;
        private System.Windows.Forms.Button kllncılar;
    }
}