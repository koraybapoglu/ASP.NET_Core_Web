namespace MiddlewareCalismasiOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Middleware1();
            Console.ReadLine();
        }
        public static void Middleware1() 
        {
            Console.WriteLine("Request Geldi");
            Console.WriteLine("Middleware 1 Çalıştı !");
            Dongu("Middleware1");
            Middleware2();
            Console.WriteLine("Middleware 1 İşlemi Tamamladı !");
            Console.WriteLine("Response Döndürüldü !");
        }
        public static void Middleware2() 
        {
            Console.WriteLine("Middleware2 Çalıştırıldı !");
            Dongu("Middleware2");
            Middleware3();
            Console.WriteLine("Middleware 2 Tamamlandı !");
        }
        public static void Middleware3() 
        {
            Console.WriteLine("Middleware3 Çalıştırıldı !");
            Dongu("Middleware3");
            Console.WriteLine("Middleware 3 Tamamlandı !");
        }
        public static void Dongu(string MiddlewareAdi) 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(MiddlewareAdi+" "+i);
            }
        }
    }
}
