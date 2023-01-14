using System.Text;

namespace _06.SongsQueue
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Queue<string> songs = new Queue<string>(
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songs.Any())
                {
                List<string> input = Console.ReadLine().Split().ToList();
                string action = input[0];
                switch (action)
                    {
                    case "Play":
                    songs.Dequeue();
                    break;

                    case "Show":
                    Console.WriteLine(string.Join(", ", songs));
                    break;

                    case "Add":
                    input.RemoveAt(0);
                    string currentSong = string.Join(" ", input);
                        if (songs.Contains(currentSong))
                        {
                        Console.WriteLine($"{currentSong} is already contained!");
                        }
                        else
                        {
                        songs.Enqueue(currentSong);
                        }
                    break;
                    }
                }
            Console.WriteLine("No more songs!");
            }
        }
    }