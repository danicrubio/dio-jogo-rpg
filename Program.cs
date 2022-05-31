using Projeto2.src.Entities;

public class Program
{
  public static void Main()
  {
    Knight arus = new Knight("Arus", 23, "Knight");
    Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

    Console.WriteLine(arus.Attack());
    Console.WriteLine(wizard.Attack(7));
  }
}
