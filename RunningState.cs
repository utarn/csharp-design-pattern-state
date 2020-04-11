using System;

namespace pattern_state
{
    public class RunningState : StopWatchState
    {
        public StopWatch StopWatch { get; }
        public RunningState(StopWatch stopWatch)
        {
            this.StopWatch = stopWatch;
        }
        public void Click()
        {
            StopWatch.CurrentState = new StoppedState(StopWatch);
            Console.WriteLine("Stopped");
        }
    }
}