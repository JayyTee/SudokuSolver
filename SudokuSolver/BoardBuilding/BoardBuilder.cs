using SudokuSolver.BoardBuilder;
using SudokuSolver.BoardBuilder.SudokuFileReader;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.BoardBuilding
{
    public class BoardBuilder
    {
        private int BOARD_WIDTH = 9;
        private int BOARD_HEIGHT = 9;
        
        public int[,] CreateSudokuBoard(string sudokuFilePath)
        {
            int[,] gameBoard = new int[BOARD_WIDTH, BOARD_HEIGHT];
            char[] currentRow;

            ISudokuFile boardFile = SudokuFileFactory.GetFileTypeReflectively(sudokuFilePath);
            string[] boardRows = boardFile.ReadFileToList(sudokuFilePath);

            for (int row = 0; row < boardRows.Length; row++ )
            {
                currentRow = boardRows[row].ToCharArray();

                for (int column = 0; column < boardRows[row].Length; column++)
                {
                    if (char.IsDigit(currentRow[column]))
                    {
                        gameBoard[row, column] = (int)char.GetNumericValue(currentRow[column]);
                    }
                    else
                    {
                        gameBoard[row, column] = 0;
                    }
                }
            }
            return gameBoard;
        }
    }
}
