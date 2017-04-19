using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseTower
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;

        private static readonly Random _random = new Random();
        private const double _accuracy = .75;

        public Tower(MapLocation location)
        {
            _location = location;
        }
        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvader(Invader[] invaders)
        {


            

            foreach(Invader invader in invaders)
            {
                if(invader.IsActive &&_location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    
                }
            }
        }
    }
}
