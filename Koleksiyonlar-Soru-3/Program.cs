namespace Koleksiyonlar_Soru_3;

class Program
{
    static void Main(string[] args)
    {
        //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde 
        //saklayan ve dizinin elemanlarını sıralayan programı yazınız.
        List<char> Sesliler =new List<char>();
        string cumle="";
        string seslihrflr="aeıioöuü";
        Console.WriteLine("Cümle giriniz");
        cumle=Console.ReadLine();
        foreach (char item in cumle)
        {
            if (seslihrflr.Contains(char.ToLower(item)))
            {
                Sesliler.Add(item);
            }
        }
        Sesliler.Sort();
        Console.WriteLine("Cümledeki sesli harfler: ");
            foreach (var harf in Sesliler)
            {
                Console.Write(harf + " ");
            }



        Console.ReadLine();
    }
}
