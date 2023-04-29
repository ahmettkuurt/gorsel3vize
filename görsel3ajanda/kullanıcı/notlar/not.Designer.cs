namespace görsel3ajanda.kullanıcı
{
    partial class not
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
            this.lblis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notekle = new System.Windows.Forms.Button();
            this.notbak = new System.Windows.Forms.Button();
            this.notsil = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.düzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblis
            // 
            this.lblis.AutoSize = true;
            this.lblis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblis.Location = new System.Drawing.Point(122, 29);
            this.lblis.Name = "lblis";
            this.lblis.Size = new System.Drawing.Size(35, 13);
            this.lblis.TabIndex = 41;
            this.lblis.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(304, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 40;
            this.label3.Text = "NOTLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 352);
            this.dataGridView1.TabIndex = 42;
            // 
            // notekle
            // 
            this.notekle.Location = new System.Drawing.Point(700, 86);
            this.notekle.Name = "notekle";
            this.notekle.Size = new System.Drawing.Size(88, 56);
            this.notekle.TabIndex = 43;
            this.notekle.Text = "Not Ekle";
            this.notekle.UseVisualStyleBackColor = true;
            this.notekle.Click += new System.EventHandler(this.notekle_Click);
            // 
            // notbak
            // 
            this.notbak.Location = new System.Drawing.Point(700, 282);
            this.notbak.Name = "notbak";
            this.notbak.Size = new System.Drawing.Size(88, 56);
            this.notbak.TabIndex = 44;
            this.notbak.Text = "Notu Görüntüle";
            this.notbak.UseVisualStyleBackColor = true;
            this.notbak.Click += new System.EventHandler(this.notbak_Click);
            // 
            // notsil
            // 
            this.notsil.Location = new System.Drawing.Point(700, 382);
            this.notsil.Name = "notsil";
            this.notsil.Size = new System.Drawing.Size(88, 56);
            this.notsil.TabIndex = 45;
            this.notsil.Text = "Notu Sil";
            this.notsil.UseVisualStyleBackColor = true;
            this.notsil.Click += new System.EventHandler(this.notsil_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::görsel3ajanda.Properties.Resources.back_48px;
            this.pictureBox3.Location = new System.Drawing.Point(22, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3ajanda.Properties.Resources.close_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(739, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // düzenle
            // 
            this.düzenle.Location = new System.Drawing.Point(700, 178);
            this.düzenle.Name = "düzenle";
            this.düzenle.Size = new System.Drawing.Size(88, 56);
            this.düzenle.TabIndex = 46;
            this.düzenle.Text = "Notu Düzenle";
            this.düzenle.UseVisualStyleBackColor = true;
            this.düzenle.Click += new System.EventHandler(this.düzenle_Click);
            // 
            // not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.düzenle);
            this.Controls.Add(this.notsil);
            this.Controls.Add(this.notbak);
            this.Controls.Add(this.notekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "not";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notlar";
            this.Load += new System.EventHandler(this.notlar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notlar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notlar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notlar_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button notekle;
        private System.Windows.Forms.Button notbak;
        private System.Windows.Forms.Button notsil;
        private System.Windows.Forms.Button düzenle;
    }
}