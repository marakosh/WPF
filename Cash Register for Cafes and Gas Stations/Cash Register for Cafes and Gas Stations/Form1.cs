using System.Diagnostics;
using System.Security.Cryptography;

namespace Cash_Register_for_Cafes_and_Gas_Stations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Count_textBox1.Text = "0";
            Sum_textBox2.Text = "0";
        }
        #region empty
        private void Form1_Load(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void checkBox1_CheckedChanged(object sender, EventArgs e){}
        private void CountC_textBox1_TextChanged(object sender, EventArgs e) { }
        private void CountF_textBox4_TextChanged(object sender, EventArgs e) { }
        private void FullPrice_textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Price_textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        #endregion
        private void Oil_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Oil_comboBox1.SelectedIndex)
            {
                case 0:
                    Price_textBox1.Text = "1";
                    break;
                case 1:
                    Price_textBox1.Text = "2";
                    break;
                case 2:
                    Price_textBox1.Text = "0.8";

                    break;

            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Count_textBox1.ReadOnly = false;
        }

        private void Sum_radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Sum_textBox2.ReadOnly = false;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Sum_textBox2.Text == "0")
            {
                float oil_count = Convert.ToSingle(Count_textBox1.Text);
                
                double price = Convert.ToDouble(Price_textBox1.Text);
                Sum_textBox2.Text = Convert.ToString(oil_count * price);
                FullOIlPrice_textBox1.Text = Sum_textBox2.Text;
                Count_textBox1.ReadOnly = true;
            }
            else if (Count_textBox1.Text == "0")
            {
                double oil = Convert.ToDouble(Price_textBox1.Text);
                float oil_price = Convert.ToSingle(Sum_textBox2.Text);
                Count_textBox1.Text = Convert.ToString(oil_price / oil);
                FullOIlPrice_textBox1.Text = Sum_textBox2.Text;
                Sum_textBox2.ReadOnly = true;
            }
        }
      
        private void Clear_button1_Click(object sender, EventArgs e)
        {
            Count_textBox1.Text = "0";
            Sum_textBox2.Text = "0";
            //Sum_textBox2.ReadOnly = true;
            //Count_textBox1.ReadOnly = true;
        }
        
        private void FrenchFries_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CountF_textBox4.ReadOnly = false;
        }
        private void HotDog_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CountH_textBox3.ReadOnly = false;
        }

        private void Hamburger_checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CountH_textBox2.ReadOnly = false;
        }

        private void Cola_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CountC_textBox1.ReadOnly = false;
        }

        private void CalcEat_button1_Click(object sender, EventArgs e)
        {
            int frenchFries = Convert.ToInt32(CountF_textBox4.Text);
            int HotDog = Convert.ToInt32(CountH_textBox3.Text);
            int Hamburger = Convert.ToInt32(CountH_textBox2.Text);
            int Cola = Convert.ToInt32(CountC_textBox1.Text);

            int fPrice = Convert.ToInt32(FrenchFries_textBox1.Text);
            int hdPrice = Convert.ToInt32(HotDog_textBox2.Text);
            int hPrice = Convert.ToInt32(Hamburger_textBox3.Text);
            int cPrice = Convert.ToInt32(Cola_textBox4.Text);

            FullEatSum_textBox1.Text = Convert.ToString((frenchFries * fPrice) +
                                (HotDog * hdPrice) +
                                (Hamburger * hPrice) +
                                (Cola * cPrice));
        }

        private void ClearEat_button2_Click(object sender, EventArgs e)
        {
            CountF_textBox4.Text = "0";
            CountH_textBox3.Text = "0";
            CountH_textBox2.Text = "0";
            CountC_textBox1.Text = "0";

            FullEatSum_textBox1.Text = "0";

            CountF_textBox4.ReadOnly = true;
            CountH_textBox3.ReadOnly = true;
            CountH_textBox2.ReadOnly = true;
            CountC_textBox1.ReadOnly = true;

            FrenchFries_checkBox1.Checked = false;
            HotDog_checkBox2.Checked = false;
            Hamburger_checkBox3.Checked = false;
            Cola_checkBox4.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int oilPice = Convert.ToInt32(FullOIlPrice_textBox1.Text);
            int eatPrice = Convert.ToInt32(FullEatSum_textBox1.Text);
            FullPrice_textBox1.Text = Convert.ToString(oilPice + eatPrice);
        }
    }
}