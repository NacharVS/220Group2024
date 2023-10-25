using System;
public class Program 
{
    static void Main(string[] args)
    {
        Table[] tables = { new Table(1, 4), new Table(2, 6), new Table(3, 9), new Table(4, 4) };
        while (true)
        {
            Console.WriteLine("Администрирование кафе. \n");
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i].ShowInfo(); 
            }

            Console.Write("\nВведите номер стола: ");
            int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("\nВведите количество мест для брони: ");
            int desiredPlaces = Convert.ToInt32(Console.ReadLine());

            bool isReservationComplited = tables[wishTable].Reserve(desiredPlaces);

            if (isReservationComplited)
            {
                Console.WriteLine("Бронь прошла успешно!");
            }
            else
            {
                Console.WriteLine("Бронь не прошла. Недостаточно мест в кафе.");
            }
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
class Table
{
    public int Number;
    public int MaxPlaces;
    public int FreePlaces;
    public Table(int number, int maxPlaces) 
    {
        this.Number = number;
        this.MaxPlaces = maxPlaces;
        this.FreePlaces = maxPlaces;

    }
    public void ShowInfo()
    {
        Console.WriteLine($"Стол: {Number}. Свободно мест: {FreePlaces} из {MaxPlaces}");
    }
    public bool Reserve(int places) 
    {
        if (FreePlaces >= places)
        {
            FreePlaces -= places;
            return true;
        }
        else
        {
            return false;
        }
    }
}

