using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeFunction
{
    /// <summary>
    /// 
    /// <variable name = 'X' id="X">X = 1</variable>
    /// </summary>
    public enum Symbol
    {
        X = 1,
        Y = 2,
        ADD = 3,
        SUB = 4,
        MUL = 5,
        DIV = 6,
        MOD = 7,
        COS = 8,
        SIN = 9,
        TAN = 10,
        LOG = 11,
        EXP = 12,
        POP = 13,
        PCL = 14
    }

    public class Function
    {
        Symbol x;
        Symbol y;
        Symbol[] _expression;

        public Function()
        {
            
        }
    }


    public struct Coordinate
    {
        int x;
        int y;

        public Coordinate(int x, int y)
        {
            this.x = 0;
            this.y = 0;
        }
    }

    public partial class MyFunction
    {
        public MyFunction()
        {
            
        }



        private void makeFunction()
        {
            
        }
    }
}
