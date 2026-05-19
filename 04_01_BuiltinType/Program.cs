//kur bilgileri ve Tarih
var dollarRate = 40.70M;
var goldRate = 4400M;
var eurorate = 47.50M;
Console.WriteLine(dollarRate.GetType());
DateTime rateDate= DateTime.Now;
Console.WriteLine("TL Miktarini Giriniz: ");

decimal amuntinTL=Convert.ToDecimal(Console.ReadLine());
//Menü
Console.WriteLine("1-Dolar");
Console.WriteLine("2-Euro");
Console.WriteLine("3-Altın");
Console.WriteLine("Lütfen Seçiminizi Yapınız:(1-3)");
int choice=int.Parse(Console.ReadLine());
decimal result = 0m;
string currencyName = "";
switch (choice)
{
    case 1:
        result = amuntinTL / dollarRate;
        currencyName = "USD";
        Console.WriteLine($"Dollar:{result}");
        break;
        case 2:
        result = amuntinTL / eurorate;
        currencyName = "Euro";
        Console.WriteLine($"Euro:{result}");
        break;
    case 3:
        result=amuntinTL / goldRate;
        currencyName = "Gold";
        Console.WriteLine($"Gold:{result:2}");
        break;
    default:
        {
            Console.WriteLine("Geçersiz hatalı Seçim");
        }
        break;


}
Console.ReadKey();
