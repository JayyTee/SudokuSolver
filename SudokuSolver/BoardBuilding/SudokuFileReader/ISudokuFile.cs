using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.BoardBuilder.SudokuFileReader
{
    interface ISudokuFile
    {
        string[] ReadFileToList(string filePath);
    }
}
