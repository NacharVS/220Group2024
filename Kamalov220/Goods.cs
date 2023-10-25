using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kamalov220
{
    public class Goods
    {
        public string _name; // наименование
        public double _price; // цена
        public int _amount; // количество
        public string _producer; // производитель
        public double _discount; // размер скидки
        public Goods(string name, int price, int amount, string getter, int discount)
        {
            _name = name;
            _price = price;
            _amount = amount;
            _producer = getter;
            _discount = discount;
        }
        public string Info()
        {
            string header = "{0,-22}{1,9}{2,15}{3,20}{4,10}";

            string headerText = string.Format(header, "Наименование", "Цена", "Количество", "Производитель", "Скидка");

            string itemText = string.Format(header, _name, _price, _amount, _producer, $"{_discount}%");

            return $"{headerText}\n{itemText}";
        }
        public void ChangeName(string newName)
        {
            _name = newName;
        }
    }
}
