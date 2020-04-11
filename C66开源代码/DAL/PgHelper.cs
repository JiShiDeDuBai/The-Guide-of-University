using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class PgHelper
    {
        #region 连接字符串
        //连接字符串
        private static string connStr = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=university";
        #endregion

        #region 返回受影响的行数
        //返回受影响的行数
        public static int ExcuteNonQuery(string sql, params NpgsqlParameter[] parms)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                //创建执行工具
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(parms);
                //打开数据库
                conn.Open();
                //返回受影响行数
                return cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region 执行查询并返回查询结果的第一行的第一列
        //执行查询并返回查询结果的第一行的第一列
        public static object ExcuteScalar(string sql, params NpgsqlParameter[] parms)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                //创建执行工具
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(parms);
                //打开数据库
                conn.Open();

                return cmd.ExecuteScalar();
            }
        }
        #endregion

        #region 查询结果并返回结果集DataTable
        //查询结果并返回结果集DataTable        
        public static DataTable ExcuteDataTable(string sql, params NpgsqlParameter[] parms)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                //创建适配器
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                //打开数据库
                conn.Open();
                //创建DataTable
                DataTable dt = new DataTable();
                //设置执行参数
                adapter.SelectCommand.Parameters.AddRange(parms);
                adapter.Fill(dt);
                //返回结果
                return dt;
            }
        }
        #endregion

        #region 查询结果并返回结果集DataSet
        //查询结果并返回结果集DataSet
        public static DataSet ExcuteDataSet(string sql, params NpgsqlParameter[] parms)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                //创建适配器
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                //打开数据库
                conn.Open();
                //创建DataSet
                DataSet ds = new DataSet();
                //设置执行参数
                adapter.SelectCommand.Parameters.AddRange(parms);
                adapter.Fill(ds);
                //返回结果
                return ds;
            }
        }
        #endregion

        
        #region DataTable转为List<T>
        public static List<T> TableToList<T>(DataTable dt)
        {
            var list = new List<T>();
            var plist = new List<PropertyInfo>(typeof(T).GetProperties());
            foreach (DataRow item in dt.Rows)
            {
                T s = Activator.CreateInstance<T>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    PropertyInfo info = plist.Find(p => p.Name == dt.Columns[i].ColumnName);
                    if (info != null)
                    {
                        try
                        {
                            if (!Convert.IsDBNull(item[i]))
                            {
                                object v = null;
                                if (info.PropertyType.ToString().Contains("System.Nullable"))
                                {
                                    v = Convert.ChangeType(item[i], Nullable.GetUnderlyingType(info.PropertyType));
                                }
                                else
                                {
                                    v = Convert.ChangeType(item[i], info.PropertyType);
                                }
                                info.SetValue(s, v, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("字段[" + info.Name + "]转换出错," + ex.Message);
                        }
                    }
                }
                list.Add(s);
            }
            return list;
        }

        #endregion

        #region 检查登陆信息
        //检查登录信息
        public static bool CheckLogin(string sql, params NpgsqlParameter[] parms)
        {
            bool flag = false;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                //创建执行工具
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(parms);
                //打开数据库
                conn.Open();
                //执行
                NpgsqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    flag = true;
                }
                reader.Close();
                return flag;
            }
        }
        #endregion
    }
}
