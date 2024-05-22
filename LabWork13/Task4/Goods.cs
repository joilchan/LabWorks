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
            => ($" Название: {String.Format("{0}{1}", Name[..1].ToUpper(), Name[1..])}\n" +
                $" Цена: {String.Format("{0:C}", Price)} \n" +
                $" Срок годности: {String.Format("{0:yyyy dd mm}", ExpirationDate)}");
    }
}
