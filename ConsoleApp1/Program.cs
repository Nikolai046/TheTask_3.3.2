internal class Program
{
        private static void Main(string[] args)
    {
        bool have_a_pet = true;
        Console.WriteLine("Как Вас зовут?");
        
        string name = Console.ReadLine();
        Console.WriteLine("Сколько Вам лет?");
        byte age = Convert.ToByte (Console.ReadLine());
        Console.WriteLine("Если ли у вас питомец? Y/N?");
        string have_a_pet_ = Console.ReadLine();
        Console.WriteLine("Какой у вас размер ноги?");
        double foot_size = Convert.ToDouble (Console.ReadLine());
        if (have_a_pet_ == "N")
        {
            have_a_pet = false;
        }
        ConsoleApp1.Write.Writer(name, age, have_a_pet, foot_size);
    }
}