
int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    int lastDigit = number % 10;

    if (lastDigit % 2 == 0)
    {
        int currentFactorial = CheckFactoriel(lastDigit);
        sum += currentFactorial;
    }

    number = number / 10;
}

Console.WriteLine(sum);
static int CheckFactoriel(int num)
{
    int factorial = 1;

    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }

    return factorial;
}


//Second Solution below:

//string number = Console.ReadLine();

//int sum = 0;

//for (int i = 0; i < number.Length; i++)
//{
//    int lastDigit = int.Parse(number[i].ToString());

//    if (lastDigit / 2 == 0)
//    {
//        int currentFactorial = FactorialNumber(lastDigit);
//        sum = sum + currentFactorial;
//    }
//}

//Console.WriteLine(sum);

//static int FactorialNumber(int n)
//{
//    if (n == 0 || n == 1)
//    {
//        return 1;
//    }

//    return n * FactorialNumber(n - 1);
//}
