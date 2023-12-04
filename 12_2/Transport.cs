using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _12_2
{
    /// <summary>
    /// Класс описывающий транспорт
    /// </summary>
    class Transport
    {
        /// <summary>
        /// Поле типа транспотра 
        /// </summary>
        public string type;
        /// <summary>
        /// Поле цвета
        /// </summary>
        public string color;
        /// <summary>
        /// Поле скорости
        /// </summary>
        public int speed;
        /// <summary>
        /// Поле массы
        /// </summary>
        public int mass;
        /// <summary>
        /// Конструктор без параметра
        /// </summary>
        public Transport() { }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="mass"></param>
        public Transport(string type, string color, int speed, int mass)
        {
            this.type = type;
            this.color = color;
            this.speed = speed;
            this.mass = mass;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Тип:{type}\nЦвет:{color}\nСкорость:{speed} км/ч\nМасса:{mass} т");
        }
    }
}
