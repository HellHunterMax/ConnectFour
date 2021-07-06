using ConnectFour.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Factories
{
    public class CheckerFactory
    {
        /// <summary>
        /// Will create a checker with the correct color for the given board.
        /// </summary>
        /// <param name="board">will use this board to check which color is next.</param>
        /// <returns></returns>
        public static Checker Create(Board board)
        {
            CheckerColor color = board.IsItWhitesTurn ? CheckerColor.White : CheckerColor.Black;
            return new Checker(color);
        }
    }
}
