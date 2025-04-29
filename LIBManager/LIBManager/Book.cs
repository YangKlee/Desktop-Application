using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBManager
{
    internal class Book
    {
        private int bookID;
        private string title;
        private string author;
        private int pageCount;
        private string topic;
        private string code;

        public Book(int bookID, string title, string author, int pageCount, string topic, string code)
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.topic = topic;
            this.code = code;
        }
        public Book() { }
        public int BookID { get => bookID; set => bookID = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Code { get => code; set => code = value; }
    }
}
