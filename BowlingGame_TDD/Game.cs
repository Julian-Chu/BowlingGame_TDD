using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingGame_TDD
{
    public class Game
    {
        int score=0;
        public void Roll(int pins)
        {
            score += pins;
        }

        public int CalculatingScore()
        {
            return score;
        }
    }
}