using System;
using System.IO;
using System.Windows.Forms;
using SudokuSolver.BoardBuilding;

namespace SudokuSolver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInputBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtInputPath.Text = openFileDialog.FileName;
                    }
                }
            }
            catch(Exception E)
            {
                ErrorHandler.HandleException(E);
            }
            
        }

        private void btnOutputBrowser_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                try
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        txtOutputDirectory.Text = folderBrowser.SelectedPath;
                    }
                }
                catch(Exception E)
                {
                    ErrorHandler.HandleException(E);
                }
               
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtInputPath.Text) && Directory.Exists(txtOutputDirectory.Text))
                {
                    BoardBuilding.BoardBuilder build = new BoardBuilding.BoardBuilder();
                    SolveSudoku problemSolver = new SolveSudoku(build.CreateSudokuBoard(txtInputPath.Text));
                    PrintSudokuBoard(problemSolver.SolveBoard(), txtOutputDirectory.Text, txtInputPath.Text);
                }
            }
            catch (Exception E)
            {
                ErrorHandler.HandleException(E);
            }

        }

        private bool PrintSudokuBoard(int[,] Board, string savePath, string fileName)
        {
            try
            {
                int boardSize = 9;
                string newFilePath = $"{savePath}\\{Path.GetFileNameWithoutExtension(fileName)}.sln.txt";
                using (TextWriter tw = new StreamWriter(newFilePath))
                {
                    for (int boardRow = 0; boardRow < boardSize; boardRow++)
                    {

                        for (int boardColumn = 0; boardColumn < boardSize; boardColumn++)
                        {
                            tw.Write(Board[boardRow, boardColumn]);
                        }
                        tw.Write(Environment.NewLine);
                    }
                }
                MessageBox.Show($"Sudoko file has been saved to: {newFilePath}.");
            }
            catch(Exception E)
            {
                ErrorHandler.HandleException(E);
            }
            return true;
        }
    }
}
