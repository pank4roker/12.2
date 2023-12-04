using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    /// <summary>
    /// Класс описывющий компьютер
    /// </summary>
    class Computer
    {
        /// <summary>
        /// Поле модели
        /// </summary>
        public string model;
        /// <summary>
        /// Поле OЗУ
        /// </summary>
        public int OZU;
        /// <summary>
        /// Поле ПЗУ
        /// </summary>
        public int PZU;
        public Computer() { }
        /// <summary>
        /// Конструктор с парамтром
        /// </summary>
        /// <param name="model"></param>
        /// <param name="OZU"></param>
        /// <param name="PZU"></param>
        public Computer(string model, int OZU,int PZU)
        {
            this.model = model;
            this.OZU = OZU; 
            this.PZU = PZU;
        }
        public void Info()
        {
            Console.WriteLine($"Model:{model}\nOZU:{OZU}\nPZU:{PZU}");
        }

    }
}
