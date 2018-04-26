namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBirds = new System.Windows.Forms.DataGridView();
            this.dgvCounts = new System.Windows.Forms.DataGridView();
            this.lblBirds = new System.Windows.Forms.Label();
            this.lblBirdCounts = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCommitData = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBirds
            // 
            this.dgvBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirds.Location = new System.Drawing.Point(25, 42);
            this.dgvBirds.Name = "dgvBirds";
            this.dgvBirds.RowTemplate.Height = 24;
            this.dgvBirds.Size = new System.Drawing.Size(702, 190);
            this.dgvBirds.TabIndex = 0;
            // 
            // dgvCounts
            // 
            this.dgvCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounts.Location = new System.Drawing.Point(25, 376);
            this.dgvCounts.Name = "dgvCounts";
            this.dgvCounts.RowTemplate.Height = 24;
            this.dgvCounts.Size = new System.Drawing.Size(702, 190);
            this.dgvCounts.TabIndex = 1;
            // 
            // lblBirds
            // 
            this.lblBirds.AutoSize = true;
            this.lblBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirds.Location = new System.Drawing.Point(22, 22);
            this.lblBirds.Name = "lblBirds";
            this.lblBirds.Size = new System.Drawing.Size(45, 17);
            this.lblBirds.TabIndex = 2;
            this.lblBirds.Text = "Birds";
            // 
            // lblBirdCounts
            // 
            this.lblBirdCounts.AutoSize = true;
            this.lblBirdCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirdCounts.Location = new System.Drawing.Point(22, 356);
            this.lblBirdCounts.Name = "lblBirdCounts";
            this.lblBirdCounts.Size = new System.Drawing.Size(92, 17);
            this.lblBirdCounts.TabIndex = 3;
            this.lblBirdCounts.Text = "Bird Counts";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(578, 254);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(149, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(390, 254);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(149, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(25, 254);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(149, 23);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(208, 254);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(149, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(215, 300);
            this.lblMsg.MaximumSize = new System.Drawing.Size(300, 20);
            this.lblMsg.MinimumSize = new System.Drawing.Size(300, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(300, 20);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCommitData
            // 
            this.btnCommitData.Location = new System.Drawing.Point(578, 297);
            this.btnCommitData.Name = "btnCommitData";
            this.btnCommitData.Size = new System.Drawing.Size(149, 23);
            this.btnCommitData.TabIndex = 10;
            this.btnCommitData.Text = "Commit";
            this.btnCommitData.UseVisualStyleBackColor = true;
            this.btnCommitData.Click += new System.EventHandler(this.btnCommitData_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(299, 334);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 596);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCommitData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lblBirdCounts);
            this.Controls.Add(this.lblBirds);
            this.Controls.Add(this.dgvCounts);
            this.Controls.Add(this.dgvBirds);
            this.Name = "MainForm";
            this.Text = "BirdAdapter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBirds;
        private System.Windows.Forms.DataGridView dgvCounts;
        private System.Windows.Forms.Label lblBirds;
        private System.Windows.Forms.Label lblBirdCounts;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCommitData;
        private System.Windows.Forms.Button btnRefresh;
    }
}

