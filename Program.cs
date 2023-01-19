// See https://aka.ms/new-console-template for more information

// ekrandan girilen sayıya kadar tek sayıları ekrana yazdır.
Console.WriteLine("Lütfen bir sayı giriniz");
int sayac = int.Parse(Console.ReadLine());
for (int i = 0; i < sayac; i++)
{
    if(i%2!=0){
        Console.WriteLine(i);
    }
}
//1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
int tekToplam=0;
int ciftToplam=0;

for (int i = 0; i <=1000; i++)
{
    if(i%2!=0){
        tekToplam += i;
    }else{
        ciftToplam += i;
    }
}

Console.WriteLine("Tek toplam:"+tekToplam);
Console.WriteLine("Çift toplam"+ciftToplam);

for (int i = 0; i < 10; i++)
{
    if(i==4)
        break;
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i);
}