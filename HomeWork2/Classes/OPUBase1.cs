namespace HomeWork2.Classes
{
    public class OPUBase1
    {
        public OPUBase1()
        {
        }

        public OPUBase1(string groupName, int groupId, int divId)
        {
            DivID = divId;
            GroupID = groupId;
            GroupName = groupName;
        }

        public string GroupName { get; set; }
        public int GroupID { get; set; }
        public int DivID { get; set; }
    }
}