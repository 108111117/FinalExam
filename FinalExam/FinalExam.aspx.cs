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
        string[,] sa_Prod = new string[3, 6] { { "基隆：鳳梨酥、海產"
                                                ,"台北：陽明山橘子"
                                                ,"新北：淡水海產、鶯歌陶磁、文山茶"
                                                ,"桃園：大溪豆乾、筍乾"
                                                ,"宜蘭：蜜餞"
                                                ,"新竹：米粉、柿餅、貢丸"},
                                                { "苗栗：大湖草莓、三義木雕、福菜"
                                                , "台中：大甲草蓆、梧棲海鮮、高山水果、巨峰葡萄、太陽餅、鳳梨酥、牛肉乾、豆腐乾"
                                                , "南投：竹山竹製品、鹿谷茶葉、高山水果"
                                                ,"彰化：鹿港海鮮、彰化北斗肉圓、田尾永靖花卉、員林蜜餞、巨峰葡萄"
                                                ,"雲林：草莓、花生、西螺醬油、稻米"
                                                ,"花蓮：大理石、花蓮薯、麻薯"},
                                                { "嘉義：新港飴、布袋海產、稻米"
                                                , "台南：肉粽、擔仔麵、「棺材板」"
                                                , "高雄：美濃紙傘、岡山羊肉、豆瓣醬"
                                                ,"屏東：萬巒豬腳、楓港海鮮、椰子"
                                                ,"台東：太麻金針、柴魚、關山米、釋迦果",null} };
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
                    Lb_Name.Text = sa_Prod[0, 0];
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ddl_Place.SelectedValue == "基隆")
            {
                Lb_Name.Text = sa_Prod[0, 0];
            }
            else if (ddl_Place.SelectedValue == "台北")
            {
                Lb_Name.Text = sa_Prod[0, 1];
            }
            else if (ddl_Place.SelectedValue == "新北")
            {
                Lb_Name.Text = sa_Prod[0, 2];
            }
            else if (ddl_Place.SelectedValue == "桃園")
            {
                Lb_Name.Text = sa_Prod[0, 3];
            }
            else if (ddl_Place.SelectedValue == "宜蘭")
            {
                Lb_Name.Text = sa_Prod[0, 4];
            }
            else if (ddl_Place.SelectedValue == "新竹")
            {
                Lb_Name.Text = sa_Prod[0, 5];
            }
            else if (ddl_Place.SelectedValue == "苗栗")
            {
                Lb_Name.Text = sa_Prod[1, 0];
            }
            else if (ddl_Place.SelectedValue == "台中")
            {
                Lb_Name.Text = sa_Prod[1, 1];
            }
            else if (ddl_Place.SelectedValue == "南投")
            {
                Lb_Name.Text = sa_Prod[1, 2];
            }
            else if (ddl_Place.SelectedValue == "彰化")
            {
                Lb_Name.Text = sa_Prod[1, 3];
            }
            else if (ddl_Place.SelectedValue == "雲林")
            {
                Lb_Name.Text = sa_Prod[1, 4];
            }
            else if (ddl_Place.SelectedValue == "花蓮")
            {
                Lb_Name.Text = sa_Prod[1, 5];
            }
            else if (ddl_Place.SelectedValue == "嘉義")
            {
                Lb_Name.Text = sa_Prod[2, 0];
            }
            else if (ddl_Place.SelectedValue == "台南")
            {
                Lb_Name.Text = sa_Prod[2, 1];
            }
            else if (ddl_Place.SelectedValue == "高雄")
            {
                Lb_Name.Text = sa_Prod[2, 2];
            }
            else if (ddl_Place.SelectedValue == "屏東")
            {
                Lb_Name.Text = sa_Prod[2, 3];
            }
            else if (ddl_Place.SelectedValue == "台東")
            {
                Lb_Name.Text = sa_Prod[2, 4];
            }
        }
    }
}