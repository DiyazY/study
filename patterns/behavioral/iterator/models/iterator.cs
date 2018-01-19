using System;

namespace iterator.models
{
    public interface IIterator
    {
        IProfile Next();
        bool HasNext();
    }

    public interface ISocialNetworkNumerable
    {
        IIterator CreateFriendsIterator();
        IIterator CreateKithIterator();
        int Count { get; }
        IProfile this[int index] { get;}
    }

    public interface IProfile
    {
        string getName();
        bool isFriend{get;}
    }
    public class Profile : IProfile
    {
        private string _name;
        bool _isFriend;
        public Profile(string name,bool isFriend=false){
            _name = name;
            _isFriend = isFriend;
        }

        public bool isFriend =>_isFriend;

        public string getName()=>_name;
    }

    public class Facebook : ISocialNetworkNumerable
    {
        public readonly IProfile[] _profiles;

        public Facebook()
        {
            _profiles = new Profile[]{
                new Profile("Smit",true),
                new Profile("John"),
                new Profile("Mike",true),
                new Profile("Diyaz")
            };
        }

        public IProfile this[int index] => _profiles[index];

        public int Count => _profiles.Length;

        public IIterator CreateFriendsIterator()=> new FriendsNumerator(this);

        public IIterator CreateKithIterator()=>new KithNumerator(this);
    }

    public class PeopleNumerator : IIterator
    {
        private readonly ISocialNetworkNumerable _aggregate;
        int index=0;
        public PeopleNumerator(ISocialNetworkNumerable aggregate)
        {
            _aggregate=aggregate;
        }

        public bool HasNext()=>index<_aggregate.Count;

        public IProfile Next()=>_aggregate[index++];
    }

    public class FriendsNumerator : IIterator
    {
        private readonly ISocialNetworkNumerable _aggregate;
        int index=0;
        int _count=0;
        public FriendsNumerator(ISocialNetworkNumerable aggregate)
        {
            _aggregate=aggregate;
        }
        public bool HasNext(){
            //this condition can be removed if you work with dynamically list
            if(_count==0){
                int count =0; 
                for(int i=0;i<_aggregate.Count;i++){
                    if(_aggregate[i].isFriend)
                        count++;
                }
                _count = count;
            }
            return index<_count;  
        }

        public IProfile Next(){
            index++;
            for(int i=index;i<_aggregate.Count;i++){
                if(_aggregate[i].isFriend){
                    index = i;
                    return _aggregate[i];                  
                }
            }
            return null;  
        }
    }

    public class KithNumerator : IIterator
    {
        private readonly ISocialNetworkNumerable _aggregate;
        int index=0;
        int _count = 0;
        public KithNumerator(ISocialNetworkNumerable aggregate)
        {
            _aggregate=aggregate;
        }

         public bool HasNext(){
            //this condition can be removed if you work with dynamically list
            if(_count==0){
                int count =0; 
                for(int i=0;i<_aggregate.Count;i++){
                    if(_aggregate[i].isFriend)
                        count++;
                }
                _count = count;
            }
            return index<_count;  
        }

        public IProfile Next(){
            index++;
            for(int i=index;i<_aggregate.Count;i++){
                if(!_aggregate[i].isFriend){
                    index = i;
                    return _aggregate[i];                  
                }
            }
            return null; 
        }
    }

    public class Spamer{
        public void SpamFriends(ISocialNetworkNumerable sn){
             IIterator iterator = sn.CreateFriendsIterator();
             System.Console.WriteLine("Friends:");
            while(iterator.HasNext())
            {
                IProfile profile = iterator.Next();
                Console.WriteLine($"--{profile.getName()}");
            }
        }
        public void SpamKith(ISocialNetworkNumerable sn){
            IIterator iterator = sn.CreateKithIterator();
            System.Console.WriteLine("Kith:");
            while(iterator.HasNext())
            {
                IProfile profile = iterator.Next();
                Console.WriteLine($"--{profile.getName()}");
            }
        }
    }




}
