namespace Soldiers{
    using Weapon;
    public class SamuraiSoldier : Soldier{
        protected System.Random r;
        public SamuraiSoldier(string name) : base (name, 70, new Katana()){ this.r = new System.Random(); }

        public  override void Atack(Soldier enemy){
            this.Weapon.Hit(this, enemy);
        }
        public  override void Defend(Soldier enemy){
            System.Console.WriteLine($"Text");
            var a = r.Next(0, enemy.Weapon.Damage);
            System.Console.WriteLine($"{a}");
            
            this.HP -= (enemy.Weapon.Damage - a);   
        }
    }
}