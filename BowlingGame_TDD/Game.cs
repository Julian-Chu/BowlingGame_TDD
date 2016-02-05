using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingGame_TDD
{
    public class Game
    {
        int totalScore=0;
        int[] rolls=new int[22];
        int rollsIndex = 0;
        public void Roll(int pins)
        {
            rolls[rollsIndex] = pins;
            if(pins==10 && rollsIndex%2==0 && rollsIndex<20)
            {
                rolls[++rollsIndex] = 0;
            }
            rollsIndex++;
        }

        public int CalculatingScore()
        {
            for (int frame = 0; frame < 10; frame++ )
            {
                int scoreInFrame=rolls[frame * 2] + rolls[frame * 2 + 1];
                if (IsOneStrike(frame))
                    scoreInFrame += StrikeBonus(frame);
                if (IsOneSpare(scoreInFrame))
                    scoreInFrame += SpareBonus(frame);
                totalScore += scoreInFrame;                
            }
            return totalScore;
        }

        private int SpareBonus(int frame)
        {
            return rolls[frame * 2 + 2];
        }

        private int StrikeBonus(int frame)
        {
            
            if(frame!=9 && IsOneStrike(frame+1))
            {
                return 10 + rolls[(frame + 2) * 2];
            }
            return rolls[frame * 2 + 2] + rolls[frame * 2 + 3];
        }

        private bool IsOneStrike(int frame)
        {
            return rolls[frame * 2] == 10;
        }

        private static bool IsOneSpare(int scoreInFrame)
        {
            return scoreInFrame == 10;
        }
    }
}