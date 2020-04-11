using System;

namespace pattern_state
{
    public class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}