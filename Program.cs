namespace matematik_fonksi
{
    internal class Program
    { //14.06.2023 18:27:19
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("C# zaman fonksiyonları \n");
            Console.WriteLine("Kısa Tarih: {0:d}", zaman);
            Console.WriteLine("Uzun Tarih: {0:D}", zaman);
            Console.WriteLine("Tam Tarih: {0:f}", zaman);
            Console.WriteLine("Tam Tarih 2: {0:F}", zaman);
            Console.WriteLine("Sayısal Tarih 2: {0:g}", zaman);
            Console.WriteLine("Sayısal Tarih 2: {0:G}", zaman);
            Console.WriteLine("Saat: {0:t}", zaman);
            Console.WriteLine("Saat 2: {0:T}", zaman);
            Console.WriteLine("Ay: {0:m}", zaman);
            Console.WriteLine("Yıl: {0:y}", zaman);
            Console.ReadLine();
        }
    }
}