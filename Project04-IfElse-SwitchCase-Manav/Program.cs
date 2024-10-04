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
