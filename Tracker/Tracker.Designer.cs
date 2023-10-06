namespace CovidTracker
{
    partial class Tracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            resultButton = new Button();
            DataGrid = new DataGridView();
            cryptoComboBox = new ComboBox();
            cryptoName = new DataGridViewTextBoxColumn();
            cryptoSymbol = new DataGridViewTextBoxColumn();
            currPrice = new DataGridViewTextBoxColumn();
            volume = new DataGridViewTextBoxColumn();
            marketcap = new DataGridViewTextBoxColumn();
            currSupply = new DataGridViewTextBoxColumn();
            maxSupply = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // resultButton
            // 
            resultButton.AutoSize = true;
            resultButton.BackColor = Color.FromArgb(23, 184, 144);
            resultButton.Font = new Font("Microsoft JhengHei", 16F, FontStyle.Bold, GraphicsUnit.Point);
            resultButton.ForeColor = Color.White;
            resultButton.Location = new Point(708, 616);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(351, 55);
            resultButton.TabIndex = 0;
            resultButton.Text = "查詢當前貨幣資訊";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += button1_Click;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.BackgroundColor = SystemColors.Window;
            DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { cryptoName, cryptoSymbol, currPrice, volume, marketcap, currSupply, maxSupply });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.GridColor = SystemColors.ActiveCaptionText;
            DataGrid.Location = new Point(12, 12);
            DataGrid.Name = "DataGrid";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.RowHeadersWidth = 62;
            DataGrid.RowTemplate.Height = 60;
            DataGrid.Size = new Size(1404, 580);
            DataGrid.TabIndex = 1;
            DataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cryptoComboBox
            // 
            cryptoComboBox.BackColor = Color.White;
            cryptoComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cryptoComboBox.ForeColor = Color.Black;
            cryptoComboBox.FormattingEnabled = true;
            cryptoComboBox.Items.AddRange(new object[] { "bitcoin", "ethereum", "tether", "dogecoin", "acid" });
            cryptoComboBox.Location = new Point(1125, 616);
            cryptoComboBox.Name = "cryptoComboBox";
            cryptoComboBox.Size = new Size(291, 53);
            cryptoComboBox.TabIndex = 2;
            cryptoComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cryptoName
            // 
            cryptoName.HeaderText = "貨幣名稱";
            cryptoName.MinimumWidth = 8;
            cryptoName.Name = "cryptoName";
            cryptoName.Width = 170;
            // 
            // cryptoSymbol
            // 
            cryptoSymbol.HeaderText = "貨幣符號";
            cryptoSymbol.MinimumWidth = 8;
            cryptoSymbol.Name = "cryptoSymbol";
            cryptoSymbol.Width = 170;
            // 
            // currPrice
            // 
            currPrice.HeaderText = "當前價格";
            currPrice.MinimumWidth = 8;
            currPrice.Name = "currPrice";
            currPrice.Width = 191;
            // 
            // volume
            // 
            volume.HeaderText = "成交量";
            volume.MinimumWidth = 8;
            volume.Name = "volume";
            volume.Width = 192;
            // 
            // marketcap
            // 
            marketcap.HeaderText = "交易量";
            marketcap.MinimumWidth = 8;
            marketcap.Name = "marketcap";
            marketcap.Width = 230;
            // 
            // currSupply
            // 
            currSupply.HeaderText = "流通供應量";
            currSupply.MinimumWidth = 8;
            currSupply.Name = "currSupply";
            currSupply.Width = 192;
            // 
            // maxSupply
            // 
            maxSupply.HeaderText = "最大供應量";
            maxSupply.MinimumWidth = 8;
            maxSupply.Name = "maxSupply";
            maxSupply.Width = 195;
            // 
            // Tracker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 694);
            Controls.Add(cryptoComboBox);
            Controls.Add(DataGrid);
            Controls.Add(resultButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "加密貨幣查詢 App";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resultButton;
        private DataGridView DataGrid;
        private ComboBox cryptoComboBox;
        private DataGridViewTextBoxColumn cryptoName;
        private DataGridViewTextBoxColumn cryptoSymbol;
        private DataGridViewTextBoxColumn currPrice;
        private DataGridViewTextBoxColumn volume;
        private DataGridViewTextBoxColumn marketcap;
        private DataGridViewTextBoxColumn currSupply;
        private DataGridViewTextBoxColumn maxSupply;
    }
}