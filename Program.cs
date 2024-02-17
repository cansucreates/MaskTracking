// See https://aka.ms/new-console-template for more information
// ALIŞTIRMA SAYFASI

// Metotlar
// default : noname
static void SelamVer(string isim="noname") //  void means that the method does not return a value
{
    Console.WriteLine("Selam" + isim);
}

// Array (Diziler)
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Derin";
ogrenciler[2] = "Salih";

// for döngüsü
for(int i = 0; i < ogrenciler.Length; i++) {
    Console.WriteLine(ogrenciler[i]);
}
// örnek
string [] sehirler1 = new string[] {"Ankara", "İstanbul", "İzmir"};
string [] sehirler2 = new [] {"Kastamonu", "Malatya", "Kocaeli"};

// referans tipleri array, class, interface, string etc...
sehirler2 = sehirler1; // sehirler1'in referans numarasını sehirler2'ye atadık. Yani sehirler2'nin referans numarası sehirler1'in referans numarası oldu.
sehirler1[0] = "Adana";
// sehirler2[0] = ?? ne olur = Adana. Çünkü referans tipi

// NOT: new dediğimizde bellekte yeni bir adres oluşturulur. 
// Yani new demek yeni bir referans numarası demek.

// değer tipleri int, double, bool etc...
int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
// sayi2 = ?? kaç olur = 10. Çünkü değer tipi

// foreach döngüsü
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

// Listeler (Array gibi ama daha esnek)
// generic collection
List<string> yeniSehirler3 = new List<string> {"Ankara", "İstanbul", "İzmir"};
// yeni eleman oluşturuldu
yeniSehirler3.Add("Adana");