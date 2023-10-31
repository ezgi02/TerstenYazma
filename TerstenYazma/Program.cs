Console.Write("Lütfen bir metin giriniz");
string metin = Console.ReadLine();
//metin.Length "-1" deme sebebimiz diziler
//diziler "0". indisden başlamaktır
Console.WriteLine("Metnimizin ters hali");
for (int i = metin.Length - 1; i >= 0; i--)
{
    Console.Write(metin[i]);
}