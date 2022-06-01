using System;

namespace Modul6
{
    class Program
    {
		static void Main(string[] args)
		{

			Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4};

			Console.ReadKey();

		}

		class Rectngle
        {
			public int a;
			public int b;

            Rectngle(int aa, int bb)
            {
				a = aa;
				b = bb;
            }

            Rectngle(int aa)
            {
				a = aa;
				b = aa;
            }

            Rectngle()
            {
				a = 6;
				b = 4;
            }

            int Square()
            {
				return a * b;
            }
        }

		class Pen
		{
			public string color;
			public int cost;

            Pen()
            {
				color = "Чёрный";
				cost = 100;
            }

			Pen( string penColor, int penCost)
            {
				color = penColor;
				cost = penCost;
            }
		}

		class Human
		{
			// Поля класса
			public string name;
			public int age;
			// Конструктор 1
			public Human()
			{
				name = "Неизвестно";
				age = 20;
			}
			// Конструктор 2
			public Human(string n)
			{
				name = n;
				age = 20;
			}
			// Конструктор 3
			public Human(string n, int a)
			{
				name = n;
				age = a;
			}
			// Метод класса
			public void Greetings()
			{
				Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
			}
		}

		struct Animal
		{
			// Поля структуры
			public string type;
			public string name;
			public int age;

			// Метод структуры
			public void Info()
			{
				Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
			}
		}
	}
}
