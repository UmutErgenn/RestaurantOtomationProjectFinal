using System;
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
    public partial class AdminPersonel : Form
    {
        public AdminPersonel()
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

                sqlMethods4Ace2.InsertPersonAndEmployee(name, surname, mail, phone, position, salary, gender);
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

            sqlMethods4Ace2.DeletePersonelByMail(mail);
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

            sqlMethods4Ace2.UpdateEmployeeSalaryByMail(mail, salary);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
