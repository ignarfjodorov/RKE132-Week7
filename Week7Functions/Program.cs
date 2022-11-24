Console.WriteLine("Are you coming or leaving?");
string userChoise = Console.ReadLine();

if(userChoise == "coming")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}





static void PrintHello() //function / method
{
    Console.WriteLine("hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later.");
}

