using Business.Concrete;
using Entities.Concrete;


SelamVer(isim:"Jale");
SelamVer(isim:"Emre");
SelamVer();

int sonuc = Topla(20,55);
Console.WriteLine(sonuc);

string ogrenci1 = "Emre";
string ogrenci2 = "Jale";
string ogrenci3 = "Can";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Emre";
ogrenciler[1] = "Jale";
ogrenciler[2] = "Can";


ogrenciler = new string[4];
ogrenciler[3] = "Nur";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


Vatandas vatandas1 = new Vatandas();
vatandas1.FirstName = "Jale";

Vatandas vatandas2 = new Vatandas();
vatandas2.FirstName = "Emre";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new VatandasManager());
pttManager.GiveMask(vatandas1);

Console.ReadLine();

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}
static int  Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc.ToString());
    return sonuc;
}

//static void Degiskenler()
//{
//    string mesaj = "Selam";
//    double tutar = 100000;
//    int sayi = 100;
//    bool GirisYapmisMi = false;

//    string Ad = "Jale";
//    string Soyad = "Müşdeci";
//    string DogumYili = "2001";
//    long TcNo = 12345678910;


//    Console.WriteLine(tutar * 1.18);
//    Console.WriteLine(tutar * 1.18);
//}

//public class Vatandas

//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}