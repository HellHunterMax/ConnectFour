using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.Models
{
    public enum CheckerColor
    {
        White,
        Black
    }
    public class Checker
    {
        public CheckerColor Color { get; init; }

        public Checker()
        {

        }
        public Checker(CheckerColor color)
        {
            Color = color;
        }
    }
}
