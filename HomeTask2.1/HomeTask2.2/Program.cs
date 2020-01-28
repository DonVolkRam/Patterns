using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var clothes = new Clothes();
            var db = new List<IDiscountable>() { car, clothes };
            foreach (var item in db)
            {
                item.SetDiscount(10);
            }
        }
    }
    interface IItem
    {
        void SetPrice(double price);
    }
    class Clothes : IItem, IClothable, IDiscountable
    {
        public void SetColor(Color color) { }
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
        public void SetSize(Size size) { }
    }
    interface IDiscountable
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);
    }
    interface IClothable
    {
        void SetColor(Color color);
        void SetSize(Size size);
    }

    class Car: IItem, IDiscountable
    {
        public void SetDiscount(double discount) { }
        public void SetPrice(double price) { }
        public void SetPromocode(string promocode) { }
    }

    public class Size
    {
    }

    public class Color
    {
    }
}
