using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Ai
{

    public class clsGetSpeac
    {

        public string connetionString;
        public SqlConnection cnn;

        public clsGetSpeac()
        {
            connetionString = @"server=LAPTOP-7A012LKL\SQLEXPRESS01; database =RecomendationDb ; integrated security =true";
            cnn = new SqlConnection(connetionString);
        }

        public string CheckConnection()
        {
            cnn.Open();
            Console.WriteLine("Connection Open  !");
            cnn.Close();
            return "Connection Open  !";
        }

        public string GetSpecById(int id)
        {
            cnn.Open();
            string query = "SELECT * FROM Samsung where id =" + id + ";";
            SqlCommand command = new SqlCommand(query, cnn);
            //SqlDataReader reader = command.ExecuteReader();
            //var speac = reader.Read();
            SqlDataReader dr = command.ExecuteReader();
            string speac;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    speac = dr["Name"].ToString();
                    return speac;
                    cnn.Close();
                }
                return "";
            }
            else
            {
                return "";
            }
        }

        public List<string> GetSpecByName(string name)
        {
            cnn.Open();
            string query = String.Format("select * from Samsung where Name LIKE '%{0}%' ;", name);
            SqlCommand command = new SqlCommand(query, cnn);

            SqlDataReader dr = command.ExecuteReader();
            List<string> speac = new List<string>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    for (int i = 0; i < 41; i++)
                    {
                        speac.Add(dr[i].ToString());
                    }
                    return speac;
                    cnn.Close();
                }
                return speac;
            }
            else
            {
                return speac;
            }
        }

        public List<MobileSpaceObject> GetAllMobile()
        {
            try
            {
                cnn.Open();
                string query = String.Format("select * from {0} ;", "rating");
                SqlCommand command = new SqlCommand(query, cnn);

                SqlDataReader dr = command.ExecuteReader();
                List<MobileSpaceObject> speac = new List<MobileSpaceObject>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MobileSpaceObject spaceObject = new MobileSpaceObject();
                        //speac.Add(dr[i].ToString());
                        spaceObject.MobileID = Convert.ToInt32(dr[0]);
                        spaceObject.MobileName = Convert.ToString(dr[1]);
                        spaceObject.Performance = (float)dr[2];
                        spaceObject.Display = (float)dr[3];
                        spaceObject.Camera = (float)dr[4];
                        spaceObject.Battary = (float)dr[5];
                        spaceObject.BuildQuality = (float)dr[6];
                        spaceObject.Price =(float)dr[7];
                        speac.Add(spaceObject);
                    }
                    return speac;
                    cnn.Close();
                }
                return speac;

            }
            finally
            {
                cnn.Close();
            }
        }
}
    }



