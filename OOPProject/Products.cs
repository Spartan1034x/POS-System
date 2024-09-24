using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject
{
    public abstract class Products
    {   //Fields
        private int stock;
        protected const decimal tax = 0.15m;
        protected const decimal saleAmount = 0.25m;
        private bool inStock;
        private int incart;

        //Properties
        public string Code {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get { return inStock; } set { inStock = (this.Stock > 0) ? true : false; } }
        public int Stock { get { return stock; } set { stock = (value >= 0) ? value : 0; } }
        public bool OnSale { get; set; }
        public string Name { get; set; }
        public int InCart { get { return incart; } set { incart = (value >= 0) ? value : 0; } }

        //Default Constructor
        protected Products() { }
        //Custom Constructor
        protected Products(string code, string description, decimal price, int stock, string name, bool onsale) 
        {
            Code = code;
            Description = description;
            Price = price;
            Stock = stock;
            Name = name;
            OnSale = onsale;
            inStock = (stock > 0) ? true : false;
        }

        //Override ToString for My cart list box display
        public override string ToString()
        {
            return String.Format("{0,-30}{1, -20}{2,-15}", Name, InCart.ToString(), Price.ToString("C2"));
        }

        //Virtual method must be overidden in child classes
        public abstract decimal CalculateCost();

        //Virtual method must be overidden in child classes
        public abstract decimal CalculateTax();
    }// End Products

    public sealed class SnowBoards : Products, ISale
    {   //Fields
        private double length;

        //Properties
        public bool Goofy { get; set; }
        //Sets the value only if >= 120 inches
        public double Length { get { return length; } set => length = (value >= 120.0) ? value : 120.0; }

        //Default const
        public SnowBoards() { }

        //Custom const
        public SnowBoards(string code, string description, decimal price, int stock, bool goofy, double length, string name, bool onsale) : base(code, description, price, stock, name, onsale)
        {
            Code = code;
            Description = description;
            Price = price;
            Stock = stock;
            Goofy = goofy;
            Length = length;
            Name = name;
            OnSale = onsale;
        }

        //overload -- adds one to InCart property of item, subtracts one from Stock
        public static SnowBoards operator --(SnowBoards board)
        {
            board.Stock += 1;
            board.InCart -= 1;
            return board;
        }

        //overload ++ adds one to InCart property of item, subtracts one from Stock
        public static SnowBoards operator ++(SnowBoards board)
        {
            board.Stock -= 1;
            board.InCart += 1;
            return board;
        }
        //Sent: 2 Snowboard obj
        //Returned: Snowboard
        //Description: determines which board has a lower price
        public static SnowBoards operator <=(SnowBoards board1, SnowBoards board2)
        {
            return (board1.Price < board2.Price) ? board1 : board2;
        }
        //Sent: 2 Snowboard obj
        //Returned: Snowboard
        //Description: determines which board has a higher price
        public static SnowBoards operator >=(SnowBoards board1, SnowBoards board2)
        {
            return (board1.Price > board2.Price) ? board1 : board2;
        }

        //Sent: Nil
        //Returned: Decimal
        //Description: Overriden Interface method, returns price - sales %
        public decimal CalculateDiscount() => Price * saleAmount;

        //Sent: nil
        //Returned: decimal
        //Description: If item is on sale calcs discount then adds tax, if not adds tax
        public override decimal CalculateCost()
        {
            decimal price = 0;
            if (OnSale)
                price = (Price - CalculateDiscount()) * (1+ tax);
            else
                price = Price * (1 + tax);
            return price;
        }

        //Sent: nil
        //Returned: decimal
        //Description: Calculates tax amount
        public override decimal CalculateTax() 
        {
            return Price * tax; 
        }
    }
    
    public sealed class GolfClubs : Products, ISale
    {   //Fields
        private string flex;
        //Properties
        public bool RightHanded { get; set; }
        public string Flex
        {   //Only sets value if one of the three flex types, otherwise sets to unknown
            get { return flex; }
            set => flex = (value == "Stiff" || value == "Regular" || value == "Soft") ? value : "Unknown";
        }

        //Default cons
        public GolfClubs() : base() { }

        //Custom const
        public GolfClubs(string code, string description, decimal price, int stock, bool rHand, string flex, string name, bool onsale) : base(code, description, price, stock, name, onsale)
        {
            Code = code;
            Description = description; 
            Price = price; 
            Stock = stock;
            RightHanded = rHand;
            Flex = flex;
            Name = name;
            OnSale = onsale;
        }

        //overload -- adds one to InCart property of item, subtracts one from Stock
        public static GolfClubs operator --(GolfClubs club)
        {
            club.Stock += 1;
            club.InCart -= 1;
            return club;
        }

        //overload -- adds one to InCart property of item, subtracts one from Stock
        public static GolfClubs operator ++(GolfClubs club)
        {
            club.Stock -= 1;
            club.InCart += 1;
            return club;
        }

        //Sent: Nil
        //Returned: Decimal
        //Description: Overriden Interface method, returns price - sales %
        public decimal CalculateDiscount() => Price * saleAmount;

        //Sent: nil
        //Returned: decimal
        //Description: If item is on sale calcs discount then adds tax, if not adds tax
        public override decimal CalculateCost()
        {  decimal price = 0;
            if (OnSale)
                price = (Price - CalculateDiscount()) * (1 + tax);
            else 
                price = Price * (1 + tax);
            return price;
        }

        //Sent: nil
        //Returned: decimal
        //Description: Calculates tax amount
        public override decimal CalculateTax()
        {
            return Price * tax;
        }

        //Sent: 2 GolfClubs obj
        //Returned: GolfClubs
        //Description: determines which club has a lower price
        public static GolfClubs operator <=(GolfClubs club1, GolfClubs club2)
        {
            return (club1.Price < club2.Price) ? club1 : club2;
        }
        //Sent: 2 GolfClubs obj
        //Returned: GolfClubs
        //Description: determines which club has a higher price
        public static GolfClubs operator >=(GolfClubs club1, GolfClubs club2)
        {
            return (club1.Price > club2.Price) ? club1 : club2;
        }
    }// End GolfClub class

    interface ISale
    {  
        //CalculateDiscount Method
        decimal CalculateDiscount();
    }//End Interface
}
