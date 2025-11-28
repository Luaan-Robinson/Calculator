namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "-";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "/";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "3";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "+";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += ".";
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "*";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text.Substring(0, TextBox.TextLength - 1);
        }

        private void Modulusbutton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "%";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }
    }
}
