﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    class Game
    {

        public Player[] Players;
        public Player[,] Room;
        public Game(int n)
        {
            Players = new Player[n];
            Room = new Player[n * 10, n * 10];
        }

    }
}
