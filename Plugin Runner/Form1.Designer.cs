
namespace Plugin_Runner
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoadPlugin = new System.Windows.Forms.Button();
            this.labConsole = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.ListBox();
            this.dgvPlugins = new System.Windows.Forms.DataGridView();
            this.lblVerticalLine = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPlugin
            // 
            this.btnLoadPlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoadPlugin.Location = new System.Drawing.Point(139, 49);
            this.btnLoadPlugin.Name = "btnLoadPlugin";
            this.btnLoadPlugin.Size = new System.Drawing.Size(219, 74);
            this.btnLoadPlugin.TabIndex = 0;
            this.btnLoadPlugin.Text = "Load Plugin";
            this.btnLoadPlugin.UseVisualStyleBackColor = true;
            this.btnLoadPlugin.Click += new System.EventHandler(this.btnLoadPlugin_Click);
            // 
            // labConsole
            // 
            this.labConsole.AutoSize = true;
            this.labConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.labConsole.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labConsole.Location = new System.Drawing.Point(72, 190);
            this.labConsole.Name = "labConsole";
            this.labConsole.Size = new System.Drawing.Size(65, 32);
            this.labConsole.TabIndex = 84;
            this.labConsole.Text = "Logs";
            // 
            // logs
            // 
            this.logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.logs.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.logs.ForeColor = System.Drawing.Color.Gainsboro;
            this.logs.FormattingEnabled = true;
            this.logs.ItemHeight = 19;
            this.logs.Items.AddRange(new object[] {
            ""});
            this.logs.Location = new System.Drawing.Point(64, 226);
            this.logs.Name = "logs";
            this.logs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logs.Size = new System.Drawing.Size(349, 365);
            this.logs.TabIndex = 85;
            // 
            // dgvPlugins
            // 
            this.dgvPlugins.AllowUserToAddRows = false;
            this.dgvPlugins.AllowUserToDeleteRows = false;
            this.dgvPlugins.AllowUserToResizeColumns = false;
            this.dgvPlugins.AllowUserToResizeRows = false;
            this.dgvPlugins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dgvPlugins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlugins.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlugins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlugins.ColumnHeadersHeight = 40;
            this.dgvPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlugins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.version});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlugins.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlugins.EnableHeadersVisualStyles = false;
            this.dgvPlugins.Location = new System.Drawing.Point(582, 60);
            this.dgvPlugins.MultiSelect = false;
            this.dgvPlugins.Name = "dgvPlugins";
            this.dgvPlugins.ReadOnly = true;
            this.dgvPlugins.RowHeadersVisible = false;
            this.dgvPlugins.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlugins.RowTemplate.Height = 30;
            this.dgvPlugins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPlugins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlugins.Size = new System.Drawing.Size(423, 480);
            this.dgvPlugins.TabIndex = 86;
            // 
            // lblVerticalLine
            // 
            this.lblVerticalLine.BackColor = System.Drawing.Color.White;
            this.lblVerticalLine.Location = new System.Drawing.Point(495, -6);
            this.lblVerticalLine.Name = "lblVerticalLine";
            this.lblVerticalLine.Size = new System.Drawing.Size(2, 629);
            this.lblVerticalLine.TabIndex = 87;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 270;
            // 
            // version
            // 
            this.version.HeaderText = "Version";
            this.version.Name = "version";
            this.version.ReadOnly = true;
            this.version.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.version.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.version.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1068, 603);
            this.Controls.Add(this.lblVerticalLine);
            this.Controls.Add(this.dgvPlugins);
            this.Controls.Add(this.labConsole);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.btnLoadPlugin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlugins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPlugin;
        private System.Windows.Forms.Label labConsole;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.DataGridView dgvPlugins;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn version;
        private System.Windows.Forms.Label lblVerticalLine;
    }
}

