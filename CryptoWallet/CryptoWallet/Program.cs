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
using System;


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


var fungibleAssets = new List<Asset>()
{
    new FungibleAsset("Bitcoin", 16911.40m, "BTC"),
    new FungibleAsset("Ethereum", 1242.08m, "ETH"),
    new FungibleAsset("Ripple", 0.39m, "XRP"),
    new FungibleAsset("Binance coin", 29046m , "BNB"),
    new FungibleAsset("Polkadot", 5.10m, "DOT"),
    new FungibleAsset("Cardano", 0.32m,"ADA"),
    new FungibleAsset("Polygon", 0.9222m ,"MATIC"),
    new FungibleAsset("USD coin", 1.00m , "USDC"),
    new FungibleAsset("Dogecoin", 0.10m, "DOGE"),
    new FungibleAsset("Tether", 1.00m, "USDT"),


};

var listOfTransactions = new List<Transaction>();
var addressOfAsset = fungibleAssets[1].Address;
var nonFungubleAssets = new List<Asset>()
{
    new NonFungibleAsset("KILLABERS", 2.97m , addressOfAsset),
    new NonFungibleAsset("Abstraction", 0.40m , addressOfAsset),
    new NonFungibleAsset("RarePass", 34m ,addressOfAsset),
    new NonFungibleAsset("The Sandbox", 1.07m , addressOfAsset),
    new NonFungibleAsset("Azuki", 9.75m, addressOfAsset),
    new NonFungibleAsset("Valhalla", 0.75m , addressOfAsset),
    new NonFungibleAsset("Doodles", 7m , addressOfAsset),
    new NonFungibleAsset("Pudgy Penguins", 3.4m , addressOfAsset),
    new NonFungibleAsset("Decentraland", 1.3m , addressOfAsset),
    new NonFungibleAsset("Mutant Ape Yacht Club", 13.75m , addressOfAsset),
    new NonFungibleAsset("Bored Ape Yacht Club", 68.95m , addressOfAsset),
    new NonFungibleAsset("The Memes by 6529", 0.25m , addressOfAsset),
    new NonFungibleAsset("Rug Radio", 0.52m , addressOfAsset),
    new NonFungibleAsset("Dabloons Adventure", 0.05m , addressOfAsset),
    new NonFungibleAsset("Pre-Process", 7.49m , addressOfAsset),
    new NonFungibleAsset("Mystery of Chessboxing by anon", 0.1m , addressOfAsset),
    new NonFungibleAsset("Cel Mates by Mcbess", 0.43m , addressOfAsset),
    new NonFungibleAsset("Crypto Unicorns Market", 0.01m , addressOfAsset),
    new NonFungibleAsset("Cel Mates Hello World", 0.3m, addressOfAsset),
    new NonFungibleAsset("Oderdeed for Otherside",1.31m , addressOfAsset),

};

int InputNumber()
{
    int num;
    do
    {
        Console.WriteLine("Enter number");
        var choice = (Console.ReadLine());
        var result = int.TryParse(choice, out num);
        if (result == false)
        {
            Console.WriteLine("It is necessary to enter a NUMBER");
        }
        else if (num < 0 || num > 3)
        {

            if (Confirmation()) break;


        }
        else if (result == true && num >= 0 && num <= 3)
            break;
    }
    while (true);
    return num;
}
void MainMenu()
{
    Console.Clear();
    Console.WriteLine("Crypto Wallet");
    Console.WriteLine("1 - Create wallet");
    Console.WriteLine("2 - Access the wallet");

    var num = InputNumber();
    switch (num)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Create wallet:");
            CreateWallet();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Access the wallet:");
            AccessTheWallet();
            break;
        

    }
    /*
    Console.WriteLine("Bitcoin wallet");
    Console.WriteLine("Ethereum wallet");
    Console.WriteLine("Solana wallet");
    */
}

void CreateWallet()
{
    Console.WriteLine("0 - Main Menu");
    Console.WriteLine("1 - Bitcoin wallet");
    Console.WriteLine("2 - Ethereum wallet");
    Console.WriteLine("3 - Solana wallet");


    var num = InputNumber();
    

    switch (num)
    {
        case 0:
            Console.WriteLine("Back to main menu.");
            MainMenu();
            break;
        case 1:
            Console.WriteLine("Bitcoin wallet:");
            wallets.Add(new BitcoinWallet());
            Console.WriteLine("A new Bitcoin wallet has just been added. ");

            break;
        case 2:
            Console.WriteLine("Ethereum wallet:");
            wallets.Add(new EthereumWallet());
            Console.WriteLine("A new Ethereum wallet has just been added. ");

            break;
        case 3:
            Console.WriteLine("Solana wallet:");
            wallets.Add(new SolanaWallet());
            Console.WriteLine("A new Solana wallet has just been added. ");

            break;
        

    }
}

void AccessTheWallet()
{
    PrintWallets();
    Console.WriteLine("Enter address:"); //nadopuni
    foreach (var item in wallets)
    {
        Console.WriteLine(item.Address); //prebacit 
    }
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("0 - Main Menu");
    Console.WriteLine("1 - Portfolio");
    Console.WriteLine("2 - Transfer");
    Console.WriteLine("3 - Transaction history");
    
    var num = InputNumber();

    switch (num)
    {
        case 0: 
            Console.WriteLine("Back to main menu: ");
            MainMenu();
            break;
        case 1:
            Console.WriteLine("Portfolio: ");
            Portfolio();
            break;
        case 2:
            Console.WriteLine("Transfer: ");
            Transfer();
            break;
        case 3:
            Console.WriteLine("Transaction history: ");
            TransactionHistory();
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

void PrintWallets()
{
    Console.WriteLine("All wallets: ");
    foreach (var wallet in wallets)
    {
        wallet.PrintAllWallets(listOfTransactions, fungibleAssets);
    }
}

MainMenu();

