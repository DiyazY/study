using System;

namespace adapter.models
{
    //Adapter
    class SqurePegAdapter : IRound
    {
        private readonly SquarePeg _squarePeg;

        public SqurePegAdapter(SquarePeg squarePeg){
            _squarePeg = squarePeg;
        }

        public double Radius()
        {
            var halfWidth = _squarePeg.Width()/2;
            return Math.Sqrt(Math.Pow(halfWidth,2)*2);
        }
    }


    #region Round

    interface IRound
    {
        double Radius();
    }
    class RoundHole : IRound
    {
        public double _radius { get; set; }
        public RoundHole(double radius){
            _radius=radius;
        }
        public double Radius()
        {
            return _radius;
        }

        public bool Fits(IRound Peg){
            System.Console.WriteLine($"Hole:{_radius}; Peg:{Peg.Radius()}");
            return _radius>=Peg.Radius();
        }
    }

    class RoundPeg : IRound
    {
        public double _radius { get; set; }
        public RoundPeg(double radius){
            _radius=radius;
        }
        public double Radius()
        {
            return _radius;
        }
    }
    #endregion

    #region Peg
        class SquarePeg
        {
            public double _width { get; set; }
            public SquarePeg(double width){
                _width=width;
            }

            public double Width(){
                return _width;
            }
        }
    #endregion


}
