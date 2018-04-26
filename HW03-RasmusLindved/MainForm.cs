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
        private const string LoadSuccesMsg = "Data succesfully loaded.";
        private const string CommitFailMsg = "Failed to commit changes to database...";
        private const string CommitSuccessMsg = "Successfully commited changes to database.";
        private const string NoChangeMsg = "No changes to commit...";
        private const string SaveMsg = "To save changes, click commit.";
        private const string CantMoveMsg = "Unable to move further...";
        private const string CantDeleteMsg = "Unable to delete that row...";

        private readonly DatabaseAccessFacade _facade;

        private DataSet _data;

        //private DataSet
        public MainForm()
        {
            InitializeComponent();
            _facade = DatabaseAccessFacade.GetInstance();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Loads data from the database and displays it.
        /// </summary>
        private void LoadData()
        {
            try
            {
                _data = _facade.Database.GetData();

                dgvBirds.DataSource = _data;
                dgvBirds.DataMember = SharedNames.Birds;
                dgvBirds.Columns[SharedNames.BirdId].ReadOnly = true;

                dgvCounts.DataSource = _data;
                dgvCounts.DataMember = $"{SharedNames.Birds}.{SharedNames.BirdRelation}";

                lblMsg.Text = LoadSuccesMsg;
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dgvBirds.CurrentCell = dgvBirds.Rows[0].Cells[0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var currentRowIndex = dgvBirds.CurrentCell.RowIndex;
            try
            {
                dgvBirds.CurrentCell = dgvBirds.Rows[currentRowIndex - 1].Cells[0];
            }
            catch (Exception)
            {
                lblMsg.Text = CantMoveMsg;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var currentRowIndex = dgvBirds.CurrentCell.RowIndex;
            try
            {
                dgvBirds.CurrentCell = dgvBirds.Rows[currentRowIndex + 1].Cells[0];
            }
            catch (Exception)
            {
                lblMsg.Text = CantMoveMsg;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dgvBirds.CurrentCell = dgvBirds.Rows[dgvBirds.RowCount - 1].Cells[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCommitData_Click(object sender, EventArgs e)
        {
            if (_data.HasChanges())
            {
                try
                {
                    _facade.Database.CommitData(_data);
                    lblMsg.Text = CommitSuccessMsg;
                }
                catch (Exception)
                {
                    lblMsg.Text = CommitFailMsg;
                }
            }
            else
            {
                lblMsg.Text = NoChangeMsg;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var currentRowIndex = dgvBirds.CurrentCell.RowIndex;
            try
            {
                _data.Tables[SharedNames.Birds].Rows[currentRowIndex].Delete();
                lblMsg.Text = SaveMsg;
            }
            catch (Exception)
            {
                lblMsg.Text = CantDeleteMsg;
            }
        }
    }
}
