using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    /// <summary>
    /// Класс описывающий проект стрения
    /// </summary>
    class Build
    {
        /// <summary>
        /// Поле имени
        /// </summary>
        public string name;
        /// <summary>
        /// Поле площади
        /// </summary>
        public int area;
        /// <summary>
        /// Поле кол-ва жильцов
        /// </summary>
        public int kvo;
        /// <summary>
        /// Поле этажей
        /// </summary>
        public int floor;
        /// <summary>
        /// Констрцктор без параметров
        /// </summary>
        public Build() { }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>
        public Build(string name, int area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        public Build(string name, int area, int kvo, int floor):this(name,area,kvo) 
        {
            this.floor = floor;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{name}\nArea:{area}\nKvo:{kvo}\n Площадь на одного жильца:{area/kvo}");
        }
        public void ShowWarning()
        { 
            Console.WriteLine($"Name:{name}\nArea:{area}\nKvo:{kvo}\n Площадь на одного жильца:{area / kvo}\n floor:{floor}"); 
        }
       
    }
}
