using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class BookStore
    {
        // Creates a linked list that takes the values from '_books' and fills them into the linked list
        private LinkedList<Books> _books = new LinkedList<Books>();


        // Filling the linked list with data
        public LinkedList<Books> Books
        {
            get { return _books; }
            set { _books = value; }
        }
    }
}
