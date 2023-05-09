namespace CarProject
{
    partial class CarExtrasForm
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
            labelCarName = new Label();
            inputCarName = new TextBox();
            labelExtraId = new Label();
            comboExtraId = new ComboBox();
            buttonAdd = new Button();
            buttonExit = new Button();
            manyToManyGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)manyToManyGrid).BeginInit();
            SuspendLayout();
            // 
            // labelCarName
            // 
            labelCarName.AutoSize = true;
            labelCarName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCarName.Location = new Point(178, 28);
            labelCarName.Name = "labelCarName";
            labelCarName.Size = new Size(45, 26);
            labelCarName.TabIndex = 0;
            labelCarName.Text = "Car";
            // 
            // inputCarName
            // 
            inputCarName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inputCarName.Location = new Point(229, 25);
            inputCarName.Name = "inputCarName";
            inputCarName.ReadOnly = true;
            inputCarName.Size = new Size(173, 34);
            inputCarName.TabIndex = 1;
            // 
            // labelExtraId
            // 
            labelExtraId.AutoSize = true;
            labelExtraId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtraId.Location = new Point(154, 68);
            labelExtraId.Name = "labelExtraId";
            labelExtraId.Size = new Size(69, 26);
            labelExtraId.TabIndex = 2;
            labelExtraId.Text = "Extras";
            // 
            // comboExtraId
            // 
            comboExtraId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboExtraId.FormattingEnabled = true;
            comboExtraId.Location = new Point(229, 65);
            comboExtraId.Name = "comboExtraId";
            comboExtraId.Size = new Size(173, 34);
            comboExtraId.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(12, 163);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 34);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(462, 163);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(125, 34);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // manyToManyGrid
            // 
            manyToManyGrid.AllowUserToResizeColumns = false;
            manyToManyGrid.AllowUserToResizeRows = false;
            manyToManyGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            manyToManyGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            manyToManyGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            manyToManyGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            manyToManyGrid.Location = new Point(12, 203);
            manyToManyGrid.Name = "manyToManyGrid";
            manyToManyGrid.RowHeadersWidth = 51;
            manyToManyGrid.RowTemplate.Height = 29;
            manyToManyGrid.Size = new Size(575, 374);
            manyToManyGrid.TabIndex = 6;
            // 
            // CarExtrasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 589);
            Controls.Add(manyToManyGrid);
            Controls.Add(buttonExit);
            Controls.Add(buttonAdd);
            Controls.Add(comboExtraId);
            Controls.Add(labelExtraId);
            Controls.Add(inputCarName);
            Controls.Add(labelCarName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarExtrasForm";
            Text = "Car Extras";
            ((System.ComponentModel.ISupportInitialize)manyToManyGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarName;
        private TextBox inputCarName;
        private Label labelExtraId;
        private ComboBox comboExtraId;
        private Button buttonAdd;
        private Button buttonExit;
        private DataGridView manyToManyGrid;
    }
}