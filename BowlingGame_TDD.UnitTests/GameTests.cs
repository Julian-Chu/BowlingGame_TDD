using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame_TDD;
using NUnit.Framework;
namespace BowlingGame_TDD.UnitTests
{
    [TestFixture()]
    public class GameTests
    {
        Game game;
        [Test()]
        public void CalculatingScore_Roll20timesGutter_Returns0()
        {
            //Arrange
            game = new Game();
            int expected = 0;
            int actual;
            //Act
            RollMany(20,0);
            actual = game.CalculatingScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        

        [Test()]
        public void CalculatingScore_testAllOnes_Returns20()
        {
            //Arrange
            game = new Game();
            int expected = 20;
            int actual;

            //Act
            RollMany(20, 1);
            actual = game.CalculatingScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CalcuatingScore_testOneSpare_Returns16()
        {
            //User story: player rolled 5/5,3/0,0/0......
            //Arrange
            game = new Game();
            int expected = 16;
            int actual;

            //Act
            RollOneSpare();
            game.Roll(3);
            RollMany(17,0);
            actual = game.CalculatingScore();

            //Assert
            Assert.AreEqual(expected, actual); 
     }

        private void RollMany(int times, int pins)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        private void RollOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }
    }
}
