﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Battleship.Model;

namespace Battleship
{
    [TestClass]
    public class TestSurroundingShooting
    {
        [TestMethod]
        public void ForEmptyGridSurroundingShootingTargetsOneOfSquaresArroundHitOne()
        {
            var grid = new EnemyGrid(10, 10);
            var firstHit = new Square(3, 3);
            int shipLength = 3;
            var ss = new SurroundingShooting(grid, firstHit, shipLength);
            var candidates = new List<Square> { new Square(3, 2), new Square(3, 4), new Square(2, 3), new Square(4, 3) };
            var next = ss.NextTarget();
            CollectionAssert.Contains(candidates, next);
        }
        [TestMethod]
        public void SurroundingShootingTargetsOnlySquaresThatAreNotMarked1()
        {
            var grid = new EnemyGrid(10, 10);
            grid.ChangeSquareState(3, 2, SquareState.Hit);
            var firstHit = new Square(3, 3);
            int shipLength = 3;

            var ss = new SurroundingShooting(grid, firstHit, shipLength);
            var candidates = new List<Square> { new Square(3, 4), new Square(2, 3), new Square(4, 3) };
            var next = ss.NextTarget();
            CollectionAssert.Contains(candidates, next);
        }
        [TestMethod]
        public void SurroundingShootingTargetsOnlySquaresThatAreNotMarked2()
        {
            var grid = new EnemyGrid(10, 10);
            grid.ChangeSquareState(3, 2, SquareState.Hit);
            grid.ChangeSquareState(3, 4, SquareState.Hit);
            var firstHit = new Square(3, 3);
            int shipLength = 3;

            var ss = new SurroundingShooting(grid, firstHit, shipLength);
            var candidates = new List<Square> { new Square(2, 3), new Square(4, 3) };
            var next = ss.NextTarget();
            CollectionAssert.Contains(candidates, next);
        }
        [TestMethod]
        public void SurroundingShootingTargetsOnlySquaresThatAreNotMarked3()
        {
            var grid = new EnemyGrid(10, 10);
            grid.ChangeSquareState(3, 2, SquareState.Hit);
            grid.ChangeSquareState(3, 4, SquareState.Hit);
            grid.ChangeSquareState(4, 3, SquareState.Hit);
            var firstHit = new Square(3, 3);
            int shipLength = 3;

            var ss = new SurroundingShooting(grid, firstHit, shipLength);
            var next = ss.NextTarget();
            Assert.AreEqual(new Square(2, 3), next);
        }
    }
}