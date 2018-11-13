using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public class Account
    {
        public static string BankName;
        public static decimal Reserves;

        public string Number { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public decimal Balance { get; set; }

        //Constructor
        public Account()
        {
            // ...
        }
    }

  

}
