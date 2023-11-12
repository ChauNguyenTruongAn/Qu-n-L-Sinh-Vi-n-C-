using System;
namespace An{
    class Man{
        private string Name;
        private int Age;
        public Man(){
            this.Name = "";
            this.Age = 0;
        }    

        public Man(string Name, int Age){
            this.Name = Name;
            this.Age = Age;
        }

        public void Show(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        public int AGE
        {
            set{this.Age = value;}
            get{return this.Age;}
        }
    }
}