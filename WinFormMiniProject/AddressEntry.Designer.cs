namespace WinFormMiniProject
{
    partial class AddressEntry
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
            cityText = new TextBox();
            streetAddressText = new TextBox();
            cityLabel = new Label();
            streetAddressLabel = new Label();
            zipCodeText = new TextBox();
            stateText = new TextBox();
            zipCodeLabel = new Label();
            stateLabel = new Label();
            saveButton = new Button();
            headerLabel = new Label();
            SuspendLayout();
            // 
            // cityText
            // 
            cityText.Location = new Point(147, 119);
            cityText.Name = "cityText";
            cityText.Size = new Size(270, 39);
            cityText.TabIndex = 6;
            // 
            // streetAddressText
            // 
            streetAddressText.Location = new Point(147, 74);
            streetAddressText.Name = "streetAddressText";
            streetAddressText.Size = new Size(270, 39);
            streetAddressText.TabIndex = 5;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(12, 126);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(55, 32);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City";
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(12, 81);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(76, 32);
            streetAddressLabel.TabIndex = 4;
            streetAddressLabel.Text = "Street";
            // 
            // zipCodeText
            // 
            zipCodeText.Location = new Point(147, 209);
            zipCodeText.Name = "zipCodeText";
            zipCodeText.Size = new Size(270, 39);
            zipCodeText.TabIndex = 10;
            // 
            // stateText
            // 
            stateText.Location = new Point(147, 164);
            stateText.Name = "stateText";
            stateText.Size = new Size(270, 39);
            stateText.TabIndex = 9;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(12, 216);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(107, 32);
            zipCodeLabel.TabIndex = 7;
            zipCodeLabel.Text = "Zip code";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(12, 171);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(67, 32);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(147, 268);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 40);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(102, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(250, 47);
            headerLabel.TabIndex = 12;
            headerLabel.Text = "Address Entry";
            // 
            // AddressEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 334);
            Controls.Add(headerLabel);
            Controls.Add(saveButton);
            Controls.Add(zipCodeText);
            Controls.Add(stateText);
            Controls.Add(zipCodeLabel);
            Controls.Add(stateLabel);
            Controls.Add(cityText);
            Controls.Add(streetAddressText);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "AddressEntry";
            Text = "Address Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cityText;
        private TextBox streetAddressText;
        private Label cityLabel;
        private Label streetAddressLabel;
        private TextBox zipCodeText;
        private TextBox stateText;
        private Label zipCodeLabel;
        private Label stateLabel;
        private Button saveButton;
        private Label headerLabel;
    }
}