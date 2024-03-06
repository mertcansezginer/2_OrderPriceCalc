
string[] urunler = { "kalem", "silgi", "defter" }; //fiyat soracagimiz urunlerin isimlerini iceren array olusturduk
double[] fiyatlar = new double[3]; // urunlerin fiyatlarini saklamak icin array olusturduk
double ToplamFiyat = 0;            // toplam fiyatin tutulacagi bir variable belirledik

for (int i = 0; i < urunler.Length; i++)
{
    
    Console.WriteLine("Kac adet " + urunler[i] + " alinacak?"); //adet bilgisi alma
    int adet = int.Parse(Console.ReadLine());

    Console.WriteLine("Fiyati ne kadar?");                       //her urun icin fiyat bilgisi alma
    double fiyat = double.Parse(Console.ReadLine());

    fiyatlar[i] = adet * fiyat;          //toplam fiyat hesaplama 
    ToplamFiyat += fiyatlar[i];

}

Console.WriteLine ("Toplam alisveris tutari : " +  ToplamFiyat + " TL");



