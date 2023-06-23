using ToDo;

public class Program
{
    private static void Main(string[] args)
    {
        ToDomanager toDomanager = new ToDomanager();
        while (true)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Add todo");
            Console.WriteLine("2. Show person");
            Console.WriteLine("3. List Cards");
            Console.WriteLine("4. Update Cards");
            Console.WriteLine("5. Delete Cards");
            Console.WriteLine("6. Exit");
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
                    toDomanager.ListCards();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}