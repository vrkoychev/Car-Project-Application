namespace CarProject
{
    partial class CoreForm
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
            inputId = new TextBox();
            inputModel = new TextBox();
            inputYear = new TextBox();
            inputBrands = new ComboBox();
            labelId = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelBrands = new Label();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            CarGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CarGridView).BeginInit();
            SuspendLayout();
            // 
            // inputId
            // 
            inputId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inputId.Location = new Point(93, 12);
            inputId.Name = "inputId";
            inputId.Size = new Size(151, 34);
            inputId.TabIndex = 0;
            // 
            // inputModel
            // 
            inputModel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inputModel.Location = new Point(93, 52);
            inputModel.Name = "inputModel";
            inputModel.Size = new Size(151, 34);
            inputModel.TabIndex = 1;
            // 
            // inputYear
            // 
            inputYear.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inputYear.Location = new Point(93, 92);
            inputYear.Name = "inputYear";
            inputYear.Size = new Size(151, 34);
            inputYear.TabIndex = 2;
            // 
            // inputBrands
            // 
            inputBrands.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            inputBrands.FormattingEnabled = true;
            inputBrands.Location = new Point(93, 132);
            inputBrands.Name = "inputBrands";
            inputBrands.Size = new Size(151, 34);
            inputBrands.TabIndex = 3;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(55, 15);
            labelId.Name = "labelId";
            labelId.Size = new Size(32, 26);
            labelId.TabIndex = 4;
            labelId.Text = "Id";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelModel.Location = new Point(16, 55);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(71, 26);
            labelModel.TabIndex = 5;
            labelModel.Text = "Model";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelYear.Location = new Point(33, 95);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(54, 26);
            labelYear.TabIndex = 6;
            labelYear.Text = "Year";
            // 
            // labelBrands
            // 
            labelBrands.AutoSize = true;
            labelBrands.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelBrands.Location = new Point(10, 135);
            labelBrands.Name = "labelBrands";
            labelBrands.Size = new Size(77, 26);
            labelBrands.TabIndex = 7;
            labelBrands.Text = "Brands";
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(121, 308);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(123, 39);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(121, 353);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(123, 39);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(121, 398);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(123, 39);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // CarGridView
            // 
            CarGridView.AllowUserToAddRows = false;
            CarGridView.AllowUserToDeleteRows = false;
            CarGridView.AllowUserToResizeColumns = false;
            CarGridView.AllowUserToResizeRows = false;
            CarGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CarGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CarGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarGridView.Location = new Point(270, 12);
            CarGridView.Name = "CarGridView";
            CarGridView.ReadOnly = true;
            CarGridView.RowHeadersWidth = 51;
            CarGridView.RowTemplate.Height = 29;
            CarGridView.Size = new Size(518, 426);
            CarGridView.TabIndex = 11;
            // 
            // CoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarGridView);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(labelBrands);
            Controls.Add(labelYear);
            Controls.Add(labelModel);
            Controls.Add(labelId);
            Controls.Add(inputBrands);
            Controls.Add(inputYear);
            Controls.Add(inputModel);
            Controls.Add(inputId);
            Name = "CoreForm";
            Text = "Core Form";
            ((System.ComponentModel.ISupportInitialize)CarGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputId;
        private TextBox inputModel;
        private TextBox inputYear;
        private ComboBox inputBrands;
        private Label labelId;
        private Label labelModel;
        private Label labelYear;
        private Label labelBrands;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView CarGridView;
    }
}