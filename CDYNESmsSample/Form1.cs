using System;
using System.Windows.Forms;
using CDYNESmsSample.SmsService;

namespace CDYNESmsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendButtonClick(object sender, EventArgs e)
        {
            using (var smsClient = new IsmsClient("sms2SOAPbasicHttpBinding"))
            {
                // Trim + from begining of phone number 
                var phoneNumber = _phoneNumberTextBox.Text.TrimStart('+');

                // For international (NOT US) numbers add prefix 011 
                var prefix = _usaRadioButton.Checked ? string.Empty : "011"; 

                phoneNumber = prefix + phoneNumber;

                var response = smsClient.SimpleSMSsend(phoneNumber, _messageTextBox.Text, new Guid(_keyTextBox.Text));

                MessageBox.Show(response.SMSError == SMSErrors.NoError ? "SMS sent successfully!" : string.Format("SMS was not sent successfully!\nError: {0}", response.SMSError));
            }
        }

        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
