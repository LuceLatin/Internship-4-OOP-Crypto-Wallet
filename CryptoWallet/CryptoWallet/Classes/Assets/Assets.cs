using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Assets
{
    public class Assets
    {
        public Guid Address { get; }
        public string Name; //Unique vrijednost što znači da ne mogu postojat dva fungible asseta s istim imenom
        private Decimal _value { get; } //moguce dohvatiti ne i mijenjati u klasi?

        public Assets(string name, Decimal value) 
        { 
            Address = Guid.NewGuid();
            Name = name;
            _value = value;

        }
    }
}
