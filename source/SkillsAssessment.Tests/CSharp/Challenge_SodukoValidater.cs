using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_SodukoValidater
    {
        [Hard]
        [TestMethod]
        public void Should_ValidateSoduko()
        {
            // Arrange
            var board = CreateBoard(
                "5|3| | |7| | | | ",
                "6| | |1|9|5| | | ",
                " |9|8| | | | |6| ",
                "8| | | |6| | | |3",
                "4| | |8| |3| | |1",
                "7| | | |2| | | |6",
                " |6| | | | |2|8| ",
                " | | |4|1|9| | |5",
                " | | | |8| | |7|9"
            );

            // Act
            var isValid = IsValidSudoku(board);

            // Assert
            Assert.IsTrue(isValid);
        }

        /// <summary>
        /// Determine if a Sudoku is valid, according to: Sudoku Puzzles -The Rules.
        /// http://sudoku.com.au/TheRules.aspx
        /// each row must contain 1-9
        /// each column must contain 1-9
        /// each of the 3x3 sub-boxes must contain 1-9
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public bool IsValidSudoku(char[,] board)
        {
            throw new NotImplementedException("Code solution here"); 
        }

        char[,] CreateBoard(params string[] rows)
        {
            // top down
            var board = new char[9, 9];
            for (var y = 0; y < 9; y++)
                for (var x = 0; x < 9; x++)
                    board[y, x] = rows[y][x * 2];

            return board;
        }

    }
}
