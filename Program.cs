// See https://aka.ms/new-console-template for more information
Console.WriteLine("Radiusni kiriting: ");
int r = Convert.ToInt32(Console.ReadLine());

decimal L = 2*3.14m*r;
decimal S = 3.14m*(r*r);
System.Console.WriteLine(L);
System.Console.WriteLine(S);