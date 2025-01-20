namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbCoffeePrice = new TextBox();
            tbGreenteaPrice = new TextBox();
            chbCoffee = new CheckBox();
            chbGreentea = new CheckBox();
            tbTotal = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tbCoffeeQuantity = new TextBox();
            tbGreenteaQuantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tbCash = new TextBox();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tbPizzaPrice = new TextBox();
            tbPastaPrice = new TextBox();
            tbPizzaQuantity = new TextBox();
            tbPastaQuantity = new TextBox();
            chbPizza = new CheckBox();
            chbPasta = new CheckBox();
            groupBox3 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            tbDiscountFood = new TextBox();
            tbDiscountBeverage = new TextBox();
            tbDiscountAll = new TextBox();
            chbFood = new CheckBox();
            chbBeverage = new CheckBox();
            chbAll = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(320, 30);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(150, 31);
            tbCoffeePrice.TabIndex = 1;
            // 
            // tbGreenteaPrice
            // 
            tbGreenteaPrice.Location = new Point(320, 69);
            tbGreenteaPrice.Name = "tbGreenteaPrice";
            tbGreenteaPrice.Size = new Size(150, 31);
            tbGreenteaPrice.TabIndex = 2;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(18, 30);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(90, 29);
            chbCoffee.TabIndex = 3;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreentea
            // 
            chbGreentea.AutoSize = true;
            chbGreentea.Location = new Point(18, 71);
            chbGreentea.Name = "chbGreentea";
            chbGreentea.Size = new Size(108, 29);
            chbGreentea.TabIndex = 4;
            chbGreentea.Text = "Greentea";
            chbGreentea.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(678, 30);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(150, 31);
            tbTotal.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(678, 449);
            button1.Name = "button1";
            button1.Size = new Size(150, 133);
            button1.TabIndex = 6;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(566, 36);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(151, 30);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(150, 31);
            tbCoffeeQuantity.TabIndex = 8;
            tbCoffeeQuantity.TextChanged += tbCoffeeQuantity_TextChanged;
            // 
            // tbGreenteaQuantity
            // 
            tbGreenteaQuantity.Location = new Point(151, 69);
            tbGreenteaQuantity.Name = "tbGreenteaQuantity";
            tbGreenteaQuantity.Size = new Size(150, 31);
            tbGreenteaQuantity.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 90);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 36);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 92);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(566, 73);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 14;
            label6.Text = "Cash";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(566, 110);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 15;
            label7.Text = "Change";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(566, 147);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 16;
            label8.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 183);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 17;
            label9.Text = "500";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(566, 224);
            label10.Name = "label10";
            label10.Size = new Size(42, 25);
            label10.TabIndex = 18;
            label10.Text = "100";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(566, 264);
            label11.Name = "label11";
            label11.Size = new Size(32, 25);
            label11.TabIndex = 19;
            label11.Text = "50";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(566, 301);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 20;
            label12.Text = "20";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(566, 341);
            label13.Name = "label13";
            label13.Size = new Size(32, 25);
            label13.TabIndex = 21;
            label13.Text = "10";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(566, 381);
            label14.Name = "label14";
            label14.Size = new Size(22, 25);
            label14.TabIndex = 22;
            label14.Text = "5";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(566, 418);
            label15.Name = "label15";
            label15.Size = new Size(22, 25);
            label15.TabIndex = 23;
            label15.Text = "1";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(678, 70);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(150, 31);
            tbCash.TabIndex = 24;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(678, 107);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(150, 31);
            tbChange.TabIndex = 25;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(678, 144);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(150, 31);
            tb1000.TabIndex = 26;
            // 
            // tb500
            // 
            tb500.Location = new Point(678, 184);
            tb500.Name = "tb500";
            tb500.Size = new Size(150, 31);
            tb500.TabIndex = 27;
            // 
            // tb100
            // 
            tb100.Location = new Point(678, 224);
            tb100.Name = "tb100";
            tb100.Size = new Size(150, 31);
            tb100.TabIndex = 28;
            // 
            // tb50
            // 
            tb50.Location = new Point(678, 264);
            tb50.Name = "tb50";
            tb50.Size = new Size(150, 31);
            tb50.TabIndex = 29;
            // 
            // tb20
            // 
            tb20.Location = new Point(678, 301);
            tb20.Name = "tb20";
            tb20.Size = new Size(150, 31);
            tb20.TabIndex = 30;
            // 
            // tb10
            // 
            tb10.Location = new Point(678, 338);
            tb10.Name = "tb10";
            tb10.Size = new Size(150, 31);
            tb10.TabIndex = 31;
            // 
            // tb5
            // 
            tb5.Location = new Point(678, 375);
            tb5.Name = "tb5";
            tb5.Size = new Size(150, 31);
            tb5.TabIndex = 32;
            // 
            // tb1
            // 
            tb1.Location = new Point(678, 412);
            tb1.Name = "tb1";
            tb1.Size = new Size(150, 31);
            tb1.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGreenteaPrice);
            groupBox1.Controls.Add(chbCoffee);
            groupBox1.Controls.Add(chbGreentea);
            groupBox1.Controls.Add(tbCoffeePrice);
            groupBox1.Controls.Add(tbCoffeeQuantity);
            groupBox1.Controls.Add(tbGreenteaQuantity);
            groupBox1.Location = new Point(26, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 121);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Controls.Add(tbPastaPrice);
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Controls.Add(tbPastaQuantity);
            groupBox2.Controls.Add(chbPizza);
            groupBox2.Controls.Add(chbPasta);
            groupBox2.Location = new Point(27, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 124);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(319, 74);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(150, 31);
            tbPizzaPrice.TabIndex = 41;
            // 
            // tbPastaPrice
            // 
            tbPastaPrice.Location = new Point(319, 30);
            tbPastaPrice.Name = "tbPastaPrice";
            tbPastaPrice.Size = new Size(150, 31);
            tbPastaPrice.TabIndex = 40;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(150, 74);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(150, 31);
            tbPizzaQuantity.TabIndex = 39;
            // 
            // tbPastaQuantity
            // 
            tbPastaQuantity.Location = new Point(150, 30);
            tbPastaQuantity.Name = "tbPastaQuantity";
            tbPastaQuantity.Size = new Size(150, 31);
            tbPastaQuantity.TabIndex = 38;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.Location = new Point(17, 74);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(77, 29);
            chbPizza.TabIndex = 37;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // chbPasta
            // 
            chbPasta.AutoSize = true;
            chbPasta.Location = new Point(15, 33);
            chbPasta.Name = "chbPasta";
            chbPasta.Size = new Size(79, 29);
            chbPasta.TabIndex = 36;
            chbPasta.Text = "Pasta";
            chbPasta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(tbDiscountFood);
            groupBox3.Controls.Add(tbDiscountBeverage);
            groupBox3.Controls.Add(tbDiscountAll);
            groupBox3.Controls.Add(chbFood);
            groupBox3.Controls.Add(chbBeverage);
            groupBox3.Controls.Add(chbAll);
            groupBox3.Location = new Point(27, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(505, 198);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Discount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(406, 138);
            label18.Name = "label18";
            label18.Size = new Size(27, 25);
            label18.TabIndex = 8;
            label18.Text = "%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(406, 93);
            label17.Name = "label17";
            label17.Size = new Size(27, 25);
            label17.TabIndex = 7;
            label17.Text = "%";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(406, 46);
            label16.Name = "label16";
            label16.Size = new Size(27, 25);
            label16.TabIndex = 6;
            label16.Text = "%";
            // 
            // tbDiscountFood
            // 
            tbDiscountFood.Location = new Point(250, 137);
            tbDiscountFood.Name = "tbDiscountFood";
            tbDiscountFood.Size = new Size(150, 31);
            tbDiscountFood.TabIndex = 5;
            // 
            // tbDiscountBeverage
            // 
            tbDiscountBeverage.Location = new Point(250, 90);
            tbDiscountBeverage.Name = "tbDiscountBeverage";
            tbDiscountBeverage.Size = new Size(150, 31);
            tbDiscountBeverage.TabIndex = 4;
            // 
            // tbDiscountAll
            // 
            tbDiscountAll.Location = new Point(250, 44);
            tbDiscountAll.Name = "tbDiscountAll";
            tbDiscountAll.Size = new Size(150, 31);
            tbDiscountAll.TabIndex = 3;
            // 
            // chbFood
            // 
            chbFood.AutoSize = true;
            chbFood.Location = new Point(15, 137);
            chbFood.Name = "chbFood";
            chbFood.Size = new Size(80, 29);
            chbFood.TabIndex = 2;
            chbFood.Text = "Food";
            chbFood.UseVisualStyleBackColor = true;
            // 
            // chbBeverage
            // 
            chbBeverage.AutoSize = true;
            chbBeverage.Location = new Point(15, 92);
            chbBeverage.Name = "chbBeverage";
            chbBeverage.Size = new Size(110, 29);
            chbBeverage.TabIndex = 1;
            chbBeverage.Text = "Beverage";
            chbBeverage.UseVisualStyleBackColor = true;
            // 
            // chbAll
            // 
            chbAll.AutoSize = true;
            chbAll.Location = new Point(15, 46);
            chbAll.Name = "chbAll";
            chbAll.Size = new Size(58, 29);
            chbAll.TabIndex = 0;
            chbAll.Text = "All";
            chbAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tbTotal);
            Name = "Form1";
            Text = " POS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private TextBox tbGreenteaPrice;
        private CheckBox chbCoffee;
        private CheckBox chbGreentea;
        private TextBox tbTotal;
        private Button button1;
        private Label label1;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenteaQuantity;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tbCash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chbPasta;
        private TextBox tbPizzaPrice;
        private TextBox tbPastaPrice;
        private TextBox tbPizzaQuantity;
        private TextBox tbPastaQuantity;
        private CheckBox chbPizza;
        private GroupBox groupBox3;
        private CheckBox chbFood;
        private CheckBox chbBeverage;
        private CheckBox chbAll;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox tbDiscountFood;
        private TextBox tbDiscountBeverage;
        private TextBox tbDiscountAll;
    }
}
