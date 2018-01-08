using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    private string tablename;
    private int colCnt;
    private List<string> colNsmeList;
    protected void Page_Load(object sender, EventArgs e)
    {
        tablename = "社員";
        SqlConnection con
            = new SqlConnection();
        con.ConnectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True"; //接続情報を入れる
        con.Open();

        //クエリーの生成
        SqlCommand sqlCom = new SqlCommand();

        //クエリー送信先及びトランザクションの指定
        sqlCom.Connection = con;
        //sqlCom.Transaction = this.sqlTran;

        //クエリー文の指定
        sqlCom.CommandText = "SELECT * FROM " + tablename + ";";

        //データテーブルを作成するためのアダプタ
        SqlDataAdapter sqlAda = new SqlDataAdapter();
        sqlAda.SelectCommand = sqlCom;

        DataTable dsgrid = new DataTable();
        dsgrid.Columns.Add("Column", typeof(string));
        dsgrid.Columns.Add("word2vec距離", typeof(string));
        //dsにテーブルデータを代入
        DataTable ds = new DataTable();
        sqlAda.Fill(ds);
        colCnt = ds.Columns.Count;
        colNsmeList = new List<string>();
        //List<String> columnList = new List<string>();
        foreach (DataColumn clm in ds.Columns)
        {
            //columnList.Add(clm.ColumnName);
            //var sim =getSimilarity(tablename, clm.ColumnName);
            var sim = "0";
            string[] row = new string[] { clm.ColumnName, sim };
            dsgrid.Rows.Add(row);
            colNsmeList.Add(clm.ColumnName);
        }
        //dsgrid.Rows[10]["word2vec距離"] = "0.1";

        columnlist1.DataSource = dsgrid;
        columnlist1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Hello";
    }
}