using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class DefaultCard
    {
        public List<Person> personList = new List<Person>();
        public  List<Card> cardList = new List<Card>();


        public DefaultCard()
        {
            Person person1 = new Person("John", "Doe", 1);
            Person person2 = new Person("Jake", "Doe", 2);

                personList.Add(person1);
                personList.Add(person2);

                foreach (var person in personList)
                {
                    Console.WriteLine("Name: " + person.Name +
                     " Surname: " + person.Surname +
                     " ID: " + person.Id1);
                }
            Card card1 = new Card();
            card1.Title = "İngilizce Öğren";
            card1.Content = "xx";
            card1.AssignedPerson = person1;
            card1.CardSize = Card.CardSizeType.XL;
            card1.Line = Board.BoardLine.INPROGRESS;
            cardList.Add(card1);

            Card card2 = new Card();
            card2.Title = "C# Öğren";
            card2.Content = "Patikayı bitir";
            card2.AssignedPerson = person2;
            card2.CardSize = Card.CardSizeType.M;
            card2.Line = Board.BoardLine.INPROGRESS;
            cardList.Add(card2);
        }
    }
}
