using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWallet.Classes.Transactions;
using CryptoWallet.Classes.Assets;
using CryptoWallet.Interfaces;

namespace CryptoWallet.Classes.Wallets
{
    public class BitcoinWallet : Wallets, IFungibleWallet
    {

        public BitcoinWallet() : base()
        {

        }


        public decimal FungibleTotalValueOfAllAssetsInUSD(List<Asset> listOfAssets)
        {
            if (listOfAssets.Count == 0) return 0m;
            return     (from balance in BalancesOfFungibleAssets
                        let valueOfAsset = listOfAssets.Find(a => a.Address.Equals(balance.Key)).Value
                        where valueOfAsset is not 0m
                        select valueOfAsset * balance.Value).Sum();
        }


        public override void PrintAllWallets(List<Transaction> listOfTransactions, List<Asset> listOfAssets)
        {

            Console.WriteLine($"Type of wallet: Bitcoin.\n"
                + $"Address of wallet: {Address}\n " +
                $"Total value of all assets that it own is: {FungibleTotalValueOfAllAssetsInUSD(listOfAssets)} (USD) \n" +
                $"");
            //interfaces
            //Ukupna vrijednost svih asseta koje posjeduje u USD
            //Postotak pada/povečanja ukupne USD vrijednosti svih asseta koje
            //posjeduje u odnosu na prošli put kada se ta informacija prikazala


        }

    }
}
