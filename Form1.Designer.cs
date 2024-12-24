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
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(321, 31);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(150, 31);
            tbCoffeePrice.TabIndex = 1;
            // 
            // tbGreenteaPrice
            // 
            tbGreenteaPrice.Location = new Point(321, 86);
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
            tbTotal.Location = new Point(520, 142);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(150, 31);
            tbTotal.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(731, 33);
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
            label1.Location = new Point(412, 148);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 7;
            label1.Text = "ราคารวม";
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(520, 33);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(150, 31);
            tbCoffeeQuantity.TabIndex = 8;
            // 
            // tbGreenteaQuantity
            // 
            tbGreenteaQuantity.Location = new Point(520, 86);
            tbGreenteaQuantity.Name = "tbGreenteaQuantity";
            tbGreenteaQuantity.Size = new Size(150, 31);
            tbGreenteaQuantity.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 317);
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
            Text = "Form1";
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
    }
}
