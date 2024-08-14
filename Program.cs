class Program
{   
    static List<Book> books = new List<Book>();

    static void Main(string[] args)
    {
        string son = "";

        while(son != "exit")
        {
            Console.WriteLine("buyruq kiriting(add, view, bron, qaytarish, exit): ");
            son = Console.ReadLine();

            switch(son)
            {
                case "add":
                    AddBook();
                    break;
                case "view":
                    BookView();
                    break;
                case "bron":
                    BookBron();
                    break;
                case "qaytarish":
                    BookQaytarish();
                    break;
                case "exit":
                    Console.WriteLine("dasturdan chiqilmoqda...");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri buyruq...");
                    break;
            }

            static void AddBook()
            {
                Console.WriteLine("Familiyangizni kiriting: ");
                string sureName = Console.ReadLine();
                Console.WriteLine("Ismingizni kiriting: ");
                string name = Console.ReadLine();
                Console.WriteLine("Kitob nomi: ");
                string bName = Console.ReadLine();

                if(sureName.Trim().Length > 0 && name.Trim().Length > 0 && bName.Trim().Length > 0)
                {
                    books.Add(new Book(sureName, name, bName));
                    Console.WriteLine("Kitob qo'shildi.");
                }
                else
                {
                    System.Console.WriteLine("Kitob qo'shishda muammo yuzaga keldi.");
                }
            }

            static void BookView()
            {
                Console.WriteLine("Kitoblar ro'yxati: ");
                for(int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{i+1}.Kitob qo'shgan odamning Familiyasi: {books[i].SureName}, Ismi: {books[i].Name}, Kitob Nomi: {books[i].BName}");
                }
            }

            static void BookBron()
            {
                BookView();
                Console.WriteLine("Bron qlish uchun kitob raqamini kiriting: ");
                int bookNumber = Convert.ToInt32(Console.ReadLine());
                if(bookNumber > 0 && bookNumber <= books.Count)
                {
                    books.RemoveAt(bookNumber-1);
                    Console.WriteLine("Kitob bron qlindi.");
                }
                else
                {
                    Console.WriteLine("Noto'g'ri raqam.");
                }
            }

            static void BookQaytarish()
            {
                Console.WriteLine("Familiyangizni kiriting: ");
                string sureName = Console.ReadLine();
                Console.WriteLine("Ismingizni kiriting: ");
                string name = Console.ReadLine();
                Console.WriteLine("Kitob nomi: ");
                string bName = Console.ReadLine();

                if(sureName.Trim().Length > 0 && name.Trim().Length > 0 && bName.Trim().Length > 0)
                {
                    books.Add(new Book(sureName, name, bName));
                    Console.WriteLine("Kitob qaytarildi.");
                }
                else
                {
                    System.Console.WriteLine("Kitob qaytarishda muammo yuzaga keldi.");
                }
            }

        }
    }

    class Book
    {
        public string SureName {get; set;}
        public string Name {get; set;}
        public string BName {get; set;}

        public Book(string sureName, string name, string bName)
        {
            Name = name;
            BName = bName;
            SureName = sureName;
        }
    }
}