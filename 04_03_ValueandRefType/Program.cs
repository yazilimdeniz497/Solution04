//değer tip
int num1 = 10;
int num2 = 20;
Console.WriteLine($"Metot çağrısı öncesi değer tipi:num1={num1} ,num2={num2}"); ;
SwapNumbers(num1, num2);
Console.WriteLine($"Metot çağrısı sonrası değer tipi:num1={num1}, num2={num2}");

void SwapNumbers(int num1, int num2)
{
    int temp=num1;
    num1=num2;
    num1 = temp;
}

//referans tip
int[] numbers = { 10, 2 };
Console.WriteLine($"Metot çağrısı öncesi değer tipi:num1={numbers[0]} ,num2={numbers[1]}"); ;

Swaparrays(numbers);
Console.WriteLine($"Metot çağrısı sonrası değer tipi:num1={numbers[0]}, num2={numbers[1]}");


void Swaparrays(int[] numbers)
{
    int temp = numbers[0];
    numbers[0]=numbers[1];
    numbers[1]=temp;
   

}

Console.ReadKey();

