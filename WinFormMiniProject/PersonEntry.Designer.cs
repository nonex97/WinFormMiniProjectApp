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
            lastNameText = new TextBox();
            checkboxLabel = new Label();
            isActive = new CheckBox();
            addressesLabel = new Label();
            addressesList = new ListBox();
            button1 = new Button();
            saveButton = new Button();
            lastNameLabel = new Label();
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
            // lastNameText
            // 
            lastNameText.Location = new Point(150, 55);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(224, 39);
            lastNameText.TabIndex = 2;
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
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(150, 125);
            isActive.Name = "isActive";
            isActive.Size = new Size(15, 14);
            isActive.TabIndex = 3;
            isActive.UseVisualStyleBackColor = true;
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
            // addressesList
            // 
            addressesList.FormattingEnabled = true;
            addressesList.Location = new Point(15, 209);
            addressesList.Name = "addressesList";
            addressesList.Size = new Size(539, 228);
            addressesList.TabIndex = 6;
            addressesList.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(479, 170);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(182, 452);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(212, 42);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(15, 62);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 506);
            Controls.Add(saveButton);
            Controls.Add(button1);
            Controls.Add(addressesList);
            Controls.Add(addressesLabel);
            Controls.Add(isActive);
            Controls.Add(checkboxLabel);
            Controls.Add(lastNameText);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "PersonEntry";
            Text = "Person Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameText;
        private Label checkboxLabel;
        private CheckBox isActive;
        private Label addressesLabel;
        private ListBox addressesList;
        private Button button1;
        private Button saveButton;
        private Label lastNameLabel;
    }
}
