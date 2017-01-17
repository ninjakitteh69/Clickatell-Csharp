using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickatell_Service
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string username;
        private string password;
        private string api;
        private string to;
        private string from;
        private string delivery;
        private string message;
        private string response;

        public Form()
        {
            InitializeComponent();
        }

        private void btn_sendsms_Click(object sender, EventArgs e)
        {
            api = txt_api.Text;
            to = txt_to.Text;
            from = txt_from.Text;
            delivery = txt_delivery.Text;
            message = txt_message.Text;
            
            if (api != "")
            {
                response = Api.SendSMS(api, "{\"content\":\"" + message + "\"" +
                                            ",\"to\":[\"" + to + "\"]}");
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show("Error: API Key cannot be blank");
            }
        }
    }
}
