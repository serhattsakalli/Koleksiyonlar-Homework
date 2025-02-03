using System.Collections;
using System.Linq.Expressions;

namespace Koleksiyonlar_Soru_1;

class Program
{
    static void Main(string[] args)
    {
        int[] Girdiler=new int[20];
        ArrayList AsalVeriler= new ArrayList();
        ArrayList tamVeriler= new ArrayList();
        Console.WriteLine("Lütfen 20 adet pozitif tam sayı verisi girişi yapalım.");
        string veri="";
        for (int i = 0; i < 20; i++)
        {
            veri=Console.ReadLine();
            if (int.TryParse(veri, out int number) && int.Parse(veri) > 0)
            {
                Girdiler[i]=int.Parse(veri); 
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı gir.");
                i--;
            }
        }

        foreach (var item in Girdiler)
            {
                if (Asalkontrol(item)) 
                {
                    AsalVeriler.Add(item); 
                }
                else
                {
                    tamVeriler.Add(item); 
                }
            }
        AsalVeriler.Sort();
        tamVeriler.Sort();
        AsalVeriler.Reverse();
        tamVeriler.Reverse();

        Console.WriteLine("asallar");
        foreach (var item in AsalVeriler)
        {
            Console.WriteLine(item);
            
        }
        Console.WriteLine("asal olmayanlar");
        foreach (var item in tamVeriler)
        {
            Console.WriteLine(item);
        }
        double asaltop=0;
        double tamtop=0;
        foreach (var item in tamVeriler)
        {
            tamtop+=(int)item;
        }
        foreach (var item in AsalVeriler)
        {
            asaltop+=(int)item;
        }
        
            

        double aort=asaltop/AsalVeriler.Count;
        double tort=tamtop/tamVeriler.Count;
        Console.WriteLine("Asal Saıların aded :"+AsalVeriler.Count+" tanedir ve ortalaması: "+aort);
        Console.WriteLine("Asal Olmayan Saıların aded :"+tamVeriler.Count+" tanedir ve ortalaması: "+tort);
        Console.ReadLine();
    }

    static bool Asalkontrol(int numara)
    {
            if (numara <= 1) 
                return false;

            for (int i = 2; i <= Math.Sqrt(numara); i++)  
            {
                if (numara % i == 0)  
                        return false;
            }

            return true;
    }
}




