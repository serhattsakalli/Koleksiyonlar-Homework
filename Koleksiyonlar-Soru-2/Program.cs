using System.Collections;

namespace Koleksiyonlar_Soru_2;

class Program
{
    static void Main(string[] args)
    {
        ArrayList girdiler=new ArrayList();
        ArrayList kucuk= new ArrayList();
        ArrayList buyuk= new ArrayList();
        Console.WriteLine("Lütfen 20 adet pozitif tam sayı verisi girişi yapalım.");
        string veri="";
        double kort=0;
        double bort=0;
        //giriş anahtarı(farklı bir tip değişken girilmesini önlemek için)
        for (int i = 0; i < 20; i++)
        {
            veri=Console.ReadLine();
            if (int.TryParse(veri, out int numara))
            {
                girdiler.Add(int.Parse(veri)); 
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı gir.");
                i--;
            }
        }
        girdiler.Sort();//sıralama

        //büyük ve küçükleri ayrıştırma
        for (int i = 0; i < 3; i++)
        {
            kucuk.Add(girdiler[i]);
            kort+=Convert.ToInt32(girdiler[i]);
            
        } 
        kort=kort/kucuk.Count;
        for (int i = girdiler.Count - 3; i < girdiler.Count; i++)
        {
              buyuk.Add(girdiler[i]);
              bort+=Convert.ToInt32(girdiler[i]);
        }
        bort=bort/buyuk.Count;
        //yazdırma
        Console.WriteLine("en küçük 3 sayı:");
        foreach (var item in kucuk)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("en büyük 3 sayı:");
        foreach (var item in buyuk)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("en küçük 3 sayının ortalaması:"+kort);
        Console.WriteLine("en büyük 3 sayının ortalaması:"+bort);
        Console.WriteLine("bu ortalamaların toplamları"+(kort+bort));
        Console.ReadLine();
    }
}
