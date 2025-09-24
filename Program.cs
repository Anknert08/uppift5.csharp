// See https://aka.ms/new-console-template for more information
int[] v = new int[5];
Console.WriteLine("write a number");
v[0] = int.Parse(Console.ReadLine());
Console.WriteLine("you wrote " + v[0]);
Console.WriteLine("write a number");
v[1] = int.Parse(Console.ReadLine());
Console.WriteLine("you wrote " + v[1]); 
Console.WriteLine("write a number");
v[2] = int.Parse(Console.ReadLine());
Console.WriteLine("you wrote " + v[2]);
Console.WriteLine("write a number");
v[3] = int.Parse(Console.ReadLine());
Console.WriteLine("you wrote " + v[3]);
Console.WriteLine("write a number");
v[4] = int.Parse(Console.ReadLine());
Console.WriteLine("you wrote " + v[4]);
Console.WriteLine("the numbers you wrote are: " + v[0] + ", " + v[1] + ", " + v[2] + ", " + v[3] + ", " + v[4]);