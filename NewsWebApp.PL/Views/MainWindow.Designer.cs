
namespace NewsWebApp.PL.Views
{
    partial class MainWindow
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
            this.button_RegisterView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_news = new System.Windows.Forms.ListBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_topyc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Headings = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_newsName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_RegisterView
            // 
            this.button_RegisterView.Location = new System.Drawing.Point(645, 12);
            this.button_RegisterView.Name = "button_RegisterView";
            this.button_RegisterView.Size = new System.Drawing.Size(143, 23);
            this.button_RegisterView.TabIndex = 0;
            this.button_RegisterView.Text = "Autorisation";
            this.button_RegisterView.UseVisualStyleBackColor = true;
            this.button_RegisterView.Click += new System.EventHandler(this.button_RegisterView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_news);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 548);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "News";
            // 
            // listBox_news
            // 
            this.listBox_news.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_news.FormattingEnabled = true;
            this.listBox_news.ItemHeight = 30;
            this.listBox_news.Location = new System.Drawing.Point(6, 22);
            this.listBox_news.Name = "listBox_news";
            this.listBox_news.Size = new System.Drawing.Size(764, 514);
            this.listBox_news.TabIndex = 0;
            this.listBox_news.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_news_MouseDoubleClick);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(496, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(143, 23);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_topyc
            // 
            this.textBox_topyc.Location = new System.Drawing.Point(390, 12);
            this.textBox_topyc.Name = "textBox_topyc";
            this.textBox_topyc.Size = new System.Drawing.Size(100, 23);
            this.textBox_topyc.TabIndex = 3;
            this.textBox_topyc.TextChanged += new System.EventHandler(this.textBox_topyc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Topyc:";
            // 
            // comboBox_Headings
            // 
            this.comboBox_Headings.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_Headings.FormattingEnabled = true;
            this.comboBox_Headings.Location = new System.Drawing.Point(241, 12);
            this.comboBox_Headings.Name = "comboBox_Headings";
            this.comboBox_Headings.Size = new System.Drawing.Size(99, 23);
            this.comboBox_Headings.TabIndex = 9;
            this.comboBox_Headings.SelectedIndexChanged += new System.EventHandler(this.comboBox_Headings_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Heading";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(241, 41);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(101, 23);
            this.dateTimePicker_from.TabIndex = 10;
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(390, 41);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker_to.TabIndex = 11;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // textBox_newsName
            // 
            this.textBox_newsName.Location = new System.Drawing.Point(63, 12);
            this.textBox_newsName.Name = "textBox_newsName";
            this.textBox_newsName.Size = new System.Drawing.Size(114, 23);
            this.textBox_newsName.TabIndex = 14;
            this.textBox_newsName.TextChanged += new System.EventHandler(this.textBox_newsName_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_newsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.comboBox_Headings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_topyc);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_RegisterView);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RegisterView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_news;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_topyc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Headings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_newsName;
    }
}