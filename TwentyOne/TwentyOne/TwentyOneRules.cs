using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);  // counts aces in hand
            int[] result = new int[aceCount + 1];                // creates a new list with enough slots to hold our hand value plus alternate aces
            int value = Hand.Sum(x => _cardValues[x.Face]);      // adds up the value of your hand based on the _cardValue
            result[0] = value;                                   // adds our hand value to result list
            if (result.Length == 1) return result;               // if we dont have any aces then our result is final and can be returned
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);                               // adds new values to our result list for each ace
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }
    }
}
