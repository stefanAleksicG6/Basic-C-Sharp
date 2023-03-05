Console.WriteLine("Enter first number :");
string firstInput = Console.ReadLine();
int firstNum;
bool firstSuccess = int.TryParse(firstInput, out firstNum);

Console.WriteLine("Enter second number");
string secondInput = Console.ReadLine();
int secondNum;
bool secondSuccess = int.TryParse(secondInput, out secondNum);

int swapFirstNum = secondNum;
int swapSecondNum = firstNum;

firstNum = swapFirstNum;
secondNum = swapSecondNum;
Console.WriteLine("Swaped numbers :");
Console.WriteLine(" First number :" + firstNum);
Console.WriteLine(" Second number :" + secondNum);