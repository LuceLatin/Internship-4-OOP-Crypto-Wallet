/*namespace CryptoWallet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {

        }
    }
    
}
*/

using CryptoWallet.Classes.Wallets;
using CryptoWallet.Classes.Assets;
using CryptoWallet.Classes.Transactions;
using System.Xml.Serialization;


var wallets = new List<Wallets>()
{
    new BitcoinWallet(),
    new EthereumWallet(),
    new SolanaWallet(),
    new BitcoinWallet(),
    new EthereumWallet(),
    new SolanaWallet(),
    new BitcoinWallet(),
    new EthereumWallet(),
    new SolanaWallet(),

};

var nonFungibleAssets = new List<Assets>()
{

};

var fungibleAssets = new List<Assets>()
{
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),
    new FungibleAsset(),


};

void MainMenu()
{
    Console.WriteLine("Enter number");
    int num;

    var choice = (Console.ReadLine());
    var result = int.TryParse(choice, out num);
    if (result == false )
    {
        Console.WriteLine("It is necessary to enter a NUMBER");
        return;
    }
     
    switch(num)
    {
        case 1:
            Console.WriteLine("1 - Create wallet");
            CreateWallet();
            break;
        case 2:
            Console.WriteLine("2 - Access the wallet");
            AccessTheWallet();
            break;
        default:
            if(!Confirmation()); //popravi
            break;

    }


        


    
    Console.WriteLine("Bitcoin wallet");
    Console.WriteLine("Ethereum wallet");
    Console.WriteLine("Solana wallet");
}

void CreateWallet()
{
    Console.WriteLine("Enter number");
    int num;

    var choice = (Console.ReadLine());
    var result = int.TryParse(choice, out num);
    if (result == false)
    {
        Console.WriteLine("It is necessary to enter a NUMBER");
        return;
    }

    switch (num)
    {
        case 1:
            Console.WriteLine("1 - Bitcoin wallet");


            break;
        case 2:
            Console.WriteLine("2 - Ethereum wallet");

            break;
        case 3:
            Console.WriteLine("3 - Solana wallet");

            break;
        default:
            if (!Confirmation()) ; //popravi
            break;

    }
}

void AccessTheWallet()
{
    Console.WriteLine("Enter number");
    int num;

    var choice = (Console.ReadLine());
    var result = int.TryParse(choice, out num);
    if (result == false)
    {
        Console.WriteLine("It is necessary to enter a NUMBER");
        return;
    }

    switch (num)
    {
        case 1:
            Console.WriteLine("1 - Portfolio");
            Portfolio();
            break;
        case 2:
            Console.WriteLine("2 - Transfer");
            Transfer();
            break;
        case 3:
            Console.WriteLine("3 - Transaction history");
            TransactionHistory();
            break;
        default:                    //povratak na inicijalni meni
            if (!Confirmation()) ; //popravi 
            break;

    }
}

void Portfolio()
{

}

void Transfer()
{

}

void TransactionHistory()
{

}

bool Confirmation()
{
    Console.WriteLine("Are you sure you want to exit? y/n");
    var choice = Console.ReadLine().ToLower();
    if (choice == "y")
    {
        Console.WriteLine("End of program.");
        return true;
    }
    return false;
        
    
}


MainMenu();
