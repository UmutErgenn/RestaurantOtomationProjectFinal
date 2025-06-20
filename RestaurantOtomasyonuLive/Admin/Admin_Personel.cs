﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class Admin_Personel : Form
    {
        public Admin_Personel()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_name.Text.Trim();
                string surname = txt_surname.Text.Trim();
                string mail = txt_mail.Text.Trim();
                string phone = txt_telno.Text.Trim();
                string position = txt_position.Text.Trim();
                decimal salary = decimal.Parse(txt_salary.Text.Trim());

                // combobox_gender: "Kadın" => false, "Erkek" => true
                bool gender = combobox_gender.SelectedItem.ToString() == "Erkek";

                sqlMethods.InsertPersonAndEmployee(name, surname, mail, phone, position, salary, gender);
            }
            catch (FormatException)
            {
                MessageBox.Show("Maaş sayısal olmalıdır.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string mail = txt_mailPersonDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Lütfen mail adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sqlMethods.DeletePersonelByMail(mail);
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            string mail = txt_mailSalary.Text.Trim();
            decimal salary;

            if (string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Lütfen mail adresini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_salaryUpdate.Text.Trim(), out salary))
            {
                MessageBox.Show("Lütfen geçerli bir maaş giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sqlMethods.UpdateEmployeeSalaryByMail(mail, salary);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }

        private void btn_Campaigns_Click(object sender, EventArgs e)
        {
            Admin_Campaign admin_Campaign = new Admin_Campaign();
            admin_Campaign.Show();
            this.Close();
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Admin_Menu admin_Menu = new Admin_Menu();
            admin_Menu.Show();
            this.Close();
        }

        private void btn_Staffs_Click(object sender, EventArgs e)
        {
            Admin_Personel admin_Personel = new Admin_Personel();
            admin_Personel.Show();
            this.Close();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Admin_Users admin_Users = new Admin_Users();
            admin_Users.Show();
            this.Close();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var ordersUC = new OrdersUserControl { Dock = DockStyle.Fill };
            panel1.Controls.Add(ordersUC);
        }
    }
}
