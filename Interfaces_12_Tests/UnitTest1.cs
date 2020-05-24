using System;
using Interfaces_12;
using NUnit.Framework;

namespace Interfaces_12_Tests
{
	public class Tests
	{
		[Test]
		public void Test_Traveler()
		{
			Professor Hous = new Professor("1", "Hous", "Alex", 45, "13", "Chemistry"); 
			Professor Smit = new Professor("2", "Smit", "Max", 56, "10", "Biology");
			Student Oleg = new Student("3", "Kovalev", "Oleg", 20, "Biology", "3");
			Student Anna = new Student("4", "Erofeeva", "Anna", 19, "Chemistry", "4");

			Person[] listOfPeople = new Person[4];

			listOfPeople[0] = Hous;
			listOfPeople[1] = Smit;
			listOfPeople[2] = Oleg;
			listOfPeople[3] = Anna;

			foreach (var person in listOfPeople)
			{
				Console.WriteLine(person);
			}
		}
	}
}