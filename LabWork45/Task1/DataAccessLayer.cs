using Microsoft.Data.SqlClient;
using System.Data;

namespace Task1
{
    internal static class DataAccessLayer
    {
        public static string Server { get; set; } = @"prserver\SQLEXPRESS";
        public static string DataBase { get; set; } = "ispp3510";
        public static string Login { get; set; } = "ispp3510";
        public static string Password { get; set; } = "3510";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = Server,
                    UserID = Login,
                    Password = Password,
                    TrustServerCertificate = true,
                    InitialCatalog = DataBase
                };

                return builder.ConnectionString;
            }
        }

        //lab45
        public static object GetValue(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteScalar();
        }

        public static DataTable GetTable(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            DataTable table = new();
            using SqlDataAdapter adapter = new(query, connection);
            adapter.Fill(table);
            return table;
        }

        public static List<Book> GetBookList()
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT bookId, title, price FROM Book";

            SqlCommand command = new(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Book> books = new();

            while (reader.Read())
            {
                var book = new Book
                {
                    Id = Convert.ToInt32(reader["bookId"]),
                    Title = reader["title"].ToString(),
                    Price = Convert.ToDouble(reader["price"])
                };
                books.Add(book);
            }
            return books;
        }

        // lab46
        public static int ChangeTable(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }

        public static bool ChangePrice(int userPrice, int userBookId)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"UPDATE Book SET price = {userPrice} WHERE bookId = {userBookId}";
            SqlCommand command = new(query, connection);
            return (command.ExecuteNonQuery() > 0);
        }

        public static DataTable GetDataTable(string table)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"SELECT * FROM {table}";
            using SqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //lab47
        public static int GetBookPrice(int price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = @"SELECT COUNT(*) 
                             FROM Book 
                             WHERE price < @price;";
            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@price", price);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static int GetGameId(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new($"{query}; SET @id=SCOPE_IDENTITY();", connection);

            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            return Convert.ToInt32(command.Parameters["@id"].Value);
        }

        public static DataTable GetBookTable(int price, string genre)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"SELECT price, genre FROM Book WHERE genre = @genre AND price < @price";

            using SqlDataAdapter adapter = new(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@price", price);
            adapter.SelectCommand.Parameters.AddWithValue("@genre", genre);
            DataTable table = new();
            adapter.Fill(table);

            return table;
        }

        //lab48
        public static void AddAuthor(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "AddAuthor @surname, @name, @country";
            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);

            command.ExecuteNonQuery();
        }

        public static DataTable GetAuthorTable()
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT * FROM Author";
            using SqlDataAdapter adapter = new(query, connection);
            DataTable table = new();
            adapter.Fill(table);

            return table;
        }

        public static int AddAuthorWithId(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "AddAuthorWithId @surname, @name, @country";
            SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);

            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static DataTable GetBookListPrice(int initialPrice, int endPrice)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "GetBookList @initialPrice, @endPrice";
            using SqlDataAdapter adapter = new(query, connection);

            adapter.SelectCommand.Parameters.AddWithValue("@initialPrice", initialPrice);
            adapter.SelectCommand.Parameters.AddWithValue("@endPrice", endPrice);

            DataTable table = new();
            adapter.Fill(table);

            return table;
        }
    }
}
