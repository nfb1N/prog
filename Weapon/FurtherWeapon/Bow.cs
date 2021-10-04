namespace Weapon{
using Soldiers;
   public class Bow : WeaponAbstruct{
       public float Power { get; set; }
       
       
       private float Range;
       public float RangeProp
       {
           get { return Range; }
           set { Range = Power/(System.Math.Abs(value*value)+1); }
       }
            
        public Bow() : base(10){

        }

        public int Hit(Soldier owner,Soldier enemy){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

   }
}