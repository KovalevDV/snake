using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Snake
    {
        public Snake()
        {
            SetInitialSettings();
        }

        private void SetInitialSettings()
        {
            Length = 2;
            Color = ConsoleColor.Green;
            Speed = 2;
        }
        public int Length { get; private set; }

        public ConsoleColor Color { get; set; }

        public int Speed { get; set; }

    }
}
