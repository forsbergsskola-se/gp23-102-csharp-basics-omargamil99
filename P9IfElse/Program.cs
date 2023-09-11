Console.WriteLine("What is your age?");
int age = int.Parse(Console.ReadLine());

string agegroup; 
if (age <= 12)
{
    agegroup = "child";
}
else if (age <= 19) 
{
    agegroup = "teenager";
}
else
{
    agegroup = "grownup";
}

Console.WriteLine($"you are a {agegroup}" );

Console.WriteLine("Enter another integer");
int anotherNumber = int.Parse(Console.ReadLine()); 

int greaterNumber = Math.Max(age, anotherNumber);
Console.WriteLine($"The greater number is: {greaterNumber}");

string evenOrOdd = (greaterNumber % 2 == 0) ? "even" : "odd";
Console.WriteLine($"The greater number is an {evenOrOdd} number");








