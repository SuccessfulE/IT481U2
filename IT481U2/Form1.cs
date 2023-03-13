namespace IT481U2
{
    public partial class Form1 : Form
    {
        Controller database;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new Controller("Server = desktop-hp19nsb\\SQLEXPRESS;" +
                                        "Trusted_Connection = true;" +
                                        "Database = northwind;" +
                                        "User Instance = false ;" +
                                        "Connection timeout = 30");
            MessageBox.Show("Connection Information Sent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

    }
}