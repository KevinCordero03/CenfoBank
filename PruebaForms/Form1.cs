using AppCoreLogic;
using DTO_POJOS;
using POJO_DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_App
{
    public partial class Cust_Info : Form
    {
        public Cust_Info()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            var cm = new CustomerManager();

            //Validar que todos los campos esten completos.
            var customer = new Customer()
            {
                ID = txt_id.Text,
                Name = text_name.Text,
                LastName = text_lastname.Text,
                email = text_email.Text,
                phone = text_phone.Text,

            };
            cm.Create(customer);
            MessageBox.Show("Customer created successfully.", "Status");
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            var cm = new CustomerManager();
            var id = txt_id.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please complete ID space", "Request Status:");
            }
            else
            {
                var customer = cm.RetrieveById(id);
                if (customer != null)
                {
                    text_name.Text = customer.Name;
                    text_lastname.Text = customer.LastName;
                    text_phone.Text = customer.phone;
                    text_email.Text = customer.email;
                }
                else
                {
                    MessageBox.Show("Customer not found. Please verify.", "Request Status:");
                }
            }
        }

        private void btn_createCoin_Click(object sender, EventArgs e)
        {
            var cm = new CoinManager();
            var coin = new Coin()
            {
                ID = text_idCoin.Text,
                Name = txt_coinName.Text,
            };
            cm.Create(coin);
            MessageBox.Show("Currency created successfully.", "Status");
        }

        private void btn_updateCoin_Click(object sender, EventArgs e)
        {
        }




        private void text_name_TextChanged(object sender, EventArgs e) { }
        private void text_lastname_TextChanged(object sender, EventArgs e) { }
        private void text_email_TextChanged(object sender, EventArgs e) { }
        private void text_phone_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void text_idCoin_TextChanged(object sender, EventArgs e) { }

        private void btn_searchACC_Click(object sender, EventArgs e)
        {

            var am = new AccountManager();
            var id = txt_uban.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Complete the UBAN number", "Request Status:");
            }
            else
            {
                var account = am.RetrieveById(id);
                if (account != null)
                {
                    txt_uban.Text = account.UBAN;
                    txt_descrip.Text = account.Name;
                    txt_status.Text = account.Status;
                    txt_cod.Text = account.MoneyCode;
                    txt_custID.Text = account.CustomerId;
                }
                else
                {
                    MessageBox.Show("Account not found. Please verify.", "Request Status:");
                }
            }
        }

    }//
}//