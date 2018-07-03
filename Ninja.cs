namespace Human{



        public class Ninja : Human{

            public Ninja(string ninjaName):base(ninjaName){
                this.name=ninjaName;
                this.dexterity=175;
            }

            public void stealth(Human rhs){
                this.health+=10;
            }
            public void get_away(){
                this.health-=15;
            }
        }

}