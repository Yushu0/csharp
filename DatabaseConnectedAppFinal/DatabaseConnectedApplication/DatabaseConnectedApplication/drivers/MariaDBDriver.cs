using DatabaseConnectedApplication.contracts;
using DatabaseConnectedApplication.problemdomain;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectedApplication.drivers
{
    public class MariaDBDriver : DatabaseDriver
    {
        private MySqlConnection conn;

        public bool Connect()
        {
            string connectstr = "server=localhost;port=3307;database=moviemanagement;user=root;password=123456;CharacterSet =utf8mb4;SslMode=none;"; 

            if (null == conn)
            {
                conn = new MySqlConnection(connectstr);
            }

            try
            {
                conn.Open();

                //after open to avoid the createTable error
                MySqlCommand setcmd = new MySqlCommand("SET character_set_results=utf8mb4", conn);
                int n = setcmd.ExecuteNonQuery();
                setcmd.Dispose();

                TestLogManager.Log("Connect to MariaDB successfully !");

                return true;
            }
            catch (Exception ex)
            {
                TestLogManager.Log("Connect to MariaDB ecxception, message: " + ex.Message + " 、 connectstr: " + connectstr);
                return false;
            }
        }

        public void Disconnect()
        {
            if (null != conn)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    TestLogManager.Log("Close MariaDB successfully !");
                }
            }
        }

        public List<T> Get<T>(string strQuerySql)
        {
            try
            {
                if (string.IsNullOrEmpty(strQuerySql)) return new List<T>();
                TestLogManager.Log("Get strQuerySql: " + strQuerySql);

                MySqlCommand cmd = new MySqlCommand(strQuerySql, conn);
                               
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                var list = GetModelFromDB<T>(dataTable);

                TestLogManager.Log("Get MariaDB successfully strQuerySql: " + strQuerySql);

                return list;

            }
            catch (Exception ex)
            {
                TestLogManager.Log("Get MariaDB error ex.Message: " + ex.Message + "、 strQuerySql: " + strQuerySql);
                return new List<T>();
            }
        }

        public bool Update(string strUpdateSql)
        {
            if (string.IsNullOrEmpty(strUpdateSql)) return false;

            var result = ExecuteQuery(strUpdateSql);
            if (result)
            {
                TestLogManager.Log("Update MariaDB successfully !");
            }
            else
            {
                TestLogManager.Log("Update MariaDB error !");
            }
            return result;
        }


        
        public bool Insert(List<string> strSqlList)
        {
            //Create the command object to execute the command
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            //mysql
            MySqlTransaction transaction = conn.BeginTransaction();
            command.Transaction = transaction;

            try
            {
                foreach (var strSql in strSqlList)
                {
                    command.CommandText = strSql;
                    command.ExecuteNonQuery();
                }
                transaction.Commit();
                TestLogManager.Log("Insert MariaDB successfully strSqlList: " + Newtonsoft.Json.JsonConvert.SerializeObject(strSqlList));
                return true;
            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
                TestLogManager.Log("Insert MariaDB error ex.Message:" + ex.Message + " strSqlList: " + Newtonsoft.Json.JsonConvert.SerializeObject(strSqlList));
                return false;
            }
        }

        public bool Delete(string strSql)
        {
            if (string.IsNullOrEmpty(strSql)) return false;

            var result = ExecuteQuery(strSql);
            if (result)
            {
                TestLogManager.Log("Delete MariaDB successfully !");
            }
            else
            {
                TestLogManager.Log("Delete MariaDB error !");
            }
            return result;
        }

        private bool ExecuteQuery(string strSql)
        {
            try
            {
                MySqlCommand myCmd = new MySqlCommand(strSql, conn);
                myCmd.ExecuteNonQuery();
                TestLogManager.Log("ExecuteQuery successfully strSql: " + strSql);
                return true;
            }
            catch (MySqlException ex)
            {
                TestLogManager.Log("ExecuteQuery error ex.Message: " + ex.Message + " 、 strSql: " + strSql);
                return false;
            }
        }


        private List<T> GetModelFromDB<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        /// <summary>
        /// Convert a DataRow to an entity object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static T GetItem<T>(DataRow dr)
        {
            try
            {
                Type temp = typeof(T);
                T obj = Activator.CreateInstance<T>();
                foreach (DataColumn column in dr.Table.Columns)
                {
                    foreach (PropertyInfo pro in temp.GetProperties())
                    {
                        if (pro.Name.ToLower() == column.ColumnName.ToLower())
                        {
                            if (dr[column.ColumnName] == DBNull.Value)
                            {
                                pro.SetValue(obj, " ", null);
                                break;
                            }
                            else
                            {
                                pro.SetValue(obj, dr[column.ColumnName], null);
                                break;
                            }
                        }
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
             }
        }
    }
}
