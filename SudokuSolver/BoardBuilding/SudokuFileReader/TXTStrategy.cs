using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudokuSolver.BoardBuilder.SudokuFileReader
{
    public class TXTStrategy : ISudokuFile
    {
        public string[] ReadFileToList(string filePath)
        {
            string[] SudokuFileAsList;

            SudokuFileAsList = File.ReadAllLines(filePath);

            return SudokuFileAsList;
        }
    }
}
