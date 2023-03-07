Console.WriteLine("Enter first number :");
string firstInput = Console.ReadLine();
int firstNum;
bool firstSuccess = int.TryParse(firstInput, out firstNum);

Console.WriteLine("Enter second number :");
string secondInput = Console.ReadLine();
int secondNum;
bool secondSuccess = int.TryParse(secondInput, out secondNum);

Console.WriteLine("Enter third number :");
string thirdInput = Console.ReadLine();
int thirdNum;
bool ThirdSuccess = int.TryParse(thirdInput, out thirdNum);

Console.WriteLine("Enter fourth number :");
string fourthInput = Console.ReadLine();
int fourthNum;
bool fourthSucces = int.TryParse(fourthInput, out fourthNum);

Console.WriteLine("The average of the four numbers is :" + (firstNum + secondNum + thirdNum + fourthNum) / 4 );