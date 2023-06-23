using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Board
    {
        public enum BoardLine
        {
            TODO = 1,
            INPROGRESS,
            DONE
        }

        public static IEnumerable<BoardLine> GetBoardLines()
        {
            return Enum.GetValues(typeof(BoardLine)).Cast<BoardLine>();
        }
    }
}
