using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transactions
{
    public class Transactions
    {
        private Guid Id;
        public DateTime Date { get; }

        public bool HasBeenRecalled;



        public Transactions(DateTime date)
        { 
            Id= Guid.NewGuid();
            Date = date;
        }
    }
}
