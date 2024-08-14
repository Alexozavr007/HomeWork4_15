using HomeWork4_15_4;
using System.Text;

SynchronizationContext.SetSynchronizationContext(new ThreadedSynchronizationContext());
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Before method call");

MethodWithError();

Console.WriteLine("After method call");

static async void MethodWithError() {
    throw new Exception("Here we go");
}