namespace görsel3ajanda.yönetici
{
    partial class kllnclar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kllncarama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.görsel3vizeDataSet = new görsel3ajanda.görsel3vizeDataSet();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new görsel3ajanda.görsel3vizeDataSetTableAdapters.kullaniciTableAdapter();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(310, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 38);
            this.label3.TabIndex = 35;
            this.label3.Text = "KULLANICILAR";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label3_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kullanıcının Adı Soyadı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kllncarama
            // 
            this.kllncarama.Location = new System.Drawing.Point(302, 103);
            this.kllncarama.Name = "kllncarama";
            this.kllncarama.Size = new System.Drawing.Size(156, 20);
            this.kllncarama.TabIndex = 36;
            this.kllncarama.TextChanged += new System.EventHandler(this.kllncarama_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 410);
            this.dataGridView1.TabIndex = 41;
            // 
            // görsel3vizeDataSet
            // 
            this.görsel3vizeDataSet.DataSetName = "görsel3vizeDataSet";
            this.görsel3vizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.görsel3vizeDataSet;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // sil
            // 
            this.sil.Image = global::görsel3ajanda.Properties.Resources.musteri_sil;
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.Location = new System.Drawing.Point(700, 87);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(77, 50);
            this.sil.TabIndex = 40;
            this.sil.Text = "Sİl";
            this.sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.Image = global::görsel3ajanda.Properties.Resources.musteri_duzenle;
            this.güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelle.Location = new System.Drawing.Point(529, 87);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(102, 50);
            this.güncelle.TabIndex = 39;
            this.güncelle.Text = "Güncelle";
            this.güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::görsel3ajanda.Properties.Resources.back_48px;
            this.pictureBox3.Location = new System.Drawing.Point(12, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3ajanda.Properties.Resources.close_64px1;
            this.pictureBox1.Location = new System.Drawing.Point(830, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kllnclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(896, 565);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kllncarama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kllnclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kllnclar";
            this.Load += new System.EventHandler(this.kllnclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.görsel3vizeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kllncarama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private görsel3vizeDataSet görsel3vizeDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private görsel3vizeDataSetTableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
    }
}