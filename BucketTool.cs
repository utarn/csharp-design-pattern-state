using System;

namespace pattern_state
{
    public class BucketTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Bucket icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Paint one color");
        }
    }
}