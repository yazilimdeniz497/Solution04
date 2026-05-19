object data = "Merhaba";
if(data is string)
{
    Console.WriteLine("ifade string'tir");
} else if(data is int)
{
    Console.WriteLine("ifade int'tir");
}
else
{
    Console.WriteLine("başka bir ifade");
}
Console.ReadKey();