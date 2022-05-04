using SudokuSolver.BoardBuilder.SudokuFileReader;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.BoardBuilding.SudokuFileReader
{
    class UnknownFileStrategy : ISudokuFile
    {
        public string[] ReadFileToList(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
