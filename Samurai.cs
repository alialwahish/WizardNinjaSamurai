namespace Human{

        public class Samurai : Human{

            public Samurai(string samuraiName):base(samuraiName){
                this.health=200;
            }
            public void death_blow(Human rhs){
                if(rhs.health<=50){
                    rhs.health=0;
                }
                else{
                    rhs.health-=50;
                }
            }
            public void meditate(){
                this.health=200;
            }
        }


}