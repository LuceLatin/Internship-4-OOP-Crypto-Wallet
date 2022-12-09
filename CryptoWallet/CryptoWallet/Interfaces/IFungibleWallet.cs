using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoWallet.Classes.Assets;
using CryptoWallet.Classes.Transactions;

namespace CryptoWallet.Interfaces
{
    internal interface IFungibleWallet
    {
        //decimal CalculateTotalValueOfWallet(List<FungibleAsset> listOfFungibleAsset);

        //Ukupna vrijednost svih asseta koje posjeduje u USD
        decimal FungibleTotalValueOfAllAssetsInUSD(List<Asset> listOfAssets);
       

        //■ Postotak pada/povečanja ukupne USD vrijednosti svih asseta koje
        //posjeduje u odnosu na prošli put kada se ta informacija prikazala

    }
}
