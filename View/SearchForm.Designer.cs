namespace View
{
    partial class SearchForm
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
            this.labelParam1 = new System.Windows.Forms.Label();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.buttonRunSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Location = new System.Drawing.Point(12, 15);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(17, 13);
            this.labelParam1.TabIndex = 8;
            this.labelParam1.Text = "V:";
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(35, 12);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam1.TabIndex = 7;
            // 
            // buttonRunSearch
            // 
            this.buttonRunSearch.Location = new System.Drawing.Point(35, 53);
            this.buttonRunSearch.Name = "buttonRunSearch";
            this.buttonRunSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonRunSearch.TabIndex = 10;
            this.buttonRunSearch.Text = "Search";
            this.buttonRunSearch.UseVisualStyleBackColor = true;
            this.buttonRunSearch.Click += new System.EventHandler(this.buttonRunSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(160, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 212);
            this.listBox1.TabIndex = 11;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 245);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonRunSearch);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.textBoxParam1);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParam1;
        private System.Windows.Forms.TextBox textBoxParam1;
        private System.Windows.Forms.Button buttonRunSearch;
        private System.Windows.Forms.ListBox listBox1;
    }
}