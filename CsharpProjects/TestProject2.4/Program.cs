﻿string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;
foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        x++; 
    } 
}
string new_message = new String(charMessage);
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");