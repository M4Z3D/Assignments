using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack.Model
{
    public struct Card
    {
        public string Suit { get; set; }
        public string FaceValue { get; set; }

        public override string ToString()
        {
            return $"{FaceValue} of {Suit}";
        }
    }

    
}