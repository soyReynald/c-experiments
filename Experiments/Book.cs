using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    internal class Book
    {
        public string title;
        public string author;
        public string description;

        public Book (string title = "", string author = "", string description = "")
        {
            this.title = title;
            this.author = author;
            this.description = description;

            showPortrait(this.title, this.author, this.description);
        }

        public string showPortrait (string title, string author, string description)
        {
            this.title = title;
            this.author = author;
            this.description = description;

            string returningString = "Welcome to the book: " + this.title + ", the author is: " + this.author + " and the description will be bellow: ";
            returningString = returningString + "\n" +this.description;

            Console.WriteLine("Hi!, this program is to introduce the books that I have on my bookstore"); // This will be momentary.
            return returningString;
        }
    }
}
