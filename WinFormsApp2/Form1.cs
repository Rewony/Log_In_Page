namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("ankara");
            comboBox1.Items.Add("elbistan");
            comboBox1.Items.Add("sakarya");


        }

        private void Btngiris_Click(object sender, EventArgs e)
        {
            string ka = tboxka.Text;
            string sifre = textpass.Text;
            
            if (ka == "admin")
            {

                if (sifre == "admin")
                {

                    lablsonuc.Text = "giri� ba�ar�l�";
                    

                }

                else
                    lablsonuc.Text = "�ifre yanl��";

            }

            else
                lablsonuc.Text = "kullan�c� ad� yanl��";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilensehir = comboBox1.SelectedItem.ToString();
            labelsehir.Text = $"{secilensehir} �ehrini se�tiniz";

        }
    }
}