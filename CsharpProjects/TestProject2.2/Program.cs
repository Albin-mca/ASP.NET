// string[] fraudulentOrderIDs=new string[3];
// fraudulentOrderIDs[0]="A123";
// fraudulentOrderIDs[1]="B456";
// fraudulentOrderIDs[2]="C789";
// // fraudulentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs={"Aa123","Ba456","Ca789"};


Console.WriteLine($"First {fraudulentOrderIDs[0]}");
Console.WriteLine($"2nd {fraudulentOrderIDs[1]}");
Console.WriteLine($"3rd {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0]="ZZ567";
Console.WriteLine($"Re assigned First {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");