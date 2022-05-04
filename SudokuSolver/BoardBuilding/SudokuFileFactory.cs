using SudokuSolver.BoardBuilder.SudokuFileReader;
using SudokuSolver.BoardBuilding.SudokuFileReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SudokuSolver.BoardBuilder
{
    class SudokuFileFactory
    {
        /// <summary>
        /// Gets The <b>ISudokuFile</b> type needed to read a file containing the provided fileExtension
        /// </summary>
        /// <remarks>This function is dependant on <b>ISudokuFile</b> type names Starting with their respective file extension</remarks>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static ISudokuFile GetFileTypeReflectively(string filePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string fileExtension = Path.GetExtension(filePath).Replace(".","");
            try
            {
                var inputFileType = assembly.DefinedTypes
                                .Where(x => 
                                x.ImplementedInterfaces
                                .Contains(typeof(ISudokuFile)) && x.Name.ToLower().StartsWith(fileExtension))
                                .First().AsType();
                
                return (ISudokuFile)Activator.CreateInstance(inputFileType);
            }
            catch(InvalidOperationException E)
            {
                return new UnknownFileStrategy();
            }


        }
    }
}
