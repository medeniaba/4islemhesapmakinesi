
Console.WriteLine("Birinci Sayıyı Giriniz ");
int sayi1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("İkinici Sayıyı Giriniz");
int sayi2 = Int32.Parse(Console.ReadLine());
double sonuc;
String a;
Console.WriteLine("Bir operatör Seçiniz : + , - , * , / ");
a = Console.ReadLine();
if (a == "+")
{
    Console.WriteLine(sonuc = sayi1 + sayi2);
}
else if (a == "-")
{
    Console.WriteLine(sonuc = sayi1 - sayi2);
}
else if (a == "*")
{
    Console.WriteLine(sonuc = sayi1 * sayi2);
}
else if (a == "/")
{
    Console.WriteLine(sonuc = (sayi1 / sayi2));
}
