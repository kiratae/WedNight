using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHunt.WedNight.Model
{
    public class ResultPaging
    {
        public ResultPaging(int itemPerPage, int pageNo)
        {
            ItemPerPage = itemPerPage;
            PageNo = pageNo;
        }

        public int ItemPerPage { get; set; }

        public int PageNo { get; set; }

        public int TotalItem { get; set; }

        public bool NoCounting { get; set; }
    }
}
