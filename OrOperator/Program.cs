

int math, biology, chemistry;

Console.WriteLine("Enter your Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("enter your biology result:");
chemistry
    = Int32.Parse(Console.ReadLine());

if((math >= 90 || chemistry >= 90)||(math >= 90 && biology >= 90) ||( chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("congratulatsions! you got accepted");
}
else
{
    Console.WriteLine("your application could not be approved");
}