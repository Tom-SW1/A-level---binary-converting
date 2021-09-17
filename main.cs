using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("please enter a value in denary");
    int userinput = Convert.ToInt32(Console.ReadLine());
    string binary = "";
    while (true) {
      int bitvalue = userinput % 2;
      userinput = (int)userinput / 2;
      binary = $"{bitvalue}{binary}";
      if (userinput < 1) {
        break;
      };
    };
    Console.WriteLine(binary);
  }
}