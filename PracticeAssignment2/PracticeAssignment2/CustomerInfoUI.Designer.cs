namespace PracticeAssignment2
{
    partial class CustomerInfoUI
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
            this.saveButton = new System.Windows.Forms.Button();
            this.orderQuantity = new System.Windows.Forms.Label();
            this.cutomerOrder = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.Label();
            this.customerContact = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.orderTextBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.customerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.saveButton);
            this.customerGroupBox.Controls.Add(this.orderQuantity);
            this.customerGroupBox.Controls.Add(this.cutomerOrder);
            this.customerGroupBox.Controls.Add(this.customerAddress);
            this.customerGroupBox.Controls.Add(this.customerContact);
            this.customerGroupBox.Controls.Add(this.customerName);
            this.customerGroupBox.Controls.Add(this.orderTextBox);
            this.customerGroupBox.Controls.Add(this.quantityTextBox);
            this.customerGroupBox.Controls.Add(this.AddressTextBox);
            this.customerGroupBox.Controls.Add(this.contactTextBox);
            this.customerGroupBox.Controls.Add(this.customerTextBox);
            this.customerGroupBox.Location = new System.Drawing.Point(28, 30);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(343, 397);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(247, 357);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderQuantity
            // 
            this.orderQuantity.AutoSize = true;
            this.orderQuantity.Location = new System.Drawing.Point(64, 322);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(46, 13);
            this.orderQuantity.TabIndex = 9;
            this.orderQuantity.Text = "Quantity";
            // 
            // cutomerOrder
            // 
            this.cutomerOrder.AutoSize = true;
            this.cutomerOrder.Location = new System.Drawing.Point(64, 284);
            this.cutomerOrder.Name = "cutomerOrder";
            this.cutomerOrder.Size = new System.Drawing.Size(33, 13);
            this.cutomerOrder.TabIndex = 8;
            this.cutomerOrder.Text = "Order";
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSize = true;
            this.customerAddress.Location = new System.Drawing.Point(52, 99);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(45, 13);
            this.customerAddress.TabIndex = 7;
            this.customerAddress.Text = "Address";
            // 
            // customerContact
            // 
            this.customerContact.AutoSize = true;
            this.customerContact.Location = new System.Drawing.Point(53, 57);
            this.customerContact.Name = "customerContact";
            this.customerContact.Size = new System.Drawing.Size(44, 13);
            this.customerContact.TabIndex = 6;
            this.customerContact.Text = "Contact";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(52, 22);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 5;
            this.customerName.Text = "Customer Name";
            // 
            // orderTextBox
            // 
            this.orderTextBox.FormattingEnabled = true;
            this.orderTextBox.Items.AddRange(new object[] {
            "Black",
            "Hot",
            "Cold",
            "Regular"});
            this.orderTextBox.Location = new System.Drawing.Point(164, 284);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(158, 21);
            this.orderTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(164, 322);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(158, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(164, 99);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(163, 20);
            this.AddressTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(164, 57);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(163, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(164, 19);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(163, 20);
            this.customerTextBox.TabIndex = 0;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(404, 39);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(342, 388);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            // 
            // CustomerInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "CustomerInfoUI";
            this.Text = "Form1";
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label orderQuantity;
        private System.Windows.Forms.Label cutomerOrder;
        private System.Windows.Forms.Label customerAddress;
        private System.Windows.Forms.Label customerContact;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.ComboBox orderTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}

