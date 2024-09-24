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
    public partial class LogIn : Form
    {   //User List
        private static List<Users> userList = new List<Users>();

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //Creates path for .txt file
            string path = "users.txt";
            string[] user;
            try
            {   //uses streamreader sends in path
                using (StreamReader reader = new StreamReader(path))
                {
                    if (File.Exists(path))
                    {   //Reads all lines of txt file, splits string, creates either admin or customer, then adds to list 
                        user = File.ReadAllLines(path);
                        for (int i = 0; i < user.Length; i++)
                        {   //creates new string array based of split strings
                            string[] login = user[i].Split(',');
                            if (login[0] == "admin")
                            {
                                Admin admin = new Admin(login[0], login[1]);
                                userList.Add(admin);
                            }
                            else
                            {
                                Customer customer = new Customer(login[0], login[1]); 
                                userList.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "File Path Error");
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {   //Variables retrieved from txt box based on user input
            string userName = txtUser.Text;
            string password = txtPass.Text;
            //flag for valid username
            bool goodUser = true;
            //loop through entire list of user objects, if none match username throw error
            //if one matches check if password is correct then call function for showdialog / send in object bool for admin access
            for (int i = 0;i < userList.Count;i++)
            {
                if (userList[i].UserId == userName)
                {
                    if (userList[i].Password == password)
                    {
                        OrderForm(userList[i]);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }                }
                else
                { goodUser = false; }

            }
            if (!goodUser) MessageBox.Show("Incorrect username entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Semt: Users obj
        //Returned: nil
        //Description: Creates new orderform instance and sends in user obj from log in, if log out on orderform
        //             is pressed shows this page, resets inputs and focuses top txt box
        private void OrderForm(Users user)
        {
            //Clears all inputs
            txtPass.Text = ""; txtUser.Text = ""; txtPass.Focus();
            OrderScreen orderScreen = new OrderScreen(user);
            //Cant be modal causes child forms to close orderform when they are closed
            orderScreen.Show();
        }
    }
}
