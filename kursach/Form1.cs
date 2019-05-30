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

namespace kursach
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {

            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //адрес таблицы данных
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DevilS\source\repos\kursach\kursach\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;// получение таблицы
            SqlCommand command = new SqlCommand("SELECT*FROM[Abiturient]", sqlConnection);//выбор всех столбцов таблицы
            try
            {
                sqlReader = await command.ExecuteReaderAsync();//считывание таблицы
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Number"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Secondname"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["Firstname"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["Thirdname"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Examfirst"]));
                    listBox8.Items.Add(Convert.ToString(sqlReader["Examsecond"]));
                    listBox9.Items.Add(Convert.ToString(sqlReader["Examthird"]));
                    listBox10.Items.Add(Convert.ToString(sqlReader["Atestat"]));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //отключение от таблицы..............................................................................................................................................................................................
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();

            }
        }



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
        //обновление таблицы.............................................................................................................................................................................................
        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            SqlDataReader sqlReader = null;// получение таблицы
            SqlCommand command = new SqlCommand("SELECT*FROM[Abiturient]", sqlConnection);//выбор всех столбцов таблицы
            try
            {
                sqlReader = await command.ExecuteReaderAsync();//считывание таблицы
                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]));
                    listBox2.Items.Add(Convert.ToString(sqlReader["Number"]));
                    listBox3.Items.Add(Convert.ToString(sqlReader["Secondname"]));
                    listBox4.Items.Add(Convert.ToString(sqlReader["Firstname"]));
                    listBox5.Items.Add(Convert.ToString(sqlReader["Thirdname"]));
                    listBox6.Items.Add(Convert.ToString(sqlReader["Date"]));
                    listBox7.Items.Add(Convert.ToString(sqlReader["Examfirst"]));
                    listBox8.Items.Add(Convert.ToString(sqlReader["Examsecond"]));
                    listBox9.Items.Add(Convert.ToString(sqlReader["Examthird"]));
                    listBox10.Items.Add(Convert.ToString(sqlReader["Atestat"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        //Добавить
        private async void button2_Click(object sender, EventArgs e)
        {
            if (label22.Visible)
                label22.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Abiturient](Firstname,Secondname,Thirdname,Number,Examfirst,Examsecond,Examthird,Atestat,Date)VALUES(@Firstname,@Secondname,@Thirdname,@Number,@Examfirst,@Examsecond,@Examthird,@Atestat,@Date)", sqlConnection);
                command.Parameters.AddWithValue("Firstname", textBox3.Text);
                command.Parameters.AddWithValue("Secondname", textBox2.Text);
                command.Parameters.AddWithValue("Thirdname", textBox4.Text);
                command.Parameters.AddWithValue("Number", textBox1.Text);
                command.Parameters.AddWithValue("Examfirst", textBox7.Text);
                command.Parameters.AddWithValue("Examsecond", textBox9.Text);
                command.Parameters.AddWithValue("Examthird", textBox8.Text);
                command.Parameters.AddWithValue("Date", textBox5.Text);
                command.Parameters.AddWithValue("Atestat", textBox6.Text);
                await command.ExecuteNonQueryAsync();
            }
            //ошибка при не заполненных полях
            else
            {
                label22.Visible = true;
                label22.Text = "Поля не заполенны";
            }
        }
        //Конец добавления

        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        //удаление.....................................................................................................................................................................................................
        private async void button3_Click(object sender, EventArgs e)

        {

            if (label24.Visible)
                label24.Visible = false;
            if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrWhiteSpace(textBox21.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM[Abiturient] WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox21.Text);
                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label24.Visible = true;
                label24.Text = "Введите Id";


            }
        }
        //Удаление абитуриентов с баллом атестата ниже 8(заданного)
        private async void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM[Abiturient] WHERE[Atestat]<8", sqlConnection);
            await command.ExecuteNonQueryAsync();
        }
        //конец удаления
        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //ИЗМЕНИТЬ!!!..............................................................................................................................................................................
        //изменение.Фамилия.........................................................................................................................................................................................................
        private async void button4_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrWhiteSpace(textBox17.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Secondname]=@Secondname  WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Secondname", textBox17.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox17.Text) || string.IsNullOrWhiteSpace(textBox17.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Фамилия) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //изменение.Имя.......................................................................................................................................................................................................................
        private async void button5_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox16.Text) && !string.IsNullOrWhiteSpace(textBox16.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Firstname]=@Firstname  WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Firstname", textBox16/*Ввод имени*/.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox16.Text) || string.IsNullOrWhiteSpace(textBox16.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Имя) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //изменение.Отчество..........................................................................................................................................................................................................
        private async void button6_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox15.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Thirdname]=@Thirdname WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Thirdname", textBox15.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox15.Text) || string.IsNullOrWhiteSpace(textBox15.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Отчество) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Дата рождения.......................................................................................................................................................................................................
        private async void button7_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrWhiteSpace(textBox14.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Date]=@Date WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Date", textBox14.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox14.Text) || string.IsNullOrWhiteSpace(textBox14.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Дата рождения) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Рег.Номер................................................................................................................................................................................................
        private async void button8_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrWhiteSpace(textBox18.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Number]=@Number WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Number", textBox18.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле Индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox18.Text) || string.IsNullOrWhiteSpace(textBox18.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Рег.Номер) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Первый экзамен....................................................................................................................................................................................................
        private async void button9_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Examfirst]=@Examfirst WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Examfirst", textBox12.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox12.Text)  ||string.IsNullOrWhiteSpace(textBox12.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Первый экзамен) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Второй экзамен.....................................................................................................................................................................................................
        private async void button10_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Examsecond]=@Examsecond WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Examsecond", textBox10.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrWhiteSpace(textBox10.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Второй экзамен) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Третий экзамен..............................................................................................................................................................................................
        private async void button11_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Examthird]=@Examthird WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Examthird", textBox11.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) ||string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox11.Text) ||string.IsNullOrWhiteSpace(textBox11.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Третий экзамен) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }
        //Изменение.Балл атестата.............................................................................................................................................................................................
        private async void button12_Click(object sender, EventArgs e)
        {
            if (label23.Visible)
                label23.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text) && (textBox23.Text == textBox19.Text)
                && !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Abiturient] SET [Atestat]=@Atestat WHERE[Id]=@Id", sqlConnection);
                command.Parameters.AddWithValue("Id", textBox20.Text);
                command.Parameters.AddWithValue("Atestat", textBox13.Text);
                await command.ExecuteNonQueryAsync();
            }
            else if (string.IsNullOrEmpty(textBox20.Text) || string.IsNullOrWhiteSpace(textBox20.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле индефикатора не заполненно";
            }
            else if (string.IsNullOrEmpty(textBox13.Text) ||string.IsNullOrWhiteSpace(textBox13.Text))
            {
                label23.Visible = true;
                label23.Text = "Поле (Балл атестата) не заполненно";
            }
            else if (textBox23.Text != textBox19.Text)
            {
                label23.Visible = true;
                label23.Text = "Неверный пароль";
            }
            else if (string.IsNullOrEmpty(textBox19.Text) || string.IsNullOrWhiteSpace(textBox19.Text))
            {
                label23.Visible = true;
                label23.Text = "Введите пароль";
            }
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT[Number],[Secondname]FROM Abiturient WHERE Secondname LIKE 'test'");
           listBox11.
        }
        // добавление пароля.............................................................................................................................................................................................
        private void button14_Click(object sender, EventArgs e)
        {
            if (label37.Visible)
                label37.Visible = false;
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Abiturient](Password)VALUES(@Password)", sqlConnection);
                command.Parameters.AddWithValue("Password", textBox23.Text);
                label37.Visible = true;
                label37.Text = "Пароль успешно добавлен";
            }
            else if (string.IsNullOrEmpty(textBox23.Text) && string.IsNullOrWhiteSpace(textBox23.Text))
                {
                    label37.Visible = true;
                    label37.Text = "Поле пустое,добавьте пароль";
                }
               
            
        }
        //Cправка..................................................................................................................................................................................................................
        private void button15_Click(object sender, EventArgs e)
        {
            Form2 Spravka = new Form2();
            Spravka.ShowDialog();
        }
    }
  }