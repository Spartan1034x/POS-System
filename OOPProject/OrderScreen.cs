using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPProject
{
    public partial class OrderScreen : Form
    {   //Two objects created of admin and customer so depending on value sent in one can be cast
        private Users users;
        //4 lists, snowboard, golf, products(read in)
        private static List<Products> products = new List<Products>();
        private static List<SnowBoards> snowBoards = new List<SnowBoards>();
        private static List<GolfClubs> golfclubs = new List<GolfClubs>();
        //Non static list for customer cart
        private List<Products> Cart = new List<Products>();

        //Fields for total
        private decimal total = 0m;
        private int count = 0;
        private bool checkedout = false;

        public OrderScreen(Users user)
        {   //receives bool from log in form sets member to value sent in
            InitializeComponent();
            users = user;
            //Allows admin to edit rows, admin cant add to cart, Creates customer from casted user sent it
            if (user is Admin )
            {
                dgvGolf.Columns[0].Visible = false;
                dgvSnowboard.Columns[0].Visible = false;
                btnCheck.Visible = false;
                grpAdmin.Visible = true;
                btnAdd.Visible = true;
                btnSave.Visible = true;
                btnClearAll.Visible = true;
                btnLoad.Visible = true;
                btnClear.Visible = false;
                dgvGolf.ReadOnly = false;
                dgvSnowboard.ReadOnly = false;
            }
            else if (user is Customer )
            {
                dgvGolf.Columns[0].ReadOnly = false;
                dgvSnowboard.Columns[0].ReadOnly = false;
                dgvGolf.Columns[1].Visible = false;
                dgvSnowboard.Columns[1].Visible=false;
                grpAdmin.Visible=false;
                btnAdd.Visible = false;
                btnLoad.Visible = false;
                btnCheck.Visible = true;
                dgvGolf.ReadOnly = true;
                dgvSnowboard.ReadOnly = true;
            }
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //Only adds products to gold/snowboard list and populates dgv if products is empty, so on initial page load
            if (products.Count <= 0)
            {
                //load initial .xml file
                products = ProductDB.GetOrders("products.xml");

                //Call populatelists ftn
                PopulateLists();

                //Call populate dgvftn
            }    PopulateDGV();

        }

        //Sent: Nil
        //Returned: Nil
        //Description: Takes snowboard and golf objects respectively and places them in their dgv
        private void PopulateDGV()
        {   //Clear rows
            dgvGolf.Rows.Clear();
            dgvSnowboard.Rows.Clear();
            //loop through each list and add items to dgv
            foreach (SnowBoards board in snowBoards)
            {   //Only adds if stock is above 0
                if (board.Stock > 0)
                {
                    //Creates new row for dgv
                    DataGridViewRow row = new DataGridViewRow();
                    //Adds instock column, and continuing down adds every column required for boards
                    row.Cells.Add(new DataGridViewButtonCell { Value = "Add To Cart" });
                    //add column for delete chk
                    row.Cells.Add(new DataGridViewButtonCell { Value = "Delete" });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = board.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = "$" + Convert.ToString(board.Price) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = board.Description });
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = board.Goofy });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(board.Length) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = board.Stock });
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = board.OnSale });
                    //add row to snowboard dgv
                    dgvSnowboard.Rows.Add(row);
                }
            }
            foreach (GolfClubs club in golfclubs)
            {   if (club.Stock > 0)//Only adds if stock is above 0
                {
                    //Creates new row for dgv
                    DataGridViewRow row = new DataGridViewRow();
                    //Adds instock column, and continuing down adds every column required for boards
                    row.Cells.Add(new DataGridViewButtonCell { Value = "Add To Cart" });
                    //add column for delete chk
                    row.Cells.Add(new DataGridViewButtonCell { Value = "Delete" });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = club.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = "$" + Convert.ToString(club.Price) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = club.Description });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = club.Flex });
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = club.RightHanded });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = club.Stock });
                    row.Cells.Add(new DataGridViewCheckBoxCell { Value = club.OnSale });
                    //add row to snowboard dgv
                    dgvGolf.Rows.Add(row);
                }
            }
                
            
        }

        //Clears cart and closes form
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (!checkedout)
                RemoveFromCart();
            Close();
        }

        //Sent: Click Event
        //Returned: Nil
        //Description: Takes mouse click event in snowboard dgv, ensures its a button then adds selected item to cart dgv or delets item if admin
        private void dgvSnowboard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   //First checks if e (which is mouse click target aka button hopefully) row index is greater than -1 (so a valid index is selected)
            //Then checks if the column index is greater than -1, then makes sure the clicked item at indices is of type dgvbutton
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvSnowboard.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                if (users is Customer)
                {
                    if (snowBoards[e.RowIndex].Stock > 0) //Only adds if stock is greater than 0
                    {
                        //Removes old entery into dgv if one being sent in matches name, basiccaly updates the list and removes duplicates
                        SnowBoards board = snowBoards[e.RowIndex];
                        for (int i = 0; i < dgvCart.Rows.Count; i++)
                        {
                            if (Convert.ToString(dgvCart.Rows[i].Cells[0].Value) == board.Name)
                            {
                                dgvCart.Rows.RemoveAt(i);
                            }
                        }

                        //Adds item to cart dgv, increments item count and adds price to total
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = snowBoards[e.RowIndex].Name });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(snowBoards[e.RowIndex].Price) });
                        total += snowBoards[e.RowIndex].Price;
                        count++;
                        //overloaded operator to increment item clicked
                        snowBoards[e.RowIndex]++;
                        //Add total incart to cart dgv
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(snowBoards[e.RowIndex].InCart) });
                        dgvCart.Rows.Add(row);
                        //add item to cart list
                        //adds selected item to cart list, if not already in the list
                        if (Cart.Count > 0)
                        {
                            bool inList = false;
                            for (int i = 0; i < Cart.Count; i++)
                            {
                                if (Cart[i].Name == snowBoards[e.RowIndex].Name)
                                { inList = true; break; }
                            }
                            if (!inList)
                                Cart.Add(snowBoards[e.RowIndex]);
                        }
                        else
                            Cart.Add(snowBoards[e.RowIndex]);
                        RefreshTotals();
                    }
                }
                else if (users is Admin)
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (products[i].Name == snowBoards[e.RowIndex].Name)
                        {
                            products.RemoveAt(i);
                            PopulateLists();
                            PopulateDGV();
                            return;
                        }
                    }
                }
            }
        }

        //Sent: Nil
        //Return: Nil
        //Description: clears txts, then refreshes with totals and counts
        private void RefreshTotals()
        {
            txtItemCount.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtItemCount.Text = count.ToString();
            txtTotal.Text = total.ToString("C2");
            dgvGolf.Rows.Clear();
            dgvSnowboard.Rows.Clear();
            // Refresh dgv
            PopulateDGV();
        }

        //Sent: Click Event
        //Returned: Nil
        //Description: Takes mouse click event in golf dgv, ensures its a button then adds selected item to cart dgv
        private void dgvGolf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //First checks if e (which is mouse click target aka button hopefully) row index is greater than -1 (so a valid index is selected)
            //Then checks if the column index is greater than -1, then makes sure the clicked item at indices is of type dgvbutton
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvGolf.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {   if (users is Customer)
                {
                    if (golfclubs[e.RowIndex].Stock > 0) //Only adds if stock is greater than 0
                    {
                        //Removes old entery into dgv if one being sent in matches name, basiccaly updates the list and removes duplicates
                        GolfClubs club = golfclubs[e.RowIndex];
                        for (int i = 0; i < dgvCart.Rows.Count; i++)
                        {
                            if (Convert.ToString(dgvCart.Rows[i].Cells[0].Value) == club.Name)
                            {
                                dgvCart.Rows.RemoveAt(i);
                            }
                        }

                        //Adds item to cart dgv, increments item count and adds price to total
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = golfclubs[e.RowIndex].Name });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(golfclubs[e.RowIndex].Price) });
                        total += golfclubs[e.RowIndex].Price;
                        count++;
                        //overloaded operator to increment item clicked
                        golfclubs[e.RowIndex]++;
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = Convert.ToString(golfclubs[e.RowIndex].InCart) });
                        //adds selected item to cart list, if not already in the list
                        if (Cart.Count > 0)
                        {
                            bool inList = false;
                            for (int i = 0; i < Cart.Count; i++)
                            {
                                if (Cart[i].Name == golfclubs[e.RowIndex].Name)
                                { inList = true; break; }
                            }
                            if (!inList)
                                Cart.Add(golfclubs[e.RowIndex]);
                        }
                        else
                            Cart.Add(golfclubs[e.RowIndex]);
                        dgvCart.Rows.Add(row);
                        //add item to cart list
                        RefreshTotals();
                    }
                }
                else if (users is Admin)
                {
                     for (int i = 0; i < products.Count; i++)
                     {
                          if (products[i].Name == golfclubs[e.RowIndex].Name)
                          {
                              products.RemoveAt(i);
                              PopulateLists();
                              PopulateDGV();
                              return;
                          }
                     }
                }

            }

        }

        //Sent: event
        //Returned: nil
        //Description: opens add item form, gets sent back an object of admins choosing
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem(users);
            if (addItem.ShowDialog() == DialogResult.OK)
            {
                PopulateLists();
                PopulateDGV();
            }

        }

        //Sent: event
        //Retuned: nil
        //Description: Opens a load file dialog and allows admin to load new product file, then populates it into dgv
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = "";
            //Sets base directory to exes level, Gets path from user selection
            ofdLoad.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                path = ofdLoad.FileName;
                //Clear current lists
                products.Clear();
                snowBoards.Clear();
                golfclubs.Clear();
                //Send path to static class to serialize into list
                products = ProductDB.GetOrders(path);

                PopulateLists();
                //Call populate dgvftn
                PopulateDGV();
            }
        }

        //Sent:Nil
        //Returned: Nil
        //Description: Creates new list from instance of product class, both new class are copys of product class so
        // changes in these classes will be reflected in products class
        private static void PopulateLists()
        {
            //Clears lists first
            snowBoards.Clear();
            golfclubs.Clear();  
            //seperate snowboard and golf clubs for population into dgv
            foreach (Products product in products)
            {
                if (product is SnowBoards board)
                {
                    snowBoards.Add(board);
                }
                else if (product is GolfClubs club)
                {
                    golfclubs.Add(club);
                }

            }
        }

        //Calls removefromcart ftn
        private void btnClear_Click(object sender, EventArgs e)
        {
            RemoveFromCart();
        }

        //Sent: Nil
        //Returned: Nil
        //Description: Loops through every item in every row, and uses overloaded operator to add stock back into static lists, then clears cart list
        private void RemoveFromCart()
        {
            //Loops through every row in cart
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {   //loops through each item in row
                for (int j = 0; j < Convert.ToUInt32(dgvCart.Rows[i].Cells[2].Value); j++)
                {   //loop through both lists if name matches -- then refresh lists in main dgv
                    for (int k = 0; k < snowBoards.Count; k++)
                    {
                        if (snowBoards[k].Name == dgvCart.Rows[i].Cells[0].Value.ToString())
                        {
                            snowBoards[k]--;
                        }
                    }
                    for (int z = 0; z < golfclubs.Count; z++)
                    {
                        if (golfclubs[z].Name == dgvCart.Rows[i].Cells[0].Value.ToString())
                        {
                            golfclubs[z]--;
                        }
                    }
                }
            }
            //0 total variable
            total = 0;
            //0 count
            count = 0;
            //Clear Cart list
            Cart.Clear();
            //Clear cart dgv
            dgvCart.Rows.Clear();
            //Refresh 
            RefreshTotals();
        }

        //Sent: event
        //Returned: nil
        //Description: creates new instance of checkout form, if checkout is clicked in other form sets bool to true
        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckOut checkout = new CheckOut(Cart, products, users);
            if (DialogResult.OK == checkout.ShowDialog())
                checkedout = true;
        }

        //Sent: Product List
        //Returned: Nil
        //Description: Publiuc method that can be cvalled from edit form, receivesd an updated list and adds to products list, then it can
        // repopulate the golf and snow lists and update the dgv
        public void ReceiveModdedList(List<Products> pro)
        {
            foreach (Products product in pro)
            {
                products.Add(product);
            }

        }

        //Sent: event
        //Returned: nil
        //Description: On form closing sent products to be written to xml file, so changes reflect throughout page loading
        private void OrderScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (users is Admin)
            {
                if (MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveFile();
            
                }
            }
            else
                SaveFile();
        }

        //Sent: nil
        //Returned: nil
        //description: writes product list to xml file, zeros in cart properties
        private static void SaveFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "products.xml";
            //Set all incart values to 0
            foreach (Products prod in products)
            {
                prod.InCart = 0;
            }
            ProductDB.SaveOrders(products, path);
        }

        //Sent: event
        //Return: nil
        //description: event trigger when cell value changed, if cell is in edit mode, and proper cell is selected
        // modifies items in list
        private void dgvSnowboard_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSnowboard.IsCurrentCellInEditMode)
            {   //Checks if cell is stock cell
                if (e.RowIndex > -1 && e.ColumnIndex == 7 && dgvSnowboard.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell)
                {
                    int newStock = Convert.ToInt32(dgvSnowboard.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    string Name = dgvSnowboard.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //loop through products list when a match is found set to new data entered from user
                    foreach (Products pro in products)
                    {
                        if (pro.Name == Name)
                        {
                            pro.Stock = newStock;
                        }
                    }

                }
            }
        }

        //Sent: event
        //Return: nil
        //description: event trigger when cell value changed, if cell is in edit mode, and proper cell is selected
        // modifies items in list
        private void dgvGolf_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGolf.IsCurrentCellInEditMode)
            {   //Checks if cell is stock cell
                if (e.RowIndex > -1 && e.ColumnIndex == 7 && dgvGolf.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell)
                {
                    int newStock = Convert.ToInt32(dgvGolf.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    string Name = dgvGolf.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //loop through products list when a match is found set to new data entered from user
                    foreach (Products pro in products)
                    {
                        if (pro.Name == Name)
                        {
                            pro.Stock = newStock;
                        }
                    }

                }
            }
        }

        //Sent: event
        //Returned: nil
        //Description: Saves current products to base directory
        private void btnSave_Click(object sender, EventArgs e)
        {
            sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ProductDB.SaveOrders(products, sfd.FileName);
            }
        }

        //Sent: event
        //Returned: Nil
        //Description: Clears current lists, refreshes dgv to be empty
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvGolf.Rows.Clear();
            dgvSnowboard.Rows.Clear();
            golfclubs.Clear();
            snowBoards.Clear();
            products.Clear();

        }
    }
}

