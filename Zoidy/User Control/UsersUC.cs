using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zoidy
{
    public partial class UsersUC : UserControl
    {
        public void LoadUsersRecords()
        {


            var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                var DisplayAllUsers = "SELECT * FROM USER_DETAILS;";

                SqlDataAdapter adapter = new SqlDataAdapter(DisplayAllUsers, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsersList.DataSource = dt;
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

        public UsersUC()
        {
            InitializeComponent();
            LoadUsersRecords();
        }

        string _id, _firstName, _middleName, _lastName, _username, _role, _password;

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            var FirstName = txtBoxFirstName.Text;

            var MiddleName = txtBoxMiddleName.Text;

            var LastName = txtBoxLastName.Text;

            var Username = txtBoxUsername.Text;

            var Role = cmbBoxRole.Text;

            var Password = txtBoxPassword.Text;

            var ConfirmPassword = txtBoxConfirmPassword.Text;


            if (string.IsNullOrEmpty(FirstName) &&
                string.IsNullOrEmpty(LastName) &&
                string.IsNullOrEmpty(Username) &&
                string.IsNullOrEmpty(Role) &&
                string.IsNullOrEmpty(Password) &&
                string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("PLEASE FILL OUT ALL THE BOX PROVIDED!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                MessageBox.Show("First Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("Last Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Username is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Role is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("Confirm Password is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(FirstName) &&
                !string.IsNullOrEmpty(LastName) &&
                !string.IsNullOrEmpty(Username) &&
                !string.IsNullOrEmpty(Role) &&
                !string.IsNullOrEmpty(Password) &&
                !string.IsNullOrEmpty(ConfirmPassword))
            {
                var hasNumber = new Regex(@"[0-9]+");


                if (hasNumber.IsMatch(FirstName))
                {
                    MessageBox.Show("First Name must not contain Numbers");
                    return;
                }

                if (hasNumber.IsMatch(MiddleName))
                {
                    MessageBox.Show("Middle Name must not contain Numbers");
                    return;
                }

                if (hasNumber.IsMatch(LastName))
                {
                    MessageBox.Show("Last Name must not contain Numbers");
                    return;
                }

                var hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (hasSpecialChar.IsMatch(FirstName))
                {
                    MessageBox.Show("First Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(MiddleName))
                {
                    MessageBox.Show("Middle Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(LastName))
                {
                    MessageBox.Show("Last name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(Username))
                {
                    MessageBox.Show("Username must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(Password))
                {
                    MessageBox.Show("Password must not contain Special Characters!");
                    return;
                }

                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Password and ConfirmPassword must be the same! Try Again");
                    return;
                }
                else
                {
                    int i = dataGridViewUsersList.CurrentRow.Index;
                    var UpdateUserQuery = "UPDATE USER_DETAILS SET user_firstname = '" + FirstName +
                                                                "', user_middlename = '" + MiddleName +
                                                                "', user_lastname = '" + LastName +
                                                                "', user_username = '" + Username +
                                                                "', user_role = '" + Role +
                                                                "', user_password = '" + Password +
                                                                "' WHERE user_id LIKE '" + dataGridViewUsersList[0, i].Value.ToString() + "'";

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);

                   

                    DialogResult UpdateUserConfirmation = MessageBox.Show("Are you sure you want to add the Following: \n" +
                                                                        "\n" +
                                                                        "       First Name: " + FirstName + "\n" +
                                                                        "       Middle Name: " + MiddleName + "\n" +
                                                                        "       Last Name: " + LastName + "\n" +
                                                                        "       Username: " + Username + "\n" +
                                                                        "       Role: " + Role + "\n" +
                                                                        "       Password: " + Password + "\n" +
                                                                        "       ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (UpdateUserConfirmation == DialogResult.Yes)
                    {
                        connection.Open();
                        try
                        {
                            var updateCommand = new SqlCommand(UpdateUserQuery, connection);
                            updateCommand.ExecuteNonQuery();

                            dataGridViewUsersList.Refresh();
                            LoadUsersRecords();

                            UpdateUserNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                            UpdateUserNotification.Text = "Hello";
                            UpdateUserNotification.Visible = true;
                            UpdateUserNotification.BalloonTipTitle = "User Details Successfully Updated!";
                            UpdateUserNotification.BalloonTipText = "List Updated";
                            UpdateUserNotification.ShowBalloonTip(100);

                            btnAdd.Enabled = true;
                            btnUpdate.Enabled = false;

                            txtBoxFirstName.Clear();
                            txtBoxMiddleName.Clear();
                            txtBoxLastName.Clear();
                            txtBoxUsername.Clear();
                            txtBoxPassword.Clear();
                            txtBoxConfirmPassword.Clear();

                            btnAdd.BringToFront();

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

        public void ClearAllUsers()
        {
            txtBoxFirstName.Text = null;
            txtBoxMiddleName.Text = null;
            txtBoxLastName.Text = null;
            txtBoxUsername.Text = null;
            txtBoxConfirmPassword.Text = null;
            txtBoxPassword.Text = null;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var FirstName = txtBoxFirstName.Text;

            var MiddleName = txtBoxMiddleName.Text;

            var LastName = txtBoxLastName.Text;

            var Username = txtBoxUsername.Text;

            var Role = cmbBoxRole.Text;

            var Password = txtBoxPassword.Text;

            var ConfirmPassword = txtBoxConfirmPassword.Text;

            if (string.IsNullOrEmpty(FirstName) &&
                string.IsNullOrEmpty(LastName) &&
                string.IsNullOrEmpty(Username) &&
                string.IsNullOrEmpty(Role) &&
                string.IsNullOrEmpty(Password) &&
                string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("It is already cleared! ;D", "Oh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ClearAll = MessageBox.Show("Are you sure you want to clear all?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ClearAll == DialogResult.Yes)
                {
                    ClearAllUsers();
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewUsersList_SelectionChanged_1(object sender, EventArgs e)
        {


            int i = dataGridViewUsersList.CurrentRow.Index;
            _firstName = dataGridViewUsersList[1, i].Value.ToString();
            _middleName = dataGridViewUsersList[2, i].Value.ToString();
            _lastName = dataGridViewUsersList[3, i].Value.ToString();
            _username = dataGridViewUsersList[4, i].Value.ToString();
            _role = dataGridViewUsersList[5, i].Value.ToString();
            _password = dataGridViewUsersList[6, i].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            var Profile = pctrBoxProfile.Image;

            var FirstName = txtBoxFirstName.Text;

            var MiddleName = txtBoxMiddleName.Text;

            var LastName = txtBoxLastName.Text;

            var Username = txtBoxUsername.Text;

            var Role = cmbBoxRole.Text;

            var Password = txtBoxPassword.Text;

            var ConfirmPassword = txtBoxConfirmPassword.Text;


            if (string.IsNullOrEmpty(FirstName) &&
                string.IsNullOrEmpty(LastName) &&
                string.IsNullOrEmpty(Username) &&
                string.IsNullOrEmpty(Role) &&
                string.IsNullOrEmpty(Password) &&
                string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("PLEASE FILL OUT ALL THE BOX PROVIDED!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                MessageBox.Show("First Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("Last Name is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Username is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Role is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("Confirm Password is Empty! Fill it out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(FirstName) &&
                !string.IsNullOrEmpty(LastName) &&
                !string.IsNullOrEmpty(Username) &&
                !string.IsNullOrEmpty(Role) &&
                !string.IsNullOrEmpty(Password) &&
                !string.IsNullOrEmpty(ConfirmPassword))
            {
                var hasNumber = new Regex(@"[0-9]+");


                if (hasNumber.IsMatch(FirstName))
                {
                    MessageBox.Show("First Name must not contain Numbers");
                    return;
                }

                if (hasNumber.IsMatch(MiddleName))
                {
                    MessageBox.Show("Middle Name must not contain Numbers");
                    return;
                }

                if (hasNumber.IsMatch(LastName))
                {
                    MessageBox.Show("Last Name must not contain Numbers");
                    return;
                }

                var hasSpecialChar = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (hasSpecialChar.IsMatch(FirstName))
                {
                    MessageBox.Show("First Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(MiddleName))
                {
                    MessageBox.Show("Middle Name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(LastName))
                {
                    MessageBox.Show("Last name must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(Username))
                {
                    MessageBox.Show("Username must not contain Special Characters!");
                    return;
                }

                if (hasSpecialChar.IsMatch(Password))
                {
                    MessageBox.Show("Password must not contain Special Characters!");
                    return;
                }

                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Password and ConfirmPassword must be the same! Try Again");
                    return;
                }
                else
                {
                    var AddUserQuery = "INSERT INTO USER_DETAILS " +
                              "(" +
                              "user_profile," +
                              "user_firstname," +
                              "user_middlename," +
                              "user_lastname," +
                              "user_username," +
                              "user_role," +
                              "user_password" +
                              ") VALUES " +
                              "(" +
                              $"'{Profile}'," +
                              $"'{FirstName}'," +
                              $"'{MiddleName}'," +
                              $"'{LastName}'," +
                              $"'{Username}'," +
                              $"'{Role}'," +
                              $"'{Password}'" +
                              $");";

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);

                    connection.Open();

                    DialogResult AddUserConfirmation = MessageBox.Show("Are you sure you want to add the Following: \n" +
                                                                        "\n" +
                                                                        "       First Name: " + FirstName + "\n" +
                                                                        "       Middle Name: " + MiddleName + "\n" +
                                                                        "       Last Name: " + LastName + "\n" +
                                                                        "       Username: " + Username + "\n" +
                                                                        "       Role: " + Role + "\n" +
                                                                        "       Password: " + Password + "\n" +
                                                                        "       ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (AddUserConfirmation == DialogResult.Yes)
                    {
                        try
                        {


                            var addCommand = new SqlCommand(AddUserQuery, connection);
                            addCommand.ExecuteNonQuery();

                            dataGridViewUsersList.Refresh();
                            LoadUsersRecords();

                            AddUserNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                            AddUserNotification.Text = "Hello";
                            AddUserNotification.Visible = true;
                            AddUserNotification.BalloonTipTitle = "User Successfully Added!";
                            AddUserNotification.BalloonTipText = "List Updated";
                            AddUserNotification.ShowBalloonTip(100);


                        }
                        catch (Exception ex)
                        {


                            MessageBox.Show(ex.Message);


                        }
                        finally
                        {

                            txtBoxFirstName.Clear();
                            pctrBoxProfile.Image.Dispose();
                            txtBoxMiddleName.Clear();
                            txtBoxLastName.Clear();
                            txtBoxUsername.Clear();
                            txtBoxPassword.Clear();
                            txtBoxConfirmPassword.Clear();


                            connection.Close();


                        }
                    }
                }
            }
        }

        private void pctrBoxProfile_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(); // in order to open file 

            pctrBoxProfile.ImageLocation = openFileDialog.FileName;  // to set the image


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {





        }

        private void dataGridViewUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dataGridViewUsersList.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                txtBoxFirstName.Text = _firstName;
                txtBoxMiddleName.Text = _middleName;
                txtBoxLastName.Text = _lastName;
                txtBoxUsername.Text = _username;
                cmbBoxRole.Text = _role;
                txtBoxPassword.Text = _password;

                btnUpdate.BringToFront();

            }
            else if (colName == "Delete")
            {
                DialogResult DeleteUser = MessageBox.Show("Are you sure you want to delete this User? ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DeleteUser == DialogResult.Yes)
                {

                    var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
                    var connection = new SqlConnection(connectionString);

                    try
                    {
                        connection.Open();

                        int i = dataGridViewUsersList.CurrentRow.Index;

                        var DeleteUserQuery = "DELETE FROM USER_DETAILS WHERE user_id = '" + dataGridViewUsersList[0, i].Value.ToString() + "'";
                        var DeleteCommand = new SqlCommand(DeleteUserQuery, connection);
                        DeleteCommand.ExecuteNonQuery();

                        dataGridViewUsersList.Refresh();
                        LoadUsersRecords();

                        DeleteUserNotification.Icon = new System.Drawing.Icon(Path.GetFullPath("C:\\Users\\Anna Agduma\\source\\repos\\POS_ZOIDY\\POS_ZOIDY\\NotifyIcon\\success.ico"));
                        DeleteUserNotification.Text = "Hello";
                        DeleteUserNotification.Visible = true;
                        DeleteUserNotification.BalloonTipTitle = "User Successfully Removed!";
                        DeleteUserNotification.BalloonTipText = "List Updated";
                        DeleteUserNotification.ShowBalloonTip(100);
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



        private void UsersUC_Load(object sender, EventArgs e)
        {


            btnAdd.BringToFront();

            


        }
    }
}
