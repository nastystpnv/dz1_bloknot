namespace dz1_bloknot
{
    partial class FontSettings
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
            this.ExampleLable = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExampleLable
            // 
            this.ExampleLable.AutoSize = true;
            this.ExampleLable.Location = new System.Drawing.Point(26, 73);
            this.ExampleLable.Name = "ExampleLable";
            this.ExampleLable.Size = new System.Drawing.Size(49, 13);
            this.ExampleLable.TabIndex = 1;
            this.ExampleLable.Text = "образец";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleText.Location = new System.Drawing.Point(22, 86);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(181, 39);
            this.ExampleText.TabIndex = 2;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.fontBox.Location = new System.Drawing.Point(1, 12);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(105, 21);
            this.fontBox.TabIndex = 4;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "жирный"});
            this.styleBox.Location = new System.Drawing.Point(112, 12);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(100, 21);
            this.styleBox.TabIndex = 5;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLable);
            this.Name = "FontSettings";
            this.Text = "шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLable;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button button1;
    }
}