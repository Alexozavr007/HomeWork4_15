using HomeWork4_15_3;
using System.Text;

SynchronizationContext.SetSynchronizationContext(new ThreadedSynchronizationContext());
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId}, thread name = {Thread.CurrentThread.Name}, is ThreadPool thread  = {Thread.CurrentThread.IsThreadPoolThread}");

var fact5 = await Task.Run(() => Factorial(5))
    .ConfigureAwait(false); // Дозволяє продовжити виконання в треді з ThreadPool

Console.WriteLine($"Factorial 5 = {fact5}");
Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId}, thread name = {Thread.CurrentThread.Name}, is ThreadPool thread  = {Thread.CurrentThread.IsThreadPoolThread}");

static long Factorial(int number) {
    long result = 1;
    for (int i = 1; i <= number; i++) {
        result = result * i;
    }

    return result;
}