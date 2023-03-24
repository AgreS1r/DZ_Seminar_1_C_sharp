Console.Write("Enter number : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0){
    Console.WriteLine($"number {number} - чётное!");
}
else Console.WriteLine($"number {number} - нечётное!");