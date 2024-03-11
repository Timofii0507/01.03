using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03
{
    public class Passport
    {
        private string _firstName;
        private string _lastName;
        private string _nationality;
        private string _passportNumber;
        private DateTime _issueDate;
        private DateTime _expirationDate;

        public Passport(string firstName, string lastName, string nationality, string passportNumber, DateTime issueDate, DateTime expirationDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _nationality = nationality;
            _passportNumber = passportNumber;
            _issueDate = issueDate;
            _expirationDate = expirationDate;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Nationality
        {
            get => _nationality;
            set => _nationality = value;
        }

        public string PassportNumber
        {
            get => _passportNumber;
            set => _passportNumber = value;
        }

        public DateTime IssueDate
        {
            get => _issueDate;
            set => _issueDate = value;
        }

        public DateTime ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public override string ToString()
        {
            return $"ПІБ: {_lastName} {_firstName}\n" +
                   $"Національність: {_nationality}\n" +
                   $"Номер паспорта: {_passportNumber}\n" +
                   $"Дата видачі: {_issueDate.ToString("dd.MM.yyyy")}\n" +
                   $"Дата закінчення дії: {_expirationDate.ToString("dd.MM.yyyy")}";
        }
    }

}
