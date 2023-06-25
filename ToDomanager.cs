using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        DefaultCard defaultCard = new DefaultCard();

        public ToDomanager()
         {
            foreach (Person person in personList)
            {
                defaultCard.personList.Add(person);
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
            foreach (var person in defaultCard.personList)
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
            defaultCard.cardList.Add(newCard);
            
            Console.WriteLine("Card added successfully.");

        }
        public void showAllPerson()
        {
            Console.WriteLine("------Kişiler------");
            foreach (Person person in defaultCard.personList)
            {
                Console.WriteLine("Ad: " + person.Name);
                Console.WriteLine("Soyad:  " + person.Surname);
                Console.WriteLine("ID:  " + person.Id1);
                Console.WriteLine("-------------------");
            }
        }
        public void ListCardsByLine()
        {
            Console.WriteLine("Card List - All Lines:");
            foreach (Board.BoardLine line in Enum.GetValues(typeof(Board.BoardLine)))
            {
                Console.WriteLine($"--- {line} Line ---");
                foreach (Card card in defaultCard.cardList)
                {
                    if (card.Line == line)
                    {
                        
                        Console.WriteLine("Title: " + card.Title);
                        Console.WriteLine("Content: " + card.Content);
                        Console.WriteLine("Assigned Person: " + card.AssignedPerson.Name);
                        Console.WriteLine("Card Size: " + card.CardSize);
                        Console.WriteLine("--------------------");
                    }
                }
            }
        }
        public void UpdateCard()
        {
            Console.WriteLine("Enter the index of the card to update:");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index >= 0 && index < defaultCard.cardList.Count)
            {
                Console.WriteLine("Enter new content:");
                string newContent = Console.ReadLine();

                defaultCard.cardList[index].Content = newContent;
                Console.WriteLine("Content updated.");

                Console.WriteLine("Enter new title:");
                string newTitle = Console.ReadLine();

                defaultCard.cardList[index].Title = newTitle;
                Console.WriteLine("Title updated.");

            }
        }
        public void MoveToNextLine()
        {
            Console.WriteLine("Enter the index of the card to update:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < defaultCard.cardList.Count)
            {
                Console.WriteLine("Enter new line:");
                string newLine = Console.ReadLine();

                if (newLine.ToUpper() == "DONE")
                {
                    defaultCard.cardList[index].Line = Board.BoardLine.DONE;
                }
                else if (newLine.ToUpper() == "INPROGRESS")
                {
                    defaultCard.cardList[index].Line = Board.BoardLine.INPROGRESS;
                }
                else if (newLine.ToUpper() == "TODO")
                {
                    defaultCard.cardList[index].Line = Board.BoardLine.TODO;
                }
            }
            else
            {
                Console.WriteLine("Invalid index entered.");
            }

        }
        public void DeleteCard()
        {
            Console.WriteLine("Enter the ID of the card to delete:");
            string title = Console.ReadLine();

            Card cardRemove = defaultCard.cardList.Find(p=>p.Title==title);
            //Card cardToDelete = null;
            //foreach (var card in defaultCard.cardList)
            //{
            //    if (card.Title == title)
            //    {
            //        cardToDelete = card;
            //        break;
            //    }
            //}

            if (cardRemove != null)
            {
                defaultCard.cardList.Remove(cardRemove);
                Console.WriteLine("Card deleted successfully.");
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

       

    }
}

