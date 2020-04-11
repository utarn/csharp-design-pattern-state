using System;

namespace pattern_state
{
    public class StoppedState : StopWatchState
    {
        public StopWatch StopWatch { get; }
        public StoppedState(StopWatch stopwatch)
        {
            this.StopWatch = stopwatch;
        }
        public void Click()
        {
            StopWatch.CurrentState = new RunningState(StopWatch);
            Console.WriteLine("Running");
        }
    }
}