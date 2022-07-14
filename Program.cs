// See https://aka.ms/new-console-template for more information

using Dungeon_Dio.SRC.Entities;

class Program
{
  static void Main(string[] args)
  {
    Hero hero = new Hero("Arus", 23, "Knight");
    Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
    Ninja ninja = new Ninja("Wedge", 23, "Ninja");
    BlackWizard blackwizard = new BlackWizard("Topapa", 23, "Black Wizard");

    Console.WriteLine(hero.Attack());
    Console.WriteLine(wizard.Attack());
    Console.WriteLine(ninja.Attack());
    Console.WriteLine(blackwizard.Attack());
  }
}