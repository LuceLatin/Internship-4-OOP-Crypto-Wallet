using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Assets
{
    public class NonFungibleAsset : Assets
    {
        private Guid _addressOfFungibleAssets;
        

        public NonFungibleAsset(string name, Decimal value, Guid adressOfFungibleAssets) : base(name, value)
        {
            _addressOfFungibleAssets= adressOfFungibleAssets;
        }

    }
}
