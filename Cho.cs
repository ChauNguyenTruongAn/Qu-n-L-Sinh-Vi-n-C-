using System;
class Man{
    string Name;
    int Age;
    public Man(){
        Name = "";
        Age = "";
    }    

    public Man(string Name, int Age){
        this.Name = Name;
        this.Age = Age;
    }

    public void Show(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }

    public int Age{
        set{this.Age = value;}
        get{return this.Age}
    }
    //COn cho rah

}

