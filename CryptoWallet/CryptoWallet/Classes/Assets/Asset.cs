using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Assets
{
    public class Asset
    {
        public Guid Address { get; }
        public string Name { get; set; } //Unique vrijednost što znači da ne mogu postojat dva fungible asseta s istim imenom
        public Decimal Value { get; private set; } //moguce dohvatiti ne i mijenjati u klasi?

        public Asset(string name, Decimal value) 
        { 
            Address = Guid.NewGuid();
            Name = name;
            Value = value;

        }
    }
}
