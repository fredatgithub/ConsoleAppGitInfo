using System;

namespace ConsoleAppGitInfo
{
  internal class Program
  {
    static void Main()
    {
      Console.WriteLine(Git.Commit);

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
