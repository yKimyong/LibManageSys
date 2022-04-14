using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMain
{
    internal class BookManage
    {
        //Add,Delete,Modify,Select,ShowAll
        public List<Book> books=new List<Book>();

        public  Boolean Delete(string name)
        {
            foreach (Book book in books)
            {
                if(name==book.Name)
                    books.Remove(book);
                return true;
            }
            return false;
        }

        public  List<Book> ShowAll()
        {
            return books;
        }

        public  Boolean Add(string name,string author,decimal price,string des)
        {
            if (name != null && author != null && price != 0)
            {
                books.Add(new Book(name, author, price, des));
                return true;
            }
            return false ;
        }

        public Book Select(string name)
        {
            return (Book)books.Select(book => book.Name);
        }
    }
}
