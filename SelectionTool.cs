using System;

namespace pattern_state
{
    public class SelectionTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}