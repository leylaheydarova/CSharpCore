int number = 50;
while (number > 10)
{
    Console.WriteLine("Hello!");
    number /= 2;
    if (number < 22) continue; //oldugu setirden asagi getmesine izn vermir,
                               //scope-un evveline qaytarir
    Console.WriteLine($"I am {number}");
}