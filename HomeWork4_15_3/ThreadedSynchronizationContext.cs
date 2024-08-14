﻿namespace HomeWork4_15_3;

internal class ThreadedSynchronizationContext : SynchronizationContext {

    public override void Post(SendOrPostCallback d, object? state) {
        var thread = new Thread(() => {
            d(state);
        });
        thread.Name = "Капітан Америка";
        thread.Start();
    }


}

