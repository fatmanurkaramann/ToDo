using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static ToDo.Board;
using static ToDo.Card;

namespace ToDo
{
    public class ToDomanager
    {
        List<Person> personList = new List<Person>();
        public static List<Card> cardList = new List<Card>();
        // Create and add person objects to the list

        public ToDomanager()
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
            }

        public void AddCard()
        {
            Console.WriteLine("Title :");
            string title = Console.ReadLine();

            Console.WriteLine("Content:");
            string content= Console.ReadLine();

            Console.WriteLine("Assigned Person ID:");
            int assignedPersonId = int.Parse(Console.ReadLine());
            Person assignedPerson = null;
            foreach (var person in personList)
            {
                if (person.Id1 == assignedPersonId)
                {
                    assignedPerson = person;
                    break;
                }
            }

            Console.WriteLine("Card Size Type:");
            foreach (CardSizeType sizeType in Enum.GetValues(typeof(CardSizeType)))
            {
                Console.WriteLine($"{(int)sizeType}. {sizeType}");
            }
            int selectedSizeTypeValue = int.Parse(Console.ReadLine());
            if (!Enum.IsDefined(typeof(CardSizeType), selectedSizeTypeValue))
            {
                Console.WriteLine("Invalid Card Size Type.");
                return;
            }
            CardSizeType selectedSizeType = (CardSizeType)selectedSizeTypeValue;

            Console.WriteLine("Select Board Line:");
            foreach (BoardLine line in Enum.GetValues(typeof(BoardLine)))
            {
                Console.WriteLine($"{(int)line}. {line}");
            }
            int selectedLineValue = int.Parse(Console.ReadLine());
            if (!Enum.IsDefined(typeof(BoardLine), selectedLineValue))
            {
                Console.WriteLine("Invalid Board Line.");
                return;
            }
            BoardLine selectedLine = (BoardLine)selectedLineValue;

            Card newCard = new Card(title, content, assignedPerson, selectedSizeType, selectedLine);
            cardList.Add(newCard);

            Console.WriteLine("Card added successfully.");

        }
        public void showAllPerson()
        {
            Console.WriteLine("------Kişiler------");
            foreach (Person person in personList)
            {
                Console.WriteLine("Ad: " + person.Name);
                Console.WriteLine("Soyad:  " + person.Surname);
                Console.WriteLine("ID:  " + person.Id1);
                Console.WriteLine("-------------------");
            }
        }
        public  void ListCards()
        {
            Console.WriteLine("Card List:");
            foreach (Card card in cardList)
            {
                Console.WriteLine("Title: " + card.Title);
                Console.WriteLine("Content: " + card.Content);
                Console.WriteLine("Assigned Person: " + card.AssignedPerson.Name);
                Console.WriteLine("Card Size: " + card.CardSize);
                Console.WriteLine("Board Line: " + card.Line);
                Console.WriteLine("--------------------");
            }
        }
    }
}
