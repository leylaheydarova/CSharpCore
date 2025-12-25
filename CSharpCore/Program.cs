void SayHello(string name = "Guest")
{
    Console.WriteLine($"Hello, {name}! Welcome to our restaurant!");
}


SayHello("Hemid");
SayHello("Vugar");
SayHello("Kubra");
SayHello();
//void SendMessage()
//{
//    Console.WriteLine("I am good today");
//}
////SendMessage();

//int SendNumber()
//{
//    return 10;
//}

//int number = SendNumber();
//Console.WriteLine(number + 45);

//string SendDenyMessage()
//{
//    return "access denied!";
//}

//string SendAcceptMessage()
//{
//    return "access accepted!";
//}

//bool isAccepted = false;
//for (int i = 0; i <= 3; i++)
//{
//    string message;
//    if (!isAccepted)
//    {
//        message = SendDenyMessage();
//    }
//    else
//    {
//        message = SendAcceptMessage();
//    }
//    Console.WriteLine(message);
//    if (i >= 2) isAccepted = true;
//}