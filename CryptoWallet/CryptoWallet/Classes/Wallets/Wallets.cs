using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallets
{
    public class Wallets
    {
        private static Guid Address;
        public Dictionary<Guid, int> BalancesOfFungibleAssets = new Dictionary<Guid, int>(); //get set NIJE MOGUCE MIJENJATI fungibleAssetsAddress - amount
        public List<Guid> AddressesOfSupportedFungibleAssets { get; set; } = new List<Guid>();
        public List<Guid> TransactionAddresses { get; set; } = new List<Guid>();


        public Wallets()
        {
            Address = Guid.NewGuid();
        } 
    }
}
