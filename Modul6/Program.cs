using System;

namespace Modul6
{
    class Program
    {
		static void Main(string[] args)
		{

			//			Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4};
			{
				var department = GetCurrentDepartment();
			}

			static Department GetCurrentDepartment()
			{
				// logic
				Department department = new Department();

				if(department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
				{
					Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
				}

				return department;
			}

			Console.ReadKey();
		}

		class Triangle
        {
			double a;
			double b;
			double c;

			public double Surface()
            {

            }

			public double Perimeter()
            {

            }
		}

		class Square
		{
			double a;

			public double Square()
			{
			
			}

			public double Perimeter()
			{
			
			}
		}

		class Circle
		{
			double r;

			public double Square()
			{
			
			}

			public double Length()
			{
			
			}
		}

		class Car
		{
			public double Fuel;
			public int Mileage;

			public Car()
			{
				Fuel = 50;
				Mileage = 0;
			}

			public void Move()
			{
				// Move a kilometer
				Mileage++;
				Fuel -= 0.5;
			}

			public void FillTheCar()
			{
				Fuel = 50;
			}
		}

		class Bus
		{
			public int? Load; 

			public void PrintStatus()
			{
				if (Load.HasValue)
				{
					Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
				}
				else
				{
					Console.WriteLine("Автобус пуст!");
				}
			}
		}

		class Company
		{
			public string Type;
			public string Name;
		}

		class Department
		{
			public Company Company;
			public City City;
		}

		class City
		{
			public string Name;
		}

		class Rectngle
        {
			public int a;
			public int b;

            Rectngle(int aa, int ab)
            {
				a = aa;
				b = ab;
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
