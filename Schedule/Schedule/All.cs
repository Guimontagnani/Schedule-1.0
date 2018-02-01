using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        private void All_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scheduleDataSet11.cadastro' table. You can move, or remove it, as needed.
            this.cadastroTableAdapter.Fill(this.scheduleDataSet11.cadastro);

        }
    }
}
