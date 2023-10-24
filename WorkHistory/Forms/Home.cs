using System.Windows.Forms;
using WorkHistory.DataAccess;
using WorkHistory.Models;

namespace WorkHistory.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Ignorar la tecla si no es un número o un separador decimal
            }

            // Permitir solo un separador decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            this.lblResult.Text = string.Empty;
            if (string.IsNullOrEmpty(this.txtHours.Text) || string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtObservation.Text)) return;

            HistoryEntry data = new HistoryEntry
            {
                WorkItemId = this.txtId.Text,
                Hours = decimal.Parse(this.txtHours.Text),
                Description = this.txtObservation.Text,
                Name = this.txtName.Text
            };

            History history = new History();

            Result result = history.AddNewHistory(data);

            if (result == Result.Success)
            {
                this.lblResult.Text = "Registro exitoso";
                this.lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.lblResult.Text = "Ocurrio un error";
                this.lblResult.ForeColor = System.Drawing.Color.Red;
            }

            this.txtHours.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtObservation.Text = string.Empty;
        }
    }
}
