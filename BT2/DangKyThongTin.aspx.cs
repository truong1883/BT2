﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BT2
{
    public partial class DangKyThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTrinhDo.Items.Add(new ListItem("Trung Cấp"));
                ddlTrinhDo.Items.Add(new ListItem("Cao Đẳng"));
                ddlTrinhDo.Items.Add(new ListItem("Đại Học"));
               


                lstNgheNghiep.Items.Add(new ListItem("Bác Sĩ"));              
                lstNgheNghiep.Items.Add(new ListItem("Công Nhân"));
                lstNgheNghiep.Items.Add(new ListItem("Hoạ Sĩ"));
                lstNgheNghiep.Items.Add(new ListItem("Ca Sĩ"));

                chkListSoThich.Items.Add(new ListItem("Mua Sắm"));
                chkListSoThich.Items.Add(new ListItem("Xem Phim"));
                chkListSoThich.Items.Add(new ListItem("Chơi Game"));
                
            }

        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h2>Thông tin đăng ký của bạn</h2>";
            kq += "<ul>";
            //Lấy thông tin
            kq += $"<li>Họ Tên {txtHoTen.Text}</li>";

            kq += $"<li>Ngày Sinh {txtNgaySinh.Text}</li>";

            if (rdNam.Checked)
            {
                kq += $"<li>Giới Tính {rdNam.Text}</li>";
            }
            else
            {
                kq += $"<li>Giới Tính {rdNu.Text}</li>";
            }

            kq += $"<li>Trình Độ {ddlTrinhDo.SelectedItem.Text}</li>";

            kq += $"<li>Nghề Nghiệp {lstNgheNghiep.SelectedItem.Text}</li>";

            if (FHinh.HasFile)
            {
                string path = Server.MapPath("~/Uploads");
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li>Hình: <img src='Uploads/{FHinh.FileName}'> <li>";
            }

            kq += $"<li>Sở Thích: {chkListSoThich.SelectedItem.Text}</li>";

            kq += "</ul>";

            lbKetQua.Text = kq;
        }
    }
}