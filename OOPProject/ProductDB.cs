using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OOPProject
{
    public static class ProductDB
    {
        //Sent: string path of xml 
        //Returned: List of products
        //Description: Reads .xml file and serializes an object of GolfClubs or Snowboards depending on xml specs
        public static List<Products> GetOrders(string path)
        {
            // create the list
            List<Products> products = new List<Products>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            try
            {
                // create the XmlReader object
                XmlReader xmlIn = XmlReader.Create(path, settings);
                //loops through everynode until next one is empty
                // read past all nodes to the first golf node
                if (xmlIn.ReadToDescendant("golf"))
                {
                    // create one golf object for each golf node
                    do
                    {
                        xmlIn.ReadStartElement("golf");
                        string code =
                            xmlIn.ReadElementContentAsString();
                        int stock =
                            xmlIn.ReadElementContentAsInt();
                        string name =
                            xmlIn.ReadElementContentAsString();
                        string description = xmlIn.ReadElementContentAsString();
                        decimal price = xmlIn.ReadElementContentAsDecimal();
                        bool onsale = xmlIn.ReadElementContentAsBoolean();
                        string flex = xmlIn.ReadElementContentAsString();
                        bool rHanded = xmlIn.ReadElementContentAsBoolean();
                        GolfClubs golf = new GolfClubs(code, description, price, stock, rHanded, flex, name, onsale);
                        products.Add(golf);
                    }
                    while (xmlIn.ReadToNextSibling("golf"));

                }
                // close the XmlReader object
                xmlIn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                // create the XmlReader object
                XmlReader xmlIn = XmlReader.Create(path, settings);
                //loops through everynode until next one is empty
                // read past all nodes to the first snowboard node
                if (xmlIn.ReadToDescendant("snowboard"))
                    do
                    {
                        {
                            // create one snowboard object for each snowboard node
                            xmlIn.ReadStartElement("snowboard");
                            string code =
                                xmlIn.ReadElementContentAsString();
                            int stock =
                                xmlIn.ReadElementContentAsInt();
                            string name =
                                xmlIn.ReadElementContentAsString();
                            string description = xmlIn.ReadElementContentAsString();
                            decimal price = xmlIn.ReadElementContentAsDecimal();
                            bool onsale = xmlIn.ReadElementContentAsBoolean();
                            double length = xmlIn.ReadElementContentAsDouble();
                            bool goofy = xmlIn.ReadElementContentAsBoolean();
                            SnowBoards board = new SnowBoards(code, description, price, stock, goofy, length, name, onsale);
                            products.Add(board);
                        }
                    }
                    while (xmlIn.ReadToNextSibling("snowboard"));
                // close the XmlReader object
                xmlIn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return products;
        }

        //Sent: string path of xml, List of Products
        //Returned: Nil
        //Description: Deserializes the Snowboard or GolfClub object then writes to xml file
        public static void SaveOrders(List<Products> products, string path)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            try
            {
                // create the XmlWriter object
                XmlWriter xmlOut = XmlWriter.Create(path, settings);

                // write the start of the document
                xmlOut.WriteStartDocument();
                xmlOut.WriteStartElement("products");

                // write each Order object to the xml file
                foreach (Products product in products)
                {   // Checks wether product is of type snowboard, if true then declares board variable of type Snowboards with the product variable data
                    if (product is SnowBoards board)
                    {
                        xmlOut.WriteStartElement("snowboard");
                        xmlOut.WriteElementString("code", board.Code);
                        xmlOut.WriteElementString("stock", board.Stock.ToString());
                        xmlOut.WriteElementString("name", board.Name);
                        xmlOut.WriteElementString("description", board.Description);
                        xmlOut.WriteElementString("price", board.Price.ToString());
                        xmlOut.WriteElementString("onsale", board.OnSale.ToString().ToLower());
                        xmlOut.WriteElementString("length", board.Length.ToString());
                        xmlOut.WriteElementString("goofy", board.Goofy.ToString().ToLower());
                        xmlOut.WriteEndElement();
                    }
                    else if (product is GolfClubs club) //Does the same as above except with GolfClubs class
                    {
                        xmlOut.WriteStartElement("golf");
                        xmlOut.WriteElementString("code", club.Code);
                        xmlOut.WriteElementString("stock", club.Stock.ToString());
                        xmlOut.WriteElementString("name", club.Name);
                        xmlOut.WriteElementString("description", club.Description);
                        xmlOut.WriteElementString("price", club.Price.ToString());
                        xmlOut.WriteElementString("onsale", club.OnSale.ToString().ToLower());
                        xmlOut.WriteElementString("flex", club.Flex);
                        xmlOut.WriteElementString("righthanded", club.RightHanded.ToString().ToLower());
                        xmlOut.WriteEndElement();
                    }
                }

                // write the end tag for the root element
                xmlOut.WriteEndElement();

                // close the xmlWriter object
                xmlOut.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
