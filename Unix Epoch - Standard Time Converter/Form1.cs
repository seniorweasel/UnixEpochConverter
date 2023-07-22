namespace Unix_Epoch___Standard_Time_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private DateTime FromUnixTime(long epochTime)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return unixEpoch.AddSeconds(epochTime).ToLocalTime();
        }

        private long ToUnixTime(DateTime standardTime)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = standardTime - unixEpoch;
            return (long)timeSpan.TotalSeconds;
        }

        private void ConvertToEpochButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime standardTime = standardTimePicker.Value;
                long epochTime = ToUnixTime(standardTime);
                epochTextBox.Text = epochTime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertToStandardButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                long epochTime = long.Parse(epochTextBox.Text);
                DateTime standardTime = FromUnixTime(epochTime);
                standardTimePicker.Value = standardTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}