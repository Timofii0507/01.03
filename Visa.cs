using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Visa
    {
        private string _country;
        private DateTime _entryDate;
        private DateTime _expirationDate;

        public Visa(string country, DateTime entryDate, DateTime expirationDate)
        {
            _country = country;
            _entryDate = entryDate;
            _expirationDate = expirationDate;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public DateTime EntryDate
        {
            get => _entryDate;
            set => _entryDate = value;
        }

        public DateTime ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public override string ToString()
        {
            return $"Країна: {_country}\n" +
                   $"Дата в'їзду: {_entryDate.ToString("dd.MM.yyyy")}\n" +
                   $"Дата закінчення дії: {_expirationDate.ToString("dd.MM.yyyy")}";
        }
    }

}
