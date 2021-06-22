using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            repeatone.DataSource = GetQuotes();
            repeatone.DataBind();
        }
        public List<quote> GetQuotes()
        {  
            List<quote> quotes = new List<quote>();
            //Get connection string from web.config file  
            string strcon = ConfigurationManager.ConnectionStrings["opsresconnection"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            using (SqlConnection con = new SqlConnection(strcon))
            {
                SqlCommand cmd = new SqlCommand("select Quotes,author from tblQuoate", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())                {

                    quote obj = new quote() { Quotes = dr["Quotes"].ToString(), author = dr["author"].ToString() };
                    quotes.Add(obj);
                }
            }
            return quotes;
          
        }
        
    }
    public class quote
    { 
        public string Quotes { get; set; }
        public string author { get; set; }
    }
}