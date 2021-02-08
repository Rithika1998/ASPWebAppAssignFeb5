using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryAssignFeb5
{
    public partial class CountryDetails : System.Web.UI.Page
    {
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString());
        
        //--------- COUNTRY DETAILS --------------

        public void CountryDet()
        {
            cn.Open();
            using (SqlCommand cmd = new SqlCommand("select CountryName,CountryId from Country", cn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    DropDownCountry.DataSource = dr;
                    DropDownCountry.Items.Clear();
                    
                    DropDownCountry.DataTextField = "CountryName";
                    DropDownCountry.DataValueField = "CountryId";
                    DropDownCountry.DataBind();

                }
            }
        }

        //--------- STATE DETAILS --------------

        public void StateDet()
        {
            cn.Open();
            //Response.Write(DropDownCountry.SelectedValue);
            using (SqlCommand cmd = new SqlCommand("select StateName,StateId from Statetable where CountryId='" + DropDownCountry.SelectedValue + "'", cn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    DropDownState.DataSource = dr;
                    DropDownState.Items.Clear();
                   
                    DropDownState.DataTextField = "StateName";
                    DropDownState.DataValueField = "StateId";
                    DropDownState.DataBind();
                }
            }
        }

        //--------- CITY DETAILS --------------

        public void CityDet()
        {
            cn.Open();
            using (SqlCommand cmd = new SqlCommand("select CityName,CityId from CityTable where StateId='" + DropDownState.SelectedValue + "'", cn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    DropDownCity.DataSource = dr;
                    DropDownCity.Items.Clear();
                    
                    DropDownCity.DataTextField = "CityName";
                    DropDownCity.DataValueField = "CityId";
                    DropDownCity.DataBind();
                }
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CountryDet();

            }
        }

        protected void DropDownCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCountry.Text = DropDownCountry.SelectedValue;
            StateDet();
        }

        protected void DropDownState_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStat.Text= DropDownState.SelectedValue;
            CityDet();
        }

        protected void DropDownCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCity.Text = DropDownCity.SelectedValue;
        }
    }
}