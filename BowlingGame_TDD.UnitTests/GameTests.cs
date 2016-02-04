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
        public void Game_Roll20timesGutter_Returns0()
        {
            //Arrange
            game = new Game();
            int expected = 0;
            int actual;
            //Act
            for(int i=0;i<20;i++)
            {
                game.Roll(0);
            }
            actual = game.CalculatingScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
