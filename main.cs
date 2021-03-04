using System;

class MainClass {
  public static void Main (string[] args) {
    int[] celcius = new int[7];
    int[] fahrenheit = new int[7];
    double avrg = 0;
    for(int counter = 0; counter <= 7; counter++)
    {
      Console.WriteLine("What's the degree in Celsius?");
      celcius[counter] = Convert.ToInt32(Console.ReadLine());
      fahrenheit[counter] = (celcius [counter] *9/5)+32;

      Console.WriteLine("Fahrenheit is " + fahrenheit[counter]);
      avrg = (avrg+fahrenheit[counter]) / 7;
      Console.WriteLine("the average in Fahrenheit is " + avrg);
    }
  }
}