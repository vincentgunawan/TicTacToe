using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class BoardTests
    {
        private Board game;

        [TestMethod()]
        public void BoardTest()
        {
            Board board = new Board();
          

            Assert.AreEqual(Board(9));
        }

        [TestMethod()]
        public void CurrentPlayer()
        {
            CurrentPlayer player = new player();
            Assert.AreEqual(game.Player.EqualTo("X"));
  
        }

        [TestMethod()]
        public void MakeMoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SpacesInUseTest()
        {
            Assert.Fail();
        }
    }
}