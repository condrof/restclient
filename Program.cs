using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using restClient.bookService;

namespace restClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BookServiceClient client = new BookServiceClient();
            //values are hardcoded for simplicity. They change the value of the first record in the db
            johnwalsh.com.BookInfo b = new johnwalsh.com.BookInfo()
            {
                name = "Dublin",
                price = 30,
                Pages = 20,
                paperback = true
            };
            johnwalsh.com.BookInfo ret = client.UpdateBook(b);
            Console.WriteLine("city is now: " + ret.name + " with " + ret.Pages + " costing " + ret.price);

            Console.ReadLine();

        }
    }
}
