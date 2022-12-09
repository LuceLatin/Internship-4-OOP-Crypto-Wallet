using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transactions
{
    public class NonFungibleAssetTransaction : Transaction
    {

        private Guid _addressOfNonFungibleAsset;
        private Guid _addressOfWalletThatSendsNonFungibleAsset { get; }

        private Guid _addressOfWalletThatReceivesNonFungibleAsset { get; }

        public NonFungibleAssetTransaction(Guid addressOfWalletThatSendsNonFungibleAsset,
                                           Guid addressOfWalletThatReceivesNonFungibleAsset, 
                                           Guid addressOfNonFungibleAsset, DateTime date) : base(date)
        {
            _addressOfNonFungibleAsset = addressOfNonFungibleAsset;
            _addressOfWalletThatReceivesNonFungibleAsset = addressOfWalletThatReceivesNonFungibleAsset;
            _addressOfWalletThatSendsNonFungibleAsset = addressOfWalletThatSendsNonFungibleAsset;
        }
    }
}
