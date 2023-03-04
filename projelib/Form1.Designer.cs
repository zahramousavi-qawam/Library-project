using System;

namespace projelib
{
    partial class logpage
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
            this.logintextuser = new System.Windows.Forms.TextBox();
            this.logintextpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logpagebtnstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintextuser
            // 
            this.logintextuser.Location = new System.Drawing.Point(200, 98);
            this.logintextuser.Name = "logintextuser";
            this.logintextuser.Size = new System.Drawing.Size(178, 20);
            this.logintextuser.TabIndex = 0;
            // 
            // logintextpassword
            // 
            this.logintextpassword.Location = new System.Drawing.Point(200, 159);
            this.logintextpassword.Name = "logintextpassword";
            this.logintextpassword.PasswordChar = '*';
            this.logintextpassword.Size = new System.Drawing.Size(178, 20);
            this.logintextpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName :";
            // 
            // logpagebtnstart
            // 
            this.logpagebtnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logpagebtnstart.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpagebtnstart.Location = new System.Drawing.Point(303, 251);
            this.logpagebtnstart.Name = "logpagebtnstart";
            this.logpagebtnstart.Size = new System.Drawing.Size(75, 23);
            this.logpagebtnstart.TabIndex = 4;
            this.logpagebtnstart.Text = "Start";
            this.logpagebtnstart.UseVisualStyleBackColor = true;
            this.logpagebtnstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // logpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(491, 349);
            this.Controls.Add(this.logpagebtnstart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logintextpassword);
            this.Controls.Add(this.logintextuser);
            this.Name = "logpage";
            this.Text = "logpage";
            this.Load += new System.EventHandler(this.logpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void logpage_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.TextBox logintextuser;
        private System.Windows.Forms.TextBox logintextpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logpagebtnstart;
    }
}

