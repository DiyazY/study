using System;
using flyweight.models;

namespace flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var forest = new Forest();
            forest.plantTree(1,2,"Dub","#5466","12-02");
            forest.plantTree(1,3,"Dub","#5466","12-02");
            forest.plantTree(1,4,"Dub","#5466","12-02");
            forest.plantTree(1,5,"Dub","#5466","12-02");
            forest.plantTree(2,1,"Bereza","#5123","12-03");
            forest.plantTree(2,2,"Bereza","#5123","12-03");
            forest.plantTree(2,3,"Bereza","#5123","12-06");
            forest.plantTree(2,4,"Bereza","#5124","12-03");
            forest.Draw("Kazakhstan");
            forest.Draw("Russia");
            forest.Draw("USA");
        }
    }
}
