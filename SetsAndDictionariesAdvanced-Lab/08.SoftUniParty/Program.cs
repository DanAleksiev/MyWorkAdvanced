using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.SoftUniParty
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input;
            HashSet<string> guestsList = new HashSet<string>();
            bool didThePartyStart = false;
            while ((input = Console.ReadLine()) != "END")
                {
                if (input == "PARTY")
                    {
                    didThePartyStart = true;
                    }
                if (!didThePartyStart)
                    {
                    guestsList.Add(input);
                    }
                else
                    {
                    guestsList.Remove(input);
                    }
                }
            Console.WriteLine(guestsList.Count);
            List<string> noShow = new List<string>();
            List<string> VIPNoShow = new List<string>();

            if (guestsList.Count > 0)
                {
                foreach (var guest in guestsList)
                    {
                    if (char.IsDigit(guest[0]))
                        {
                        VIPNoShow.Add(guest);
                        }
                    else
                        {
                        noShow.Add(guest);
                        }
                    }
                foreach (var guest in VIPNoShow)
                    {
                    Console.WriteLine(guest);
                    }
                foreach (var guest in noShow)
                    {
                    Console.WriteLine(guest);
                    }
                }
            }
        }
    }
