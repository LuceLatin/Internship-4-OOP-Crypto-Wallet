using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes.Wallets
{
    public class EthereumWallet : Wallets
    {
        public List<Guid> AddressesOfNonFungibleAssetsThatItOwns { get; set; } = new List<Guid>();
        public List<Guid> AddressesOfSupportedNonFungibleAssets { get; set; } = new List<Guid>();



        public EthereumWallet() : base()
        {

        }
    }
}
