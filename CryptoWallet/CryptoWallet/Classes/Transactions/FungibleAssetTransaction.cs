using CryptoWallet.Classes.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Transactions
{
    public class FungibleAssetTransaction : Transaction
    {

        private Guid _addressOfFungibleAsset;
        private Guid _addressOfWalletThatSendsFungibleAsset { get; }
        private Guid _addressOfWalletThatReceivesFungibleAsset { get; }
        public Guid InitialBalanceOfSendingWallet { get; set; } //tipovi
        public Guid FinalBalanceOfSendingWallet { get; set; }
        public Guid InitialBalanceOfWalletItReceives { get; set; }
        public Guid FinalBalanceOfWalletItReceives { get; set; }


        public FungibleAssetTransaction(Guid addressOfWalletThatSendsFungibleAsset,
                                        Guid addressOfWalletThatReceivesFungibleAsset,
                                        Guid addressOfFungibleAsset, DateTime date) : base(date)
        {
            _addressOfFungibleAsset = addressOfFungibleAsset;
            _addressOfWalletThatReceivesFungibleAsset = addressOfWalletThatReceivesFungibleAsset;
            _addressOfWalletThatSendsFungibleAsset = addressOfWalletThatSendsFungibleAsset;
        }
    }
}
