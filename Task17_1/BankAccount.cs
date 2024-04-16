using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_1
{
    class BankAccount<T>
    {
        public T Number {  get; set; }
        public double Balance { get; set; }
        public string Fio {  get; set; }

        public string GetInfo()
        {
            Random random = new Random();
            double Balance = random.Next(0, 1000000);
            return $"Номер счета: {Number} ФИО: {Fio} Баланс: {Balance}"; 
        }
        public void Input()
        {           
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            
            Console.WriteLine("Введите ФИО");
            Fio = Console.ReadLine();
        }
    }
}
