using HandOn4;

Console.WriteLine("Enumeration");
EnumCheck enumCheck1 = EnumCheck.Enum1!;
Console.WriteLine("\n");
int a = 10;
Console.WriteLine(a.GetType());
//Check type of Enum1 which is EnumCheck type
Console.WriteLine(enumCheck1.GetType());
//Returning Enum1 from EnumCheck type
Console.WriteLine(enumCheck1);
//Returning data on Enum1 from EnumCheck type
Console.WriteLine((int)enumCheck1);

var b = (EnumCheck)0;
Console.WriteLine(b);

//Null Safety 

Console.WriteLine("Null Safety\n");

//Assign with ? opertor to make the variable can be null and has value
int? c=null;
if(c==null)
{
    Console.WriteLine("null");
}
c = 10;
Console.WriteLine(c!); 