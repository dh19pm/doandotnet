using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLLK.DAL
{
    class Connect
    {
        private string user = "sa";
        private string pass = "1803";
        private string db = "QLLK";
        private string instance = "SIBEN\\SIBEN";
        private SqlConnection connect;
        private SqlCommand cmd;
        private string[] parameters;
        public Connect()
        {
            try
            {
                this.connect = new SqlConnection("Data Source=" + instance + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + pass);
                this.connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Connect Query(string sql)
        {
            if (this.connect.State == System.Data.ConnectionState.Open)
            {
                parameters = sql.Trim().Split('?');
                if(parameters.Length > 0)
                {
                    sql = "";
                    for(int i = 0; i < parameters.Length; i++)
                    {
                        if (i == parameters.Length - 1)
                            sql += parameters[i];
                        else
                            sql += parameters[i] + "@param" + (i + 1);
                    }
                }
                cmd = new SqlCommand(sql, this.connect);
                return this;
            }
            return this;
        }
        public void Execute()
        {
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public int GetID()
        {
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public DataTable FetchAll()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            adapter.Dispose();
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
        public DataRow Fetch()
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            adapter.Dispose();
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return row;
            }
            return null;
        }
        public int Count()
        {
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public Connect Value(string[] array)
        {
            if (array.Length == (parameters.Length - 1))
            {
                for (int i = 0; i < array.Length; i++)
                    cmd.Parameters.AddWithValue("@param" + (i + 1), array[i]);
            }
            return this;
        }
        ~Connect()
        {
            if (this.connect.State != System.Data.ConnectionState.Open)
                this.connect.Close();
        }
    }
}
