using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    class UrlValidator : IValidationStragegy
    {
        public bool validate(string s)
        {
            return Uri.IsWellFormedUriString(s, UriKind.Absolute) == true;
        }
    }
}
