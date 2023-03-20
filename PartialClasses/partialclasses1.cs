using System;

namespace Evaluation6
{
    public partial class Debmalya
    {

        private string? _firstName;

        public string FirstName
        {
            set
            {
                if (value == null)
                    throw new Exception(" first name cannot be null");
                _firstName = value;
            }
            get
            {
                return _firstName!;
            }
        }
        public partial void GetSalary();
        }
}