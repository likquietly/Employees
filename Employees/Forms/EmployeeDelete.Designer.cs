
namespace Employees.Forms
{
    partial class EmployeeDelete
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
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.idToDeleteTxt = new System.Windows.Forms.TextBox();
            this.idToDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(392, 47);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(111, 32);
            this.BtnDeleteEmployee.TabIndex = 13;
            this.BtnDeleteEmployee.Text = "Удалить";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // idToDeleteTxt
            // 
            this.idToDeleteTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idToDeleteTxt.Location = new System.Drawing.Point(421, 12);
            this.idToDeleteTxt.Name = "idToDeleteTxt";
            this.idToDeleteTxt.Size = new System.Drawing.Size(82, 29);
            this.idToDeleteTxt.TabIndex = 12;
            // 
            // idToDelete
            // 
            this.idToDelete.AutoSize = true;
            this.idToDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idToDelete.Location = new System.Drawing.Point(12, 15);
            this.idToDelete.Name = "idToDelete";
            this.idToDelete.Size = new System.Drawing.Size(405, 21);
            this.idToDelete.TabIndex = 11;
            this.idToDelete.Text = "Введите Id сотрудника, которого хотите удалить:";
            // 
            // EmployeeDelete
            // 
            this.AcceptButton = this.BtnDeleteEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 81);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.idToDeleteTxt);
            this.Controls.Add(this.idToDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.TextBox idToDeleteTxt;
        private System.Windows.Forms.Label idToDelete;
    }
}