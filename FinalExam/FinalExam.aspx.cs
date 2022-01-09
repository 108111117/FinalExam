using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalExam
{

    public partial class FinalExam : System.Web.UI.Page
    {
        string[,] sa_Place = new string[3, 6] { { "基隆", "台北", "新北" ,"桃園","宜蘭","新竹"},
                                                { "苗栗", "台中", "南投" ,"彰化","雲林","花蓮"},
                                                { "嘉義", "台南", "高雄" ,"屏東","台東",null} };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem o_Item = new ListItem("北區", "北區");
                ddl_Area.Items.Add(o_Item);
                o_Item = new ListItem("中區", "中區");
                ddl_Area.Items.Add(o_Item);
                o_Item = new ListItem("南區", "南區");
                ddl_Area.Items.Add(o_Item);

                for (int i_ct = 0; i_ct < 6; i_ct++)
                {
                    o_Item = new ListItem(sa_Place[0, i_ct], sa_Place[0, i_ct]);
                    ddl_Place.Items.Add(o_Item);
                }

            }
        }
        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            ListItem o_Item;
            if (ddl_Area.SelectedValue == "北區")
            {
                for (int i_ct = 0; i_ct < 6; i_ct++)
                {
                    o_Item = new ListItem(sa_Place[0, i_ct], sa_Place[0, i_ct]);
                    ddl_Place.Items.Add(o_Item);
                }
            }
            else if (ddl_Area.SelectedValue == "中區")
            {
                for (int i_ct = 0; i_ct < 6; i_ct++)
                {
                    o_Item = new ListItem(sa_Place[1, i_ct], sa_Place[1, i_ct]);
                    ddl_Place.Items.Add(o_Item);
                }
            }
            else
            {
                for (int i_ct = 0; i_ct < 6; i_ct++)
                {
                    o_Item = new ListItem(sa_Place[2, i_ct], sa_Place[2, i_ct]);
                    ddl_Place.Items.Add(o_Item);
                }
            }
        }
    }
}