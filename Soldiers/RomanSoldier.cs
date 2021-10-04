namespace Soldiers{
     using Weapon;
    public class RomanSoldier : Soldier{
        public RomanSoldier(string name) : base (name, 100, 12, new Bastard(),new Shields.Shield()){

        }

        public  override void Atack(Soldier enemy){
          this.Weapon.Hit(this, enemy);
          this.Weapon.Hit(this, enemy);
        }
        public  override void Defend(Soldier enemy){
            this.SoldierShield?.Defend(this, enemy.Weapon.Damage);
        }
    }
}