
using Dapper;

namespace FirstWinForm
{

    public partial class MainForm : Form
    {
        // The name of the SQLite database file
        readonly string sqliteFileName = "MyDatabase.db";
        // The connection string of the SQLite database
        readonly string sqliteConnString = "Data Source=MyDatabase.db";
        public MainForm()
        {
            InitializeComponent();
            CreateDocument();
            InitControls();
        }
        // Initialize the controls
        void InitControls()
        {
            StartPosition = FormStartPosition.CenterScreen;
            numericUpDownID.Maximum = int.MaxValue;
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "yyyy-MM-dd";
            dataGridViewScoreData.CellMouseClick += DataGridViewScoreData_CellMouseClick;
        }
        private void DataGridViewScoreData_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Set the value of the NumericUpDown control
                numericUpDownID.Value = (int)dataGridViewScoreData.Rows[e.RowIndex].Cells[0].Value;
                // fetch single user from sqlite
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    var user = conn.QueryFirstOrDefault<User>("SELECT * FROM Users WHERE Id = @Id", new { Id = numericUpDownID.Value });
                    if (user != null)
                    {
                        textBoxName.Text = user.Name;
                        dateTimePickerBirthday.Value = user.Birthday;
                    }
                    conn.Close();
                }
            }
        }

        void CreateDocument()
        {
            // Create a SQLite document if not exist
            if (!File.Exists(sqliteFileName))
            {
                System.Data.SQLite.SQLiteConnection.CreateFile(sqliteFileName);
                MessageBox.Show("Database created successfully!");
            }
        }
        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> list = new List<User>()
                {
                    new User(1, "John", new DateTime(1990, 1, 1)),
                    new User(2, "Frank", new DateTime(1994, 3, 14)),
                    new User(3, "Maomi", new DateTime(2021, 10, 10)),
                };
                // Create a connection to the database
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // insert mock data to sqlite if the table has no data usinf dapper
                    int count = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM Users");
                    if (count == 0)
                    {
                        // transaction
                        using (var transaction = conn.BeginTransaction())
                        {
                            conn.Execute("INSERT INTO Users (Name, Birthday) VALUES (@Name, @Birthday)", list);
                            transaction.Commit();
                            MessageBox.Show("Data inserted successfully!");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void ButtonCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // Create a table of users if it does not exist using dapper
                    conn.Execute("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT, Birthday TEXT)");
                    conn.Close();
                    MessageBox.Show("Table created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void ButtonTruncateDB_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // Truncate the table users using dapper
                    conn.Execute("DELETE FROM Users");
                    conn.Close();
                    MessageBox.Show("Table dropped successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // Select all users from the table using dapper
                    List<User> users = conn.Query<User>("SELECT * FROM Users").ToList();
                    conn.Close();
                    dataGridViewScoreData.DataSource = users;
                    // set birthday format to yyyy-MM-dd
                    dataGridViewScoreData.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDownID.Value;


            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    if (id > 0)
                    {
                        var user = new User(id: id, name: textBoxName.Text, birthday: dateTimePickerBirthday.Value);
                        // Update the user using dapper
                        conn.Execute("UPDATE Users SET Name = @Name, Birthday = @Birthday WHERE Id = @Id", user);
                        MessageBox.Show("User updated successfully!");
                    }
                    else
                    {
                        conn.Execute("INSERT INTO Users (Name, Birthday) VALUES (@Name, @Birthday)", new { Name = textBoxName.Text, Birthday = dateTimePickerBirthday.Value });
                        MessageBox.Show("User inserted successfully!");
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            // drop table users
            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // Drop the table users using dapper
                    conn.Execute("DROP TABLE Users");
                    conn.Close();
                    MessageBox.Show("Table dropped successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownID.Value = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDownID.Value;
            if (id == 0)
            {
                MessageBox.Show("Please select a user to delete!");
                return;
            }
            try
            {
                using (var conn = new System.Data.SQLite.SQLiteConnection(sqliteConnString))
                {
                    conn.Open();
                    // Delete the user using dapper
                    conn.Execute("DELETE FROM Users WHERE Id = @Id", new { Id = id });
                    conn.Close();
                    MessageBox.Show("User deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "---" + ex.StackTrace);
            }
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime Birthday { get; set; }
        // this empty constructor is for dapper
        public User()
        {

        }
        public User(int id, string name, DateTime birthday)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
        }
    }
}
