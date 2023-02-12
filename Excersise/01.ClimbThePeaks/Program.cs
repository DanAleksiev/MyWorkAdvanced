namespace _01.ClimbThePeaks
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int[] dailyPortions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //last
            int[] dailyStamina = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();//first
            Stack<int> portionS = new Stack<int>(dailyPortions);
            Queue<int> staminaS = new Queue<int>(dailyStamina);

            List<string> peaks = new();
            peaks.Add("Vihren - 80");
            peaks.Add("Kutelo - 90");
            peaks.Add("Banski Suhodol - 100");
            peaks.Add("Polezhan - 60");
            peaks.Add("Kamenitza - 70");

            int days = 7;
            int peaksConquerd = 0;
            while (portionS.Count != 0 && peaksConquerd < peaks.Count)
                {
                int portion = portionS.Pop();
                int stamina = staminaS.Dequeue();
                int sum = portion + stamina;
                string[] currentRequirments = peaks[peaksConquerd].Split(" - ");
                if (sum >= int.Parse(currentRequirments[1]))
                    {
                    peaksConquerd++;
                    }
                else
                    {
                    days--;
                    if (days == 0)
                        {
                        break;
                        }
                    }

                }
            if (peaks.Count == peaksConquerd)
                {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
                }
            else
                {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
                }

            if (peaksConquerd > 0) { Console.WriteLine("Conquered peaks:"); }
            for (int i = 0; i < peaksConquerd; i++)
                {
                string[] currentPeak = peaks[i].Split(" - ");
                Console.WriteLine(currentPeak[0]);
                }
            }
        }
    }