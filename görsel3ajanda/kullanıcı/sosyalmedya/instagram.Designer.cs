﻿namespace görsel3ajanda.kullanıcı.sosyalmedya
{
    partial class instagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instagram));
            this.kullaniciTableAdapter1 = new görsel3ajanda.görsel3vizeDataSetTableAdapters.kullaniciTableAdapter();
            this.SuspendLayout();
            // 
            // kullaniciTableAdapter1
            // 
            this.kullaniciTableAdapter1.ClearBeforeFill = true;
            // 
            // instagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 550);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "instagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram";
            this.Load += new System.EventHandler(this.instagram_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private görsel3vizeDataSetTableAdapters.kullaniciTableAdapter kullaniciTableAdapter1;
    }
}