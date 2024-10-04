 Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

        // Önce yazdıracağımız fiyatları tanımladık
        int ElmaFiyat = 2;
        int ArmutFiyat = 3;
        int ÇilekFiyat = 2;
        int MuzFiyat = 3;
        int DigerFiyat = 4;

        // Tanımladığımız meyve fiyatlarını istenilen formatta yazdırdık
        Console.WriteLine("Elma = " + ElmaFiyat + " TL");
        Console.WriteLine("Armut = " + ArmutFiyat + " TL");
        Console.WriteLine("Çilek = " + ÇilekFiyat + " TL");
        Console.WriteLine("Muz = " + MuzFiyat + " TL");
        Console.WriteLine("Diğer bütün meyveler = " + DigerFiyat + " TL");
        //bir satır aşağıda yazması için console.writeline() kullanıyoruz
        Console.WriteLine();

        // Kullanıcıdan meyve seçimini alırız. 
        Console.Write("Hangi meyveyi seçmek istersiniz? (Elma, Armut, Çilek, Muz, Diğer): ");
        string meyve = Console.ReadLine().ToLower(); // Küçük harfe çevir.
                                                     // Metinleri tek bir harf biçimine dönüştürmek için ToLower ya da ToUpper kullanıyoruz
                                                     // Nedeni;girilen verinin "ElmA" gibi bir yazılımda hata çıkmaması için yapıyoruz.

// Seçime göre fiyatları çıktı olarak almak için switch case metodu kullanıyoruz.
// Seçilen meyve elma ise elma fiyatını yaz ve bu döngüyü durdur.
// Case metodu diğer meyveler içinde yapılır ve döngü kullanıcının girdiği meyveyi bulana kadar devam eder.
switch (meyve)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: " + ElmaFiyat + " TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: " + ArmutFiyat + " TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: " + ÇilekFiyat + " TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: " + MuzFiyat + " TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: " + DigerFiyat + " TL");
        break;
}


        // if else metodu ile çözüm
        if (meyve == "elma")
        {
            Console.WriteLine("ıfsonucu: Seçtiğiniz meyvenin fiyatı: " + ElmaFiyat + " TL");
        }
        else if (meyve == "armut")
        {
            Console.WriteLine("ıfsonucu: Seçtiğiniz meyvenin fiyatı: " + ArmutFiyat + " TL");
        }
        else if (meyve == "çilek")
        {
            Console.WriteLine("ıfsonucu: Seçtiğiniz meyvenin fiyatı: " + ÇilekFiyat + " TL");
        }
        else if (meyve == "muz")
        {
            Console.WriteLine("ıfsonucu: Seçtiğiniz meyvenin fiyatı: " + MuzFiyat + " TL");
        }
        else
        {
            Console.WriteLine("ıfsonucu: Seçtiğiniz meyvenin fiyatı: " + DigerFiyat + " TL");
        }

        // AÇIKLAMA
//"ıf else" yapısına göre switch case daha okunabilir
//daha az kod satırı ile daha temiz bir çözüm oldu
//ama bence bir farkı yok ikisi de kullanılır ve iş görür

switch ifadesi, bir değişkenin değerine bağlı olarak farklı kod bloklarının çalıştırılmasını 
sağlayan bir kontrol yapısıdır. Özellikle çok sayıda koşulun kontrol edilmesi gereken durumlarda, 
if-else yapılarına göre daha okunabilir ve düzenli bir yapı sunar.

Önemli Noktalar
Değişken Türü: switch ifadesi genellikle int, char, ve bazı dillerde enum türündeki değişkenlerle kullanılır.

case Anahtar Kelimesi: Her bir case, kontrol edilen değeri belirtir. Eğer değişken bu değere eşitse, ilgili
kod bloğu çalıştırılır.

break: Her case bloğunun sonunda break ifadesi kullanmak yaygındır. break, switch ifadesinden çıkmayı sağlar. 
Eğer break kullanılmazsa, sonraki case blokları da çalıştırılabilir (bu duruma "fall-through" denir).

default: Eğer hiçbir case ile eşleşmezse, default bloğu çalıştırılır. Bu opsiyonel bir bloktur.

toUpper ve toLower, bir string (metin) içindeki karakterleri büyük harfli veya küçük harfli hale getirmek için kullanılan fonksiyonlardır. Bu fonksiyonlar, genellikle metin işlemlerinde, kullanıcı girdilerini standartlaştırmak veya karşılaştırmalar yapmak için kullanılır. İşte her iki kullanımın detayları:

1. toUpper
toUpper, bir string içindeki tüm karakterleri büyük harfe dönüştüren bir fonksiyondur. Çoğu programlama dilinde
bu işlevi sağlayan bir metod veya fonksiyon bulunur.


2. toLower
toLower, bir string içindeki tüm karakterleri küçük harfe dönüştüren bir fonksiyondur.
Yine, bu işlevi sağlayan metodlar çoğu dilde mevcuttur.
