using System;


{
    Console.WriteLine("Число десятков первого числа: ");
    int a2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число единц первого числа: ");
    int a1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число десятков второго числа: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число единц второго числа: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    a2 = a2 + b2 + (a1 + b1) / 10;
    a1 = (a1 + b1) % 10;
    Console.WriteLine($"c={a2}{a1}");
}

//Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1, где 1a и 1b—число единиц, 2a и 2b—число десятков.
//Получить цифры числа, равного сумме заданных чисел (известно, что это число двузначное).
//Слагаемое-двузначное число и число-результат не определять; условный оператор не использовать.