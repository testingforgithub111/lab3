using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class AddObjectToForm : Form
    {
        public AddObjectToForm()
        {
            InitializeComponent();


            #if !DEBUG
                buttonCRD.Visible = false;
            #endif
        }

        // Выбор переключателя фигуры.
        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                labelParam3.Hide();             
                textBoxParam3.Hide();                
            }
            else if (radioButtonGCar.Checked || radioButtonHelicopter.Checked)
            {
                labelParam3.Show();               
                textBoxParam3.Show();
            }
        }

        // Нажатия на кнопку для генерации псевдослучайных значений.
        private void ButtonCRD_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            textBoxParam1.Text = Math.Round(rnd.NextDouble() * 50 + 3, 3).ToString();
            textBoxParam2.Text = Math.Round(rnd.NextDouble() * 1000 + 5, 3).ToString();
            textBoxParam3.Text = Math.Round(rnd.NextDouble(), 2).ToString();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            if (radioButtonCar.Checked)
            {
                if (!Double.TryParse(textBoxParam1.Text, out double bufV))
                { 
                    MessageBox.Show("(V) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Double.TryParse(textBoxParam2.Text, out double bufS))
                {
                    MessageBox.Show("(S) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Car obj = new Car
                    {
                        V = bufV,
                        S = bufS
                    };
                
                    mainForm.lst.Add(obj);
                    mainForm.dataGridView[0, mainForm.dataGridView.RowCount - 1].Value = "Машина";
                    mainForm.dataGridView[1, mainForm.dataGridView.RowCount - 1].Value = obj.V.ToString();
                    mainForm.dataGridView[2, mainForm.dataGridView.RowCount - 1].Value = obj.S.ToString();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonGCar.Checked)
            {
                if (!Double.TryParse(textBoxParam1.Text, out double bufV))
                {
                    MessageBox.Show("(V) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Double.TryParse(textBoxParam2.Text, out double bufS))
                {
                    MessageBox.Show("(S) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Double.TryParse(textBoxParam3.Text, out double bufK))
                {
                    MessageBox.Show("(K) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {               
                    GCar obj = new GCar
                    {
                        V = bufV,
                        S = bufS,
                        K = bufK
                    };

                    mainForm.lst.Add(obj);
                    mainForm.dataGridView[0, mainForm.dataGridView.RowCount - 1].Value = "Машина-гибрид";
                    mainForm.dataGridView[1, mainForm.dataGridView.RowCount - 1].Value = obj.V.ToString();
                    mainForm.dataGridView[2, mainForm.dataGridView.RowCount - 1].Value = obj.S.ToString();
                    mainForm.dataGridView[3, mainForm.dataGridView.RowCount - 1].Value = obj.K.ToString();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!Double.TryParse(textBoxParam1.Text, out double bufV))
                {
                    MessageBox.Show("(V) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Double.TryParse(textBoxParam2.Text, out double bufS))
                {
                    MessageBox.Show("(S) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Double.TryParse(textBoxParam3.Text, out double bufK))
                {
                    MessageBox.Show("(K) Невозможно преобразовать строку в действительное число.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Helicopter obj = new Helicopter
                    {
                        V = bufV,
                        S = bufS,
                        K = bufK
                    };

                    mainForm.lst.Add(obj);
                    mainForm.dataGridView[0, mainForm.dataGridView.RowCount - 1].Value = "Вертолёт";
                    mainForm.dataGridView[1, mainForm.dataGridView.RowCount - 1].Value = obj.V.ToString();
                    mainForm.dataGridView[2, mainForm.dataGridView.RowCount - 1].Value = obj.S.ToString();
                    mainForm.dataGridView[3, mainForm.dataGridView.RowCount - 1].Value = obj.K.ToString();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Недопустимое значение.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
