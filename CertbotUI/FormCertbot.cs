using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertbotUI.Properties;

namespace CertbotUI
{
    public partial class FormCertbot : Form
    {
        public FormCertbot()
        {
            InitializeComponent();

            // Set title and icon
            Icon = Resources.ssl_certificate_8ib_icon;
            Text = $"{Application.ProductName} [{Application.ProductVersion}]";
        }
    }
}
