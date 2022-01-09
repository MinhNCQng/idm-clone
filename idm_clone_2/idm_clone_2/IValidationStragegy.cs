using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    public interface IValidationStragegy
    {
        Boolean validate(string s);
    }
}
