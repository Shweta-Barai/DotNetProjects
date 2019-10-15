namespace Assignment4
{
    partial class CoffeeShopUI
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
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.orderTextBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.customerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.ResetButton1);
            this.customerGroupBox.Controls.Add(this.label2);
            this.customerGroupBox.Controls.Add(this.label5);
            this.customerGroupBox.Controls.Add(this.label4);
            this.customerGroupBox.Controls.Add(this.label3);
            this.customerGroupBox.Controls.Add(this.Contact);
            this.customerGroupBox.Controls.Add(this.label1);
            this.customerGroupBox.Controls.Add(this.addButton);
            this.customerGroupBox.Controls.Add(this.showButton);
            this.customerGroupBox.Controls.Add(this.orderTextBox);
            this.customerGroupBox.Controls.Add(this.quantityTextBox);
            this.customerGroupBox.Controls.Add(this.addressTextBox);
            this.customerGroupBox.Controls.Add(this.contactTextBox);
            this.customerGroupBox.Controls.Add(this.nameTextBox);
            this.customerGroupBox.Location = new System.Drawing.Point(12, 24);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(328, 401);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(65, 105);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 9;
            this.Contact.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(112, 351);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(217, 351);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // orderTextBox
            // 
            this.orderTextBox.FormattingEnabled = true;
            this.orderTextBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderTextBox.Location = new System.Drawing.Point(159, 244);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(134, 21);
            this.orderTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(159, 307);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(135, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(159, 162);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(135, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(159, 98);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(135, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(373, 35);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(370, 390);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // ResetButton1
            // 
            this.ResetButton1.Location = new System.Drawing.Point(31, 351);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(75, 23);
            this.ResetButton1.TabIndex = 14;
            this.ResetButton1.Text = "Reset";
            this.ResetButton1.UseVisualStyleBackColor = true;
            this.ResetButton1.Click += new System.EventHandler(this.ResetButton1_Click);
            // 
            // CoffeeShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "CoffeeShopUI";
            this.Text = "Form1";
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox orderTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton1;
    }
}

