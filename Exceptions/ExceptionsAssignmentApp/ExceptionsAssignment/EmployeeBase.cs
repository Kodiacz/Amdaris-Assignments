namespace ExceptionsAssignment
{
    using ExceptionsAssignment.Contracts;
    using ExceptionsAssignment.Exceptions;
    using System.Linq;

    public abstract class EmployeeBase : IEmployee
    {
        private string firtsName;
        private string lastName;
        private string phonenumber;

        public string FirstName
        {
            get
            {
                return firtsName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"{nameof(this.FirstName)} cannot be null");
                }

                if (!char.IsUpper(value[0]))
                {
                    throw new WrongNameException("Name should start with uppercase letter");
                }

                firtsName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"{nameof(this.LastName)} cannot be null");
                }

                if (!char.IsUpper(value[0]))
                {
                    throw new WrongNameException("Name should start with uppercase letter");
                }

                lastName = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return phonenumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"{nameof(this.Phonenumber)} cannot be null");
                }

                if (!value.All(c => char.IsDigit(c)))
                {
                    throw new WrongPhonenumberException($"{nameof(this.Phonenumber)} should contain only digits");
                }

                phonenumber = value;
            }
        }
    }
}
