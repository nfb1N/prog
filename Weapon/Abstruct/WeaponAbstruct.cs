namespace Weapon{
    using Soldiers;
   public class WeaponAbstruct : IWeapon{
        public int HP_Level { get; private set; }
       
        public int Damage { get; private set; }
       
        protected WeaponAbstruct(int damage)
        {
            this.HP_Level= 100;
            this.Damage = damage;
        }
        public int Hit(Soldier owner,Soldier enemy){
             owner.Defend(enemy);
             return --this.HP_Level;
        }

    }
}