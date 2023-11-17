namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is my favorite subject too!");
                    break;
                case "science":
                    Console.WriteLine("Science is really tough!");
                    break;
                case "english":
                    Console.WriteLine("Ooo, English is very fascinating!");
                    break;
                case "lunch":
                    Console.WriteLine("Hey! Isn't that cheating?");
                    break;
                case "history":
                    Console.WriteLine("History is a great way to learn about the past!");   
                    break;
                default:
                    Console.WriteLine("I've never taken that subject before! Very cool!");
                    break;    
            }
        }
    }
}