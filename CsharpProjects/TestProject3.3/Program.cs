string sku="01-MN-L ";
string[] product=sku.Split('-');

string type="";
string color="";
string size="";

if(product[0]=="01")
{
    type="Sweet shirt";
}else if(product[0]=="02")
{
    type="T-Shirt";
}else if(product[0]=="03")
{
    type="Sweet Pants";
}
else{
    type="Other";
}

if(product[1]=="BL")
{
    color="Black";
}else if(product[1]=="MN")
{
    color="Maroon";
}else
{
    color="White";
}

if(product[2]=="L")
{
    size="Large";
}
else
{
    size="one Sixze Fits all";
}

Console.WriteLine($"Product:{size} {color} {type}");
