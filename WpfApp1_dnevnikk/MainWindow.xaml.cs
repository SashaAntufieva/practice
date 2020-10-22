using System;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApp1_dnevnikk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bd();
        }
        public void bd() // Фуекция вывода информации из БД в приложение
        {
            fio.Clear(); gruppa.Clear(); datar.Clear();
            id.Clear(); data.Clear(); tema.Clear(); ocenka.Clear();

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            string ssql1 = $"SELECT TOP (1000) [name],[groupp],[data] FROM [DNEVNIK].[dbo].[student]"; //Зaпрос таблицы Student

            SqlCommand command = new SqlCommand(ssql1, conn);// Объект вывода запросов
            SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса вывод информации

            while (reader.Read()) //В цикле вывести всю информацию из таблици
            {

                fio.Text += (reader[0].ToString() + "\n");
                gruppa.Text += (reader[1].ToString() + "\n");
                datar.Text += (reader[2].ToString() + "\n");

            }
            reader.Close(); // Закрываем "чтение" первой таблицы

            string sql2 = $"SELECT TOP (1000) [id],[data],[zadanie],[osenka]FROM[DNEVNIK].[dbo].[dnevnik]"; // Запрос таблицы Dnevnik
            SqlCommand command2 = new SqlCommand(sql2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                id.Text += (reader2[0].ToString() + "\n");
                data.Text += (reader2[1].ToString() + "\n");
                tema.Text += (reader2[2].ToString() + "\n");
                ocenka.Text += (reader2[3].ToString() + "\n");
            }

            reader2.Close(); // Закрываем чтение второй таблицы
        }

        private void dobs_Click(object sender, RoutedEventArgs e)
        {
            string fio = fiod.Text;
            string group = gruppad.Text;
            string data_roz = datard.Text;

            string ssql = $"INSERT INTO student (name,groupp,data) VALUES ('{fio}', '{group}','{data_roz}')"; //ЗАпрос вставить данные в таблицу 

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nВставлено объектов: " + number);

            fiod.Clear(); gruppad.Clear(); datard.Clear();
        }

        private void dobo_Click(object sender, RoutedEventArgs e)
        {
            int id2 = Convert.ToInt32(idd.Text);
            string data = datad.Text;
            string zadanie = temad.Text;
            string ocenka = ocenkad.Text;

            string ssql = $"INSERT INTO dnevnik (id,data,zadanie,osenka) VALUES ('{id2}', '{data}','{zadanie}', '{ocenka}')"; //ЗАпрос вставить данные в таблицу

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nВставлено объектов: " + number);

            idd.Clear(); datad.Clear(); temad.Clear(); ocenkad.Clear();
        }

        private void sohf_Click(object sender, RoutedEventArgs e)
        {
            string fio1 = fioe.Text;
            string fio2 = fione.Text;

            string ssql = $"UPDATE student SET name = '{fio2}' WHERE name = '{fio1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            fioe.Clear(); fione.Clear();
        }

        private void sohg_Click(object sender, RoutedEventArgs e)
        {
            string group1 = gruppae.Text;
            string group2 = gruppane.Text;

            string ssql = $"UPDATE student SET groupp = '{group2}' WHERE groupp = '{group1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            gruppae.Clear(); gruppane.Clear();
        }

        private void sohdr_Click(object sender, RoutedEventArgs e)
        {
            string datar1 = datare.Text;
            string datar2 = datarne.Text;

            string ssql = $"UPDATE student SET data = '{datar2}' WHERE data = '{datar1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            datare.Clear(); datarne.Clear();
        }

        private void obn_Click(object sender, RoutedEventArgs e)
        {
            fio.Clear(); gruppa.Clear(); datar.Clear();
            id.Clear(); data.Clear(); tema.Clear(); ocenka.Clear();

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            string ssql1 = $"SELECT TOP (1000) [name],[groupp],[data] FROM [DNEVNIK].[dbo].[student]"; //Зaпрос таблицы Student

            SqlCommand command = new SqlCommand(ssql1, conn);// Объект вывода запросов
            SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса вывод информации

            while (reader.Read()) //В цикле вывести всю информацию из таблици
            {

                fio.Text += (reader[0].ToString() + "\n");
                gruppa.Text += (reader[1].ToString() + "\n");
                datar.Text += (reader[2].ToString() + "\n");

            }
            reader.Close(); // Закрываем "чтение" первой таблицы

            string sql2 = $"SELECT TOP (1000) [id],[data],[zadanie],[osenka]FROM[DNEVNIK].[dbo].[dnevnik]"; // Запрос таблицы Dnevnik
            SqlCommand command2 = new SqlCommand(sql2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                id.Text += (reader2[0].ToString() + "\n");
                data.Text += (reader2[1].ToString() + "\n");
                tema.Text += (reader2[2].ToString() + "\n");
                ocenka.Text += (reader2[3].ToString() + "\n");
            }

            reader2.Close(); // Закрываем чтение второй таблицы
        }

        private void sohid_Click(object sender, RoutedEventArgs e)
        {
            string id1 = ide.Text;
            string id2 = idne.Text;

            string ssql = $"UPDATE dnevnik SET id = '{id2}' WHERE id = '{id1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            ide.Clear(); idne.Clear();
        }

        private void sohd_Click(object sender, RoutedEventArgs e)
        {
            string data1 = datae.Text;
            string data2 = datane.Text;

            string ssql = $"UPDATE dnevnik SET data = '{data2}' WHERE data = '{data1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            datae.Clear(); datane.Clear();
        }

        private void soht_Click(object sender, RoutedEventArgs e)
        {
            string tema1 = temae.Text;
            string tema2 = temane.Text;

            string ssql = $"UPDATE dnevnik SET zadanie = '{tema2}' WHERE zadanie = '{tema1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            temae.Clear(); temane.Clear();
        }

        private void soho_Click(object sender, RoutedEventArgs e)
        {
            string ocenka1 = ocenkae.Text;
            string ocenka2 = ocenkane.Text;

            string ssql = $"UPDATE dnevnik SET ocenka = '{ocenka2}' WHERE ocenka = '{ocenka1}'";

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения*/

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nОбновлено объектов: " + number);

            ocenkae.Clear(); ocenkane.Clear();
        }

        private void udf_Click(object sender, RoutedEventArgs e)
        {
            string fio = fiou.Text;

            string ssql = $"DELETE  FROM student  WHERE name = '{fio}'"; //ЗАпрос удалить поле 

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nУдалено объектов: " + number);

            fiou.Clear();
        }

        private void udid_Click(object sender, RoutedEventArgs e)
        {
            string id2 = idu.Text;

            string ssql = $"DELETE  FROM dnevnik  WHERE id = '{id2}'"; //ЗАпрос удалить поле 

            string connectionString = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DNEVNIK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();// Открытие Соединения

            SqlCommand command = new SqlCommand(ssql, conn);// Объект вывода запросов

            int number = command.ExecuteNonQuery();
            MessageBox.Show("Изменения сохранены!\nУдалено объектов: " + number);

            idu.Clear();
        }
    }
}
