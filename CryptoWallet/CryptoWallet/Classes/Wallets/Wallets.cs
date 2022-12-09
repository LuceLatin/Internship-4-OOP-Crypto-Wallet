using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CryptoWallet.Classes.Transactions;
using CryptoWallet.Classes.Assets;
using CryptoWallet.Classes;


namespace CryptoWallet.Classes.Wallets
{
    public abstract class Wallets
    {
        public Guid Address { get; } = Guid.NewGuid(); //priv ispis u cl
        public Dictionary<Guid, int> BalancesOfFungibleAssets = new Dictionary<Guid, int>(); //get set NIJE MOGUCE MIJENJATI fungibleAssetsAddress - amount
        public List<Guid> AddressesOfSupportedFungibleAssets { get; set; } = new List<Guid>();
        public List<Guid> TransactionAddresses { get; set; } = new List<Guid>();

        /*
        public Wallets()
        {
            Address = Guid.NewGuid();
        }
        */

        public abstract void PrintAllWallets(List<Transaction> listOfTransactions, List<Asset> listOfAssets);
        
    }
}
