using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idm_clone_2
{
    class Validation
    {
        private IValidationStragegy validateSta;

        public void setValidationStragegy(IValidationStragegy sta)
        {
            this.validateSta = sta;
        }

        public Boolean checkValidate(string s)
        {
            return validateSta.validate(s);
        }
       
    }
}
