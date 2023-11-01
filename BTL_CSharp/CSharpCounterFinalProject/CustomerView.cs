using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CSharpCounterFinalProject
{
    public partial class CustomerView : Form
    {
        // Declare and constructor global variable in class to use DataBaseProcess
        Classes.DataBaseProcess dtBase = new Classes.DataBaseProcess();
        public CustomerView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public CustomerView(string username, string password)
        {
            InitializeComponent();
            CenterToScreen();
            txtInfoUserName.Text = username;
            txtInfoPass.Text = password;
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            // Display Item
            DisplayItemsCustomer();

            // display user
            DisplayInfoUser();

            // display cart
            DisplayCartInfo();
        }

        // btn review
        private void TblItemCustomerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == tblItemCustomer.Columns["btnReview"].Index)
            {
                DataGridViewRow row = tblItemCustomer.Rows[e.RowIndex];
                int item_ID = int.Parse(row.Cells["Item_ID"].Value.ToString());
                string itemName = row.Cells["ItemName"].Value.ToString();
                string itemType = row.Cells["ItemType"].Value.ToString();
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                string brand = row.Cells["Brand"].Value.ToString();
                DateTime releaseDate = DateTime.Parse(row.Cells["ReleaseDate"].Value.ToString());
                int price = int.Parse(row.Cells["Price"].Value.ToString());
                string discount = row.Cells["Name"].Value.ToString();
                string image = row.Cells["Image"].Value.ToString();

                var childView = new AddEditItemFrm("Xem", item_ID, itemName, itemType, quantity, brand, releaseDate, price, discount, image);
                childView.Show();
            }

        }

        // sort item
        private void SortItemCustomerHandler(object sender, EventArgs e)
        {
            if (radioSortItemCustomerByPriceASC.Checked)
            {
                tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                                                       "ORDER BY Price");
            }
            else if (radioSortItemCustomerByPriceDESC.Checked)
            {
                tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                                                       "ORDER BY Price DESC");
            }
            else if (radioSortItemCustomerByQuantity.Checked)
            {
                tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                                                       "ORDER BY Quantity DESC");
            }
            else if (radioSortItemCustomerByProductDate.Checked)
            {
                tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                                                       "ORDER BY item.ReleaseDate");
            }
            else if (radioSortItemCustomerByName.Checked)
            {
                tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                                                       "ORDER BY ItemName");
            }
        }

        // btn click search
        private void BtnSearchItemCustomerClick(object sender, EventArgs e)
        {
            if (comboSearchItemCustomer.SelectedIndex == -1)
            {
                var msg = "Vui lòng chọn tiêu chí tìm kiếm để tiếp tục";
                var title = "Lỗi dữ liệu";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboSearchItemCustomer.SelectedIndex == 0)
            {
                var name = txtSearchItemCustomer.Text;
                string sql = "SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                             "FROM Item AS item " +
                             "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                             "WHERE item.ItemName LIKE (N'%" + name + "%')";

                tblItemCustomer.DataSource = dtBase.DataReader(sql);
            }
            else if (comboSearchItemCustomer.SelectedIndex == 1)
            {
                int from = (int)numericItemCustomerFrom.Value;
                int to = (int)numericItemCustomerTo.Value;
                if (from > to)
                {
                    MessageBox.Show($"{from} không nhỏ hơn {to}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sql = "SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                             "FROM Item AS item " +
                             "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                             "WHERE item.Price BETWEEN " + from + " AND " + to;

                tblItemCustomer.DataSource = dtBase.DataReader(sql);
            }
            else if (comboSearchItemCustomer.SelectedIndex == 2) // loai mat hang
            {
                var name = txtSearchItemCustomer.Text;
                string sql = "SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                             "FROM Item AS item " +
                             "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                             "WHERE item.ItemType LIKE (N'%" + name + "%')";

                tblItemCustomer.DataSource = dtBase.DataReader(sql);
            }
            else if (comboSearchItemCustomer.SelectedIndex == 3) // hang
            {
                var name = txtSearchItemCustomer.Text;
                string sql = "SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                             "FROM Item AS item " +
                             "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                             "WHERE item.Brand LIKE (N'%" + name + "%')";

                tblItemCustomer.DataSource = dtBase.DataReader(sql);
            }
            else if (comboSearchItemCustomer.SelectedIndex == 4)
            {
                int from = (int)numericItemCustomerFrom.Value;
                int to = (int)numericItemCustomerTo.Value;
                if (from > to)
                {
                    MessageBox.Show($"{from} không nhỏ hơn {to}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string sql = "SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                             "FROM Item AS item " +
                             "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID " +
                             "WHERE item.Quantity BETWEEN " + from + " AND " + to;

                tblItemCustomer.DataSource = dtBase.DataReader(sql);
            }
        }

        private void DisplayItemsCustomer()
        {
            tblItemCustomer.Columns["Item_ID"].DataPropertyName = "Item_ID";
            tblItemCustomer.Columns["ItemName"].DataPropertyName = "ItemName";
            tblItemCustomer.Columns["ItemType"].DataPropertyName = "ItemType";
            tblItemCustomer.Columns["Quantity"].DataPropertyName = "Quantity";
            tblItemCustomer.Columns["Brand"].DataPropertyName = "Brand";
            tblItemCustomer.Columns["ReleaseDate"].DataPropertyName = "ReleaseDate";
            tblItemCustomer.Columns["Price"].DataPropertyName = "Price";
            tblItemCustomer.Columns["Name"].DataPropertyName = "Name";
            tblItemCustomer.Columns["Image"].DataPropertyName = "Image";
            // Display customer
            tblItemCustomer.DataSource = dtBase.DataReader("SELECT item.Item_ID, item.ItemName, item.ItemType, item.Quantity, item.Brand, item.ReleaseDate, item.Price, discount.Name, item.Image " +
                                                       "FROM Item AS item " +
                                                       "JOIN Discount AS discount ON item.Discount_ID = discount.Discount_ID");
        }

        private void DisplayCartInfo()
        {
            txtCartInfoName.Text = txtInfoName.Text;
            txtCartInfoPoint.Text = txtInfoPoint.Text;
            txtCartInfoPhone.Text = txtInfoPhone.Text;
            txtCartInfoType.Text = txtInfoType.Text;
        }

        private void DisplayInfoUser()
        {
            // Thực hiện truy vấn SQL và lấy dữ liệu
            string query = "select c.Customer_ID, c.BirthDate, c.Address, c.PhoneNumber, c.CustomerType, c.Point, c.CreateTime, c.Email, c.FullName, c.Username, c.Password " +
                            "from[dbo].[Customer] as c " +
                            "where c.Username = N'" + txtInfoUserName.Text +"' and c.Password = N'" + txtInfoPass.Text + "'";

            // dtBase.DataReader là một đối tượng chưa kết nối và thực hiện truy vấn

            string strConnect = "Data Source=DESKTOP-IDTOGAB\\SQLEXPRESS03;" +
                            "DataBase=BTL_LTTQ;User ID=sa;" +
                            "Password=toantung3107;Integrated Security=false";
            using (SqlConnection connection = new SqlConnection(strConnect)) // Kết nối cơ sở dữ liệu
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection)) // Thực hiện truy vấn
                {
                    using (SqlDataReader reader = command.ExecuteReader()) // Đọc dữ liệu
                    {
                        if (reader.Read())
                        {
                            // Gán dữ liệu từ truy vấn lên các thẻ Label
                            txtInfoID.Text = reader["Customer_ID"].ToString();
                            txtInfoDate.Text = reader["BirthDate"].ToString();
                            txtInfoAddress.Text = reader["Address"].ToString();
                            txtInfoPhone.Text = reader["PhoneNumber"].ToString();
                            txtInfoType.Text = reader["CustomerType"].ToString();
                            txtInfoPoint.Text = reader["Point"].ToString();
                            txtInfoTimeCreated.Text = reader["CreateTime"].ToString();
                            txtInfoEmail.Text = reader["Email"].ToString();
                            txtInfoName.Text = reader["FullName"].ToString();
                            txtInfoUserName.Text = reader["Username"].ToString();
                            txtInfoPass.Text = reader["Password"].ToString();
                        }
                        else
                        {
                            // Xử lý trường hợp không có dữ liệu
                            // Ví dụ: labelCart_ID.Text = "Không có dữ liệu";
                        }
                    }
                }
            }
        }

        private void BtnRefreshItemCustomer(object sender, EventArgs e)
        {
            DisplayItemsCustomer();
        }

    
    }
}
