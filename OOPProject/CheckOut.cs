using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class CheckOut : Form
    {   //Variables for totals
        private decimal sub = 0m;
        private decimal tax = 0;
        private decimal discount = 0;
        //Variable for user
        private Users users;

        //List to store cart items
        private List<Products> Cart = new List<Products>();
        private List<Products> products = new List<Products>();

        public CheckOut(List<Products> cart, List<Products> product, Users user)
        {   //Sets Cart list to cart sent in
            InitializeComponent();
            users = user;
            Cart = cart;
            products = product;
            //Place items in dgv
            for (int i = 0; i < Cart.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new  DataGridViewTextBoxCell() { Value = Cart[i].Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(Cart[i].Price) });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(Cart[i].InCart) });
                dgvCart.Rows.Add(row);
            }
            //Populate sub total
            for (int i = 0;i < Cart.Count;i++)
            {   //Populates subtotal txt
                sub += Cart[i].Price * Cart[i].InCart; 

                if (Cart[i] is SnowBoards board)
                {
                    tax += board.CalculateTax() * board.InCart;
                    if(board.OnSale)
                    discount += (board.CalculateDiscount() * board.InCart);
                }
                else if (Cart[i] is GolfClubs club)
                {
                    tax += club.CalculateTax() * club.InCart;
                    if (club.OnSale)
                    discount += (club.CalculateDiscount() * club.InCart);
                }
            }
            txtTax.Text = tax.ToString("C2");
            txtDiscount.Text = discount.ToString("C2");
            txtSub.Text = sub.ToString("C2");
            txtGrand.Text = (sub + tax - discount).ToString("C2");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Sent: event
        //Returned: Nil
        //Description: Writes to the xml file the contents of the products list, golf and snow lists are made from the same instance of the products list 
        // Changes in those lists are reflected in the products lists and subsequentially written to the xml file (and then read on reopening)
        // Alowws updates to persist throughout program runnings
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Cart.Count > 0)
            {
                DialogResult result = MessageBox.Show("Would you like save your receipt?", "Save Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    sfd.Filter = "TXT Files (*.txt)|*.txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter writer =  new StreamWriter(sfd.FileName))
                        {
                            writer.WriteLine(String.Format("{0,-30}{1, -20}{2,-15}", "Item", "Quantity", "Item Price") + "\n");
                            foreach (Products pro in Cart)
                            {
                                writer.WriteLine(pro.ToString());
                            }
                            writer.WriteLine("\n" + String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Subtotal", "Tax", "Discount", "Grandtotal"));
                            writer.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", sub.ToString("C2"), tax.ToString("C2"), discount.ToString("C2"), (sub + tax - discount).ToString("C2")));
                            writer.WriteLine("\nCustomer: " + users.UserId);
                        }
                    }

                    UpdateXML();
                }
                else
                {
                    UpdateXML();
                    MessageBox.Show("Order placed!", "Success", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Can not check out with empty cart!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Saves file in base directory, automatically updates stock when user checks out
        public void UpdateXML()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "products.xml";
            //Set all incart values to 0
            foreach (Products prod in products)
            {
                prod.InCart = 0;
            }
            ProductDB.SaveOrders(products, path);
        }
    }
}
