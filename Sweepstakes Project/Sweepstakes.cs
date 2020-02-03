using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary;
        private string name;
        private int registrationNumber;
        private Random random;

        public string Name { get => name; set => name = value; }
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
            name = null;
            random = new Random();
        }
        private void RegisterContestant(Contestant contestant)
        {
            RegistrationNumber = dictionary.Count();
            dictionary.Add(RegistrationNumber, contestant);
        }
        private void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
            Console.Clear();
        }
        private string PickWinner()
        {
            int winningContestant;
            string name;

            winningContestant = random.Next(1, dictionary.Count());
            for (int i = 0; i < dictionary.Count(); i++)
            {
                if (winningContestant == dictionary.ElementAt(i).Key)
                {
                    name = dictionary.ElementAt(i).Value.FirstName + dictionary.ElementAt(i).Value.LastName;
                    return name;
                }
            }
            throw new ApplicationException("If you're seeing this....It's my fault sorry...");
        }
    }
}
