using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonRunSearch_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            // Очистка списка.
            listBox1.Items.Clear();

            // Флаг поиска.
            bool flagSearched = false;
            
            // Поиск объектов в списке.
            foreach (ICalcFuel obj in mainForm.lst)
                if (obj.GetType() == typeof(Car) && ((Car)obj).V.ToString() == textBoxParam1.Text)
                {
                    listBox1.Items.Add((Car)obj);
                    flagSearched = true;
                }              
                else if (obj.GetType() == typeof(GCar) && ((GCar)obj).V.ToString() == textBoxParam1.Text)
                {
                    listBox1.Items.Add((GCar)obj);
                    flagSearched = true;
                }                    
                else if (obj.GetType() == typeof(Helicopter) && ((Helicopter)obj).V.ToString() == textBoxParam1.Text)
                {
                    listBox1.Items.Add((Helicopter)obj);
                    flagSearched = true;
                }


            if (!flagSearched)
                MessageBox.Show("Объекты не были найдены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
