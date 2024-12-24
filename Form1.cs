namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCoffeePrice = tbCoffeePrice.Text; 
            string strCoffeeQuantity = tbCoffeeQuantity.Text;
            int iCoffeePrice = 0;
            int iCoffeeQuantity = 0;
            try
            {
                if (chbCoffee.Checked) 
                {
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
                
            }
            catch (Exception ex) 
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
            }
            string strGreenteaPrice = tbGreenteaPrice.Text;
            string strGreenteaQuantity = tbGreenteaQuantity.Text;
            int iGreenteaPrice = 0;
            int iGreenteaQuantity = 0;
            try
            {
                if (chbGreentea.Checked)
                {
                    iGreenteaPrice = int.Parse(strGreenteaPrice);
                    iGreenteaQuantity = int.Parse(strGreenteaQuantity);
                }
            }
            catch(Exception ex) 
            {
                iGreenteaPrice = 0;
                iGreenteaQuantity = 0;
            }
            int iCoffeeTotal = iCoffeePrice * iCoffeeQuantity;
            int iGreenteaTotal = iGreenteaPrice * iGreenteaQuantity;
            int iTotal = iCoffeeTotal + iGreenteaTotal;

            tbTotal.Text = iTotal.ToString();

        }
    }
}
