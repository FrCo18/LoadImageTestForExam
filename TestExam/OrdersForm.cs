using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestExam
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();

            fillServices();
            cbxServices.SelectedIndex = 0;
            fillLaborants();
            cbxLaborants.SelectedIndex = 0;
            showOrders();
        }

        private void fillServices()
        {
            cbxServices.Items.Clear();
            foreach (var service in Program.app.db.Services)
            {
                cbxServices.Items.Add(buildServiceString(service));
            }
        }

        private string buildServiceString(Services service)
        {
            return $"{service.id}. {service.name} {service.price}";
        }

        private string buildLaborantString(Laborants laborant)
        {
            return laborant.id + getFioFromLaborant(laborant);
        }

        private void fillLaborants()
        {
            cbxLaborants.Items.Clear();

            foreach (var laborant in Program.app.db.Laborants)
            {
                cbxLaborants.Items.Add(buildLaborantString(laborant));
            }
        }

        private string getFioFromLaborant(Laborants laborant)
        {
            string fio = laborant.last_name;

            string firstName = Regex.Match(laborant.first_name ?? "", @"^\w").Value.ToString();

            if (firstName != "")
            {
                fio += $" {firstName}.";
            }

            string midleName = Regex.Match(laborant.middle_name ?? "", @"^\w").Value.ToString();
            if (midleName != "")
            {
                fio += $" {midleName}.";
            }

            return fio;
        }

        private void showOrders()
        {
            lvOrders.Items.Clear();

            foreach (var order in Program.app.db.Orders)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    order.id.ToString(),
                    order.created_at.Value.Date.ToString(),
                    order.finish_at == null ? null : order.finish_at.Value.Date.ToString(),
                    $"{order.Services.name}, price: {order.Services.price}",
                    getFioFromLaborant(order.Laborants),
                    order.colb_upc
                });

                item.Tag = order;
                lvOrders.Items.Add(item);
            }

            lvOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Orders order = new Orders();
            order.created_at = created_atDateTimePicker.Value.Date;

            DateTime finishDate = finish_atDateTimePicker.Value.Date;
            if (order.created_at <= finishDate)
            {
                order.finish_at = finishDate;
            }
            else
            {
                MessageBox.Show(
                    "Дата завершения должна быть больше или равна дате создания заказа!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            order.id_service = Convert.ToInt32(Regex.Match(cbxServices.SelectedItem.ToString(), @"^\d+").Value);
            order.id_laborant = Convert.ToInt32(Regex.Match(cbxLaborants.SelectedItem.ToString(), @"^\d+").Value);

            string upc = Regex.Match(cbxServices.SelectedItem.ToString(), @"^\d+").Value;
            upc += $"{order.created_at.Value.Day}{order.created_at.Value.Month}{order.created_at.Value.Year}";

            Random random = new Random();

            for (int i = 1; i <= 6; i++)
            {
                upc += random.Next(0, 9);
            }

            order.colb_upc = upc;
            Program.app.db.Orders.Add(order);
            Program.app.db.SaveChanges();
            showOrders();
        }

        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count == 1)
            {
                Orders orders = lvOrders.SelectedItems[0].Tag as Orders;
                created_atDateTimePicker.Value = orders.created_at.Value;
                finish_atDateTimePicker.Value = orders.finish_at.Value;
                cbxServices.SelectedItem = buildServiceString(orders.Services);
                cbxLaborants.SelectedItem = buildLaborantString(orders.Laborants);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count == 1)
            {
                Orders orders = lvOrders.SelectedItems[0].Tag as Orders;
                orders.created_at = created_atDateTimePicker.Value.Date;
                orders.finish_at = finish_atDateTimePicker.Value.Date;
                orders.id_service = Convert.ToInt32(Regex.Match(cbxServices.SelectedItem.ToString(), @"^\d+").Value);
                orders.id_laborant = Convert.ToInt32(Regex.Match(cbxLaborants.SelectedItem.ToString(), @"^\d+").Value);

                Program.app.db.SaveChanges();
                showOrders();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count == 1)
            {
                Orders orders = lvOrders.SelectedItems[0].Tag as Orders;
                Program.app.db.Orders.Remove(orders);
                Program.app.db.SaveChanges();
                showOrders();
            }
        }
    }
}
