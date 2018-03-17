using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Classes
{
    public class OPUBase1
    {
        public string GroupName { get; set; }
        public int GroupID { get; set; }
        public int DivID { get; set; }

        public OPUBase1() { }

        public OPUBase1(string groupName, int groupId, int divId)
        {
            DivID = divId;
            GroupID = groupId;
            GroupName = groupName;
        }
    }
}
