using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SkillsAssessment.Tests.CSharp
{
    [TestClass]
    public class Challenge_Soduko
    {
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

        [TestMethod]
        public void Should_SolveSoduko()
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

            var expected = CreateBoard(
                "5|3|4|6|7|8|9|1|2",
                "6|7|2|1|9|5|3|4|8",
                "1|9|8|3|4|2|5|6|7",
                "8|5|9|7|6|1|4|2|3",
                "4|2|6|8|5|3|7|9|1",
                "7|1|3|9|2|4|8|5|6",
                "9|6|1|5|3|7|2|8|4",
                "2|8|7|4|1|9|6|3|5",
                "3|4|5|2|8|6|1|7|9"
            );

            // Act
            SolveSudoku(board);

            // Assert
            CollectionAssert.AreEqual(expected, board);
        }


        public bool IsValidSudoku(char[,] board)
        {
            // Determine if a Sudoku is valid, according to: Sudoku Puzzles -The Rules.
            // http://sudoku.com.au/TheRules.aspx
            // each row must contain 1-9
            // each column must contain 1-9
            // each of the 3x3 sub-boxes must contain 1-9

            return false;
        }

        public void SolveSudoku(char[,] board)
        {
            // code - solve soduko board here
        }



        char[,] CreateBoard(params string[] rows)
        {
            // top down
            var board = new char[9, 9];
            for (var y = 0; y < 9; y++)
                for (var x = 0; x < 9; x++)
                    board[y, x] = rows[y][x*2];

            return board;
        }

    }
}
