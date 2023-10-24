using frmManageCategories;

namespace CodeFirsts
{
    public partial class frmManageCategories : Form
    {
        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            var categories = ManageCategories.Instance.GetCategories();
            TxtCategoryId.DataBindings.Clear();
            TxtCategoryName.DataBindings.Clear();
            TxtCategoryId.DataBindings.Add("Text", categories, "CategoryID");
            TxtCategoryName.DataBindings.Add("Text", categories, "CategoryName");
            dvgCategories.DataSource = categories;
        }


        private void frmManageCategories_Load(object sender, EventArgs e) => LoadCategory();

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var caretory = new Category { CategoryName = TxtCategoryName.Text };
                ManageCategories.Instance.InsertCategory(caretory);
                LoadCategory();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var caretory = new Category
                {
                    CategoryID = int.Parse(TxtCategoryId.Text),
                    CategoryName = TxtCategoryName.Text
                };
                ManageCategories.Instance.UpdateCategory(caretory);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var caretory = new Category { CategoryID = int.Parse(TxtCategoryId.Text) };
                ManageCategories.Instance.DeleteCategory(caretory);
                LoadCategory();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}