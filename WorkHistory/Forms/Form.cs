using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkHistory.Forms;

namespace WorkHistory
{
    public partial class Main : Form
    {

        private static Home _homeForm = null;
        private static HistoryResult _historyResultForm = null;

        private Home HomeForm
        {
            get
            {
                if (_homeForm == null)
                {
                    _homeForm = new Home();
                }

                return _homeForm;
            }
        }
        
        private HistoryResult HistoryForm
        {
            get
            {
                if (_historyResultForm == null)
                {
                    _historyResultForm = new HistoryResult();
                }

                return _historyResultForm;
            }
        }


        public Main()
        {
            InitializeComponent();

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm.TopLevel = false;
            if (pContainer.Controls.Count > 0)
            {
                pContainer.Controls.Clear();
            }

            pContainer.Controls.Add(HomeForm);
            HomeForm.BringToFront();
            HomeForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm.TopLevel = false;
            if (pContainer.Controls.Count > 0)
            {
                pContainer.Controls.Clear();
            }

            pContainer.Controls.Add(HistoryForm);
            HistoryForm.BringToFront();
            HistoryForm.Show();
        }
    }
}
