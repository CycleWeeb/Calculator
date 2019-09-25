using System;

class MainClass {
  public static void Main (string[] args) {
    double num1 = 0;
	double num2 = 0;
    char operat = 'a';
    while(true){
      num1 = Convert.ToDouble(Console.ReadLine());
      operat = Convert.ToChar(Console.ReadLine());
      num2 = Convert.ToDouble(Console.ReadLine());
      switch (operat){
        case '+':
        Console.WriteLine(num1 + num2);
        break;

        case '-':
        Console.WriteLine(num1 - num2);
        break;

        case '*':
        Console.WriteLine(num1 * num2);
        break;

        case '/':
        Console.WriteLine(num1 / num2);
        break;

        case '%':
        Console.WriteLine(num1 % num2);
        break;

        case '^':
        Console.WriteLine((Math.Pow(num1,num2)));
        break;

        case '@':
        Console.WriteLine((Math.Sqrt(num1)));
        break;

		default:
		Console.WriteLine("Please select a valid operator: + for plus, - for minus, * for times, / for divide, % for modulus, ^ for power, and @ for square root (second number does not matter)");
		break;
      }
    }
  }
}