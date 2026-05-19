//byte
Console.WriteLine("Byte Değer aralığı(0-255)");
Console.WriteLine($"Byte minimum değeri:{byte.MinValue},Byte Maximum Değeri:{byte.MaxValue}");
//sbyte
Console.WriteLine("SByte Değer aralığı(-128 127)");
Console.WriteLine($"Byte minimum değeri:{sbyte.MinValue},Byte Maximum Değeri:{sbyte.MaxValue}");
Console.WriteLine(" ");
byte unsignedvalue = 255;
Console.WriteLine($"başlangıç değeri:{unsignedvalue}");
unsignedvalue++;
Console.WriteLine($"bitiş değeri:{unsignedvalue}");
//ikili Gösterim
Console.WriteLine("Binary Sistem");
Console.WriteLine($"Bytin Binary karsiliği:{Convert.ToString(255,2)}");

Console.ReadKey();