using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Duc Tran
 * Professor Frank Friedman
 * CIS 3309 - Final Submission Bingo Project
 * Last Updated: 2/06/2019
 */

namespace Bingo.Class
{

    /*
     * Primarily used as a constructor for the player storing his/her name
     * into the Player object
     */

    class Player
    {

        public string name;

        public Player(string name)
        {
            this.name = name;
        }
    }
}
