namespace WindowsFormsApp1
{
    partial class splach
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myprogress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.onehundred = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(519, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 108);
            this.label4.TabIndex = 8;
            this.label4.Text = "S";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(418, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 91);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "M     M      tore";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myprogress
            // 
            this.myprogress.Location = new System.Drawing.Point(313, 359);
            this.myprogress.Name = "myprogress";
            this.myprogress.ProgressColor = System.Drawing.Color.Red;
            this.myprogress.ProgressColor2 = System.Drawing.Color.Red;
            this.myprogress.Size = new System.Drawing.Size(371, 11);
            this.myprogress.TabIndex = 11;
            this.myprogress.Text = "guna2ProgressBar1";
            this.myprogress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // onehundred
            // 
            this.onehundred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onehundred.Location = new System.Drawing.Point(690, 343);
            this.onehundred.Name = "onehundred";
            this.onehundred.Size = new System.Drawing.Size(100, 27);
            this.onehundred.TabIndex = 12;
            this.onehundred.Text = "%";
            // 
            // splach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1052, 759);
            this.Controls.Add(this.onehundred);
            this.Controls.Add(this.myprogress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "splach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.splach_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ProgressBar myprogress;
        private System.Windows.Forms.Label onehundred;
    }
}

