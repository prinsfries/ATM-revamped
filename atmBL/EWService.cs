using atmDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmBL
{
    public class EWService
    {
        public bool VerifyPin(string EWPin)
        {
            EWDataServices eWDataService = new EWDataServices();
            var result = eWDataService.GetEWallet(EWPin);
            return result.EWPin != null ? true : false;
        }
    }
}
