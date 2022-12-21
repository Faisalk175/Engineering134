using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafarParkApp
{
    public class Person : IMoveable
    {
        //fields
        private string _firstName = "";
        private string _lastName = "";
        public readonly string _eyecolour = "";

        //property
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            init
            {
                _firstName = value;
            }
        }

        public string LastName { get; init; }   

        public int Age { get; set; } = 18;

        //backing field
        private int _height = 200;
        public int Height
        {
            // getter method must return something
            get
            {
                return _height;
            }
            // setter method (has a 'hidden' input value)
            set
            {
                if (value < _height) _height = value;
            }

        }

        

        public int GetHeight()
        {
            return _height; 
        }

        public void SetHeight(int newHeight)
        {
            if (newHeight < 0) _height = newHeight;
        }

        //method
        public virtual string FullName()  // virtual allows you to override this method
        {
            return _firstName + " " + _lastName;
        }  


        //constructor
        public Person(string firstName, string lastName, int age = 21)
        {
            _firstName = firstName;
            _lastName = lastName;   
            Age = age;  
        }

        //Method Overloading
        //Constructor overloading
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _eyecolour = "brown";
        }

        public Person() { }

        public override string ToString()
        {
            return $"{base.ToString()} {FirstName} {LastName} {_eyecolour} eyes";
        }



        private int _capacity;
        private int _numPassengers;

        public int Position { get; set; }
        public int Speed { get; init; }
        public int NumPassengers
        {
            get
            {
                return _numPassengers;

            }
            set
            {
                if (value >= 0 && value <= _capacity) _numPassengers = value;
            }
        }

        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * Speed;
            return Move() + $" {times} times";
        }
    }
}