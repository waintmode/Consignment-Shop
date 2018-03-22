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


            store.Vendors.Add(new Vendor { FirstName = "Dellen", LastName = "Corporation" });
            store.Vendors.Add(new Vendor { FirstName = "Examinos", LastName = "Corporation" });
            store.Vendors.Add(new Vendor { FirstName = "Waint", LastName = "Corporation" });

            store.Items.Add(new item
            {
                Title = "PowerEdge T30 Mini Tower Server",
                Description = "New Dell PowerEdge T30 Mini Tower Server, with 3.5 1TB Entry HDD 4GB DIMM Intel Pentium G4400 3.3 GHz 2C / 2T",
                Price = 324.00M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new item
            {
                Title = "ProLiant DL380",
                Description = "ProLiant DL380 G6 2U 64-bit Server with 2xQuad-Core E5540 Xeon 2.53GHz + 16GB RAM + 8x146GB 10K SAS HDD, RAID, NO OS",
                Price = 255.00M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new item
            {
                Title = "ProLiant DL360",
                Description = "ProLiant DL360 G7 1U 64-bit Server with 2xSix-Core X5650 Xeon 2.66GHz + 32GB RAM + 4x146GB 10K SAS HDD, RAID, NO OS",
                Price = 259.99M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new item
            {
                Title = "ThinkServer TS140",
                Description = "ThinkServer TS140 70A40037UX 4U Tower Server Intel Core i3-4150 3.5Ghz",
                Price = 693.69M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new item
            {
                Title = "High-End Server",
                Description = "High-End Virtualization Server 12-Core 128GB RAM 12TB RAID PowerEdge R710",
                Price = 1556.00M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new item
            {
                Title = "R610 Virtualization Server",
                Description = "PowerEdge R610 Virtualization Server 2.53GHz 8-Core E5540 32GB 2x146GB PERC6",
                Price = 215.00M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new item
            {
                Title = "ProLiant EntryServer",
                Description = "837826-001 ProLiant ML10 Entry Server, 4 GB RAM, No HDD, Black",
                Price = 6003.69M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new item
            {
                Title = "DL360 64-bit Server",
                Description = "ProLiant DL360 G6 1U RackMount 64-bit Server with 2xQuad-Core X5550 Xeon 2.66GHz CPU + 24GB PC3-10600R RAM + 8x146GB 10K SAS SFF HDD, P410i RAID, 2xGigaBit NIC, 2xPower Supplies, NO OS",
                Price = 250.12M,
                Owner = store.Vendors[0]
            });


            store.Name = "Grand Evolution World";
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

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


