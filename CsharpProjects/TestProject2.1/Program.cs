// See https://aka.ms/new-console-template for more information
Random r=new Random();
int daysExp=r.Next(12);
int discount=(0);
Console.WriteLine($"daysExp,{daysExp}");
Console.WriteLine($"discount,{discount}");
if(daysExp==0)
{
    Console.WriteLine($"Your subscription has expired.");
}
else if(daysExp==1)
{
    Console.WriteLine($"Your subscription expires within a day!.");
    discount = 20;
}
else if(daysExp<=5)
{
    Console.WriteLine($"Your subscription expires in {daysExp} days.");
    discount = 10;
}
else if(daysExp<=10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discount > 0)
{
    Console.WriteLine($"Renew now and save {discount}%.");
}
