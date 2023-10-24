using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkHistory.Forms
{
    public partial class HistoryResult : Form
    {
        public HistoryResult()
        {
            InitializeComponent();
        }

        private void HistoryResult_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'workHistoryDataSet.History' Puede moverla o quitarla según sea necesario.
            this.historyTableAdapter.Fill(this.workHistoryDataSet.History);

        }
    }
}
