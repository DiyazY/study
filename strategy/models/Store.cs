using System;

namespace strategy.models
{
    public class Store
    {
        private IOwner _owner;
        private int _storeNumber;
        public Store(int storeNumber)
        {
            _storeNumber = storeNumber;
        }

        public void setOwner(IOwner owner){
            _owner = owner;
        }

        public void Sale(string good){
            if(_owner==null){
                System.Console.WriteLine($"Store is empty((( ");
            }else{
                System.Console.WriteLine($"Store number: {_storeNumber}");
                _owner?.Sale(good);
            }
        }
    }
}
