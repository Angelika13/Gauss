namespace Gauss
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAutoRezult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnBackWay = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.rdBtnAddRowToRow = new System.Windows.Forms.RadioButton();
            this.rdBtnDelRows = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBtnDiv = new System.Windows.Forms.RadioButton();
            this.rdBtnMultRow = new System.Windows.Forms.RadioButton();
            this.rdBtnEchangeRows = new System.Windows.Forms.RadioButton();
            this.numRow2 = new System.Windows.Forms.NumericUpDown();
            this.numRow1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(516, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(394, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(40, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во переменных";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(329, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(767, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Скопировать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(534, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(400, 611);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAutoRezult);
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 317);
            this.panel1.TabIndex = 11;
            // 
            // lblAutoRezult
            // 
            this.lblAutoRezult.AutoSize = true;
            this.lblAutoRezult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutoRezult.Location = new System.Drawing.Point(3, 3);
            this.lblAutoRezult.Name = "lblAutoRezult";
            this.lblAutoRezult.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblAutoRezult.Size = new System.Drawing.Size(14, 29);
            this.lblAutoRezult.TabIndex = 9;
            this.lblAutoRezult.Text = " ";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(448, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 31);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(541, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Функции для решения";
            // 
            // lblMatr
            // 
            this.lblMatr.AutoSize = true;
            this.lblMatr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatr.Location = new System.Drawing.Point(3, 3);
            this.lblMatr.Name = "lblMatr";
            this.lblMatr.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblMatr.Size = new System.Drawing.Size(14, 29);
            this.lblMatr.TabIndex = 13;
            this.lblMatr.Text = " ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.rdBtnBackWay);
            this.panel2.Controls.Add(this.textBoxX);
            this.panel2.Controls.Add(this.rdBtnAddRowToRow);
            this.panel2.Controls.Add(this.rdBtnDelRows);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rdBtnDiv);
            this.panel2.Controls.Add(this.rdBtnMultRow);
            this.panel2.Controls.Add(this.rdBtnEchangeRows);
            this.panel2.Controls.Add(this.numRow2);
            this.panel2.Controls.Add(this.numRow1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(545, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 270);
            this.panel2.TabIndex = 12;
            // 
            // rdBtnBackWay
            // 
            this.rdBtnBackWay.AutoSize = true;
            this.rdBtnBackWay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnBackWay.Location = new System.Drawing.Point(15, 156);
            this.rdBtnBackWay.Name = "rdBtnBackWay";
            this.rdBtnBackWay.Size = new System.Drawing.Size(133, 23);
            this.rdBtnBackWay.TabIndex = 26;
            this.rdBtnBackWay.Text = "Обратный ход";
            this.rdBtnBackWay.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(311, 192);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(56, 26);
            this.textBoxX.TabIndex = 25;
            this.textBoxX.Text = "1";
            this.textBoxX.Enter += new System.EventHandler(this.txtbox_Enter);
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_KeyPress);
            // 
            // rdBtnAddRowToRow
            // 
            this.rdBtnAddRowToRow.AutoSize = true;
            this.rdBtnAddRowToRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnAddRowToRow.Location = new System.Drawing.Point(15, 40);
            this.rdBtnAddRowToRow.Name = "rdBtnAddRowToRow";
            this.rdBtnAddRowToRow.Size = new System.Drawing.Size(327, 23);
            this.rdBtnAddRowToRow.TabIndex = 24;
            this.rdBtnAddRowToRow.Text = "К стр. 1 прибавить стр. 2, умн. на число";
            this.rdBtnAddRowToRow.UseVisualStyleBackColor = true;
            // 
            // rdBtnDelRows
            // 
            this.rdBtnDelRows.AutoSize = true;
            this.rdBtnDelRows.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnDelRows.Location = new System.Drawing.Point(15, 127);
            this.rdBtnDelRows.Name = "rdBtnDelRows";
            this.rdBtnDelRows.Size = new System.Drawing.Size(195, 23);
            this.rdBtnDelRows.TabIndex = 23;
            this.rdBtnDelRows.Text = "Удалить нулевые ряды";
            this.rdBtnDelRows.UseVisualStyleBackColor = true;
            this.rdBtnDelRows.CheckedChanged += new System.EventHandler(this.rdBtnDelRows_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(252, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Число:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(131, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Строка 2:";
            // 
            // rdBtnDiv
            // 
            this.rdBtnDiv.AutoSize = true;
            this.rdBtnDiv.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnDiv.Location = new System.Drawing.Point(15, 98);
            this.rdBtnDiv.Name = "rdBtnDiv";
            this.rdBtnDiv.Size = new System.Drawing.Size(240, 23);
            this.rdBtnDiv.TabIndex = 19;
            this.rdBtnDiv.Text = "Разделить строку 1 на число";
            this.rdBtnDiv.UseVisualStyleBackColor = true;
            // 
            // rdBtnMultRow
            // 
            this.rdBtnMultRow.AutoSize = true;
            this.rdBtnMultRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnMultRow.Location = new System.Drawing.Point(15, 69);
            this.rdBtnMultRow.Name = "rdBtnMultRow";
            this.rdBtnMultRow.Size = new System.Drawing.Size(231, 23);
            this.rdBtnMultRow.TabIndex = 19;
            this.rdBtnMultRow.Text = "Умножить сроку 1 на число";
            this.rdBtnMultRow.UseVisualStyleBackColor = true;
            // 
            // rdBtnEchangeRows
            // 
            this.rdBtnEchangeRows.AutoSize = true;
            this.rdBtnEchangeRows.Checked = true;
            this.rdBtnEchangeRows.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdBtnEchangeRows.Location = new System.Drawing.Point(15, 11);
            this.rdBtnEchangeRows.Name = "rdBtnEchangeRows";
            this.rdBtnEchangeRows.Size = new System.Drawing.Size(260, 23);
            this.rdBtnEchangeRows.TabIndex = 18;
            this.rdBtnEchangeRows.TabStop = true;
            this.rdBtnEchangeRows.Text = "Поменять местами строки 1 и 2";
            this.rdBtnEchangeRows.UseVisualStyleBackColor = true;
            // 
            // numRow2
            // 
            this.numRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRow2.Location = new System.Drawing.Point(212, 192);
            this.numRow2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numRow2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow2.Name = "numRow2";
            this.numRow2.ReadOnly = true;
            this.numRow2.Size = new System.Drawing.Size(40, 26);
            this.numRow2.TabIndex = 15;
            this.numRow2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numRow1
            // 
            this.numRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRow1.Location = new System.Drawing.Point(91, 192);
            this.numRow1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numRow1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow1.Name = "numRow1";
            this.numRow1.ReadOnly = true;
            this.numRow1.Size = new System.Drawing.Size(40, 26);
            this.numRow1.TabIndex = 14;
            this.numRow1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Строка 1:";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(125, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Выполнить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblMatr);
            this.panel3.Location = new System.Drawing.Point(534, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 256);
            this.panel3.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(842, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 31);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(541, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Решение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Исходная система";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Решение";
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(491, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 31);
            this.button7.TabIndex = 19;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(448, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 31);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файлы xml (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файлы xml (*.xml)|*.xml";
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(491, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 31);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(885, 318);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 31);
            this.button9.TabIndex = 22;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 650);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Form1";
            this.Text = "Решение систем линейных уравнений методом гаусса";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numRow2;
        private System.Windows.Forms.NumericUpDown numRow1;
        private System.Windows.Forms.RadioButton rdBtnEchangeRows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdBtnMultRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnDelRows;
        private System.Windows.Forms.RadioButton rdBtnAddRowToRow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.RadioButton rdBtnDiv;
        private System.Windows.Forms.RadioButton rdBtnBackWay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblAutoRezult;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

