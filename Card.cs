using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    /// <summary>
    /// The Card class represents a Card
    /// </summary>
    class Card
    {
        //private variables can only be accessed by the class
        //this prevents other programmers from changing the value
        private int id = 0;

        /// <summary>
        /// Constructor method - used to create the card
        /// </summary>
        /// <param name="i">A number that sets the card face and suit</param>
        public Card(int i)
        {
            id = i;
        }

        /// <summary>
        /// Uses the id to determine the Face - note you
        /// can only get the value, not set it.
        /// </summary>
        public FaceValue faceValue {
            get {
                return (FaceValue)(id % 13);
            }
        }

        /// <summary>
        /// Uses the id to determine the Suit - note you 
        /// can only get the value, not set it
        /// </summary>
        public SuitValue suitValue {
            get {
                return (SuitValue)(id / 13);
            }
        }

        /// <summary>
        /// All objects inherit from the Object class
        /// You can override the ToString method so it shows useful info.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.faceValue.ToString() + " of " + suitValue.ToString();
        }
    }
}
