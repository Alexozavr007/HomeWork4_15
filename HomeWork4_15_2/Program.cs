using HomeWork4_15_2;
using System.Text;

var ctx = new ThreadedSynchronizationContext();
SynchronizationContext.SetSynchronizationContext(ctx);
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId}, thread name = {Thread.CurrentThread.Name}, is ThreadPool thread  = {Thread.CurrentThread.IsThreadPoolThread}");

var fact5 = await Task.Run(() => Factorial(5));
Console.WriteLine($"Factorial 5 = {fact5}");

Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId}, thread name = {Thread.CurrentThread.Name}, is ThreadPool thread  = {Thread.CurrentThread.IsThreadPoolThread}");

static long Factorial (int number) {
    long result = 1;
    for (int i = 1; i <= number; i++) {
        result = result * i;
    }
    return result;
}