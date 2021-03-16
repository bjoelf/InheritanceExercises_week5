using System;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Book
    {
        public string this[string key]
        {
            get { return title; }
            set { title = value; }
        }

        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public string year { get; set; }
        public string pages { get; set; }
    }
}
