using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbColumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string WriteColumnMapping<T>(T item) where T : new()
        {
            string result="";
            var type = item.GetType();

            var properties = item.GetType().GetProperties();
            result = String.Format("Finding properties for {0} \r\n", type.Name);

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                string msg = "property {0} => databse column {1} \r\n";
                var columnMapping = attributes.FirstOrDefault(a => a.GetType() == typeof(DbColumnAttribute));
                if (columnMapping != null)
                {
                    var mapsto = columnMapping as DbColumnAttribute;
                    result += String.Format(msg, property.Name, mapsto.Name);
                }
            }

            return result;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            tbOut.Text = WriteColumnMapping<Client>(client);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOut.Clear();
        }
    }
}
