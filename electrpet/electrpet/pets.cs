using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrpet
{
    public class Pets
    {
        private readonly DateTime _bd = DateTime.Now;
        private string _name;
        private int _heath=0;
        public TimeSpan Age { get { return (DateTime.Now - _bd); } }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Имя уже присвоено!");
                }
            }
        }
        public int Feed()
        {
            return (_heath++);
        }
        public int Punish()
        {
            return (_heath -= 1);
        }    
        public string Color()
        {
            if (_heath > 5)
            {
                return ("зеленый");
            }
            else if (_heath == 5)
            {
                return ("желтый");
            }
            else
            {
                return ("красный");
            }
        }
      }
}
