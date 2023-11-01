using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCounterFinalProject.Sign
{
    public partial class SignUp : Form
    {
        // Declare and constructor global variable in class to use DataBaseProcess
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();
        public SignUp()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BtnSignUpClick(object sender, EventArgs e)
        {
            string sql = "";
            var id = txtCMND.Text;
            var name = txtFullName.Text;
            var address = txtAddress.Text;
            var email = txtEmail.Text;
            var phone = txtPhoneNumber.Text;
            var birthDate = dtpDate.Value;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            //Insert vào CSDL
            if(username == "admin" && password == "admin")
            {
                MessageBox.Show("Tài khoản admin không thể tạo!");
                return;
            }

            sql = "INSERT INTO Customer (Customer_ID, BirthDate, Address, PhoneNumber, CustomerType, Point, CreateTime, Email, FullName, Username, Password) VALUES (";
            sql += "N'" + id + "',N'" + birthDate + "',N'" +
                   address + "',N'" + phone + "',N'" + "Khách mua lẻ" + "',N'" + 0 + "',N'" + DateTime.Now.ToString("MM/dd/yyyy") + "',N'" + email + "',N'" + name + "',N'" + username + "',N'" + password +"')";
            dtBase.DataChange(sql);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
            var childview = new SignIn();
            childview.Show();
        }
    }
}
