using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kamalov220
{
    class Program
    {
        class Programm
        {
            static void Main(string[] args)
            {
                Goods[] goods = new Goods[10]
                {
                new Goods("Iphone 12 Pro Max", 680, 13, "Apple", 34, 231.2),
                new Goods("Redmi 8T", 124, 3, "Xiaomi", 12, 14.88),
                new Goods("Xiaomi 9T", 784, 15, "Xiaomi", 23, 180.32),
                new Goods("Xiaomi 3T", 957, 65, "Xiaomi", 43, 622.05),
                new Goods("Xiaomi 5T", 854, 7, "Xiaomi", 2, 836.92),
                new Goods("Xiaomi 321T", 856, 45, "Xiaomi", 34, 564.96),
                new Goods("Xiaomi Note 8 Pro", 754, 12, "Xiaomi", 12, 231.2),
                new Goods("Xiaomi Note 8", 976, 15, "Xiaomi", 53, 458.72),
                new Goods("Xiaomi 7", 457, 12, "Xiaomi", 32, 310.76),
                new Goods("Xiaomi 5 Pro", 254, 2, "Xiaomi", 34, 167.64),
                };

                Goods[] busket = { };
                double balance = 1000;

                Console.WriteLine("Пользователь:");
                Console.WriteLine($"У вас на счету: {balance} долларов");
                ViewMainMenu(goods, busket, balance);

            }
            static void FullInfo(Goods[] goods, Goods[] busket)
            {
                Console.Write("\nВыберите товар по выбранному списке" +
                    ": ");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("\n-----Полная информаци о товаре-----\n");
                goods[v - 1].fullOut();
                Console.WriteLine("1. Добавить в корзину");
                Console.WriteLine("2. К каталогу");
                Console.WriteLine("\n--------------------------------");
                Console.Write("Ваш выбор: ");
                int vi = Convert.ToInt32(Console.ReadLine());
                if (vi == 1) { ViewCollectBusket(goods, busket); }
                else if (vi == 2) { ViewCollectGoods(goods, busket); }

            }

            private static void ViewCollectBusket(Goods[] goods, Goods[] busket)
            {
                for (int i = 0; i < busket.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {busket[i].Info()}");
                    Console.WriteLine("----------------------------------------");
                }
                Console.WriteLine($"{busket.Length + 1}. Вернуться назад.");
                Console.WriteLine($"Выберите вышеперечисленный товар...");
            }

            private static void ViewCollectGoods(Goods[] goods, Goods[] busket)
            {
                for (int i = 0; i < goods.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {goods[i].Info()}");
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                }
                Console.WriteLine($"{goods.Length + 1}. Вернуться назад.");
                Console.WriteLine($"Выберите вышеперечисленный товар...");
            }

            private static double GetBalance(Goods[] busket, double balance)
            {
                for (int i = 0; i < busket.Length; i++)
                {
                    balance -= busket[i]._price;
                }
                return balance;
            }

            private static void SelectedItem(int variant, Goods[] goods, Goods[] busket, double balance)
            {
                if (variant == 1)
                {
                    ViewCollectGoods(goods, busket);

                    int selectedItem = Convert.ToInt32(Console.ReadLine());
                    if (busket.Length < 3)
                    {
                        if (selectedItem == 1)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);

                        }
                        else if (selectedItem == 2)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 3)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 4)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 5)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 6)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 7)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 8)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 9)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 10)
                        {
                            Array.Resize(ref busket, busket.Length + 1);
                            busket[busket.Length - 1] = goods[selectedItem - 1];
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                        else if (selectedItem == 11)
                        {
                            //Вернуться назад в главное
                            Console.Clear();
                            ViewMainMenu(goods, busket, balance);
                            FullInfo(goods, busket);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы выбрали больше трёх товаров.");
                        Console.ReadKey();
                    }

                    if (selectedItem == 11)
                    {
                        //Вернуться назад в главное
                        Console.Clear();
                        ViewMainMenu(goods, busket, balance);
                    }
                }
                else if (variant == 2)
                {
                    ViewCollectBusket(goods, busket);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (variant == 3)
                {
                    Console.Clear();
                    Console.WriteLine(GetBalance(busket, balance).ToString() + " долларов");
                    ViewMainMenu(goods, busket, balance);
                }
                else if (variant == 4)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Выбран не существующий номер списка.");
                    Console.Clear();
                    ViewMainMenu(goods, busket, balance);
                }
            }

            private static void ViewMainMenu(Goods[] goods, Goods[] busket, double balance)
            {
                Console.WriteLine("Главное меню:\n 1. Просмотреть список товаров\n 2. Просмотреть корзину\n 3. Просмотреть остаток на счете\n 4. Просмотреть подробную информацию о товаре\n 5. Выход");
                int variant = Convert.ToInt32(Console.ReadLine());
                SelectedItem(variant, goods, busket, balance);
            }
        }
        public class Goods
        {
            public string _name; // наименование
            public double _price; // цена
            public int _amount; // количество
            public string _producer; // производитель
            public double _discount; // размер скидки
            public double _pricen; // цена со скидкой
            public Goods(string name, int price, int amount, string getter, int discount, double pricen)
            {
                _name = name;
                _price = price;
                _amount = amount;
                _producer = getter;
                _discount = discount;
                _pricen = pricen;
            }
            public string Info()
            {
                string header = "{0,-20}{1,10}{2,15}{3,20}{4,10}{5,20}";

                string headerText = string.Format(header, "Наименование", "Цена", "Количество", "Производитель", "Скидка", "Цена со скидкой");

                string itemText = string.Format(header, _name, _price, _amount, _producer, $"{_discount}%", _pricen);

                return $"{headerText}\n{itemText}";
            }
            public void ChangeName(string newName)
            {
                _name = newName;

            }
            public void fullOut() { Console.WriteLine($"Наименование: {_name}\nПроизводитель: {_producer}\nКоличество на складе: {_amount} шт.\nВозможная скидка: {_discount}%\nЦена(со скидкой): {_pricen * (1 - (Convert.ToDouble(_discount) / 100))} руб.\n"); }
        }
    }   }