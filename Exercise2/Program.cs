Console.Write("Enter numberA : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numberB : ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numberC : ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max){
    max = numberB;
}
if (numberC > max){
    max = numberC;
}
Console.WriteLine($"max = {max}");