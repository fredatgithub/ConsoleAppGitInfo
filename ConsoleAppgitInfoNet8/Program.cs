namespace ConsoleAppgitInfoNet8
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine(ThisAssembly.Git.Commit);

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
