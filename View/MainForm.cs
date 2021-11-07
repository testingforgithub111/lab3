using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

namespace View
{
    public partial class MainForm : Form
    {
        // Список объектов.
        public BindingList<ICalcFuel> lst = new BindingList<ICalcFuel>();

        // Файлы для сохранения и загрузки данных (сериализации и десериализации).
        private readonly string filePathCar = "Car.list";
        private readonly string filePathGCar = "GCar.list";
        private readonly string filePathHelicopter = "Helicopter.list";
        public MainForm()
        {
            InitializeComponent();

            // Вывод названий столбцов в таблице.
            dataGridView.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "Object", HeaderText = "Object", DataPropertyName = "Object" },
                new DataGridViewTextBoxColumn() { Name = "V", HeaderText = "V", DataPropertyName = "V" },
                new DataGridViewTextBoxColumn() { Name = "S", HeaderText = "S", DataPropertyName = "S" },
                new DataGridViewTextBoxColumn() { Name = "K", HeaderText = "K", DataPropertyName = "K" }
                                         );

            // Привязка списка к таблице.
            dataGridView.DataSource = lst;
        }

        // Открытие формы AddShapeForm для добавления нового объекта.
        private void button1_Click(object sender, EventArgs e)
        {
            AddObjectToForm addShapeForm = new AddObjectToForm();
            addShapeForm.Show(this); 

        }

        // Удаление объекта из таблицы и списка.
        private void button2_Click(object sender, EventArgs e)
        {
            lst.RemoveAt(dataGridView.CurrentRow.Index);            
        }

        // Сериализация.
        private void button3_Click(object sender, EventArgs e)
        {
            var fileCar = System.IO.File.Create(filePathCar);
            var fileGCar = System.IO.File.Create(filePathGCar);
            var fileHelicopter = System.IO.File.Create(filePathHelicopter);

            var writerCar = new XmlSerializer(typeof(BindingList<Car>));
            var writerGCar = new XmlSerializer(typeof(BindingList<GCar>));
            var writerHelicopter = new XmlSerializer(typeof(BindingList<Helicopter>));

            BindingList<Car> carList = new BindingList<Car>();
            BindingList<GCar> gcarList = new BindingList<GCar>();
            BindingList<Helicopter> helicopterList = new BindingList<Helicopter>();

            foreach (ICalcFuel obj in lst)
                if (obj.GetType() == typeof(Car))
                    carList.Add((Car)obj);
                else if (obj.GetType() == typeof(GCar))
                    gcarList.Add((GCar)obj);
                else
                    helicopterList.Add((Helicopter)obj);

            writerCar.Serialize(fileCar, carList);
            writerGCar.Serialize(fileGCar, gcarList);
            writerHelicopter.Serialize(fileHelicopter, helicopterList);

            fileCar.Close();
            fileGCar.Close();
            fileHelicopter.Close();

            MessageBox.Show("Данные сохранены в файл.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Десериализация.
        private void button4_Click(object sender, EventArgs e)
        {  
            try
            {
                var readerCar = new XmlSerializer(typeof(BindingList<Car>));
                var readerGCar = new XmlSerializer(typeof(BindingList<GCar>));
                var readerHelicopter = new XmlSerializer(typeof(BindingList<Helicopter>));

                var fileCar = new System.IO.StreamReader(filePathCar);
                var fileGCar = new System.IO.StreamReader(filePathGCar);
                var fileHelicopter = new System.IO.StreamReader(filePathHelicopter);

                BindingList<Car> carList = (BindingList<Car>)readerCar.Deserialize(fileCar);
                BindingList<GCar> gcarList = (BindingList<GCar>)readerGCar.Deserialize(fileGCar);
                BindingList<Helicopter> helicopterList = (BindingList<Helicopter>)readerHelicopter.Deserialize(fileHelicopter);

                fileCar.Close();
                fileGCar.Close();
                fileHelicopter.Close();

                lst.Clear();

                foreach (Car obj in carList)
                {
                    lst.Add((Car)obj);
                    dataGridView[0, dataGridView.RowCount - 1].Value = "Машина";
                    dataGridView[1, dataGridView.RowCount - 1].Value = obj.V.ToString();
                    dataGridView[2, dataGridView.RowCount - 1].Value = obj.S.ToString();
                }

                foreach (GCar obj in gcarList)
                {
                    lst.Add((GCar)obj);
                    dataGridView[0, dataGridView.RowCount - 1].Value = "Машина-гибрид";
                    dataGridView[1, dataGridView.RowCount - 1].Value = obj.V.ToString();
                    dataGridView[2, dataGridView.RowCount - 1].Value = obj.S.ToString();
                    dataGridView[3, dataGridView.RowCount - 1].Value = obj.K.ToString();
                }
                
                foreach (Helicopter obj in helicopterList)
                {
                    lst.Add((Helicopter)obj);
                    dataGridView[0, dataGridView.RowCount - 1].Value = "Вертолёт";
                    dataGridView[1, dataGridView.RowCount - 1].Value = obj.V.ToString();
                    dataGridView[2, dataGridView.RowCount - 1].Value = obj.S.ToString();
                    dataGridView[3, dataGridView.RowCount - 1].Value = obj.K.ToString();
                }

                MessageBox.Show("Данные загружены из файла.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Не найден файл.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        // Открытие формы SearchForm для поиска объекта в списке.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show(this);
        }
    }
}
