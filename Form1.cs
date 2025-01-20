namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateTotal()
        {
            int iCoffeePrice = chbCoffee.Checked ? int.Parse(tbCoffeePrice.Text) : 0;
            int iCoffeeQuantity = chbCoffee.Checked ? int.Parse(tbCoffeeQuantity.Text) : 0;
            int iGreenteaPrice = chbGreentea.Checked ? int.Parse(tbGreenteaPrice.Text) : 0;
            int iGreenteaQuantity = chbGreentea.Checked ? int.Parse(tbGreenteaQuantity.Text) : 0;

            int iPastaPrice = chbPasta.Checked ? int.Parse(tbPastaPrice.Text) : 0;
            int iPastaQuantity = chbPasta.Checked ? int.Parse(tbPastaQuantity.Text) : 0;
            int iPizzaPrice = chbPizza.Checked ? int.Parse(tbPizzaPrice.Text) : 0;
            int iPizzaQuantity = chbPizza.Checked ? int.Parse(tbPizzaQuantity.Text) : 0;

            return (iCoffeePrice * iCoffeeQuantity) +
                   (iGreenteaPrice * iGreenteaQuantity) +
                   (iPastaPrice * iPastaQuantity) +
                   (iPizzaPrice * iPizzaQuantity);
        }
        private int ApplyDiscount(int total)
        {
            if (chbAll.Checked)
            {
                int discountAll = int.Parse(tbDiscountAll.Text);
                total -= (total * discountAll / 100);
            }
            else
            {
                if (chbBeverage.Checked)
                {
                    int beverageTotal = CalculateBeverageTotal();
                    int discountBeverage = int.Parse(tbDiscountBeverage.Text);
                    total -= (beverageTotal * discountBeverage / 100);
                }
                if (chbFood.Checked)
                {
                    int foodTotal = CalculateFoodTotal();
                    int discountFood = int.Parse(tbDiscountFood.Text);
                    total -= (foodTotal * discountFood / 100);
                }
            }
            return total;
        }
        private int CalculateBeverageTotal()
        {
            int iCoffeePrice = chbCoffee.Checked ? int.Parse(tbCoffeePrice.Text) : 0;
            int iCoffeeQuantity = chbCoffee.Checked ? int.Parse(tbCoffeeQuantity.Text) : 0;
            int iGreenteaPrice = chbGreentea.Checked ? int.Parse(tbGreenteaPrice.Text) : 0;
            int iGreenteaQuantity = chbGreentea.Checked ? int.Parse(tbGreenteaQuantity.Text) : 0;
            return (iCoffeePrice * iCoffeeQuantity) + (iGreenteaPrice * iGreenteaQuantity);
        }
        private int CalculateFoodTotal()
        {
            int iPastaPrice = chbPasta.Checked ? int.Parse(tbPastaPrice.Text) : 0;
            int iPastaQuantity = chbPasta.Checked ? int.Parse(tbPastaQuantity.Text) : 0;
            int iPizzaPrice = chbPizza.Checked ? int.Parse(tbPizzaPrice.Text) : 0;
            int iPizzaQuantity = chbPizza.Checked ? int.Parse(tbPizzaQuantity.Text) : 0;
            return (iPastaPrice * iPastaQuantity) + (iPizzaPrice * iPizzaQuantity);
        }
        private int CalculateChange(int cash, int total)
        {
            return cash - total;
        }
        private void DisplayChangeBreakdown(int change)
        {
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                denominationTextBoxes[i].Text = (change / denominations[i]).ToString();
                change %= denominations[i];
            }
        }
        
        private bool ValidateInputs()
        {

            if ((chbCoffee.Checked && (!IsValidPositiveNumber(tbCoffeePrice.Text) || !IsValidPositiveNumber(tbCoffeeQuantity.Text))) ||
               (chbGreentea.Checked && (!IsValidPositiveNumber(tbGreenteaPrice.Text) || !IsValidPositiveNumber(tbGreenteaQuantity.Text))) ||
               (chbPasta.Checked && (!IsValidPositiveNumber(tbPastaQuantity.Text) || !IsValidPositiveNumber(tbPastaPrice.Text))) ||
               (chbPizza.Checked && (!IsValidPositiveNumber(tbPastaQuantity.Text) || !IsValidPositiveNumber(tbPastaPrice.Text))))
            {
                MessageBox.Show("กรุณาใส่ข้อมูลราคาหรือจำนวนสินค้าเป็นตัวเลขบวกเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if ((chbAll.Checked && string.IsNullOrEmpty(tbDiscountAll.Text)) ||
                (chbBeverage.Checked && string.IsNullOrEmpty(tbDiscountBeverage.Text)) ||
                (chbFood.Checked && string.IsNullOrEmpty(tbDiscountFood.Text)))
            {
                MessageBox.Show("กรุณาใส่ข้อมูลส่วนลดเป็นตัวเลขบวกเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (!IsValidPositiveNumber(tbCash.Text))
            {
                MessageBox.Show("กรุณาใส่จำนวนเงินสดเป็นตัวเลขบวกเท่านั้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidPositiveNumber(string input)
        {
            if (int.TryParse(input, out int value))
            {
                return value >= 0;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่องที่จำเป็น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iTotal = CalculateTotal();
            iTotal = ApplyDiscount(iTotal);
            tbTotal.Text = iTotal.ToString();

            if (!int.TryParse(tbCash.Text, out int iCash))
            {
                MessageBox.Show("กรุณาใส่จำนวนเงินสดที่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (iCash < iTotal)
            {
                MessageBox.Show("ยอดเงินไม่พอ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iChange = CalculateChange(iCash, iTotal);
            tbChange.Text = iChange.ToString();


            DisplayChangeBreakdown(iChange);
        }
    

    

        private void tbCoffeeQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
