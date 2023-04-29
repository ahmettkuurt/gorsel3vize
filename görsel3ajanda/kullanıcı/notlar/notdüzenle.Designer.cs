namespace görsel3ajanda.kullanıcı.notlar
{
    partial class notdüzenle
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
            this.düzenle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.icerik = new System.Windows.Forms.TextBox();
            this.baslik = new System.Windows.Forms.TextBox();
            this.lblis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // düzenle
            // 
            this.düzenle.Location = new System.Drawing.Point(12, 354);
            this.düzenle.Name = "düzenle";
            this.düzenle.Size = new System.Drawing.Size(109, 57);
            this.düzenle.TabIndex = 63;
            this.düzenle.Text = "Notu Düzenle";
            this.düzenle.UseVisualStyleBackColor = true;
            this.düzenle.Click += new System.EventHandler(this.düzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label2.Location = new System.Drawing.Point(20, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "İçerik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "Başlık";
            // 
            // icerik
            // 
            this.icerik.Location = new System.Drawing.Point(138, 114);
            this.icerik.Multiline = true;
            this.icerik.Name = "icerik";
            this.icerik.Size = new System.Drawing.Size(650, 297);
            this.icerik.TabIndex = 60;
            // 
            // baslik
            // 
            this.baslik.Location = new System.Drawing.Point(138, 88);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(650, 20);
            this.baslik.TabIndex = 59;
            // 
            // lblis
            // 
            this.lblis.AutoSize = true;
            this.lblis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblis.Location = new System.Drawing.Point(123, 35);
            this.lblis.Name = "lblis";
            this.lblis.Size = new System.Drawing.Size(35, 13);
            this.lblis.TabIndex = 58;
            this.lblis.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(303, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 38);
            this.label3.TabIndex = 57;
            this.label3.Text = "NOT DÜZENLE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::görsel3ajanda.Properties.Resources.back_48px;
            this.pictureBox3.Location = new System.Drawing.Point(23, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3ajanda.Properties.Resources.close_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(740, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notdüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.düzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icerik);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.lblis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notdüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notdüzenle";
            this.Load += new System.EventHandler(this.notdüzenle_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notdüzenle_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notdüzenle_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notdüzenle_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button düzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox icerik;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Label lblis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}