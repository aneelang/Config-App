using System.Text.RegularExpressions;


namespace Config_App
{
    public partial class Form1 : Form
    {

        private String inputURL;
        private String inputAPN;
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {

            if (rbGPRS.Checked == true)
            {
                
                MessageBox.Show($" URL: { getInputUrl()}\n APN: {textBoxAPN.Text}\n Port Type: {comboBoxPort.Text}");
            }
            else if (rbWIFI.Checked == true)
            {
                MessageBox.Show($" Local Host: {textBoxLocalHost.Text}\n SSID: {textBoxSSID.Text}\n Password: {textBoxPassword.Text}\n Port Type: {comboBoxPort.Text}");
            }
            else if (rbBoth.Checked == true)
            {
                MessageBox.Show($" URL: { textBoxURL.Text} || \tAPN: {textBoxAPN.Text}\n\nLocal Host: {textBoxLocalHost.Text} || \tSSID: {textBoxSSID.Text} || \tPassword: {textBoxPassword.Text}\n" +
                    $"{comboBoxPort.Text}");

            }

        }

        private void rbGPRS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGPRS.Checked == true)
            {
                groupBoxGPRS.Enabled = true;
                groupBoxWIFI.Enabled = false;
            }

        }

        private void rbWIFI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWIFI.Checked == true)
            {
                groupBoxWIFI.Enabled = true;
                groupBoxGPRS.Enabled = false;
            }
        }

        private void rbBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBoth.Checked == true)
            {
                groupBoxGPRS.Enabled = true;
                groupBoxWIFI.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxGPRS.Enabled = false;
            groupBoxWIFI.Enabled=false;
        }
        private void setInputUrl(TextBox textBox)
        {
            inputURL = textBox.Text;
        }

        private void setInputAPN(TextBox textBox)
        {
            inputAPN = textBox.Text;
        }

        private String getInputAPN()
        {
            return inputAPN;
        }

        private String getInputUrl()
        {
            return inputURL;
        }

        private bool validateInputURL(String inputText)
        {
            Regex validateURLRegex = new Regex("^https ?:\\/\\/ (?: www\\.)?[-a - zA - Z0 - 9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$");
            if (!validateURLRegex.IsMatch(getInputUrl()))
            {
                return false;
            }
            return true;
        }

        private bool validateInputAPN(String inputText)
        {
            return true;
        }


        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            setInputUrl(textBoxURL);
        }
    }
}