using System;

namespace LilLego.Rockband
{
    class RockPowerChallenges
    {
        protected string _type;
        protected string _defeat;
        protected bool _isDefeated;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string Defeat
        {
            get
            {
                return _defeat;
            }
            set
            {
                _defeat = value;
            }
        }
        public bool IsDefeated
        {
            get
            {
                return _isDefeated;
            }
            set
            {
                if (value)
                {
                    _isDefeated = true;
                }
                if (!value)
                {
                    _isDefeated = false;
                }
            }
        }
        public RockPowerChallenges()
        {
            Defeat = "Summoning a storm";
        }
        public bool Defeating(bool isDefeated)
        {
            Console.WriteLine($"You have unlocked a {_type} by {_defeat}");
            Console.ReadLine();
            if (isDefeated)
            {
                _isDefeated = true;
                return true;
            }
            _isDefeated = false;
            return false;
        }
    }
}
