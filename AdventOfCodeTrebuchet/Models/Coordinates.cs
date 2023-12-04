using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeTrebuchet.Models
{
    public class Coordinates
    {
        public string MixedCoordinates { get; set; }    
        public int Coords {  get; set; } = 0;

        public Coordinates(string mixedCoordintes)
        {
            MixedCoordinates = mixedCoordintes;
            Coords = GetCords(mixedCoordintes);
        }

        private static int GetCords(string mixedCoordinates)
        {
            string numbers = "";
            List<int> coordinates = new List<int>();
            foreach (var symbol in mixedCoordinates)
            {
                if (Char.IsDigit(symbol))
                {
                    numbers += symbol.ToString();
                }
            }
            if(numbers.Length == 0 || !Char.IsDigit(numbers[0])) 
            {
                return 0;
            }
            if (numbers.Length == 1) 
            { 
                return Convert.ToInt32(numbers + numbers);
            }

            var answer = Convert.ToInt32((numbers.Substring(0,1) + numbers.Substring(numbers.Length - 1)));
            return answer;
        }
    }
}
