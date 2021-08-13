namespace CarDealer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListCar = new System.Windows.Forms.ListBox();
            this.textRegNumber = new System.Windows.Forms.TextBox();
            this.textMake = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textPhoto = new System.Windows.Forms.TextBox();
            this.comboBoxBay = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ListSoldCar = new System.Windows.Forms.ListBox();
            this.SoldCar = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchPriceComboBox = new System.Windows.Forms.ComboBox();
            this.SearchBayComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Make";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListCar
            // 
            this.ListCar.FormattingEnabled = true;
            this.ListCar.Location = new System.Drawing.Point(34, 284);
            this.ListCar.Name = "ListCar";
            this.ListCar.Size = new System.Drawing.Size(646, 69);
            this.ListCar.TabIndex = 7;
            // 
            // textRegNumber
            // 
            this.textRegNumber.Location = new System.Drawing.Point(112, 48);
            this.textRegNumber.Name = "textRegNumber";
            this.textRegNumber.Size = new System.Drawing.Size(100, 20);
            this.textRegNumber.TabIndex = 8;
            // 
            // textMake
            // 
            this.textMake.Location = new System.Drawing.Point(112, 79);
            this.textMake.Name = "textMake";
            this.textMake.Size = new System.Drawing.Size(100, 20);
            this.textMake.TabIndex = 9;
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(112, 105);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(100, 20);
            this.textModel.TabIndex = 10;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(112, 131);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 11;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(112, 157);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 12;
            // 
            // textPhoto
            // 
            this.textPhoto.Location = new System.Drawing.Point(112, 192);
            this.textPhoto.Name = "textPhoto";
            this.textPhoto.Size = new System.Drawing.Size(100, 20);
            this.textPhoto.TabIndex = 13;
            // 
            // comboBoxBay
            // 
            this.comboBoxBay.FormattingEnabled = true;
            this.comboBoxBay.Location = new System.Drawing.Point(91, 20);
            this.comboBoxBay.Name = "comboBoxBay";
            this.comboBoxBay.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBay.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(34, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add Car";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(137, 227);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 16;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Inventory";
            // 
            // ListSoldCar
            // 
            this.ListSoldCar.FormattingEnabled = true;
            this.ListSoldCar.Location = new System.Drawing.Point(35, 382);
            this.ListSoldCar.Name = "ListSoldCar";
            this.ListSoldCar.Size = new System.Drawing.Size(645, 56);
            this.ListSoldCar.TabIndex = 18;
            // 
            // SoldCar
            // 
            this.SoldCar.AutoSize = true;
            this.SoldCar.Location = new System.Drawing.Point(32, 366);
            this.SoldCar.Name = "SoldCar";
            this.SoldCar.Size = new System.Drawing.Size(78, 13);
            this.SoldCar.TabIndex = 19;
            this.SoldCar.Text = "List of Sold Car";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(448, 98);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bay";
            // 
            // SearchPriceComboBox
            // 
            this.SearchPriceComboBox.FormattingEnabled = true;
            this.SearchPriceComboBox.Location = new System.Drawing.Point(402, 20);
            this.SearchPriceComboBox.Name = "SearchPriceComboBox";
            this.SearchPriceComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchPriceComboBox.TabIndex = 24;
            // 
            // SearchBayComboBox
            // 
            this.SearchBayComboBox.FormattingEnabled = true;
            this.SearchBayComboBox.Location = new System.Drawing.Point(402, 66);
            this.SearchBayComboBox.Name = "SearchBayComboBox";
            this.SearchBayComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchBayComboBox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBayComboBox);
            this.Controls.Add(this.SearchPriceComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SoldCar);
            this.Controls.Add(this.ListSoldCar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.comboBoxBay);
            this.Controls.Add(this.textPhoto);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textMake);
            this.Controls.Add(this.textRegNumber);
            this.Controls.Add(this.ListCar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListCar;
        private System.Windows.Forms.TextBox textRegNumber;
        private System.Windows.Forms.TextBox textMake;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textPhoto;
        private System.Windows.Forms.ComboBox comboBoxBay;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ListSoldCar;
        private System.Windows.Forms.Label SoldCar;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SearchPriceComboBox;
        private System.Windows.Forms.ComboBox SearchBayComboBox;
    }
}

