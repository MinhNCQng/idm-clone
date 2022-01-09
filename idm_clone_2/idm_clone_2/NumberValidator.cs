using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    class NumberValidator : IValidationStragegy
    {
        public bool validate(string s)
        {
            int n;
            bool isNumeric = int.TryParse(s, out n);
            return isNumeric;
        }
    }
}
