Console.WriteLine("please enter your age");
int age = int.Parse(Console.ReadLine());

bool isChild = age >= 0 && age <= 12; 
bool isTeenager = age >= 13 && age <= 19;
bool isGrownup = age > 19; 

Console.WriteLine("you are a child " + isChild);
Console.WriteLine("you are a teenager" + isTeenager);
Console.WriteLine("you are a grownup" + isGrownup);
