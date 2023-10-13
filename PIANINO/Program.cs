using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите ноту (Q, A, Z, W, S, X, E) или 'exit' для выхода:");
            string note = Console.ReadLine();

            if (note.ToLower() == "exit")
            {
                break;
            }

            PlayNoteOnConsole(note);
        }
    }

    static void PlayNoteOnConsole(string note)
    {
        switch (note.ToUpper())
                   {
            case "Q":
                Console.Beep(261, 500); 
                break;
            case "A":
                Console.Beep(293, 500); 
                break;
            case "Z":
                Console.Beep(329, 500); 
                break;
            case "W":
                Console.Beep(349, 500); 
                break;
            case "S":
                Console.Beep(392, 500); 
                break;
            case "X":
                Console.Beep(440, 500); 
                break;
            case "E":
                Console.Beep(494, 500); 
                break;
            default:
                Console.WriteLine("НЕ туда жмал");
                break;
        }
    }
}