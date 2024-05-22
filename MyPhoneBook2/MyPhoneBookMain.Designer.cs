using System.Windows.Forms;

namespace MyPhoneBook2
{
    partial class MyPhoneBookMain
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNC = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.stBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NationalCode";
            // 
            // tbxNC
            // 
            this.tbxNC.Location = new System.Drawing.Point(84, 267);
            this.tbxNC.Name = "tbxNC";
            this.tbxNC.Size = new System.Drawing.Size(151, 20);
            this.tbxNC.TabIndex = 3;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(310, 267);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(151, 20);
            this.tbxFirstName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(525, 267);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(151, 20);
            this.tbxLastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthday";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(310, 292);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(151, 20);
            this.tbxAddress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(84, 292);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(151, 20);
            this.tbxFatherName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Father Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Checked = true;
            this.rbMan.Location = new System.Drawing.Point(84, 320);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 13;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(131, 320);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(62, 17);
            this.rbWoman.TabIndex = 14;
            this.rbWoman.Text = "Woman";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 356);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit Save";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // stBirthday
            // 
            this.stBirthday.Location = new System.Drawing.Point(525, 292);
            this.stBirthday.Name = "stBirthday";
            this.stBirthday.Size = new System.Drawing.Size(151, 20);
            this.stBirthday.TabIndex = 12;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(321, 356);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(271, 20);
            this.tbxSearch.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Search";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(597, 356);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(78, 23);
            this.btnGo.TabIndex = 19;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyPhoneBookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.stBirthday);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxFatherName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyPhoneBookMain";
            this.Text = "My Phone Book";
            this.Load += new System.EventHandler(this.MyPhoneBookMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Label label1;
        private TextBox tbxNC;
        private TextBox tbxFirstName;
        private Label label2;
        private TextBox tbxLastName;
        private Label label3;
        private Label label4;
        private TextBox tbxAddress;
        private Label label5;
        private TextBox tbxFatherName;
        private Label label6;
        private Label label7;
        private RadioButton rbMan;
        private RadioButton rbWoman;
        private Button btnEdit;
        private Button btnDelete;
        private DateTimePicker stBirthday;
        private TextBox tbxSearch;
        private Label label8;
        private Button btnGo;
        private Button btnClear;
    }
}