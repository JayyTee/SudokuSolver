using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;
using SudokuSolver.BoardBuilding;
using System;
using System.IO;
namespace SudokuSolverTests
{
    [TestClass]
    public class SudokuSolverTests
    {
        //Ran out of time, but this is basically how I would set up tests, covering all complex functions individually
        [TestMethod]
        public void SOLVE_BOARD_TEST()
        {
            int[,] testBoard;
            BoardBuilder builder = new BoardBuilder();
            var testLib = new SudokuSharp.Board();
            
            string filePath = $"{Environment.CurrentDirectory}\\TestFiles\\Puzzle1.txt";

            testBoard = builder.CreateSudokuBoard(filePath);

            SolveSudoku Solver = new SolveSudoku(testBoard);

            //Assert.IsTrue(Solver.Solve, SomeLibrary.isBoardSolved(testBoard)); 
        }
    }
}
