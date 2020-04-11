using System;

namespace pattern_state
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCanvas = new Canvas();
            newCanvas.CurrentToolType = new BucketTool();
            newCanvas.mouseDown();
            newCanvas.mouseUp();

            // var sw = new StopWatch();
            // sw.Click();
            // sw.Click();
            // sw.Click();
        }
    }
}
