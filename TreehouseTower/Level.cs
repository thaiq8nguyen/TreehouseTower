using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseTower
{
    class Level
    {
        private readonly Invader[] _invaders;
        

        public Tower[] Towers { get; set; }
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        //Returns: true if the player wins, false otherwise;
        public bool Play()
        {
            int remainingInvaders = _invaders.Length;
            
            while(remainingInvaders > 0)
            {
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvader(_invaders);
                }
                remainingInvaders = 0;

                foreach(Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                    
                }
            }
            return true;

            
        }
    }
}
