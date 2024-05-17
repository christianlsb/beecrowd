int number = Convert.ToInt16( Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    int value = number * i;
    Console.WriteLine($"{i} x {number} = {value}");  
}