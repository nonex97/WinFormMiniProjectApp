namespace WinFormMiniProject
{
    partial class PersonEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            textBox1 = new TextBox();
            checkboxLabel = new Label();
            activeCheckBox = new CheckBox();
            addressesLabel = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(15, 17);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(150, 10);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(224, 39);
            firstNameTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 39);
            textBox1.TabIndex = 1;
            // 
            // checkboxLabel
            // 
            checkboxLabel.AutoSize = true;
            checkboxLabel.Location = new Point(15, 115);
            checkboxLabel.Name = "checkboxLabel";
            checkboxLabel.Size = new Size(79, 32);
            checkboxLabel.TabIndex = 2;
            checkboxLabel.Text = "Active";
            // 
            // activeCheckBox
            // 
            activeCheckBox.AutoSize = true;
            activeCheckBox.Location = new Point(150, 125);
            activeCheckBox.Name = "activeCheckBox";
            activeCheckBox.Size = new Size(15, 14);
            activeCheckBox.TabIndex = 3;
            activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressesLabel
            // 
            addressesLabel.AutoSize = true;
            addressesLabel.Location = new Point(15, 174);
            addressesLabel.Name = "addressesLabel";
            addressesLabel.Size = new Size(121, 32);
            addressesLabel.TabIndex = 4;
            addressesLabel.Text = "Addresses";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 209);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(359, 228);
            listBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(299, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 475);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(addressesLabel);
            Controls.Add(activeCheckBox);
            Controls.Add(checkboxLabel);
            Controls.Add(textBox1);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "PersonEntry";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox textBox1;
        private Label checkboxLabel;
        private CheckBox activeCheckBox;
        private Label addressesLabel;
        private ListBox listBox1;
        private Button button1;
    }
}
