using System;

namespace bankamatik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Başlangıçta bakineyiz 0 olduğundan direkt para çekme işlemi yapılmaz.

            // menü: bakiye para yatırma para çekme çıkış

            int secim = 0;
            string user = "username";
            string pas = "password";
            int bakiye = 0;
            int[] switn = { 1, 2, 3, 4 };
            string[] deger = { "Bakiye", "Para Yatırma", "Para Çekme", "Çıkış" };
            string kTc;
            string mus;




            do
            {
                Console.Write("TC Kimlik  numarasını giriniz: ");
                kTc = Console.ReadLine();

                Console.Write("Şifrenizi giriniz: ");
                mus = Console.ReadLine();


                if (user == kTc && pas == mus)
                {
                    Console.WriteLine("Başarıyla giriş yapıldı..");


                    for (int i = 0; i < switn.Length; i++)
                    {
                        Console.WriteLine(switn[i] + "--" + deger[i]);
                    }


                    while (true)
                    {

                        Console.WriteLine("Lütfen Yapmak istediğiniz işlemin numarasını tıklayınız..");
                        secim = int.Parse(Console.ReadLine());

                        switch (secim)
                        {
                            case 1:
                                Console.WriteLine($"Mevcut bakiyeniz: {bakiye}");
                                break;
                            case 2:
                                Console.Write("Yatırılacak Değer: ");
                                int yatiralmn = int.Parse(Console.ReadLine());
                                bakiye += yatiralmn;
                                break;
                            case 3:
                                Console.WriteLine($"Güncel Bakiye: {bakiye}");
                                Console.WriteLine("Çekilecek Tutar: ");
                                int cekilcek = int.Parse(Console.ReadLine());

                                if (cekilcek > bakiye)
                                {
                                    Console.WriteLine("Bakiyeniz yetersiz");

                                }
                                else if (cekilcek < bakiye)
                                {
                                    Console.WriteLine($"{cekilcek} TL Çekiliyor..");
                                    bakiye -= cekilcek;
                                }
                                else
                                {
                                    Console.WriteLine("ç");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Teşekkürler...");
                                break;
                            default:
                                Console.WriteLine("Yanlış tuşlama yaptınız...");
                                break;
                        }
                    }



                }

            } while (!(user == kTc && pas == mus));
        }
    }
}

 

// Eklenmesi gereken şeyleri lütfen söyleyiniz.........
// Teşekkürler iyi çalışmalar




// M.Done
