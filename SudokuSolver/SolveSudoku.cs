using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace SudokuSolver
{
    public class SolveSudoku
    {
        private int _BOARD_SIZE = 9;
        private readonly int _SQUARE_SIZE = 3;
        int[,] _sudokuBoard;

        /// <summary>
        /// Attempts to solve a given 2D array as a sudoku board.
        /// </summary>
        /// <param name="sudokuBoard"></param>
        /// <returns></returns>
        /// 
        public SolveSudoku(int[,] board)
        {
            this._sudokuBoard = board;
        }

        public int[,] SolveBoard()
        {
            Solve();

            return _sudokuBoard;
        }

        public bool Solve()
        {
            for (int row = 0; row < _BOARD_SIZE; row++)
            {
                for (int column = 0; column < _BOARD_SIZE; column++)
                {
                    if (_sudokuBoard[row, column] == 0)
                    {
                        for (int digit = 1; digit <= _BOARD_SIZE; digit++)
                        {
                            if (isValid(_sudokuBoard, row, column, digit))
                            {
                                _sudokuBoard[row, column] = digit;

                                if (Solve())
                                {
                                    return true;
                                }
                                else
                                {
                                    _sudokuBoard[row, column] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isValid(int[,] board, int row, int column, int digit)
        {
            int startingPositionX = column - (column % _SQUARE_SIZE);
            int startingPositionY = row - (row % _SQUARE_SIZE);

            for (int number = 0; number < _BOARD_SIZE; number++)
            {
                if (isNumberInRow(board, row, digit))
                {
                    return false;
                }

                if (isNumberInColumn(board,column, digit))
                {
                    return false;
                }

                if (isInSquare(board, column, row, digit))
                {
                    return false;
                }
            }
            return true;
        }

        private bool isNumberInRow(int[,] board, int row,int digit)
        {
            for(int column = 0; column < _BOARD_SIZE; column++)
            {
                if (board[row, column] != 0 && board[row, column] == digit)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isNumberInColumn(int[,] board, int column, int digit)
        {
            for (int row = 0; row < _BOARD_SIZE; row++)
            {
                if (board[row, column] != 0 && board[row, column] == digit)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isInSquare(int[,] board, int column, int row, int digit)
        {
            int squareStartX = column - (column % _SQUARE_SIZE);
            int squareStartY = row - (row % _SQUARE_SIZE);

            for (int squareColumn = squareStartX; squareColumn < squareStartX + 3; squareColumn++)
            {
                for(int squareRow = squareStartY; squareRow < squareStartY + 3; squareRow++)
                {
                    if (board[squareRow,squareColumn] == digit)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

