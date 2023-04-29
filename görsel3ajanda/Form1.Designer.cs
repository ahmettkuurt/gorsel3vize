namespace görsel3ajanda
{
    partial class Form1
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
            this.btnyntc = new System.Windows.Forms.Button();
            this.btnklnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnyntc
            // 
            this.btnyntc.Location = new System.Drawing.Point(92, 111);
            this.btnyntc.Name = "btnyntc";
            this.btnyntc.Size = new System.Drawing.Size(177, 169);
            this.btnyntc.TabIndex = 0;
            this.btnyntc.Text = "YÖNETİCİ GİRİŞİ";
            this.btnyntc.UseVisualStyleBackColor = true;
            this.btnyntc.Click += new System.EventHandler(this.btnyntc_Click);
            // 
            // btnklnc
            // 
            this.btnklnc.Location = new System.Drawing.Point(445, 111);
            this.btnklnc.Name = "btnklnc";
            this.btnklnc.Size = new System.Drawing.Size(183, 169);
            this.btnklnc.TabIndex = 1;
            this.btnklnc.Text = "KULLANICI GİRİŞİ";
            this.btnklnc.UseVisualStyleBackColor = true;
            this.btnklnc.Click += new System.EventHandler(this.btnklnc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "AJANDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::görsel3ajanda.Properties.Resources.close_64px2;
            this.pictureBox1.Location = new System.Drawing.Point(673, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(729, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnklnc);
            this.Controls.Add(this.btnyntc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJANDA";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyntc;
        private System.Windows.Forms.Button btnklnc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

