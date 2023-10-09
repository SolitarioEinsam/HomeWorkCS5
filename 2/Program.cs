
double k1, b1, k2, b2;
System.Console.Write("Введите значение для параметра k1: ");
k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение для параметра b1: ");
b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение для параметра k2: ");
k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение для параметра b2: ");
b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"Координаты точки пересечения функций: ({x}, {y})");
