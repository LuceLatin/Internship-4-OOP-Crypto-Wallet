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
        private Decimal _value { get; } //moguce dohvatiti ne i mijenjati u klasi?

        public NonFungibleAsset() : base()
        {

        }

    }
}
