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
        public void CalculatingScore_testOneSpare_Returns16()
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

        [Test()]
        public void CalculatingScore_testOneStrike_Returns24()
        {
            //User story: player rolls 10/0,3/4,0/0,0/0.....
            //Arrange
            game = new Game();
            int expected = 24;
            int actual;

            //Act
            game.Roll(10);            
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);
            actual = game.CalculatingScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void CalculatingScore_testPerfectGame_Return300()
        {
            //Arrange
            game = new Game();
            int expected = 300;
            int actual;

            //Act
            RollMany(12, 10);
            actual = game.CalculatingScore();

            //Arrange
            Assert.AreEqual(expected, actual);
        }


        [Test()]
        public void CalcucalatingScore_testOneStrikeOneSpare_Returns40()
        {
            //user story: 10/0,4/6,5/0,0/0.........
            //Arrange
            game = new Game();
            int expected = 40;
            int actual;

            //Act
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(5);
            RollMany(15, 0);
            actual = game.CalculatingScore();

            //Arrange
            Assert.AreEqual(expected, actual);
        
        }

        [Test()]
        public void CalculatingScore_testTurkey_Returns60()
        {
            //User stroy: 10/0,10/0,10/0,0/0,0/0......
            //Arrange
            game = new Game();
            int expected = 60;
            int actual;

            //Act
            RollMany(3, 10);
            RollMany(14, 0);
            actual = game.CalculatingScore();

            //Arrange
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
