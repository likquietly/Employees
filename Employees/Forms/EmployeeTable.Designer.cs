
namespace Employees
{
    partial class EmployeeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTable));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.FilterPosition = new System.Windows.Forms.Label();
            this.FilterPositionBox = new System.Windows.Forms.TextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 206);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(725, 361);
            this.dataGridView.TabIndex = 0;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddEmployee.Location = new System.Drawing.Point(783, 206);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(217, 42);
            this.BtnAddEmployee.TabIndex = 1;
            this.BtnAddEmployee.Text = "Добавить сотрудника";
            this.BtnAddEmployee.UseVisualStyleBackColor = true;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(783, 265);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(217, 42);
            this.BtnDeleteEmployee.TabIndex = 2;
            this.BtnDeleteEmployee.Text = "Удалить сотрудника";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // FilterPosition
            // 
            this.FilterPosition.AutoSize = true;
            this.FilterPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterPosition.Location = new System.Drawing.Point(27, 159);
            this.FilterPosition.Name = "FilterPosition";
            this.FilterPosition.Size = new System.Drawing.Size(509, 21);
            this.FilterPosition.TabIndex = 3;
            this.FilterPosition.Text = "Введите должность, по которой хотите провести фильтрацию";
            // 
            // FilterPositionBox
            // 
            this.FilterPositionBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterPositionBox.Location = new System.Drawing.Point(542, 156);
            this.FilterPositionBox.Name = "FilterPositionBox";
            this.FilterPositionBox.Size = new System.Drawing.Size(214, 29);
            this.FilterPositionBox.TabIndex = 4;
            this.FilterPositionBox.TextChanged += new System.EventHandler(this.FilterPositionBox_TextChanged);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportButton.Location = new System.Drawing.Point(783, 322);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(217, 42);
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // EmployeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 597);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.FilterPositionBox);
            this.Controls.Add(this.FilterPosition);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма сотрудников";
            this.Load += new System.EventHandler(this.EmployeeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.Label FilterPosition;
        private System.Windows.Forms.TextBox FilterPositionBox;
        private System.Windows.Forms.Button ReportButton;
    }
}