using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task4
{
    internal class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
            => $"Название: {Name[..1].ToUpper()}{Name[1..]}\n" +
               $"Цена: {Price:C} \n" +
               $"Срок годности: {ExpirationDate:yyyy dd mm}";
    }
}
