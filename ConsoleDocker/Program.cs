// See https://aka.ms/new-console-template for more information

int i = 1;
while (i<10000)
{
    Console.WriteLine($"Hello, World! {i}");
    i++;

    Thread.Sleep(1000);
}

