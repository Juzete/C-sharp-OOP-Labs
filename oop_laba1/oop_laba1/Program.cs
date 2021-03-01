using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_laba1
{
    class persone
    {
        protected internal string name; //Имя
        protected internal int age; //возраст
        protected internal int exp; // стаж

        // без параметров
        protected internal persone (string name, int age, int exp)
        {
            this.name = name;
            this.age = age;
            this.exp = exp;
        }

        // с параметрами
        protected internal persone()
        {
            name = "Maxim";
            age = 18;
            exp = 1;
        }

        // копирования
        protected internal persone(persone copy)
        {
            name = copy.name;
            age = copy.age;
            exp = copy.exp;
        }

        // диструктор 
        ~persone()
        {
            Console.WriteLine("Object destroyed");
        }
        
        // установка данных
        protected void setName(string name)
        {
            this.name = name;
        }
        protected void setAge(int age)
        {
            this.age = age;
        }
        protected void setExp(int exp)
        {
            this.exp = exp;
        }

        //получение данных
        protected string getName()
        {
            return name;
        }
        protected int getAge()
        {
            return age;
        }
        protected int getExp()
        {
            return exp;
        }

        public override string ToString()
        {
            return "Имя: " + name + " Возраст: " + age + " Рабочий стаж: " + exp;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            persone persone1 = new persone();
            Console.WriteLine(persone1);
            persone persone2 = new persone("Какое-то имя", 24, 3);
            Console.WriteLine(persone2);
            Console.WriteLine("Введите данные служащего");
            persone persone3 = new persone();
            persone3.name = Console.ReadLine();
            persone3.age = Convert.ToInt32(Console.ReadLine());
            persone3.exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(persone3);
            Console.ReadKey();
        }
    }


}
