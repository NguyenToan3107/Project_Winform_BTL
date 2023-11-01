using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCounterFinalProject
{
    public partial class PaymentFrm : Form
    {
        // Declare and constructor global variable in class to use DataBaseProcess
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();

        private string statusBill;
        public PaymentFrm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public PaymentFrm(int cart_ID, string nameCustomer, int totalItem, double totalDiscount, double totalAmount, string status)
        {
            InitializeComponent();
            CenterToScreen();
            txtCart_ID.Text = cart_ID.ToString();
            txtCustomerName.Text = nameCustomer;
            txtTotalItem.Text = totalItem.ToString();
            txtTotalDiscount.Text = totalDiscount.ToString();
            txtTotalAmount.Text = totalAmount.ToString();
            statusBill = status;

        }

        private void PaymentClick(object sender, EventArgs e)
        {
            if (btnFinish.Text.CompareTo("Hoàn tất") == 0)
            {
                string sql = "";
                var cart_ID = txtCart_ID.Text;
                var createTime = dtpCreatedTime.Value;
                var staffName = comboStaffName.Text;
                var paymentMethod = comboPaymentMethod.Text;
                var totalAmount = txtTotalAmount.Text;
                var totalDiscount = txtTotalDiscount.Text;
                var totalItem = txtTotalItem.Text;
                //Insert vào CSDL
                sql = "INSERT INTO Bill (CreateTime, SubTotal, Status, PaymentMethod, StaffName, Cart_ID, TotalDiscountAmount, TotalAmount, TotalItem) VALUES (";
                sql += "N'" + createTime + "', " + totalAmount + ",N'" + statusBill + "',N'" + paymentMethod + "',N'" + staffName + "'," + cart_ID + "," + totalDiscount + "," + totalAmount + "," + totalItem + ") ";
                sql += "exec [dbo].[UpdateItemInventory]";
                dtBase.DataChange(sql);
                if(statusBill.CompareTo("Đã thanh toán") == 0)
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (statusBill.CompareTo("Đang chờ thanh toán") == 0)
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                string sql1 = "";
                sql1 = "delete from [dbo].[SelectedItem] where SelectedItem_ID > 33";
                dtBase.DataChange(sql1);
                Close();
                
                HomeFrm home = new HomeFrm();
                home.Show();
            }
        }

        private void BtnCancelPayment(object sender, EventArgs e)
        {
            var title = "Xác nhận";
            var message = "Bạn có chắc muốn hủy bỏ";
            var ans = ShowConfirmMessage(title, message);
            if (ans == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private DialogResult ShowConfirmMessage(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

       
    }
}
