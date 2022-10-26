bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{
// start
int num1;
int num2;
bool isNumber;

Console.WriteLine("Hello, we will ask you for two numbers and we will add them for you!");
do{

Console.Write("Enter the first number: ");

isNumber = int.TryParse(Console.ReadLine(), out num1);
if(isNumber==false)
{
    Console.WriteLine("Enter valid data,");
}

}while(isNumber==false);

do{

Console.Write("Enter the second number: ");

isNumber = int.TryParse(Console.ReadLine(), out num2);
if(isNumber==false)
{
    Console.WriteLine("Enter valid data,");
}

}while(isNumber==false);




// Console.WriteLine("Enter the first number:");
// num1 = Convert.ToInt32(Console.ReadLine());

// We can convert to Int directly
// The variable defined needs to be an int. If its defined as string will mark error.

// Console.WriteLine("Enter the second number:");
// num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of both is: {num1 + num2}");
// end
validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}

