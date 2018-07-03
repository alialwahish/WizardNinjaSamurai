using System;
namespace Human{


public class Wizard : Human{
        public Wizard(string wizardName):base(wizardName){
            this.name=wizardName;
            this.health=50;
            this.intelligence=25;

        }   

        public void heal(){
            Console.WriteLine("Wizard Healing");
            this.intelligence-=1;
            this.health+=10;
        }   

        public void fireBall(Human rhs){
            Random rand=new Random();
            rhs.health-=rand.Next(20,50);
        }
        
        
        
        
        }
}