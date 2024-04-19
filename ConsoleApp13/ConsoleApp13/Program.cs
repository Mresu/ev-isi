namespace ConsoleApp13
{
    internal class Program
    {
        private static string input;

        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>();
            while (true) 
            {
                Console.WriteLine("Menyu");
                Console.WriteLine("1.Sisteme giris");
                Console.WriteLine("0.Cixis");
                    string input= Console.ReadLine();

            }
            switch (input)
            {
                case "1":
                    Console.WriteLine("1.hotw\el yarat");
                    Console.WriteLine("2.butun otelleri gor");
                    Console.WriteLine("3.Hotel sec");
                    Console.WriteLine("0.exit");
                    switch(input)
                    {
                        case "1":
                            Console.WriteLine("hotel adi girin");
                            string hotelName= Console.ReadLine();
                            break;
                            case "2":
                            Console.WriteLine("butun oteller");
                            break;
                            case "3":
                            Console.WriteLine("hotel adi");
                            string hotelName = Console.ReadLine();




                    }

            }
        }
    }
}
