﻿namespace aomsin
{
    partial class payment
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
            this.price = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.typeincomesearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateendsearch = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datestartsearch = new System.Windows.Forms.DateTimePicker();
            this.allprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.allIncome = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descriptionincome = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.save_income = new System.Windows.Forms.Button();
            this.addTypeIncomeBox = new System.Windows.Forms.GroupBox();
            this.closetypeincome = new System.Windows.Forms.Button();
            this.dataG_ShowAllTypeIncome = new System.Windows.Forms.DataGridView();
            this.saveTypeIncome = new System.Windows.Forms.Button();
            this.txtBox_addnameIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_addIdIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTypeIncome = new System.Windows.Forms.Button();
            this.typeincoms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_income = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.addTypeIncomeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_ShowAllTypeIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Controls.Add(this.button3);
            this.price.Controls.Add(this.search);
            this.price.Controls.Add(this.typeincomesearch);
            this.price.Controls.Add(this.label10);
            this.price.Controls.Add(this.dateendsearch);
            this.price.Controls.Add(this.label9);
            this.price.Controls.Add(this.label8);
            this.price.Controls.Add(this.datestartsearch);
            this.price.Controls.Add(this.allprice);
            this.price.Controls.Add(this.label7);
            this.price.Controls.Add(this.allIncome);
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(415, 17);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(1012, 750);
            this.price.TabIndex = 4;
            this.price.TabStop = false;
            this.price.Text = "ค้นหา";
            this.price.Enter += new System.EventHandler(this.price_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = " นำออกเป็น PDF";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(526, 96);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(155, 30);
            this.search.TabIndex = 18;
            this.search.Text = "แสดงผล";
            this.search.UseVisualStyleBackColor = true;
            // 
            // typeincomesearch
            // 
            this.typeincomesearch.FormattingEnabled = true;
            this.typeincomesearch.Location = new System.Drawing.Point(134, 98);
            this.typeincomesearch.Name = "typeincomesearch";
            this.typeincomesearch.Size = new System.Drawing.Size(354, 30);
            this.typeincomesearch.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "ประเภท";
            // 
            // dateendsearch
            // 
            this.dateendsearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateendsearch.Location = new System.Drawing.Point(619, 49);
            this.dateendsearch.Name = "dateendsearch";
            this.dateendsearch.Size = new System.Drawing.Size(354, 28);
            this.dateendsearch.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "วันที่สิ้นสุด";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "วันที่เริ่มต้น";
            // 
            // datestartsearch
            // 
            this.datestartsearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestartsearch.Location = new System.Drawing.Point(134, 49);
            this.datestartsearch.Name = "datestartsearch";
            this.datestartsearch.Size = new System.Drawing.Size(354, 28);
            this.datestartsearch.TabIndex = 14;
            // 
            // allprice
            // 
            this.allprice.AutoSize = true;
            this.allprice.Location = new System.Drawing.Point(862, 679);
            this.allprice.Name = "allprice";
            this.allprice.Size = new System.Drawing.Size(20, 24);
            this.allprice.TabIndex = 3;
            this.allprice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(708, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "รวมรายรับทั้งสิ้น";
            // 
            // allIncome
            // 
            this.allIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allIncome.Location = new System.Drawing.Point(24, 165);
            this.allIncome.Name = "allIncome";
            this.allIncome.RowTemplate.Height = 24;
            this.allIncome.Size = new System.Drawing.Size(968, 485);
            this.allIncome.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionincome);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.save_income);
            this.groupBox1.Controls.Add(this.addTypeIncomeBox);
            this.groupBox1.Controls.Add(this.money);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddTypeIncome);
            this.groupBox1.Controls.Add(this.typeincoms);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_income);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 750);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "บันทึกรายจ่าย";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // descriptionincome
            // 
            this.descriptionincome.Location = new System.Drawing.Point(113, 129);
            this.descriptionincome.Multiline = true;
            this.descriptionincome.Name = "descriptionincome";
            this.descriptionincome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionincome.Size = new System.Drawing.Size(254, 122);
            this.descriptionincome.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "ลบ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // save_income
            // 
            this.save_income.Location = new System.Drawing.Point(77, 300);
            this.save_income.Name = "save_income";
            this.save_income.Size = new System.Drawing.Size(78, 35);
            this.save_income.TabIndex = 11;
            this.save_income.Text = "บันทึก";
            this.save_income.UseVisualStyleBackColor = true;
            // 
            // addTypeIncomeBox
            // 
            this.addTypeIncomeBox.Controls.Add(this.closetypeincome);
            this.addTypeIncomeBox.Controls.Add(this.dataG_ShowAllTypeIncome);
            this.addTypeIncomeBox.Controls.Add(this.saveTypeIncome);
            this.addTypeIncomeBox.Controls.Add(this.txtBox_addnameIncome);
            this.addTypeIncomeBox.Controls.Add(this.label6);
            this.addTypeIncomeBox.Controls.Add(this.txtBox_addIdIncome);
            this.addTypeIncomeBox.Controls.Add(this.label5);
            this.addTypeIncomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTypeIncomeBox.Location = new System.Drawing.Point(18, 362);
            this.addTypeIncomeBox.Name = "addTypeIncomeBox";
            this.addTypeIncomeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTypeIncomeBox.Size = new System.Drawing.Size(349, 363);
            this.addTypeIncomeBox.TabIndex = 10;
            this.addTypeIncomeBox.TabStop = false;
            this.addTypeIncomeBox.Text = "เพิ่มประเภทรายจ่าย";
            // 
            // closetypeincome
            // 
            this.closetypeincome.Location = new System.Drawing.Point(226, 134);
            this.closetypeincome.Name = "closetypeincome";
            this.closetypeincome.Size = new System.Drawing.Size(75, 35);
            this.closetypeincome.TabIndex = 14;
            this.closetypeincome.Text = "ปิด";
            this.closetypeincome.UseVisualStyleBackColor = true;
            // 
            // dataG_ShowAllTypeIncome
            // 
            this.dataG_ShowAllTypeIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_ShowAllTypeIncome.Location = new System.Drawing.Point(20, 185);
            this.dataG_ShowAllTypeIncome.Name = "dataG_ShowAllTypeIncome";
            this.dataG_ShowAllTypeIncome.RowTemplate.Height = 24;
            this.dataG_ShowAllTypeIncome.Size = new System.Drawing.Size(312, 156);
            this.dataG_ShowAllTypeIncome.TabIndex = 14;
            // 
            // saveTypeIncome
            // 
            this.saveTypeIncome.Location = new System.Drawing.Point(59, 134);
            this.saveTypeIncome.Name = "saveTypeIncome";
            this.saveTypeIncome.Size = new System.Drawing.Size(78, 35);
            this.saveTypeIncome.TabIndex = 13;
            this.saveTypeIncome.Text = "บันทึก";
            this.saveTypeIncome.UseMnemonic = false;
            this.saveTypeIncome.UseVisualStyleBackColor = true;
            // 
            // txtBox_addnameIncome
            // 
            this.txtBox_addnameIncome.Location = new System.Drawing.Point(162, 90);
            this.txtBox_addnameIncome.Name = "txtBox_addnameIncome";
            this.txtBox_addnameIncome.Size = new System.Drawing.Size(170, 27);
            this.txtBox_addnameIncome.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ชื่อประเภทรายรับ";
            // 
            // txtBox_addIdIncome
            // 
            this.txtBox_addIdIncome.Location = new System.Drawing.Point(162, 47);
            this.txtBox_addIdIncome.Name = "txtBox_addIdIncome";
            this.txtBox_addIdIncome.Size = new System.Drawing.Size(170, 27);
            this.txtBox_addIdIncome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "รหัสประเภทรายรับ";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(113, 257);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(254, 28);
            this.money.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "จำนวนเงิน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "รายละเอียด";
            // 
            // btnAddTypeIncome
            // 
            this.btnAddTypeIncome.Location = new System.Drawing.Point(325, 87);
            this.btnAddTypeIncome.Name = "btnAddTypeIncome";
            this.btnAddTypeIncome.Size = new System.Drawing.Size(42, 30);
            this.btnAddTypeIncome.TabIndex = 4;
            this.btnAddTypeIncome.Text = "..";
            this.btnAddTypeIncome.UseVisualStyleBackColor = true;
            // 
            // typeincoms
            // 
            this.typeincoms.FormattingEnabled = true;
            this.typeincoms.Location = new System.Drawing.Point(113, 87);
            this.typeincoms.Name = "typeincoms";
            this.typeincoms.Size = new System.Drawing.Size(206, 30);
            this.typeincoms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ประเภท";
            // 
            // date_income
            // 
            this.date_income.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_income.Location = new System.Drawing.Point(113, 43);
            this.date_income.Name = "date_income";
            this.date_income.Size = new System.Drawing.Size(254, 28);
            this.date_income.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "วันที่";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 797);
            this.Controls.Add(this.price);
            this.Controls.Add(this.groupBox1);
            this.Name = "payment";
            this.Text = "payment";
            this.price.ResumeLayout(false);
            this.price.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.addTypeIncomeBox.ResumeLayout(false);
            this.addTypeIncomeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_ShowAllTypeIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox price;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox typeincomesearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateendsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datestartsearch;
        private System.Windows.Forms.Label allprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView allIncome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionincome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_income;
        private System.Windows.Forms.GroupBox addTypeIncomeBox;
        private System.Windows.Forms.Button closetypeincome;
        private System.Windows.Forms.DataGridView dataG_ShowAllTypeIncome;
        private System.Windows.Forms.Button saveTypeIncome;
        private System.Windows.Forms.TextBox txtBox_addnameIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_addIdIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddTypeIncome;
        private System.Windows.Forms.ComboBox typeincoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_income;
        private System.Windows.Forms.Label label1;
    }
}