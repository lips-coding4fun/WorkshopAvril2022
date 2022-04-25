using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding4FunWorkshop.Snippets
{
    public class Records
    {
    }

    #region try-records
    // Sans modifier CheckRecords, comment faire pour que 
    public class CheckRecords
    {
        public static bool IsSamePage(CapturedPage pageA, CapturedPage pageB)
        {
            return pageA.Address == pageB.Address;
        }
    }

    public class CapturedPage
    {
        public PageAddress Address;
        public DateTime ScrapTime;
        public byte[] Content;
    }
    public class PageAddress
    {
        public string Domain;
        public string PageUri; 
    }
    #endregion
    
}
