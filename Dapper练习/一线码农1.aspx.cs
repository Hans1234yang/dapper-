using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dapper练习
{
    public partial class 一线码农 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       /// <summary>
       /// 插入
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dappertesttest;Integrated Security=True");

            var result = connection.Execute("Insert into Users values (@UserName, @Email, @Address)",
                                   new { UserName = "jack", Email = "380234234@qq.com", Address = "上海" });

            Response.Write("插入成功");
        }
        //批量插入
        protected void Button2_Click(object sender, EventArgs e)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dappertesttest;Integrated Security=True");


            var usersList = Enumerable.Range(0, 10).Select(i => new Users()
            {
                Email = i + "qq.com",
                Address = "安徽",
                UserName = i + "jack"
            });

            var result = connection.Execute("Insert into Users values (@UserName, @Email, @Address)", usersList);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dappertesttest;Integrated Security=True");

            var query = connection.Query<Users>("select * from Users where UserName=@UserName", new { UserName = "jack" });

            GridView1.DataSource = query;
            GridView1.DataBind();
            Response.Write("查询成功");

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button5_Click(object sender, EventArgs e)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dappertesttest;Integrated Security=True");


            var query = connection.Execute("delete from Users where UserID=@UserID", new { UserID = 10 });
            Response.Write("删除成功");
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button4_Click(object sender, EventArgs e)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=dappertesttest;Integrated Security=True");

            var result = connection.Execute("update Users set UserName='peter' where UserID=@UserID",new { Userid=11});
            Response.Write("修改成功");

        }
    }
}