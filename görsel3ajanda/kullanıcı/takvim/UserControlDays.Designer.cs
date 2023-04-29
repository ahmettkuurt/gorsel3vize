namespace görsel3ajanda.kullanıcı
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldays.Location = new System.Drawing.Point(3, 0);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(32, 22);
            this.lbldays.TabIndex = 0;
            this.lbldays.Text = "00";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Location = new System.Drawing.Point(8, 66);
            this.lblevent.MaximumSize = new System.Drawing.Size(132, 42);
            this.lblevent.MinimumSize = new System.Drawing.Size(132, 42);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(132, 42);
            this.lblevent.TabIndex = 1;
            this.lblevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblid.Location = new System.Drawing.Point(74, 8);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "label1";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbldays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(150, 108);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblid;
    }
}
