using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseAccess;
using SharedData;

namespace HW03_RasmusLindved
{
    public partial class MainForm : Form
    {
        private readonly DatabaseAccessFacade _facade;
        public MainForm()
        {
            InitializeComponent();
            _facade = DatabaseAccessFacade.GetInstance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var dataFromDb = _facade.Database.GetData();

                dgvBirds.DataSource = dataFromDb;
                dgvBirds.DataMember = SharedNames.Birds;

                dgvCounts.DataSource = dataFromDb;
                dgvCounts.DataMember = $"{SharedNames.Birds}.{SharedNames.BirdRelation}";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dgvBirds.CurrentCell = dgvBirds.Rows[0].Cells[0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var currentRowIndex = dgvBirds.CurrentCell.RowIndex;
            dgvBirds.CurrentCell = dgvBirds.Rows[currentRowIndex - 1].Cells[0];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var currentRowIndex = dgvBirds.CurrentCell.RowIndex;
            dgvBirds.CurrentCell = dgvBirds.Rows[currentRowIndex + 1].Cells[0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dgvBirds.CurrentCell = dgvBirds.Rows[dgvBirds.RowCount - 1].Cells[0];
        }
    }
}
