int num = new Random().Next(-10, 11);

bool flag = false;

if ( num % 2 == 0 ) flag = true;


Console.WriteLine("num = " + num);
Console.WriteLine(flag);