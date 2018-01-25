
using System;
using System.Collections.Generic;

namespace memento.models
{
    // Originator
    class Hero
    {
        private int patrons=10; // qty patrons
        private int lives=5; // qty lives
    
        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Shoot. Patrons: {0}", patrons);
            }
            else
                Console.WriteLine("doesn't have patrons");
        }
        // save state
        public HeroMemento SaveState()
        {
            Console.WriteLine("Save Game. Parameters: {0} patrons, {1} lives", patrons, lives);
            return new HeroMemento(patrons, lives);
        }
    
        // restore state
        public void RestoreState(HeroMemento memento)
        {
            this.patrons=memento.Patrons;
            this.lives = memento.Lives;
            Console.WriteLine("Restore game. Parameters: {0} patrons, {1} lives", patrons, lives);
        }
    }
    // Memento
    class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }
    
        public HeroMemento(int patrons, int lives)
        {
            this.Patrons = patrons;
            this.Lives = lives;
        }
    } 
    
    // Caretaker
    class GameHistory
    {
        private readonly Hero _hero;
        private Stack<HeroMemento> History { get; set; }
        public GameHistory(Hero hero)
        {
            History = new Stack<HeroMemento>();
            _hero = hero;
        }

        public void Undo(){
            _hero.RestoreState(History.Pop());
        }

        public void Save(){
            History.Push(_hero.SaveState());
        }
    }
}



