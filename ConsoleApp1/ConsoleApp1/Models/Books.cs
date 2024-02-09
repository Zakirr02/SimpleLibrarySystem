using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1.Models
{
    
    public class Book
    {
       

        public string Title {get ;set ;}
         public string Author {get; set;}
        public string Genre { get; set;}
         public int PublicationYear { get; set; }
         public bool CopiesAvailable{ get; set; }



        public void DisplayDetails() {
            Console.WriteLine($"{Title}\n{Author}\n{Genre}\n{PublicationYear}\n{CopiesAvailable}");
        }
    }
    
    
}
