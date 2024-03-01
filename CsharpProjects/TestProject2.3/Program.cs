
// // string[] names={"A","B","C","D"};
// // foreach(string name in names)
// // {
// //     Console.Write(name);
// // }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum=0;
// int bin=0;
// foreach(int item in inventory )
// {
//     sum+=item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");

// }

// Console.WriteLine(sum);
// Console.WriteLine(bin);

string[] Order_ID= {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach(string order in Order_ID)
{
    // Console.WriteLine(order);
    if(order.StartsWith("B"))
    {
        Console.WriteLine($"The name starts with 'B'!{order}");

    }
}