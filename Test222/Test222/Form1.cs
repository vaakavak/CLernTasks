using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Windows.Forms;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Test222
{
    public partial class Form1 : Form
    {
        private int counter; // Счетчик



        public Form1()
        {
            InitializeComponent();
            InitializeCounter(); // Инициализация счетчика при запуске приложения
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
        private void InitializeCounter()
        {
            // Прочитать последнее значение счетчика из файла Excel
            using (var excelPackage = new ExcelPackage(new FileInfo("existing_file.xlsx")))
            {
                var worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault(); // Получить первый лист
                if (worksheet != null)
                {
                    int lastRow = worksheet.Dimension.End.Row;
                    if (lastRow > 1)
                    {
                        var cellValue = worksheet.Cells[lastRow, 1].Value; // Чтение значения из последней строки
                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int lastCounter))
                        {
                            counter = lastCounter; // Установка счетчика равным последнему значению
                        }
                    }
                }
            }

            // Если не удалось прочитать значение из файла или файл пустой, начать счетчик с 1
            if (counter == 0)
            {
                counter = 1;
            }

            label5.Text = "№: " + counter.ToString(); // Отображение счетчика
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

            using (var excelPackage = new ExcelPackage(new FileInfo("existing_file.xlsx"))) // Открытие существующего файла Excel
            {
                var worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault(); // Получение первого листа

                if (worksheet == null) // Если лист не найден, создайте новый
                {
                    worksheet = excelPackage.Workbook.Worksheets.Add("Данные");
                    worksheet.Cells["A1"].Value = "№";
                    worksheet.Cells["B1"].Value = "ComboBoxValue";
                    worksheet.Cells["C1"].Value = "TextBoxValue";
                    worksheet.Cells["D1"].Value = "DateTimeValue";
                }

                int lastRow = worksheet.Dimension.End.Row;

                // Добавление новой строки
                worksheet.Cells[lastRow + 1, 1].Value = lastRow; // Номер строки
                worksheet.Cells[lastRow + 1, 2].Value = comboBoxValue;
                worksheet.Cells[lastRow + 1, 3].Value = textBoxValue;
                worksheet.Cells[lastRow + 1, 4].Value = dateTimeValue;
                worksheet.Cells[lastRow + 1, 4].Style.Numberformat.Format = "dd.mm.yyyy";

                // Сохранение изменений в файле Excel
                excelPackage.Save();
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

