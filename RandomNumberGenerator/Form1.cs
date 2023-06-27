namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random r = new Random();
        int minValue;
        int maxValue;


        private void generateButton_Click(object sender, EventArgs e)
        {


            if (!int.TryParse(minValueTextBox.Text, out minValue))
            {
                MessageBox.Show("Invalid minimum value!");
                return;
            }

            if (!int.TryParse(maxValueTextBox.Text, out maxValue))
            { 
                MessageBox.Show("Invalid maximum value!"); 
                return;
            }

            int randomNumber = r.Next(minValue, maxValue + 1);
             numberLabel.Text = randomNumber.ToString(); 
        }
    }
}