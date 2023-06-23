using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Card
    {
        public enum CardSizeType
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
        private string title;
        private string content;
        private Person assignedPerson;
        private CardSizeType cardSize;
        private Board.BoardLine line;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public Person AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
        public CardSizeType CardSize { get => cardSize; set => cardSize = value; }
        public Board.BoardLine Line { get => line; set => line = value; }

        public Card(string title, string content, Person assignedPerson, CardSizeType cardSize, Board.BoardLine line)
        {
            Title = title;
            Content = content;
            AssignedPerson = assignedPerson;
            CardSize = cardSize;
            Line = line;
        }
        public Card()
        {

        }
    }
}
