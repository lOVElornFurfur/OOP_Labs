using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Magic<T> : List<T>, IMagi<T> where T : class
    {
        private double _damage;
        private double _mana;
        private T _classOfMagic; //123 legendary mythical

        public Magic()
        {

        }
        public Magic(double damage, double mana, T classOfMagic)
        {
            _damage = damage;
            _mana = mana;
            _classOfMagic = classOfMagic;
        }

        List<T> magicList = new List<T>();

        public double Damage { get => _damage; set => _damage = value; }
        public double Mana { get => _mana; set => _mana = value; }
        public T ClassOfMagic { get => _classOfMagic; set => _classOfMagic = value; }

        public void ADD(double obj)
        {
            if (_mana <= 0)
            {
                throw new Exception("Недостаточно маны");
            }
            else _mana = obj;
        }

        public void ADD(T obj)
        {
            _classOfMagic = obj;
            magicList.Add(obj);
            
            
                if (_classOfMagic is string)
                {
                    _damage += _classOfMagic.GetHashCode() % 100;
                    Console.WriteLine($"Current damage of class {_classOfMagic} spell = {_damage}");
                }
                else throw new FormatException("Non-existing spell");
            
            
        }
        public void Delete(T obj)
        {
            magicList.Remove(obj);
            Console.WriteLine($"Your spells after deleting: ");
            LookThrough();
        }
        public void LookThrough()
        {
            
            foreach (var item in magicList)
            {
                Console.Write($"{item} ");
                Console.WriteLine();
            }
        }
    }
}
