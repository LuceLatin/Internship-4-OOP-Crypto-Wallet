using CryptoWallet.Classes.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Interfaces
{
    internal interface INonFungibleAsset
    {
        decimal ReturnValueOfAssets(List<Asset> listOfAssets);
    }
}
