using System;
using adapter.models;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hole = new RoundHole(5);
            var rpeg = new RoundPeg(5);
            System.Console.WriteLine($"RoundPeg Fits (hole:5;peg:5)={hole.Fits(rpeg)}");
            hole.Fits(rpeg);

            var small_sqpeg = new SquarePeg(2);
            var large_sqpeg = new SquarePeg(8);
            //hole.fits(small_sqpeg); compilation error
            

            var small_sqpeg_adapter = new SqurePegAdapter(small_sqpeg);
            var large_sqpeg_adapter = new SqurePegAdapter(large_sqpeg);
            System.Console.WriteLine($"SquarePeg Fits (hole:5;peg:2)={hole.Fits(small_sqpeg_adapter)}");
            System.Console.WriteLine($"SquarePeg Fits (hole:5;peg:8)={hole.Fits(large_sqpeg_adapter)}");
        }
    }
}
