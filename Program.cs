namespace Задача_05
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Введите дату в формате ГГГГ-ММ-ДД: ");
            string userDate = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParse(userDate, out date))
            {
                Console.WriteLine($"Название сезона: {GetSeason(date)}");
                Console.WriteLine($"День недели: {GetDayOfWeek(date)}");
            }
            else
            {
                Console.WriteLine("Некорректная дата!");
            }

            Console.ReadKey();
        }

        private static string GetSeason(DateTime date)
        {
            if (date.Month < 3)
                return "Зима";
            else if (date.Month < 6)
                return "Весна";
            else if (date.Month < 9)
                return "Лето";
            else
                return "Осень";
        }

        private static string GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}