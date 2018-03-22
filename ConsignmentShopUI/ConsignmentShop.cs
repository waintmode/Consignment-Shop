using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {

        private Store store = new Store();
        private List<item> shoppingCartData = new List<item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;






        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
                // => is a lamda expression
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.DisplayMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";

        }

        private void HeaderText_Click(object sender, EventArgs e)
        {

        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {
            //Vendor demoVendor = new Vendor();

            //demoVendor.FirstName = "Bill";
            //demoVendor.LastName = "Smith";
            //demoVendor.Commission = .5;

            //store.Vendors.Add(demoVendor);

            //demoVendor = new Vendor();

            //demoVendor.FirstName = "Sue";
            //demoVendor.LastName = "Jones";
            //demoVendor.Commission = .5;

            //store.Vendors.Add(demoVendor);


            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a city",
                Price = 4.90M,
                Owner = store.Vendors[0]
            });


            store.Items.Add(new item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new item
            {
                Title = "Jane Eyre",
                Description = "A book about a Girl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

           
            store.Name = "Seconds of Better";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("I have been Clicked");

            // Figure out what is selected from the items list
            // Copy that item to the shopping cart
            // Do we remove the item from the items list ? - no
            item selectedItem = (item)itemsListBox.SelectedItem;

            //MessageBox.Show(selectedItem.Title);

            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            // mark each item in the cart as sold
            // clear the cart

            foreach (item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void storeProfitLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


