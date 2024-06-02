namespace ConsoleApp1
{
    public class Write
    {
        public static void Writer(string name, byte age, bool have_a_pet, double foot_size)
        {
            string pet = "";
            if (have_a_pet == false)
            {
                pet = "не ";
            }

            string ageWord = ConsoleApp1.AgeWord.GetAgeWord(age);

            Console.WriteLine("Меня зовут, {0}", name);
            Console.WriteLine("Мне, {0} {1}", age, ageWord);
            Console.WriteLine("Я {0}имею питомца", pet);
            Console.WriteLine("У меня, {0} размер ноги", foot_size);
        }
    }
}
