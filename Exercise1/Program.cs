Console.Write("Enter numberA : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numberB : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) Console.WriteLine("numberA - max, numberB - min");
else Console.WriteLine("numberB - max, numberA - min");