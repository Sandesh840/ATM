using tests.heritance;


void printOption()
{
    Console.WriteLine("1.Deposite");
    Console.WriteLine("2.Withdraw");
    Console.WriteLine("3. showbalance");
    Console.WriteLine("4. exit");
}
void deposite(CardHolder currentUser)
{
    Console.WriteLine("Enter deposite amt");
    double deposite = Double.Parse(Console.ReadLine());
    currentUser.setBalance(deposite + currentUser.getbalance());
    Console.WriteLine("thank you, your new balance is : $" + currentUser.getbalance());
}

void Withdraw(CardHolder currentUser)
{
    Console.WriteLine("Enter withdraw  amt");
    double withdraw = Double.Parse(Console.ReadLine());
    if (currentUser.getbalance() > withdraw)
    {
        currentUser.setBalance(currentUser.getbalance() - withdraw);
        Console.WriteLine("thank you, your new balance is : $" + currentUser.getbalance());
    }
    else
    {
        Console.WriteLine("Insuffiecient balance");
    }
}
void checkBalance(CardHolder currentUser)
{
    Console.WriteLine("your balance is : " + currentUser.getbalance());
}
List<CardHolder> cards = new List<CardHolder>();
cards.Add(new CardHolder(123, "2222 4053 4324 8877","Ram",5000));
cards.Add(new CardHolder(234, "2222 9909 0525 7051", "Shyam",1234));
cards.Add(new CardHolder(345, "2223 0076 4872 6984", "Hari",8540));
cards.Add(new CardHolder(456, "2223 5771 2001 7656", "Gopal",3690));
cards.Add(new CardHolder(567, "5105 1051 0510 5100", "Rita",4590));
cards.Add(new CardHolder(678, "5111 0100 3017 5156", "Gita",7531));
//first user interface
Console.WriteLine("welcome cha sabai lai MERO BANK ma");
Console.WriteLine("inser ur card number");
string cardNumber = "";
CardHolder currentUser;
while (true)
{
    try
    {
        cardNumber=Console.ReadLine();
        //check in list
        currentUser=cards.FirstOrDefault(a=>a.cardNum==cardNumber);
        if (currentUser != null)
        {
            break;
        }
        else
        {
            Console.WriteLine("invald card. try again");
        }
    }
    catch
    {
        Console.WriteLine("invald card. try again");
    }       
}


Console.WriteLine("enter your atm pin");
int pinNumber = 0;
while (true)
{
    try
    {
        pinNumber = int.Parse(Console.ReadLine());
        //check in list
        if (currentUser.getpin() == pinNumber)
        {
            break;
        }
        else
        {
            Console.WriteLine("invald pin. try again");
        }
    }
    catch
    {
        Console.WriteLine("invald pin. try again");
    }
}
Console.WriteLine("Welcome "+currentUser.getname());
int option = 0;
do
{   
    printOption();
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch { }
    if(option == 1) { deposite(currentUser); }
    else if (option == 2) { Withdraw(currentUser); }
    else if(option == 3) { checkBalance(currentUser); }
    else if (option==4) { break; }
    else { option = 0; }
}
while (option != 4);
Console.WriteLine("thank you, Good day");
Console.ReadLine();