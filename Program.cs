namespace калькулятор_Платон { }
    class Program
{
    static void Main(string[] args)
    {
        int num1 = 0; int num2 = 0;

        Console.WriteLine("Калькулятор\r");
        Console.WriteLine("------------------------\n");

        Console.WriteLine("Выберите число и нажминет enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Выберите число и нажминет enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("\ta - сложение");
        Console.WriteLine("\ts - вычитание");
        Console.WriteLine("\tm - умножение");
        Console.WriteLine("\td - деление");
        Console.Write("Ваше действие? ");

        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                break;
            case "d":
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                break;
        }
        Console.Write("Нажмите любую кнопку, чтобы закрыть калькулятор...");
        Console.ReadKey();
    }
}
