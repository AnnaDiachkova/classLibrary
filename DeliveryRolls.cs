using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryRolls
{
    public class RollsRequestDto
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
    }
    public enum Currency
    {
        Rubles
    }
    public class WayPoint
    {
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }
    }
    public class RollSelectionDto
    {
        /// <summary>
        /// Виды роллов
        /// </summary>
       public List<TypesOfRolls> TypesOfRolls { get; set; }
        /// <summary>
        /// Дополнительно
        /// </summary>
       public List<Additionally> Additionally { get; set; }
    }

    public enum Additionally
    {
        sticks,
        soySauce,
        ginger,
        wasabi,
    }

    public enum TypesOfRolls
    {
        cucumber,
        salmon,
        sesame,
        creamСheese,
    }

    public class Program
        {
            static void Main()
            { }
        }
}


