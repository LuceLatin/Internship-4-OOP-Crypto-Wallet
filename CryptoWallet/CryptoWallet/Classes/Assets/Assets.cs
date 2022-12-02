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
        private Guid _address;
        public string Name; //Unique vrijednost što znači da ne mogu postojat dva fungible asseta s istim imenom
        
        public Assets() 
        { 
            _address = Guid.NewGuid();

        }
    }
}
