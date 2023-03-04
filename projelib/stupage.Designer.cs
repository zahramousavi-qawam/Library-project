namespace projelib
{
    partial class stupage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stupagetextname = new System.Windows.Forms.TextBox();
            this.stupagetextauthor = new System.Windows.Forms.TextBox();
            this.dataGridbook = new System.Windows.Forms.DataGridView();
            this.stupagebtnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the Book :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Name :";
            // 
            // stupagetextname
            // 
            this.stupagetextname.Location = new System.Drawing.Point(285, 53);
            this.stupagetextname.Name = "stupagetextname";
            this.stupagetextname.Size = new System.Drawing.Size(163, 20);
            this.stupagetextname.TabIndex = 2;
            // 
            // stupagetextauthor
            // 
            this.stupagetextauthor.Location = new System.Drawing.Point(285, 99);
            this.stupagetextauthor.Name = "stupagetextauthor";
            this.stupagetextauthor.Size = new System.Drawing.Size(163, 20);
            this.stupagetextauthor.TabIndex = 3;
            // 
            // dataGridbook
            // 
            this.dataGridbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridbook.Location = new System.Drawing.Point(68, 200);
            this.dataGridbook.Name = "dataGridbook";
            this.dataGridbook.Size = new System.Drawing.Size(452, 186);
            this.dataGridbook.TabIndex = 4;
            // 
            // stupagebtnsearch
            // 
            this.stupagebtnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stupagebtnsearch.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stupagebtnsearch.Location = new System.Drawing.Point(245, 158);
            this.stupagebtnsearch.Name = "stupagebtnsearch";
            this.stupagebtnsearch.Size = new System.Drawing.Size(75, 23);
            this.stupagebtnsearch.TabIndex = 5;
            this.stupagebtnsearch.Text = "Search";
            this.stupagebtnsearch.UseVisualStyleBackColor = true;
            this.stupagebtnsearch.Click += new System.EventHandler(this.stupagebtnsearch_Click);
            // 
            // stupage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 398);
            this.Controls.Add(this.stupagebtnsearch);
            this.Controls.Add(this.dataGridbook);
            this.Controls.Add(this.stupagetextauthor);
            this.Controls.Add(this.stupagetextname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stupage";
            this.Text = "stupage";
            this.Load += new System.EventHandler(this.stupage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stupagetextname;
        private System.Windows.Forms.TextBox stupagetextauthor;
        private System.Windows.Forms.DataGridView dataGridbook;
        private System.Windows.Forms.Button stupagebtnsearch;
    }
}