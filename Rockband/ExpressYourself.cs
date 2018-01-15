using System;


namespace LilLego.Rockband
{
    class ExpressYourself
    {
        protected string _type;
        protected int _challengesCompleted;
        protected string _hair;
        protected string _clothing;
        protected bool _upgradeNewLook;

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
        public int ChallengesCompleted
        {
            get
            {
                return _challengesCompleted;
            }
            set
            {
                _challengesCompleted = 3;
            }
        }
        public string Hair
        {
            get
            {
                return _hair;
            }
            set
            {
                _hair = value;
            }
        }
        public string Clothing
        {
            get
            {
                return _clothing;
            }
            set
            {
                _clothing = value;
            }
        }
        public bool UpgradeNewLook
        {
            get
            {
                return _upgradeNewLook;
            }
            set
            {
                if (value)
                {
                    _upgradeNewLook = true;
                }
                if (!value)
                {
                    _upgradeNewLook = false;
                }
            }
        }
        public ExpressYourself()
        {
            Hair = "Ponytail";
        }
        public bool Upgrading(bool upgradeNewLook)
        {
            Console.WriteLine($"Wowww, you completed {_challengesCompleted} challenges and get to {_type} to a {_hair} hairstyle and {_clothing}");
            Console.ReadLine();
            
            if (upgradeNewLook)
            {
                _upgradeNewLook = true;
                return true;
            }
                _upgradeNewLook = false;
                return false;
        }
    }
}
