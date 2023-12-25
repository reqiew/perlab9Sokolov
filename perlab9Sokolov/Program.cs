try
{

    Console.WriteLine("Введите кол-во минут");
    int min = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите кол-во секунд");
    int sec = int.Parse(Console.ReadLine()!);

    Time time = new Time(min, sec);
    time.Print();
}

catch (Exception ex)
{ Console.WriteLine(ex.Message); }


class Time
{
    public int min { set; get; }
    public int sec { set; get; }

    public Time(int min, int sec)
    {
        this.min = min;
        this.sec = sec;
    }
    public int Mis(int min, int sec)
    {
        return min * 60 + sec;
    }
    public void Print()
    {
        Console.WriteLine($"Минуты: {min}, Секунды: {sec}, Общее время в секундах: {Mis(min, sec)}");
    }
}
