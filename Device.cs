using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public abstract class Device
    {
        protected string _name;

        public Device(string name)
        {
            _name = name;
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();

        public string GetName()
        {
            return _name;
        }
    }

}
