
namespace NewsWebApp.PL.Views
{
    partial class NewsViewer
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
            this.label_newsname = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_publishdate = new System.Windows.Forms.Label();
            this.label_heading = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_newsname
            // 
            this.label_newsname.AutoSize = true;
            this.label_newsname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_newsname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_newsname.Location = new System.Drawing.Point(12, 51);
            this.label_newsname.Name = "label_newsname";
            this.label_newsname.Size = new System.Drawing.Size(112, 25);
            this.label_newsname.TabIndex = 0;
            this.label_newsname.Text = "NewsName";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_author.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_author.Location = new System.Drawing.Point(12, 9);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(86, 25);
            this.label_author.TabIndex = 2;
            this.label_author.Text = "Author: ";
            // 
            // label_publishdate
            // 
            this.label_publishdate.AutoSize = true;
            this.label_publishdate.Location = new System.Drawing.Point(13, 426);
            this.label_publishdate.Name = "label_publishdate";
            this.label_publishdate.Size = new System.Drawing.Size(73, 15);
            this.label_publishdate.TabIndex = 3;
            this.label_publishdate.Text = "Publish Date";
            // 
            // label_heading
            // 
            this.label_heading.AutoSize = true;
            this.label_heading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_heading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_heading.Location = new System.Drawing.Point(338, 9);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(93, 25);
            this.label_heading.TabIndex = 4;
            this.label_heading.Text = "Heading:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 344);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // NewsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_heading);
            this.Controls.Add(this.label_publishdate);
            this.Controls.Add(this.label_author);
            this.Controls.Add(this.label_newsname);
            this.Name = "NewsViewer";
            this.Text = "NewsViewer";
            this.Load += new System.EventHandler(this.NewsViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_newsname;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_publishdate;
        private System.Windows.Forms.Label label_heading;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}