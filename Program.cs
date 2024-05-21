using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);
            list.AddRange(new string[] { "Студент", "Фамилия" });

            Console.WriteLine("Введите количество элементов для новой коллекции:");
            int n = Convert.ToInt32(Console.ReadLine());

            ArrayList newList = new ArrayList();
            newList.Add("Новый");
            newList.Add("Список");
            newList.Add("Элементов");

            Console.WriteLine("Введите индекс, с которого начать вставку новой коллекции:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            list.InsertRange(n1, newList);

            int startIndex = n1 / 2;
            Console.WriteLine("Введите количество элементов для удаления из списка:");
            int k = Convert.ToInt32(Console.ReadLine());
            list.RemoveRange(startIndex, k);

            Console.WriteLine("Новый список:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
