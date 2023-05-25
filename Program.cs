// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    
    
    static int printNatural(int ctr,int stval)
    {
	if (ctr < 1)
	{
	    return stval;
	}
	Console.Write(" {0} ",ctr);
		ctr--;
	return printNatural(ctr,stval);
    }
    
    {
	Console.Write("\n\n Рекурсия: вывести натуральные числа от n до 1 :\n");
	
    Console.Write("--------------------------------------------------------\n");
	
    Console.Write("Введите число : ");
	int ctr= Convert.ToInt32(Console.ReadLine());
	// Вызов рекурсивного метода с двумя параметрами.	
	printNatural(ctr,1);
	Console.Write("\n\n");
    }
