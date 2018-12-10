using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dGV1.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Surname";
            column.Name = "Фамілія";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ID";
            column.Name = "Індіфікаційний код";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Telephone";
            column.Name = "Номер телефону";
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Onhand";
            column.Name = "Взяті книги";
            column.Width = 140;
            dGV1.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Toreturn";
            column.Name = "Потрібно повернути";
            column.Width = 120;
            dGV1.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Allow";
            column.Name = "Не можна видавати книги";
            column.Width = 70;
            dGV1.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();


            bindSrcAccounts.Add(new Account("Олег", "Андрієнко", 1548, 380269425,
            "Мобі Дік,Пітер Пен","Мобі Дік", true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void tlB1_Click(object sender, EventArgs e)
        {
            Account person = new Account();
            FAccount fa = new FAccount(person);
            if (fa.ShowDialog() == DialogResult.OK)
            {
                bindSrcAccounts.Add(person);
            }
        }

        private void tlB2_Click(object sender, EventArgs e)
        {
            Account person = (Account)bindSrcAccounts.List[bindSrcAccounts.Position];
            FAccount ft = new FAccount(person);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcAccounts.List[bindSrcAccounts.Position] = person;
            }
        }

        private void tlB3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
                "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcAccounts.RemoveCurrent();
            }
        }

        private void tlB4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcAccounts.Clear();
            }
        }

        private void tlB5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
