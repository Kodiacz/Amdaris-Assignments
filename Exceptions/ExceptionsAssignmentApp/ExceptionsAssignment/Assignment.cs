namespace ExceptionsAssignment
{
    public class Assignment
    {
        private string name;

        public Assignment(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Need to give a name to the Assignment");
                }

                name = value;
            }
        }
    }
}
