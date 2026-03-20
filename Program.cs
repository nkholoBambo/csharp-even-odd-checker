Console.WriteLine("Choose any number you want and the program will determine whether it\'s a even or odd number");
double x = Convert.ToDouble(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine($"{x} is an even number");
}

else
{
    Console.WriteLine($"{x} is an odd number");
}