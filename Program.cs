using ToDo;

public class Program
{
    private static void Main(string[] args)
    {
        ToDomanager toDomanager = new ToDomanager();
        while (true)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Add Card");
            Console.WriteLine("2. Show Person");
            Console.WriteLine("3. List Cards");
            Console.WriteLine("4. Update Card");
            Console.WriteLine("5. Delete Card");
            Console.WriteLine("6. Move Card");
            Console.WriteLine("7. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    toDomanager.AddCard();
                    break;
                case 2:
                    toDomanager.showAllPerson();
                    break;
                case 3:
                    toDomanager.ListCardsByLine();
                    break;
                case 4:
                    toDomanager.UpdateCard();
                    break;
                case 5:
                    toDomanager.DeleteCard();
                    break;
                case 6:
                    toDomanager.MoveToNextLine();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}