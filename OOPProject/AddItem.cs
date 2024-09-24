using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPProject
{
    public partial class AddItem : Form
    {
        //List for updated products, and variable to hold user so a new instance of the class can be created
        private List<Products> products = new List<Products>();
        private Users user;

        public AddItem(Users users)
        {
            InitializeComponent();
            user = users;
        }

        //Sent: Event
        //Returned: Nil 
        //Description: Adds new snowboard item to list
        private void btnSnowSave_Click(object sender, EventArgs e)
        {
            //Use validator to check txt boxes
            if (Validator.IsPresent(txtSnowCode) && Validator.IsPresent(txtSnowName) && Validator.IsPresent(txtSnowStock)
                && Validator.IsPresent(txtSnowDescription) && Validator.IsPresent(txtSnowPrice) && Validator.IsPresent(txtSnowLength)
                && Validator.IsDecimal(txtSnowPrice) && Validator.IsInt32(txtSnowStock) && Validator.IsWithinRange(txtSnowStock, 0m, 10000m)
                && Validator.IsWithinRange(txtSnowPrice, 0m, 50000m) && Validator.IsWithinRange(txtSnowLength, 85m, 250m))
            {
                products.Add(new SnowBoards(txtSnowCode.Text, txtSnowDescription.Text, Convert.ToDecimal(txtSnowPrice.Text),
                    Convert.ToInt32(txtSnowStock.Text), chkSnowGoofy.Checked, Convert.ToDouble(txtSnowLength.Text),
                    txtSnowName.Text, chkSnowOnsale.Checked));

                MessageBox.Show("Item Added to SnowBoard Database", "Added");
            }

        }

        private void btnGolfSave_Click(object sender, EventArgs e)
        {
            //Use validator to check txt boxes
            if (Validator.IsPresent(txtGolfCode) && Validator.IsPresent(txtGolfName) && Validator.IsPresent(txtGolfStock)
                && Validator.IsPresent(txtGolfDescription) && Validator.IsPresent(txtGolfPrice) && Validator.IsPresent(txtGolfFlex)
                && Validator.IsDecimal(txtGolfPrice) && Validator.IsInt32(txtGolfStock) && Validator.IsWithinRange(txtGolfStock, 0m, 10000m)
                && Validator.IsWithinRange(txtGolfPrice, 0m, 50000m) && Validator.IsValidFlex(txtGolfFlex))
            {
                products.Add(new GolfClubs(txtGolfCode.Text, txtGolfDescription.Text, Convert.ToDecimal(txtGolfPrice.Text),
                    Convert.ToInt32(txtGolfStock.Text), chkGolfHand.Checked, txtGolfFlex.Text,
                    txtGolfName.Text, chkGolfOnsale.Checked));

                MessageBox.Show("Item Added to Golf Club Database", "Added");
            }
        }

        //Clears snowboard side inputs
        private void button1_Click(object sender, EventArgs e)
        {
            txtSnowCode.Text = "";
            txtSnowDescription.Text = "";
            txtSnowLength.Text = "";
            txtSnowName.Text = "";
            txtSnowPrice.Text = "";
            txtSnowStock.Text = "";
            chkSnowGoofy.Checked = false;
            chkSnowOnsale.Checked = false;
        }

        //Resets inputs for golf
        private void button2_Click(object sender, EventArgs e)
        {
            txtGolfCode.Text = "";
            txtGolfDescription.Text = "";
            txtGolfFlex.Text = "";
            txtGolfName.Text = "";
            txtGolfPrice.Text = "";
            txtGolfStock.Text = "";
            chkGolfHand.Checked = false;
            chkGolfOnsale.Checked = false;
        }

        //Sent: event
        //Retunred: nil
        //Description: Calls function in orderform and sends the updated list from this page with additions from user
        private void AddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            OrderScreen instance = new OrderScreen(user);
            instance.ReceiveModdedList(products);
        }
    }
}
