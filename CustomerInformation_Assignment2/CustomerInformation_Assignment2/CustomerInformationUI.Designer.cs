namespace CustomerInformation_Assignment2
{
    partial class CustomerInformationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showLabelQuantityOfOrder = new System.Windows.Forms.Label();
            this.showLabelOrderOfCustomer = new System.Windows.Forms.Label();
            this.showLabelAddressOfCustomer = new System.Windows.Forms.Label();
            this.showLabelContactOfCustomer = new System.Windows.Forms.Label();
            this.showLabelNameOfCustomer = new System.Windows.Forms.Label();
            this.customerOrder = new System.Windows.Forms.ComboBox();
            this.orderQuantity = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerContact = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.showLabelQuantityOfOrder);
            this.groupBox1.Controls.Add(this.showLabelOrderOfCustomer);
            this.groupBox1.Controls.Add(this.showLabelAddressOfCustomer);
            this.groupBox1.Controls.Add(this.showLabelContactOfCustomer);
            this.groupBox1.Controls.Add(this.showLabelNameOfCustomer);
            this.groupBox1.Controls.Add(this.customerOrder);
            this.groupBox1.Controls.Add(this.orderQuantity);
            this.groupBox1.Controls.Add(this.customerAddress);
            this.groupBox1.Controls.Add(this.customerContact);
            this.groupBox1.Controls.Add(this.customerName);
            this.groupBox1.Location = new System.Drawing.Point(24, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // showLabelQuantityOfOrder
            // 
            this.showLabelQuantityOfOrder.AutoSize = true;
            this.showLabelQuantityOfOrder.Location = new System.Drawing.Point(36, 311);
            this.showLabelQuantityOfOrder.Name = "showLabelQuantityOfOrder";
            this.showLabelQuantityOfOrder.Size = new System.Drawing.Size(46, 13);
            this.showLabelQuantityOfOrder.TabIndex = 9;
            this.showLabelQuantityOfOrder.Text = "Quantity";
            // 
            // showLabelOrderOfCustomer
            // 
            this.showLabelOrderOfCustomer.AutoSize = true;
            this.showLabelOrderOfCustomer.Location = new System.Drawing.Point(41, 269);
            this.showLabelOrderOfCustomer.Name = "showLabelOrderOfCustomer";
            this.showLabelOrderOfCustomer.Size = new System.Drawing.Size(33, 13);
            this.showLabelOrderOfCustomer.TabIndex = 8;
            this.showLabelOrderOfCustomer.Text = "Order";
            // 
            // showLabelAddressOfCustomer
            // 
            this.showLabelAddressOfCustomer.AutoSize = true;
            this.showLabelAddressOfCustomer.Location = new System.Drawing.Point(38, 125);
            this.showLabelAddressOfCustomer.Name = "showLabelAddressOfCustomer";
            this.showLabelAddressOfCustomer.Size = new System.Drawing.Size(45, 13);
            this.showLabelAddressOfCustomer.TabIndex = 7;
            this.showLabelAddressOfCustomer.Text = "Address";
            // 
            // showLabelContactOfCustomer
            // 
            this.showLabelContactOfCustomer.AutoSize = true;
            this.showLabelContactOfCustomer.Location = new System.Drawing.Point(38, 75);
            this.showLabelContactOfCustomer.Name = "showLabelContactOfCustomer";
            this.showLabelContactOfCustomer.Size = new System.Drawing.Size(44, 13);
            this.showLabelContactOfCustomer.TabIndex = 6;
            this.showLabelContactOfCustomer.Text = "Contact";
            // 
            // showLabelNameOfCustomer
            // 
            this.showLabelNameOfCustomer.AutoSize = true;
            this.showLabelNameOfCustomer.Location = new System.Drawing.Point(38, 29);
            this.showLabelNameOfCustomer.Name = "showLabelNameOfCustomer";
            this.showLabelNameOfCustomer.Size = new System.Drawing.Size(82, 13);
            this.showLabelNameOfCustomer.TabIndex = 5;
            this.showLabelNameOfCustomer.Text = "Customer Name";
            // 
            // customerOrder
            // 
            this.customerOrder.FormattingEnabled = true;
            this.customerOrder.Items.AddRange(new object[] {
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.customerOrder.Location = new System.Drawing.Point(160, 269);
            this.customerOrder.Name = "customerOrder";
            this.customerOrder.Size = new System.Drawing.Size(164, 21);
            this.customerOrder.TabIndex = 4;
            this.customerOrder.SelectedIndexChanged += new System.EventHandler(this.customerOrder_SelectedIndexChanged);
            // 
            // orderQuantity
            // 
            this.orderQuantity.Location = new System.Drawing.Point(159, 311);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(165, 20);
            this.orderQuantity.TabIndex = 3;
            this.orderQuantity.TextChanged += new System.EventHandler(this.orderQuantity_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(160, 119);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(165, 20);
            this.customerAddress.TabIndex = 2;
            this.customerAddress.TextChanged += new System.EventHandler(this.customerAddress_TextChanged);
            // 
            // customerContact
            // 
            this.customerContact.Location = new System.Drawing.Point(160, 75);
            this.customerContact.Name = "customerContact";
            this.customerContact.Size = new System.Drawing.Size(165, 20);
            this.customerContact.TabIndex = 1;
            this.customerContact.TextChanged += new System.EventHandler(this.customerContact_TextChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(160, 29);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(165, 20);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.cutomerName_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(403, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 360);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(249, 349);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CustomerInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerInformationUI";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label showLabelQuantityOfOrder;
        private System.Windows.Forms.Label showLabelOrderOfCustomer;
        private System.Windows.Forms.Label showLabelAddressOfCustomer;
        private System.Windows.Forms.Label showLabelContactOfCustomer;
        private System.Windows.Forms.Label showLabelNameOfCustomer;
        private System.Windows.Forms.ComboBox customerOrder;
        private System.Windows.Forms.TextBox orderQuantity;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerContact;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveButton;
    }
}

