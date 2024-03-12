namespace Product_Search_Chapter_14
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
            this.productListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.productNumberButton = new System.Windows.Forms.Button();
            this.descButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minMaxUOHButton = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 31;
            this.productListBox.Location = new System.Drawing.Point(32, 29);
            this.productListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(1100, 624);
            this.productListBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(32, 701);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(1100, 38);
            this.searchTextBox.TabIndex = 1;
            // 
            // productNumberButton
            // 
            this.productNumberButton.Location = new System.Drawing.Point(32, 813);
            this.productNumberButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.productNumberButton.Name = "productNumberButton";
            this.productNumberButton.Size = new System.Drawing.Size(408, 122);
            this.productNumberButton.TabIndex = 2;
            this.productNumberButton.Text = "Find Product Number";
            this.productNumberButton.UseVisualStyleBackColor = true;
            this.productNumberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // descButton
            // 
            this.descButton.Location = new System.Drawing.Point(731, 813);
            this.descButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.descButton.Name = "descButton";
            this.descButton.Size = new System.Drawing.Size(408, 122);
            this.descButton.TabIndex = 3;
            this.descButton.Text = "Find Descriptions Contained Text";
            this.descButton.UseVisualStyleBackColor = true;
            this.descButton.Click += new System.EventHandler(this.descButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(429, 1376);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(312, 79);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minMaxUOHButton
            // 
            this.minMaxUOHButton.Location = new System.Drawing.Point(835, 1075);
            this.minMaxUOHButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.minMaxUOHButton.Name = "minMaxUOHButton";
            this.minMaxUOHButton.Size = new System.Drawing.Size(307, 157);
            this.minMaxUOHButton.TabIndex = 5;
            this.minMaxUOHButton.Text = "Find Products with Minimum and Maximum Units on Hand";
            this.minMaxUOHButton.UseVisualStyleBackColor = true;
            this.minMaxUOHButton.Click += new System.EventHandler(this.minMaxUOHButton_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(283, 1075);
            this.minTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(452, 38);
            this.minTextBox.TabIndex = 6;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(32, 1075);
            this.minLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(192, 46);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "Minimum:";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(283, 1185);
            this.maxTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(452, 38);
            this.maxTextBox.TabIndex = 8;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(32, 1180);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(204, 46);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "Maximum:";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 1483);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minMaxUOHButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.descButton);
            this.Controls.Add(this.productNumberButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.productListBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button productNumberButton;
        private System.Windows.Forms.Button descButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minMaxUOHButton;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label maxLabel;
    }
}

