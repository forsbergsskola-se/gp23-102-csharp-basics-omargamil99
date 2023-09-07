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

