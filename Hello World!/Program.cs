#region 1.Gün/ 1.Ders
//Console.WriteLine(":D");
//Console.Writline yazı sunumlandırmada kullanılıyor. Artı olarak noktalı virgüle dikkat.CTRL+k+c
#endregion

#region 1.Gün/2.Ders

using System;
using System.ComponentModel.Design;

//string adSoyad="Asilkan Mehmet Çelik";
//Console.WriteLine(adSoyad);
//adSoyad yazılması bir alışkanlık mı yoksa zorunluluk mu çözemedim. Çünkü AdSoyad da çalışıyor. String gibi çalışıyor sayı vermek sadece sayının numerik bilgisini yok ediyor.
//değişken olması için küçük harf fonksiyon olması için büyük harf.

//int sayi1 = 2;
//int sayi2 = 3;
//int sayi3 = sayi1 + sayi2;  //toplama işlemleri pythondaki gibi.
//Console.WriteLine("Sonuç="+ sayi3);

//bool kontrol = false;

//if (kontrol==true)
//{
//    Console.WriteLine("True seçildi");
//}

//else
//{ 
//    Console.WriteLine("False seçildi");
//}
////kendi denemem


//if (sayi3==5)

//{
//    Console.WriteLine("sonuç 5.");
//}

//else
//{
//    Console.WriteLine("sonuç 5 değil.");
//}
#endregion

#region 1.Gün/3.Ders
//double doubleSayi1 = 14.5;
//double doubleSayi2 = 44.9;
//Console.WriteLine("2 double sayısının toplamı" + (doubleSayi1 + doubleSayi2)); //python gibi yazı satırı içerisinde toplama yapılabiliyor.

//decimal ferhatmaasbilgisi = 50000.7m;
//decimal aylinmaasBilgisi = 50000.2m;
//decimal bedirhanmaasBilgisi = 50000.5m;
//decimal sametmaasBilgisi = 50000.3m;
//decimal mertmaasBilgisi = 50000.8m;
//decimal asilkanmaasbilgisi = 50000.4m;
//Console.ForegroundColor = ConsoleColor.Magenta;
//Console.WriteLine(ferhatmaasbilgisi+"TRY");
//Console.WriteLine(aylinmaasBilgisi + "TRY");
//Console.WriteLine(bedirhanmaasBilgisi + "TRY");
//Console.WriteLine(sametmaasBilgisi + "TRY");
//Console.WriteLine(mertmaasBilgisi + "TRY");
//Console.WriteLine(asilkanmaasbilgisi + "TRY");

//var varYas = 24;
//var varAdSoyad = "Asilkan";
//var varMaasBilgisi = 50000m;
//var varMesaiSaati = 09.00;
//var varCinsiyetKontrol = true;
//var varCinsiyet = "";

//if (varCinsiyetKontrol == true)
//{
//    varCinsiyet = "Erkek";
//}

//else
//{
//    varCinsiyet = "Kadın";
//}
//Console.WriteLine(varAdSoyad + "her sabah işe " + varMesaiSaati + "'da başlar. Cinsiyeti: " + varCinsiyet + ". Yaşı: " + varYas + ". Maaşı: " + varMaasBilgisi+ "TRY");


#endregion

#region 1.Gün/Gün Sonu,Ödevlendirme;
//Tekrarlar
//Dört İşlemler (int değişkenler ile 4 işlem)
//Double değişkenler ile dört işlem
//string ile kendinizi anlattığınız bir kompozisyon yazıyorsunuz. Buradali parametreler yaş maaş vb. en uzun yazan +5 puan(I dont know what that means.. Gıthub bağlamaya +3 puan githuba projesini bağlayana +3 puan daha)
#endregion

#region HW
int degiskenSayisi = 0; degiskenSayisi++;
string deneme = "deneme"; degiskenSayisi++;
int int1 = 1; degiskenSayisi++;
int int2 = 2; degiskenSayisi++;
int inttop12 = (int1 + int2); degiskenSayisi++;
int int3 = 3; degiskenSayisi++;
int int4 = 4; degiskenSayisi++;
int int5 = 5; degiskenSayisi++;
int int6 = 6; degiskenSayisi++;
int int7 = 7; degiskenSayisi++;
int int8 = 8; degiskenSayisi++;
int int9 = 9; degiskenSayisi++;
int int10 = 10; degiskenSayisi++;
double doubleSayi1 = 1.11; degiskenSayisi++;
double doubleSayi2 = 2.22; degiskenSayisi++;
double doubleSayi3 = 3.33; degiskenSayisi++;
double doubleSayi4 = 4.44; degiskenSayisi++;
double doubleSayi5 = 5.55; degiskenSayisi++;
double doubleSayi6 = 6.66; degiskenSayisi++;
double doubleSayi7 = 7.77; degiskenSayisi++;
double doubleSayi8 = 8.88; degiskenSayisi++;
double doubleSayi9 = 9.99; degiskenSayisi++;
double doubleSayi10 = 10.10; degiskenSayisi++;
double doubleSayi11 = 11.11; degiskenSayisi++;
double doubleSayi12 = 12.12; degiskenSayisi++;

string adSoyad = "Asilkan Çelik"; degiskenSayisi++;
string Okul = "ODTU"; degiskenSayisi++;
string bolum = "Fizik"; degiskenSayisi++;
int sinif = 3;
string calısma = ""; degiskenSayisi++;
string maas = "0"; degiskenSayisi++;
bool calismadurumu = false; degiskenSayisi++;
if (calismadurumu == false)
    calısma = "calısmıyorum";   
else
    calısma = "calısıyorum";
    
int dogumGunu = 27; degiskenSayisi++;
int dogumAyi = 12; degiskenSayisi++;
int dogumYili = 2000; degiskenSayisi++;
string ilgiAlani1 = "felsefe"; degiskenSayisi++;
string ilgiAlani2 = "müzik"; degiskenSayisi++;
string ilgiAlani3 = "finans"; degiskenSayisi++;
Console.WriteLine("Ödev 1");
Console.WriteLine("Stringler string yazılarak kulanılır. Diğer type türleri de küçük harflerle başlar " +
"tanımlanan yapılarsa küçük başlar ama devamındaki her sözcük tercihen büyük harfle kullanılmalıdır. Örnek olarak " +deneme +" string'inin nasıl kullanıldığına bakılabilir. " +
"Derste öğrendiğimiz bir diğer yapı ise toplamadır. Kodda görebileceğiniz üzere kullanım şekli " + int1+"+" +int2 +"=" + (inttop12) + " şeklindedir." +
" 1 eksik integer değeri kullanarak yapabileceğimiz metodsa şu şekildedir: " + int3 +"+" +int4 +"="+ (int3+int4) +" .Sıra diğer işlem türlerine geldi. Çıkarma " + int9+"-"+int10+"="+(int9-int10)+
"şeklinde, çarpma " +int5+"x"+int6+"=" +(int5*int6)+
" şeklinde, son olarak bölme " +int7 +"/" +int8+"="+ (int7/int8)+" şeklinde yapılır. " +
"Görebileceğiniz üzere bölme işlemi sadece bir integera sıkıştırılmak zorunda olduğu için bir basamaklık değeri verilmiştir ve doğruluktan oldukça uzaktır. Daha detaylı işlem kapasitesi için double değişkenler tercih edilebilir." +
" Örneğin toplamada "+doubleSayi1+"+"+doubleSayi2+"=" +(doubleSayi1+doubleSayi2)+ " ve çıkarmada " + doubleSayi3 + "-" + doubleSayi4 + "=" + (doubleSayi3 - doubleSayi4) + " metod aynen kullanılır. Ama görebileceğiniz üzere decimal yerine double kullanmamızdan ötürü bazı sayılar tahmini ve yanlış sonuçlar doğurabilir. " +
"Daha net sonuçlar için decimallar tercih edilmeli. Çarpım "+ doubleSayi5 +"x" +doubleSayi6 +"="+ (doubleSayi5*doubleSayi6) +" şeklinde yapılır. " +
"Bölme ise " +doubleSayi7+"/"+doubleSayi8 +(doubleSayi7/doubleSayi8) +" şeklinde yapılır." +" Daha karmaşık işlemler ise işlem önceliği sırasına göre tasarlanı. " +
"Örnek olarak (("+ doubleSayi9+"+" +doubleSayi10+")"+"x"+doubleSayi11+")/"+ doubleSayi12+ "=" +(((doubleSayi9+doubleSayi10)*doubleSayi11)/doubleSayi12)+" denklemi verilebilir. Double olması yine işlemlerde düşük ölçekte hataya sebep vermektedir. Ödev kısmı bittiğine göre şimdi kendimden bahsedebilirim." +
" Ben " + adSoyad + "." + Okul+ "'de "+ sinif +". sınıf " + bolum + "öğrencisiyim. " +dogumGunu+"." + dogumAyi + "." + dogumYili + "'de doğdum. Şu sıralar hobilerim " + ilgiAlani1+", " + ilgiAlani2 + "," + ilgiAlani3 + " olarak sıralanabilir. Öğrenci olduğum için şu sıralar " + calısma +". O nedenle şu an maaşım " +
maas +" tl." + " Aktif bir şekilde kariyerimi yazılıma yönlendirmek için oldukça heyecanlı ve kararlıyım. Son olarak değisken sayısı: " + degiskenSayisi);





#endregion