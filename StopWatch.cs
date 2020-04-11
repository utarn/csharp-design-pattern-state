using System;

namespace pattern_state
{
    public class StopWatch
    {
        public StopWatchState CurrentState { get; set; }
        public StopWatch()
        {
            CurrentState = new StoppedState(this);
        }
        public void Click()
        {
            CurrentState.Click();
        }
    }
}