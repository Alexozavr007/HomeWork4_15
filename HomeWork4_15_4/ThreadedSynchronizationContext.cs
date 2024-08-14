namespace HomeWork4_15_4;

internal class ThreadedSynchronizationContext : SynchronizationContext {

    public override void Post(SendOrPostCallback d, object? state) {
        var thread = new Thread(() => {
            try {
                d(state);
            } catch (Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Екзепшн піймано! {ex.Message}");
                Console.ResetColor();
            }
        });

        thread.Name = "Капітошка";
        thread.Start();
    }

}

