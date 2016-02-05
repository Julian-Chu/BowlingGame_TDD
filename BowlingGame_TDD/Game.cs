using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingGame_TDD
{
    public class Game
    {
        int totalScore=0;
        int[] rolls=new int[20];
        int rollsIndex = 0;
        public void Roll(int pins)
        {
            rolls[rollsIndex] = pins;
            rollsIndex++;
        }

        public int CalculatingScore()
        {
            for (int frame = 0; frame < 10; frame++ )
            {
                int scoreInFrame=rolls[frame * 2] + rolls[frame * 2 + 1];
                if (IsOneSpare(scoreInFrame))
                    scoreInFrame+=rolls[frame*2+2];
                totalScore += scoreInFrame;
                
            }
            return totalScore;
        }

        private static bool IsOneSpare(int scoreInFrame)
        {
            return scoreInFrame == 10;
        }
    }
}