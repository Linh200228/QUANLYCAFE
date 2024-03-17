using Do_an_co_so_2.DAO;
using Do_an_co_so_2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_co_so_2
{
    public partial class frm_ThucDon : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        public frm_ThucDon()
        {
            InitializeComponent();
            LoadCategoryInCombobox(cbxDanhMuc);
            dgvMon.DataSource = foodList;
            LoadListFood();
            FoodBinding();
            dgvDanhMuc.DataSource = categoryList;
            LoadListCategory();
            CategoryBinding();
        }

        //Hiển trị danh sách món ăn
        void LoadCategoryInCombobox(ComboBox cbo)
        {
            cbo.DataSource = CategoryDAO.Instance.GetListCategory();
            cbo.DisplayMember = "Name";
        }

        // lấy danh sách category
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }


        //Lấy danh sách món ăn
        void LoadListFood()
        {
            //Lấy danh sách món ăn và hiển thị lên datagridview
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        //Tạo binding để khi click vào một ô textbox hay nào đó giá trị nó thay đổi theo cái danh sách

        void FoodBinding()
        {
            //Lấy giá trị của text tên món ăn gọi binding thay đổi giá trị của nó thành giá trị name và nguồn được lấy từ datasource 
            txtTenMon.DataBindings.Add(new Binding("Text", dgvMon.DataSource, "Name"));
            txtMaMon.DataBindings.Add(new Binding("Text", dgvMon.DataSource, "id"));
            nudGia.DataBindings.Add(new Binding("Value", dgvMon.DataSource, "Price"));
        }

        void CategoryBinding()
        {
            txtMaDanhMuc.DataBindings.Add(new Binding("text", dgvDanhMuc.DataSource, "id"));
            txtTenDanhMuc.DataBindings.Add(new Binding("text", dgvDanhMuc.DataSource, "name"));
        }

        //Hàm tìm kiếm danh sách món ăn
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = new List<Food>();

            listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int idCategory = (cbxDanhMuc.SelectedItem as Category).ID;
            float price = (float)nudGia.Value;

            if (FoodDAO.Instance.InsertFood(name, idCategory, price))
            {
                MessageBox.Show("Thêm món ăn thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Thêm món không thành công!");
            }
        }

        private void btnCapNhatMon_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int idCategory = (cbxDanhMuc.SelectedItem as Category).ID;
            float price = (float)nudGia.Value;
            int id = Convert.ToInt32(txtMaMon.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, idCategory, price))
            {
                MessageBox.Show("Sửa món ăn thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Sửa món không thành công!");
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaMon.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món ăn thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Xóa món không thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvMon.DataSource = SearchFoodByName(txtTimKiem.Text);
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            string name = txtTenDanhMuc.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("thêm món ăn thành công!");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("thêm món không thành công!");
            }
        }

        private void btnCapNhatDanhMuc_Click(object sender, EventArgs e)
        {
            string name = txtTenDanhMuc.Text;
            int id = Convert.ToInt32(txtMaDanhMuc.Text);

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa món ăn thành công!");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Sửa món không thành công!");
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaDanhMuc.Text);


            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa món ăn thành công!");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Xóa món không thành công!");
            }
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {

        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            if (dgvMon.SelectedCells.Count > 0)
            {
                int id = (int)dgvMon.SelectedCells[0].OwningRow.Cells["idCategory"].Value;

                Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                cbxDanhMuc.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Category item in cbxDanhMuc.Items)
                {
                    if (item.ID == cateogory.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbxDanhMuc.SelectedIndex = index;
            }
        }
    }
}
