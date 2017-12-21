using System.Collections.Generic;

namespace Maze
{
    internal class Player : Entity
    {
        #region Private Fields

        private bool aggro;
        private int damage;
        private int HP;
        private int id;
        private List<Weapon> weapons;

        #endregion Private Fields

        #region Public Constructors

        public Player()
        {
            id = 0;
            weapons = new List<Weapon>();
            HP = 100;
            aggro = false;
            damage = 10;
        }

        #endregion Public Constructors

        #region Public Properties

        public bool Aggro
        {
            get { return aggro; }
            set { aggro = value; }
        }

        public int Hp
        {
            get { return HP; }
            set { HP = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion Public Properties

        #region Public Methods

        public void Attack(Player ennemy)
        {
            if (ennemy.HP >= damage && weapons[0].Damage>0)
            {
                ennemy.HP -= damage;
                weapons[0].Damage -= 1;
                damage -= 1;
            }
            else if(weapons[0].Damage==0 && weapons[1]!= null)
            {
                damage += weapons[1].Damage;
                weapons.RemoveAt(0);
                ennemy.HP -= damage;
                weapons[0].Damage -= 1;
                damage -= 1;
            }
            else if(ennemy.HP < damage)
            {
                weapons[0].Damage -= 1;
                damage -= 1;
                ennemy.HP = 0;
            }
        }

        public void GrabWeapon(Weapon weapon)
        {
            weapons.Add(weapon);
            if (aggro==false)
            {
                aggro = true;
            }
            if (weapons[1]==null)
            {
                damage += weapon.Damage;
            }
            
        }

        #endregion Public Methods
    }
}