using CryptoWallet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWallet.Classes.Transactions;
using CryptoWallet.Classes.Assets;

namespace CryptoWallet.Classes.Wallets
{
    public class SolanaWallet : Wallets, INonFungibleWallet //, IFungibleWallet
    {
        public List<Guid> AddressesOfNonFungibleAssetsThatItOwns { get; set; } = new List<Guid>();
        public List<Guid> AddressesOfSupportedNonFungibleAssets { get; set; } = new List<Guid>();


        public SolanaWallet() : base()
        {

        }



        public decimal TotalValueOfAllAssetsInUSD(List<Asset> listOfAssets)
        {
            var temp = (from balance in BalancesOfFungibleAssets
                        let valueOfAsset = listOfAssets.Find(a => a.Address.Equals(balance.Key)).Value
                        where valueOfAsset is not 0m
                        select valueOfAsset * balance.Value).Sum();
            foreach (var address in AddressesOfNonFungibleAssetsThatItOwns.Select(address=>listOfAssets.Find(a => a.Address.Equals(address))))
            {
                if (listOfAssets is INonFungibleAsset nonFungibleAsset)
                    temp+=nonFungibleAsset.ReturnValueOfAssets(listOfAssets);
            }
            return temp;
        }


        public override void PrintAllWallets(List<Transaction> listOfTransactions, List<Asset> listOfAssets)
        {
            Console.WriteLine($"Type of wallet: Solana.\n"
                + $"Address of wallet: {Address}\n " +
                $"Total value of all assets that it own is: {TotalValueOfAllAssetsInUSD(listOfAssets)} (USD) \n" +
                $"");
            //interfaces
            //Ukupna vrijednost svih asseta koje posjeduje u USD
            //Postotak pada/povečanja ukupne USD vrijednosti svih asseta koje
            //posjeduje u odnosu na prošli put kada se ta informacija prikazala


        }

    }
}
