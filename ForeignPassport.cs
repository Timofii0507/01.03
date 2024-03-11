using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class ForeignPassport : Passport
    {
        private string _foreignPassportNumber;
        private List<Visa> _visas;

        public ForeignPassport(string firstName, string lastName, string nationality, string passportNumber, DateTime issueDate, DateTime expirationDate, string foreignPassportNumber)
            : base(firstName, lastName, nationality, passportNumber, issueDate, expirationDate)
        {
            _foreignPassportNumber = foreignPassportNumber;
            _visas = new List<Visa>();
        }

        public string ForeignPassportNumber
        {
            get => _foreignPassportNumber;
            set => _foreignPassportNumber = value;
        }

        public List<Visa> Visas
        {
            get => _visas;
        }

        public void AddVisa(Visa visa)
        {
            _visas.Add(visa);
        }

        public override string ToString()
        {
            string visasInfo = "";
            foreach (Visa visa in _visas)
            {
                visasInfo += visa.ToString() + "\n";
            }

            return base.ToString() + "\n" +
                   $"Номер закордонного паспорта: {_foreignPassportNumber}\n" +
                   $"Візи:\n" +
                   visasInfo;
        }
    }
}
