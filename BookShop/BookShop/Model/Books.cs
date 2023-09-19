using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class Books
    {
        private string _bookTitle = "";
        private string _author = "";
        private decimal _price;

        // Feeding the class data
    public string BookTitle 
        {
            get { return _bookTitle; }
            set { _bookTitle = value; }
        }
    public string Author 
        {
            get { return this._author; }
            set { this._author = value; }
        }
    public decimal Price
        { 
            get { return this._price; }
            set { this._price = value; }
        
        }
    }

}
