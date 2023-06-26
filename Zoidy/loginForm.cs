using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Zoidy
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader reader;
        DataSet dataSet;
        BindingSource bindingSource;

        public static string setValueForUsername = "";

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var connectionString = @"Data Source=ZOID\ZOIDMSSQLSERVER;Initial Catalog=DB_POSZOIDY;Integrated Security=True";
            conn = new SqlConnection(connectionString);

            var Username = txtBoxUsername.Text.Trim();
            var Password = txtBoxPassword.Text.Trim();

            conn.Open();
            try
            {
                if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("No Username and Password Entered!");
                    return;
                } 
                
                if (string.IsNullOrEmpty(Username))
                {
                    MessageBox.Show("Username is empty! Fill it out!");
                    return;
                }

                if (string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Password is empty! Fill it out!");
                    return;
                }

                var hasSpecialCharacter = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");

                if (hasSpecialCharacter.IsMatch(Username))
                {
                    MessageBox.Show("Username must not contain Special Characters!");
                    return;
                }

                if (hasSpecialCharacter.IsMatch(Password))
                {
                    MessageBox.Show("Password must not contain Special Characters!");
                    return;
                }

                if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                {

                    cmd = new SqlCommand("SELECT * FROM USER_DETAILS WHERE user_username = '" + Username + "' AND user_password = '" + Password + "'", conn);

                    adapt = new SqlDataAdapter(cmd);

                    dataSet = new DataSet();
                    adapt.Fill(dataSet);

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataSet;

                    int i = dataSet.Tables[0].Rows.Count;

                    if (i == 1)
                    {

                        setValueForUsername = Username;

                        reader = cmd.ExecuteReader();
                        reader.Read();



                        if (reader[6].ToString() == "Admin")
                        {

                            adminHomeForm adminForm = new adminHomeForm();
                            adminForm.Show();
                            this.Hide();

                            UserLoggedIn.BalloonTipText = "Welcome, " + Username;
                            UserLoggedIn.ShowBalloonTip(100);

                        }

                        else if (reader[6].ToString() == "Cashier")
                        {

                            cashierHomeForm cashierForm = new cashierHomeForm();
                            cashierForm.Show();
                            this.Hide();

                            UserLoggedIn.BalloonTipText = "Welcome, " + Username;
                            UserLoggedIn.ShowBalloonTip(100);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxUsername.Clear();
                        txtBoxPassword.Clear();

                        txtBoxUsername.Focus();

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
