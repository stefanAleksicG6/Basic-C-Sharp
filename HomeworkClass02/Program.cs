Console.WriteLine("Enter the first number:");
string inputFirstNum = Console.ReadLine();
int firstNum;
bool firstSuccess = int.TryParse(inputFirstNum, out firstNum);

Console.WriteLine("Enter the second number");
string inputSecondNum = Console.ReadLine();
int secondNum;
bool secondSuccess = int.TryParse(inputSecondNum, out secondNum);

Console.WriteLine("Enter operation +, -, /, * :");
string operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine(firstNum + secondNum);
}
else if (operation == "-")
{
    Console.WriteLine(firstNum - secondNum);
}
else if (operation == "*")
{
    Console.WriteLine(firstNum * secondNum);
}
else if (operation == "/")
{
    Console.WriteLine(firstNum / secondNum);
}
else
{
    Console.WriteLine("Invalid operation");
}


