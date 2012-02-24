namespace CDYNESmsSample
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
            this._messageTextBox = new System.Windows.Forms.TextBox();
            this._messageLabel = new System.Windows.Forms.Label();
            this._keyLabel = new System.Windows.Forms.Label();
            this._sendButton = new System.Windows.Forms.Button();
            this._usaRadioButton = new System.Windows.Forms.RadioButton();
            this._internationalRadioButton = new System.Windows.Forms.RadioButton();
            this._phoneNumberGroupBox = new System.Windows.Forms.GroupBox();
            this._phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this._keyTextBox = new System.Windows.Forms.TextBox();
            this._close = new System.Windows.Forms.Button();
            this._phoneNumberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _messageTextBox
            // 
            this._messageTextBox.Location = new System.Drawing.Point(12, 58);
            this._messageTextBox.MaxLength = 160;
            this._messageTextBox.Multiline = true;
            this._messageTextBox.Name = "_messageTextBox";
            this._messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._messageTextBox.Size = new System.Drawing.Size(259, 121);
            this._messageTextBox.TabIndex = 0;
            // 
            // _messageLabel
            // 
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(12, 42);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(50, 13);
            this._messageLabel.TabIndex = 2;
            this._messageLabel.Text = "SMS text";
            // 
            // _keyLabel
            // 
            this._keyLabel.AutoSize = true;
            this._keyLabel.Location = new System.Drawing.Point(12, 19);
            this._keyLabel.Name = "_keyLabel";
            this._keyLabel.Size = new System.Drawing.Size(25, 13);
            this._keyLabel.TabIndex = 3;
            this._keyLabel.Text = "Key";
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(118, 263);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(75, 23);
            this._sendButton.TabIndex = 6;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this.SendButtonClick);
            // 
            // _usaRadioButton
            // 
            this._usaRadioButton.AutoSize = true;
            this._usaRadioButton.Checked = true;
            this._usaRadioButton.Location = new System.Drawing.Point(12, 19);
            this._usaRadioButton.Name = "_usaRadioButton";
            this._usaRadioButton.Size = new System.Drawing.Size(47, 17);
            this._usaRadioButton.TabIndex = 7;
            this._usaRadioButton.TabStop = true;
            this._usaRadioButton.Text = "USA";
            this._usaRadioButton.UseVisualStyleBackColor = true;
            // 
            // _internationalRadioButton
            // 
            this._internationalRadioButton.AutoSize = true;
            this._internationalRadioButton.Location = new System.Drawing.Point(170, 19);
            this._internationalRadioButton.Name = "_internationalRadioButton";
            this._internationalRadioButton.Size = new System.Drawing.Size(83, 17);
            this._internationalRadioButton.TabIndex = 8;
            this._internationalRadioButton.Text = "International";
            this._internationalRadioButton.UseVisualStyleBackColor = true;
            // 
            // _phoneNumberGroupBox
            // 
            this._phoneNumberGroupBox.Controls.Add(this._phoneNumberTextBox);
            this._phoneNumberGroupBox.Controls.Add(this._internationalRadioButton);
            this._phoneNumberGroupBox.Controls.Add(this._usaRadioButton);
            this._phoneNumberGroupBox.Location = new System.Drawing.Point(12, 185);
            this._phoneNumberGroupBox.Name = "_phoneNumberGroupBox";
            this._phoneNumberGroupBox.Size = new System.Drawing.Size(259, 72);
            this._phoneNumberGroupBox.TabIndex = 9;
            this._phoneNumberGroupBox.TabStop = false;
            this._phoneNumberGroupBox.Text = "Phone number";
            // 
            // _phoneNumberTextBox
            // 
            this._phoneNumberTextBox.Location = new System.Drawing.Point(12, 42);
            this._phoneNumberTextBox.Name = "_phoneNumberTextBox";
            this._phoneNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this._phoneNumberTextBox.TabIndex = 9;
            // 
            // _keyTextBox
            // 
            this._keyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CDYNESmsSample.Properties.Settings.Default, "Key", true));
            this._keyTextBox.Location = new System.Drawing.Point(43, 15);
            this._keyTextBox.Name = "_keyTextBox";
            this._keyTextBox.Size = new System.Drawing.Size(228, 20);
            this._keyTextBox.TabIndex = 1;
            this._keyTextBox.Text = global::CDYNESmsSample.Properties.Settings.Default.Key;
            // 
            // _close
            // 
            this._close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._close.Location = new System.Drawing.Point(199, 263);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(75, 23);
            this._close.TabIndex = 10;
            this._close.Text = "Close";
            this._close.UseVisualStyleBackColor = true;
            this._close.Click += new System.EventHandler(this.CloseClick);
            // 
            // Form1
            // 
            this.AcceptButton = this._sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._close;
            this.ClientSize = new System.Drawing.Size(286, 298);
            this.Controls.Add(this._close);
            this.Controls.Add(this._phoneNumberGroupBox);
            this.Controls.Add(this._sendButton);
            this.Controls.Add(this._keyLabel);
            this.Controls.Add(this._messageLabel);
            this.Controls.Add(this._keyTextBox);
            this.Controls.Add(this._messageTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send SMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this._phoneNumberGroupBox.ResumeLayout(false);
            this._phoneNumberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _messageTextBox;
        private System.Windows.Forms.TextBox _keyTextBox;
        private System.Windows.Forms.Label _messageLabel;
        private System.Windows.Forms.Label _keyLabel;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.RadioButton _usaRadioButton;
        private System.Windows.Forms.RadioButton _internationalRadioButton;
        private System.Windows.Forms.GroupBox _phoneNumberGroupBox;
        private System.Windows.Forms.TextBox _phoneNumberTextBox;
        private System.Windows.Forms.Button _close;
    }
}

