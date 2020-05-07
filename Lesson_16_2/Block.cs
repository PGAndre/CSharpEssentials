using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_2
{
    class Block
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public Block(int side1, int side2,int side3,int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;              
        }

        public override bool Equals(object obj)
        {
            if (obj is Block block)
            {
                return (Side1 == block.Side1) && (Side2 == block.Side2) && (Side3 == block.Side3) && (Side4 == block.Side4);
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Параметры блока: " + Side1 + " * " + Side2 + " * " + Side3 + " * " + Side4;
        }

        public override int GetHashCode()
        {
            return Side1 ^ Side2 ^ Side3 ^ Side4;
        }
    }
}
