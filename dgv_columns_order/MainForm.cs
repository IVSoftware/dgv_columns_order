using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dgv_columns_order
{
    enum StdColumnName
    {
        Apple0, 
        Orange1,
        Banana2,
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            foreach (string name in Enum.GetNames(typeof(StdColumnName)))
            {
                var col = new DataGridViewTextBoxColumn()
                {
                    Name = name,
                    HeaderText = name,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
                };
                dataGridView.Columns.Add(col);
            }
        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            var col = dataGridView.Columns[nameof(StdColumnName.Banana2)];
            col.DisplayIndex = 0;
        }
    }
}
