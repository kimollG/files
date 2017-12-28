namespace Semestr2Att3
{
    partial class FormGraph
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
            this.buttonReadGraf = new System.Windows.Forms.Button();
            this.dataGridViewGraf = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownMin1 = new System.Windows.Forms.NumericUpDown();
            this.labelMin1 = new System.Windows.Forms.Label();
            this.radioButtonEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonNode = new System.Windows.Forms.RadioButton();
            this.buttonFind = new System.Windows.Forms.Button();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin1)).BeginInit();
            this.groupBoxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReadGraf
            // 
            this.buttonReadGraf.Location = new System.Drawing.Point(321, 36);
            this.buttonReadGraf.Name = "buttonReadGraf";
            this.buttonReadGraf.Size = new System.Drawing.Size(126, 36);
            this.buttonReadGraf.TabIndex = 0;
            this.buttonReadGraf.Text = "Почитать граф из файла";
            this.buttonReadGraf.UseVisualStyleBackColor = true;
            this.buttonReadGraf.Click += new System.EventHandler(this.buttonReadGraf_Click);
            // 
            // dataGridViewGraf
            // 
            this.dataGridViewGraf.AllowUserToAddRows = false;
            this.dataGridViewGraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraf.Location = new System.Drawing.Point(23, 25);
            this.dataGridViewGraf.Name = "dataGridViewGraf";
            this.dataGridViewGraf.Size = new System.Drawing.Size(240, 224);
            this.dataGridViewGraf.TabIndex = 1;
            this.dataGridViewGraf.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGraf_CellEndEdit);
            this.dataGridViewGraf.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewGraf_RowsAdded);
            this.dataGridViewGraf.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewGraf_UserDeletedRow);
            this.dataGridViewGraf.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewGraf_UserDeletedRow);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownMin1
            // 
            this.numericUpDownMin1.Location = new System.Drawing.Point(340, 143);
            this.numericUpDownMin1.Name = "numericUpDownMin1";
            this.numericUpDownMin1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMin1.TabIndex = 4;
            // 
            // labelMin1
            // 
            this.labelMin1.AutoSize = true;
            this.labelMin1.Location = new System.Drawing.Point(337, 117);
            this.labelMin1.Name = "labelMin1";
            this.labelMin1.Size = new System.Drawing.Size(129, 13);
            this.labelMin1.TabIndex = 6;
            this.labelMin1.Text = "Номер первой вершины";
            // 
            // radioButtonEdge
            // 
            this.radioButtonEdge.AutoSize = true;
            this.radioButtonEdge.Location = new System.Drawing.Point(6, 19);
            this.radioButtonEdge.Name = "radioButtonEdge";
            this.radioButtonEdge.Size = new System.Drawing.Size(108, 17);
            this.radioButtonEdge.TabIndex = 8;
            this.radioButtonEdge.TabStop = true;
            this.radioButtonEdge.Text = "Поиск в глубину\r\n";
            this.radioButtonEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonNode
            // 
            this.radioButtonNode.AutoSize = true;
            this.radioButtonNode.Location = new System.Drawing.Point(6, 38);
            this.radioButtonNode.Name = "radioButtonNode";
            this.radioButtonNode.Size = new System.Drawing.Size(106, 17);
            this.radioButtonNode.TabIndex = 9;
            this.radioButtonNode.TabStop = true;
            this.radioButtonNode.Text = "Поиск в ширину";
            this.radioButtonNode.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(275, 181);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(223, 33);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Искать";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.radioButtonEdge);
            this.groupBoxChoice.Controls.Add(this.radioButtonNode);
            this.groupBoxChoice.Location = new System.Drawing.Point(269, 236);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(328, 68);
            this.groupBoxChoice.TabIndex = 11;
            this.groupBoxChoice.TabStop = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(664, 143);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(122, 117);
            this.textBoxAnswer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ответ";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(664, 59);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(109, 48);
            this.buttonDraw.TabIndex = 14;
            this.buttonDraw.Text = "Нарисовать граф";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(108, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "+Узел";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(108, 295);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "-Узел";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 321);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelMin1);
            this.Controls.Add(this.numericUpDownMin1);
            this.Controls.Add(this.dataGridViewGraf);
            this.Controls.Add(this.buttonReadGraf);
            this.Name = "FormGraph";
            this.Text = "Задача 34";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin1)).EndInit();
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadGraf;
        private System.Windows.Forms.DataGridView dataGridViewGraf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDownMin1;
        private System.Windows.Forms.Label labelMin1;
        private System.Windows.Forms.RadioButton radioButtonEdge;
        private System.Windows.Forms.RadioButton radioButtonNode;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
    }
}

