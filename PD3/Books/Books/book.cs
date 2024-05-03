using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class book
    {
        public string Book_title;
        public string author;
        public string publicationYear;
        public float price;
        public int quantity;
        public book(string Book_title, string author, string publicationYear, float price, int quantity)
        {
            this.Book_title = Book_title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.price = price;
            this.quantity = quantity;
        }

        public string getTitle()
        {
            return "Title: " + Book_title;
        }


        public string getAuthor()
        {
            return "Author: " + author;
        }


        public string getPublicationYear()
        {
            return "Publication Year: " + publicationYear;
        }

        public string Price()
        {
            return "Price: " + price;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public string sellCopies(int sold_Copies)
        {
            string Return = "";
            if (sold_Copies <= quantity)
            {
                quantity = quantity - sold_Copies;
                Return = "Sold";
            }
            else
            {
                Return = "Not enough stock";
            }

            return Return;
        }

        public void Restock(int no_of_books)
        {
            quantity = quantity + no_of_books;
        }


        public string bookDetails()
        {
            return "Title: " + Book_title + "\n" + "Author: " + author + "\n" + "Publication Year: " + publicationYear + "\n" + "Price: " + price + "\n" + "Quantity: " + quantity;
        }

    }
}
