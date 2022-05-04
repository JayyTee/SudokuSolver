using System;
using System.Windows.Forms;

namespace SudokuSolver
{
    class ErrorHandler
    {
        //Welcome to over simplified error handling!
        public static void HandleException(Exception exception)
        {
            MessageBox.Show(exception.Message, "Uh Oh...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
