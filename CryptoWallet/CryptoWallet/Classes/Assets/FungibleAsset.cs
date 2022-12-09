using CryptoWallet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Assets
{
    public class FungibleAsset : Asset
    {
        public string Label { get; set; } //(skraćena verzija imena kao što je BTC za Bitcoin)  //UNIQUE

        public FungibleAsset(string name, Decimal value, string label) : base(name, value)
        {
            Label = label;
        }


        //nasljediti IFungible
    }


}
