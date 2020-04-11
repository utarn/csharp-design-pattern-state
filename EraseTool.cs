using System;

namespace pattern_state
{
    public class EraseTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}