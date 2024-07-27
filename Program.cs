using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("알람 기능을 구현합니다.");
        Console.Write("알람 시간을 초 단위로 입력하세요: ");
        
        if (int.TryParse(Console.ReadLine(), out int seconds))
        {
            Console.WriteLine($"알람이 {seconds}초 후에 울립니다.");
            await SetAlarm(seconds);
        }
        else
        {
            Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.");
        }
    }

    static async Task SetAlarm(int seconds)
    {
        await Task.Delay(seconds * 1000);
        Console.WriteLine("알람! 지정한 시간이 지났습니다.");
    }
}
