using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Property & object initializer syntax in property topic//
    //public class Dept
    //    {
    //        public int DeptId { get; set; }
    //        public string DeptName { get; set; }
    //        public string Location { get; set; }
    //    }


    //Named argument//

    //public class Dept
    //    {
    //        private int deptid;
    //        private string deptname;
    //        private string location;

    //        public Dept(int deptid, string deptname, string location)
    //        {
    //            this.deptid = deptid;
    //            this.deptname = deptname;
    //            this.location = location;
    //        }
    //    }

    //
    public class Dept : IPrintable
    {
        private int deptid;
        private string deptname;
        private string location;

        public Dept(int deptid, string deptname, string location)
        {
            this.deptid = deptid;
            this.deptname = deptname;
            this.location = location;
        }

        public string Print()
        {
            return $"deptid ={deptid}, deptname={deptname}, location={location}";
        }
    }


}
