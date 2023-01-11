
Console.WriteLine("enter the tempature: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("boiling hot");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("hot");
}
else if(temp < 20 && temp >= 15)
{
    Console.WriteLine("warm");
}
else if(temp < 15 && temp >= 10)
{
    Console.WriteLine("chilly");
}
else if(temp < 10 && temp > 0)
{
    Console.WriteLine("cold");

}
else
{
    Console.WriteLine("freezing cold");
}