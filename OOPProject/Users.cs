using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    public abstract class Users
    {
        //properties
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool AdminAccess { get; set; }

        //Defult Constructor
        protected Users() { }
        //Custom Constructor
        protected Users(string id, string pass)
        {
            UserId = id;
            Password = pass;
        }
    }//End Users

    sealed class Customer : Users
    {   //Properties
        public List<Products> Cart { get; set; }

        //Default Constructor
        public Customer() : base() { }
        //Custom Constructor
        public Customer(string id, string pass) : base(id, pass)
        {
            UserId = id;
            Password = pass;
            AdminAccess = false;
            Cart = new List<Products>();
        }
    }//End Customer

    sealed class Admin : Users
    {
        //Default Constructor
        public Admin() : base() { }
        //Custom Constructor
        public Admin(string id, string pass) : base(id, pass)
        {
            UserId = id;
            Password = pass;
            AdminAccess = true;
        }

    }
}
