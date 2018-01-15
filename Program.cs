using System;
using LilLego.Rockband;

namespace LilLego
{
    class Program
    {
        static void Main(string[] args)
        {
            var rockPowerChallenges = new RockPowerChallenges
            {
                Type = "Riff Challenge",
                Defeat = "Defeating the Giant Octopus",
                IsDefeated = true
            };
            rockPowerChallenges.Defeating(rockPowerChallenges.IsDefeated);
        }
    }
}
