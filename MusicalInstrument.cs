using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public abstract class MusicalInstrument
    {
        protected string _name;
        protected string _sound;
        protected string _description;
        protected string _history;

        public MusicalInstrument(string name, string sound, string description, string history)
        {
            _name = name;
            _sound = sound;
            _description = description;
            _history = history;
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }

}
