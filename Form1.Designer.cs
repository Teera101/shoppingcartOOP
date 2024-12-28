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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(346, 33);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(150, 31);
            tbCoffeePrice.TabIndex = 1;
            // 
            // tbGreenteaPrice
            // 
            tbGreenteaPrice.Location = new Point(346, 86);
            tbGreenteaPrice.Name = "tbGreenteaPrice";
            tbGreenteaPrice.Size = new Size(150, 31);
            tbGreenteaPrice.TabIndex = 2;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(144, 33);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(90, 29);
            chbCoffee.TabIndex = 3;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreentea
            // 
            chbGreentea.AutoSize = true;
            chbGreentea.Location = new Point(144, 86);
            chbGreentea.Name = "chbGreentea";
            chbGreentea.Size = new Size(108, 29);
            chbGreentea.TabIndex = 4;
            chbGreentea.Text = "Greentea";
            chbGreentea.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(1071, 36);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(150, 31);
            tbTotal.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(802, 28);
            button1.Name = "button1";
            button1.Size = new Size(112, 142);
            button1.TabIndex = 6;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(982, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(603, 33);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(150, 31);
            tbCoffeeQuantity.TabIndex = 8;
            tbCoffeeQuantity.TextChanged += tbCoffeeQuantity_TextChanged;
            // 
            // tbGreenteaQuantity
            // 
            tbGreenteaQuantity.Location = new Point(603, 86);
            tbGreenteaQuantity.Name = "tbGreenteaQuantity";
            tbGreenteaQuantity.Size = new Size(150, 31);
            tbGreenteaQuantity.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 36);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 10;
            label2.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 90);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 11;
            label3.Text = "ราคา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 36);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 12;
            label4.Text = "จำนวน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 92);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 13;
            label5.Text = "จำนวน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(982, 79);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 14;
            label6.Text = "Cash";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(982, 113);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 15;
            label7.Text = "Change";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(982, 153);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 16;
            label8.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(982, 190);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 17;
            label9.Text = "500";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(982, 227);
            label10.Name = "label10";
            label10.Size = new Size(42, 25);
            label10.TabIndex = 18;
            label10.Text = "100";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(982, 264);
            label11.Name = "label11";
            label11.Size = new Size(32, 25);
            label11.TabIndex = 19;
            label11.Text = "50";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(982, 301);
            label12.Name = "label12";
            label12.Size = new Size(32, 25);
            label12.TabIndex = 20;
            label12.Text = "20";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(982, 338);
            label13.Name = "label13";
            label13.Size = new Size(32, 25);
            label13.TabIndex = 21;
            label13.Text = "10";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(982, 375);
            label14.Name = "label14";
            label14.Size = new Size(22, 25);
            label14.TabIndex = 22;
            label14.Text = "5";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(982, 412);
            label15.Name = "label15";
            label15.Size = new Size(22, 25);
            label15.TabIndex = 23;
            label15.Text = "1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1071, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1071, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1071, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1071, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1071, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1071, 258);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1071, 295);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 30;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1071, 332);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 31;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1071, 369);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 32;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1071, 406);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(150, 31);
            textBox10.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 661);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Controls.Add(tbGreenteaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tbTotal);
            Controls.Add(chbGreentea);
            Controls.Add(chbCoffee);
            Controls.Add(tbGreenteaPrice);
            Controls.Add(tbCoffeePrice);
            Name = "Form1";
            Text = " ";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
    }
}
