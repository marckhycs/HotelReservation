namespace HotelReservationApps
{
    partial class Form1
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
            this.txt_TransactionID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_MiddleInitial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_Single = new System.Windows.Forms.RadioButton();
            this.radio_Master = new System.Windows.Forms.RadioButton();
            this.radio_Family = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Adult = new System.Windows.Forms.TextBox();
            this.txt_Children = new System.Windows.Forms.TextBox();
            this.txt_Days = new System.Windows.Forms.TextBox();
            this.lbl_RoomPrice = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.btn_Total = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL RESERVATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction No.";
            // 
            // txt_TransactionID
            // 
            this.txt_TransactionID.Location = new System.Drawing.Point(149, 67);
            this.txt_TransactionID.Name = "txt_TransactionID";
            this.txt_TransactionID.Size = new System.Drawing.Size(188, 20);
            this.txt_TransactionID.TabIndex = 2;
            this.txt_TransactionID.TextChanged += new System.EventHandler(this.txt_TransactionID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MiddleInitial);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Middle Initial";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(10, 70);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(225, 26);
            this.txt_LastName.TabIndex = 5;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(301, 70);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(247, 26);
            this.txt_FirstName.TabIndex = 8;
            // 
            // txt_MiddleInitial
            // 
            this.txt_MiddleInitial.Location = new System.Drawing.Point(628, 70);
            this.txt_MiddleInitial.Name = "txt_MiddleInitial";
            this.txt_MiddleInitial.Size = new System.Drawing.Size(126, 26);
            this.txt_MiddleInitial.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_Family);
            this.groupBox2.Controls.Add(this.radio_Master);
            this.groupBox2.Controls.Add(this.radio_Single);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(19, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Type";
            // 
            // radio_Single
            // 
            this.radio_Single.AutoSize = true;
            this.radio_Single.Location = new System.Drawing.Point(10, 35);
            this.radio_Single.Name = "radio_Single";
            this.radio_Single.Size = new System.Drawing.Size(71, 24);
            this.radio_Single.TabIndex = 0;
            this.radio_Single.TabStop = true;
            this.radio_Single.Text = "Single";
            this.radio_Single.UseVisualStyleBackColor = true;
            this.radio_Single.CheckedChanged += new System.EventHandler(this.radio_Single_CheckedChanged);
            // 
            // radio_Master
            // 
            this.radio_Master.AutoSize = true;
            this.radio_Master.Location = new System.Drawing.Point(118, 38);
            this.radio_Master.Name = "radio_Master";
            this.radio_Master.Size = new System.Drawing.Size(76, 24);
            this.radio_Master.TabIndex = 1;
            this.radio_Master.TabStop = true;
            this.radio_Master.Text = "Master";
            this.radio_Master.UseVisualStyleBackColor = true;
            this.radio_Master.CheckedChanged += new System.EventHandler(this.radio_Master_CheckedChanged);
            // 
            // radio_Family
            // 
            this.radio_Family.AutoSize = true;
            this.radio_Family.Location = new System.Drawing.Point(242, 35);
            this.radio_Family.Name = "radio_Family";
            this.radio_Family.Size = new System.Drawing.Size(72, 24);
            this.radio_Family.TabIndex = 2;
            this.radio_Family.TabStop = true;
            this.radio_Family.Text = "Family";
            this.radio_Family.UseVisualStyleBackColor = true;
            this.radio_Family.CheckedChanged += new System.EventHandler(this.radio_Family_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_TotalAmount);
            this.groupBox3.Controls.Add(this.lbl_RoomPrice);
            this.groupBox3.Controls.Add(this.txt_Days);
            this.groupBox3.Controls.Add(this.txt_Children);
            this.groupBox3.Controls.Add(this.txt_Adult);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(353, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 145);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Number of Adult";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number of Children";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Number of Days to Stay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Room Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "TOTAL AMOUNT";
            // 
            // txt_Adult
            // 
            this.txt_Adult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Adult.Location = new System.Drawing.Point(251, 33);
            this.txt_Adult.Name = "txt_Adult";
            this.txt_Adult.Size = new System.Drawing.Size(169, 22);
            this.txt_Adult.TabIndex = 9;
            // 
            // txt_Children
            // 
            this.txt_Children.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Children.Location = new System.Drawing.Point(251, 52);
            this.txt_Children.Name = "txt_Children";
            this.txt_Children.Size = new System.Drawing.Size(169, 22);
            this.txt_Children.TabIndex = 14;
            // 
            // txt_Days
            // 
            this.txt_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Days.Location = new System.Drawing.Point(251, 73);
            this.txt_Days.Name = "txt_Days";
            this.txt_Days.Size = new System.Drawing.Size(169, 22);
            this.txt_Days.TabIndex = 15;
            // 
            // lbl_RoomPrice
            // 
            this.lbl_RoomPrice.AutoSize = true;
            this.lbl_RoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomPrice.Location = new System.Drawing.Point(248, 98);
            this.lbl_RoomPrice.Name = "lbl_RoomPrice";
            this.lbl_RoomPrice.Size = new System.Drawing.Size(128, 16);
            this.lbl_RoomPrice.TabIndex = 16;
            this.lbl_RoomPrice.Text = "No room is selected";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmount.Location = new System.Drawing.Point(248, 125);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(59, 16);
            this.lbl_TotalAmount.TabIndex = 17;
            this.lbl_TotalAmount.Text = "Php 0.00";
            // 
            // btn_Total
            // 
            this.btn_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total.Location = new System.Drawing.Point(431, 383);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(276, 30);
            this.btn_Total.TabIndex = 7;
            this.btn_Total.Text = "TOTAL";
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(12, 322);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(154, 34);
            this.btn_CheckIn.TabIndex = 8;
            this.btn_CheckIn.Text = "CHECK-IN";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(12, 376);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(154, 34);
            this.btn_CheckOut.TabIndex = 10;
            this.btn_CheckOut.Text = "CHECK-OUT";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(183, 322);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(154, 34);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(182, 376);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 34);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.btn_Total);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TransactionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TransactionID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MiddleInitial;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_Family;
        private System.Windows.Forms.RadioButton radio_Master;
        private System.Windows.Forms.RadioButton radio_Single;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.Label lbl_RoomPrice;
        private System.Windows.Forms.TextBox txt_Days;
        private System.Windows.Forms.TextBox txt_Children;
        private System.Windows.Forms.TextBox txt_Adult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_clear;
    }
}

