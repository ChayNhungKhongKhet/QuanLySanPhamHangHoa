using System.Data.SqlClient;
using System.Data;

public class XuLyDuLieu
{
    SqlConnection con;

    public XuLyDuLieu()
    {
        this.con = new SqlConnection();
        this.con.ConnectionString 
            = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\HocKy122\C_sharp_web\Web\PhamNgocTan_2050531200307_AppWebBanHang\PhamNgocTan_2050531200307_AppWebBanHang\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";

    }
    private void OpenConnection()
    {
        if (con.State == ConnectionState.Closed)
            con.Open();
    }
    private void CloseConnection()
    {
        if (con.State == ConnectionState.Open)
            con.Close();
    }

    public DataTable getTable(string sql)
    {
        OpenConnection();
        SqlDataAdapter adapter =  new SqlDataAdapter(sql,con);
        DataTable table = new DataTable();
        adapter.Fill(table);
        CloseConnection();
        return table;
    }

    public DataTable getTable(string procedurce , SqlParameter[] pr)
    {
        OpenConnection();
        DataTable table = new DataTable();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection = con;
        sqlCommand.CommandText = procedurce;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        if (pr != null)
            sqlCommand.Parameters.AddRange(pr);
        SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
        adp.Fill(table);
        CloseConnection();
        return table;
    }

    public void getDataSet(ref DataSet ds, string sql)
    {
        ds.Tables.Add(this.getTable(sql));
    }

    public void getDataSet(ref DataSet ds, string procedurce, SqlParameter[] pr)
    {
        ds.Tables.Add(this.getTable(procedurce));
    }

    public int Execute(string sql)
    {
        OpenConnection();
        SqlCommand sqlCommand = new SqlCommand(sql,con);
        CloseConnection();
        int result = (int)sqlCommand.ExecuteNonQuery();
        return result;
    }

    public int Execute(string procedurce, SqlParameter[] pr)
    {
        OpenConnection();
        SqlCommand sqlCommand = new SqlCommand();
        sqlCommand.Connection=con;
        sqlCommand.CommandText = procedurce;
        sqlCommand.CommandType = CommandType.StoredProcedure;
        if (pr != null)
            sqlCommand.Parameters.AddRange(pr);
        CloseConnection();
        int result = (int)sqlCommand.ExecuteNonQuery();
        return result;

    }
}