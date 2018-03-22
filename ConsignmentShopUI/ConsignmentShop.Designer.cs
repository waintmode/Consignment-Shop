namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsignmentShop));
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.BackColor = System.Drawing.Color.SteelBlue;
            this.headerText.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(243, 39);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            this.headerText.Click += new System.EventHandler(this.HeaderText_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(52, 86);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(338, 224);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.itemsListBoxLabel.Location = new System.Drawing.Point(49, 65);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(104, 18);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(490, 178);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(133, 31);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListBoxLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(687, 63);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(124, 20);
            this.shoppingCartListBoxLabel.TabIndex = 4;
            this.shoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(691, 86);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(333, 224);
            this.shoppingCartListBox.TabIndex = 5;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(928, 312);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(96, 29);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.ForeColor = System.Drawing.Color.White;
            this.vendorListBoxLabel.Location = new System.Drawing.Point(57, 316);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorListBoxLabel.TabIndex = 7;
            this.vendorListBoxLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(52, 339);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(338, 184);
            this.vendorListBox.TabIndex = 8;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.storeProfitLabel.Location = new System.Drawing.Point(729, 405);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(106, 20);
            this.storeProfitLabel.TabIndex = 9;
            this.storeProfitLabel.Text = "Store Profit:";
            this.storeProfitLabel.Click += new System.EventHandler(this.storeProfitLabel_Click);
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.BackColor = System.Drawing.SystemColors.InfoText;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.ForeColor = System.Drawing.SystemColors.Window;
            this.storeProfitValue.Location = new System.Drawing.Point(871, 405);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.descriptionBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptionBox.Location = new System.Drawing.Point(433, 9);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(402, 25);
            this.descriptionBox.TabIndex = 11;
            this.descriptionBox.Text = "All Servers are efficient to work in Real World Situations";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 535);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
        private System.Windows.Forms.TextBox descriptionBox;
    }
}

