using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoidy.User_Control
{
    public partial class ItemsUC : UserControl
    {

        string _menuName, _menuPrice;

        public void LoadMenuRecords()
        {


            var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                var DisplayAllMenu = "SELECT * FROM MENU_DETAILS;";

                SqlDataAdapter adapter = new SqlDataAdapter(DisplayAllMenu, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewMenuList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LOL");
            }
            finally
            {
                connection.Close();
            }

            connection.Close();


        }

        public ItemsUC()
        {
            InitializeComponent();
            LoadMenuRecords();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

            var MenuName = txtBoxName.Text;

            var MenuPrice = txtBoxPrice.Text;

            var MenuPicture = pctrBoxMenuPicture.Image;
            


            if (string.IsNullOrEmpty(MenuName) &&
                string.IsNullOrEmpty(MenuPrice))
            {
                MessageBox.Show("PLEASE FILL OUT ALL THE BOX PROVIDED!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(MenuName))
            {
                MessageBox.Show("Menu Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(MenuPrice))
            {
                MessageBox.Show("Menu Price is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(MenuName) &&
                !string.IsNullOrEmpty(MenuPrice))
            {
                var hasNumber = new Regex(@"[0-9]+");


                if (hasNumber.IsMatch(MenuName))
                {
                    MessageBox.Show("Menu Name must not contain Numbers");
                    return;
                }

                var hasLetters = new Regex(@"[a-zA-Z]");

                if (hasLetters.IsMatch(MenuPrice))
                {
                    MessageBox.Show("Menu Price must not contain Letters");
                    return;
                }

                var hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (hasSpecialChar.IsMatch(MenuName))
                {
                    MessageBox.Show("Menu Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(MenuPrice))
                {
                    MessageBox.Show("Menu Price  must not contain Special Characters!");
                    return;
                }

                else
                {
                    var AddMenuQuery = "INSERT INTO MENU_DETAILS " +
                              "(" +
                              "menu_Name," +
                              "menu_Price," +
                              "menu_Picture" +
                              ") VALUES " +
                              "(" +
                              $"'{MenuName}'," +
                              $"'{MenuPrice}'," +
                              $"'{MenuPicture}'" +
                              $");";

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);

                    connection.Open();

                    DialogResult AddMenuConfirmation = MessageBox.Show("Are you sure you want to add the Following: \n" +
                                                                        "\n" +
                                                                        "       Menu Name: " + MenuName + "\n" +
                                                                        "       Menu Price: " + MenuPrice + "\n" +
                                                                        "       ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (AddMenuConfirmation == DialogResult.Yes)
                    {
                        try
                        {

                            var addCommand = new SqlCommand(AddMenuQuery, connection);
                            addCommand.ExecuteNonQuery();

                            dataGridViewMenuList.Refresh();
                            LoadMenuRecords();

                            AddMenuNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                            AddMenuNotification.Text = "Hello";
                            AddMenuNotification.Visible = true;
                            AddMenuNotification.BalloonTipTitle = "User Successfully Added!";
                            AddMenuNotification.BalloonTipText = "List Updated";
                            AddMenuNotification.ShowBalloonTip(100);

                        }
                        catch (Exception ex)
                        {


                            MessageBox.Show(ex.Message);


                        }
                        finally
                        {

                            ClearAllMenuDetails();


                            connection.Close();


                        }
                    }
                }
            }
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            var menuName = txtBoxName.Text;

            var menuPrice = txtBoxPrice.Text;


            if (string.IsNullOrEmpty(txtBoxName.Text) && 
                string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                MessageBox.Show("PLEASE FILL OUT ALL THE BOX PROVIDED!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(menuName))
            {
                MessageBox.Show("Menu Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(menuPrice))
            {
                MessageBox.Show("Menu Price  is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtBoxName.Text) &&
                !string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                var hasNumber = new Regex(@"[0-9]+");


                if (hasNumber.IsMatch(menuName))
                {
                    MessageBox.Show("First Name must not contain Numbers");
                    return;
                }

                var hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (hasSpecialChar.IsMatch(menuName))
                {
                    MessageBox.Show("Menu Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(menuPrice))
                {
                    MessageBox.Show("Menu Price must not contain Special Characters!");
                    return;
                }
                else
                {
                    int i = dataGridViewMenuList.CurrentRow.Index;
                    var UpdateMenuQuery = "UPDATE MENU_DETAILS SET menu_Name = '" + menuName +
                                                                "', menu_Price = '" + menuPrice +
                                                                "' WHERE menu_ID LIKE '" + dataGridViewMenuList[0, i].Value.ToString() + "'";

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);



                    DialogResult UpdateUserConfirmation = MessageBox.Show("Are you sure you want to add the Following: \n" +
                                                                        "\n" +
                                                                        "       Menu Name: " + menuName + "\n" +
                                                                        "       Menu Price: " + menuPrice + "\n" +
                                                                        "       ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (UpdateUserConfirmation == DialogResult.Yes)
                    {
                        connection.Open();
                        try
                        {
                            var updateCommand = new SqlCommand(UpdateMenuQuery, connection);
                            updateCommand.ExecuteNonQuery();

                            dataGridViewMenuList.Refresh();
                            LoadMenuRecords();

                            UpdateMenuNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                            UpdateMenuNotification.Text = "Hello";
                            UpdateMenuNotification.Visible = true;
                            UpdateMenuNotification.BalloonTipTitle = "Menu Details Successfully Updated!";
                            UpdateMenuNotification.BalloonTipText = "List Updated";
                            UpdateMenuNotification.ShowBalloonTip(100);

                            btnAddMenu.Enabled = true;
                            btnUpdateMenu.Enabled = false;

                            txtBoxName.Clear();
                            txtBoxPrice.Clear();
                            
                            btnAddMenu.BringToFront();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        public void ClearAllMenuDetails()
        {
            txtBoxName.Text = null;
            txtBoxPrice.Text = null;
           
        }

        private void btnClearAllMenuDetails_Click(object sender, EventArgs e)
        {
            var menuName = txtBoxName.Text;

            var menuPrice= txtBoxPrice.Text;

            

            if (string.IsNullOrEmpty(menuName) &&
                string.IsNullOrEmpty(menuPrice))
            {
                MessageBox.Show("It is already cleared! ;D", "Oh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ClearAll = MessageBox.Show("Are you sure you want to clear all?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ClearAll == DialogResult.Yes)
                {
                    ClearAllMenuDetails();
                }
            }
        }

        private void dataGridViewMenuList_SelectionChanged(object sender, EventArgs e)
        {

            int i = dataGridViewMenuList.CurrentRow.Index;
            _menuName = dataGridViewMenuList[1, i].Value.ToString();
            _menuPrice = dataGridViewMenuList[2, i].Value.ToString();

        }

        private void pctrBoxMenuPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(); // in order to open file 

            pctrBoxMenuPicture.ImageLocation = openFileDialog.FileName;  // to set the image
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemsUC_Load(object sender, EventArgs e)
        {
            btnAddMenu.BringToFront();
        }

        private void dataGridViewMenuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewMenuList.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                btnAddMenu.Enabled = false;
                btnUpdateMenu.Enabled = true;
                txtBoxName.Text = _menuName;
                txtBoxPrice.Text = _menuPrice;


                btnUpdateMenu.BringToFront();

            }
            else if (colName == "Delete")
            {
                DialogResult DeleteMenu = MessageBox.Show("Are you sure you want to delete this Menu? ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DeleteMenu == DialogResult.Yes)
                {

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        int i = dataGridViewMenuList.CurrentRow.Index;

                        var DeleteMenuQuery = "DELETE FROM MENU_DETAILS WHERE menu_ID = '" + dataGridViewMenuList[0, i].Value.ToString() + "'";
                        var DeleteCommand = new SqlCommand(DeleteMenuQuery, connection);
                        DeleteCommand.ExecuteNonQuery();

                        dataGridViewMenuList.Refresh();
                        LoadMenuRecords();

                        DeleteMenuNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                        DeleteMenuNotification.Text = "Hello";
                        DeleteMenuNotification.Visible = true;
                        DeleteMenuNotification.BalloonTipTitle = "User Successfully Removed!";
                        DeleteMenuNotification.BalloonTipText = "List Updated";
                        DeleteMenuNotification.ShowBalloonTip(100);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }
    }
}
