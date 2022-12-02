using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Assets
{
    public class FungibleAsset : Assets
    {
        private string _label; //(skraćena verzija imena kao što je BTC za Bitcoin)  //UNIQUE

        public FungibleAsset() : base()
        {
            
        }

    }


}
