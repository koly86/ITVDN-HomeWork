using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWork2.Classes
{
    class ConnectDB
    {
        public OPUBase1 GetGroupName(int groupId)
        {
            OPUBase1 opuBase1 = null;
            SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT GroupID, GroupName, DivID FROM Groups " +
                                                    "where DivID is not null and GroupID = @GroupID ", connection);
                command.Parameters.AddWithValue("GroupID", groupId);
                connection.Open();
                try
                {
                    reader = command.ExecuteReader();
                    reader.Read();
                    opuBase1 = new OPUBase1()
                    {

                        GroupID = Convert.ToInt32(reader[0]),
                        GroupName = reader[1].ToString(),
                        DivID = Convert.ToInt32(reader[2])

                    };

                }
                catch (Exception e)
                {
                    MessageBox.Show($@"{e}");
                }
            }

            return opuBase1;
        }
    }
}
