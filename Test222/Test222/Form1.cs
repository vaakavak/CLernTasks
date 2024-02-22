using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Windows.Forms;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Test222
{
    public partial class Form1 : Form
    {
        private int counter = 1; // Инициализация счетчика

        public Form1()
        {
            InitializeComponent();
            string[] items = { "*",
                "блокировка почтового ящика",
                "блокировка пропуска сотрудника",
                "блокировка учетной записи",
                "включение переадресации почты",
                "восстановление информации с Fserver",
                "выгрузка данных рабочего времении c бастиона",
                "выпуск пропуска в бастионе",
                "заведение нового сотрудника на портале",
                "заведение новых проектов",
                "заведение папок на Fserver",
                "заведение почты",
                "заведение учетки пользователя в АД",
                "замена фото сотрудников в БАСТИОНЕ",
                "замена фото сотрудников на портале",
                "изменение названия проекта",
                "корректировка времени входа или выхода сотрудников",
                "корректировка телефонов сотрудников на портале",
                "организация почтовой рассылки",
                "отключение переадресации почты",
                "открытие внешней почты",
                "перевыпуск пропуска сотрудника",
                "предоставление удаленного доступа к рабочему ПК",
                "разблокировка почтового ящика",
                "разблокировка учетной записи",
                "раздача доступов к папкам на Fserver",
                "раздача доступов к папкам по проектам",
                "сброс пароля учетки пользователя",
                "смена фамилии",
                "сокращение групп доступов",
                "сохранение фотографий сотрудника",
                "удаление уволившихся сотрудников с портала"
            };
            comboBox1.Items.AddRange(items);
            label5.Text = "№: " + counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            label5.Text = "№: " + counter.ToString(); // Отображение значения
            int countBeforeSave = counter;

            // Получение значений из элементов управления c формы
            string comboBoxValue = comboBox1.Text;
            string textBoxValue = textBox1.Text;
            DateTime dateTimeValue = dateTimePicker1.Value;

            using (var excelPackage = new ExcelPackage()) // Создание объекта ExcelPackage
            {
                // Добавление листа в книгу Excel
                var worksheet = excelPackage.Workbook.Worksheets.Add("Данные");

                // Получение номера последней строки
                int lastRow = worksheet.Dimension.End.Row;

                // Добавление новой строки
                var newRow = worksheet.InsertRow(lastRow + 1, 1);

                // Запись данных в ячейки листа
                //worksheet.Cells["A1"].Value = countBeforeSave;

                //counter++; // Увеличение счетчика
                //worksheet.Cells["B1"].Value = comboBoxValue;
                //worksheet.Cells["C1"].Value = textBoxValue;
                //worksheet.Cells["D1"].Value = dateTimeValue;
                //worksheet.Cells["D1"].Style.Numberformat.Format = "dd.mm.yyyy";


                //// Запись данных в новую строку
                //newRow.Cells["A"].Value = comboBoxValue;
                //newRow.Cells["B"].Value = textBoxValue;
                //newRow.Cells["C"].Value = dateTimeValue;
                //worksheet.Cells["D"].Style.Numberformat.Format = "dd.mm.yyyy";

                // Запись данных в ячейки листа
                worksheet.Cells[newRow.Row, 1].Value = comboBoxValue;
                worksheet.Cells[newRow.Row, 2].Value = textBoxValue;
                worksheet.Cells[newRow.Row, 3].Value = dateTimeValue;
                worksheet.Cells["D" + newRow.Row].Style.Numberformat.Format = "dd.mm.yyyy";

                // Сохранение книги Excel
                excelPackage.Save();

                //// Сохранение книги Excel
                //excelPackage.SaveAs(new FileStream("data.xlsx", FileMode.Create));
            }
            IncreaseCounter();
            comboBox1.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void IncreaseCounter()
        {
            counter++;
            label5.Text = "№: " + counter.ToString();

        }
    }

}

