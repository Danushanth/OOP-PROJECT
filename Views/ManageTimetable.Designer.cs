namespace UnicomTICManagementSystem.Views
{
    partial class ManageTimetable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCourse = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmdSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvtimetable = new System.Windows.Forms.DataGridView();
            this.txtTimeslot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdroomtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // cmdCourse
            // 
            this.cmdCourse.FormattingEnabled = true;
            this.cmdCourse.Location = new System.Drawing.Point(245, 55);
            this.cmdCourse.Name = "cmdCourse";
            this.cmdCourse.Size = new System.Drawing.Size(121, 21);
            this.cmdCourse.TabIndex = 2;
            this.cmdCourse.SelectedIndexChanged += new System.EventHandler(this.cmdCourse_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(138, 206);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(399, 206);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cmdSubject
            // 
            this.cmdSubject.FormattingEnabled = true;
            this.cmdSubject.Location = new System.Drawing.Point(245, 87);
            this.cmdSubject.Name = "cmdSubject";
            this.cmdSubject.Size = new System.Drawing.Size(121, 21);
            this.cmdSubject.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Room Type";
            // 
            // dgvtimetable
            // 
            this.dgvtimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimetable.Location = new System.Drawing.Point(138, 257);
            this.dgvtimetable.Name = "dgvtimetable";
            this.dgvtimetable.Size = new System.Drawing.Size(336, 145);
            this.dgvtimetable.TabIndex = 10;
            this.dgvtimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtimetable_CellContentClick);
            // 
            // txtTimeslot
            // 
            this.txtTimeslot.Location = new System.Drawing.Point(245, 150);
            this.txtTimeslot.Name = "txtTimeslot";
            this.txtTimeslot.Size = new System.Drawing.Size(121, 20);
            this.txtTimeslot.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TimeSlot";
            // 
            // cmdroomtype
            // 
            this.cmdroomtype.FormattingEnabled = true;
            this.cmdroomtype.Location = new System.Drawing.Point(245, 124);
            this.cmdroomtype.Name = "cmdroomtype";
            this.cmdroomtype.Size = new System.Drawing.Size(121, 21);
            this.cmdroomtype.TabIndex = 13;
            // 
            // ManageTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdroomtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimeslot);
            this.Controls.Add(this.dgvtimetable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdSubject);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmdCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTimetable";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.ManageTimetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdCourse;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmdSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvtimetable;
        private System.Windows.Forms.TextBox txtTimeslot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmdroomtype;
    }
}