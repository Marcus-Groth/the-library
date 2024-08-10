using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLibrary
{
    public class GameLoop
    {
        private bool _isRunning;

        public GameLoop()
        {
            _isRunning = true;
        }

        public void Start()
        {
            string[] options = { "Option 1", "Option 2", "Option 3", "Exit" };

            while (_isRunning)
            {
                ConsolePrinter.PrintMenu(options);
                InputHandler.GetStringInput("Please select on of the options above: ");
            }
        }

        public void Stop()
        {
            _isRunning = false;
        }
    }
}