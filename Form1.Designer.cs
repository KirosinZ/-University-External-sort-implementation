
namespace STRIALG_EXTERNAL_SORT
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
            this.Comparisons = new System.Windows.Forms.DataGridView();
            this.Iterations = new System.Windows.Forms.DataGridView();
            this.ElapsedTime = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GenerateFilesStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TestSortsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberIters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberElaps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Comparisons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedTime)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Comparisons
            // 
            this.Comparisons.AllowUserToAddRows = false;
            this.Comparisons.AllowUserToDeleteRows = false;
            this.Comparisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comparisons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Random,
            this.Descending});
            this.Comparisons.Location = new System.Drawing.Point(12, 69);
            this.Comparisons.Name = "Comparisons";
            this.Comparisons.ReadOnly = true;
            this.Comparisons.RowHeadersVisible = false;
            this.Comparisons.RowHeadersWidth = 51;
            this.Comparisons.RowTemplate.Height = 24;
            this.Comparisons.Size = new System.Drawing.Size(380, 195);
            this.Comparisons.TabIndex = 0;
            // 
            // Iterations
            // 
            this.Iterations.AllowUserToAddRows = false;
            this.Iterations.AllowUserToDeleteRows = false;
            this.Iterations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Iterations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberIters,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Iterations.Location = new System.Drawing.Point(398, 69);
            this.Iterations.Name = "Iterations";
            this.Iterations.ReadOnly = true;
            this.Iterations.RowHeadersVisible = false;
            this.Iterations.RowHeadersWidth = 51;
            this.Iterations.RowTemplate.Height = 24;
            this.Iterations.Size = new System.Drawing.Size(379, 195);
            this.Iterations.TabIndex = 0;
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.AllowUserToAddRows = false;
            this.ElapsedTime.AllowUserToDeleteRows = false;
            this.ElapsedTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElapsedTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberElaps,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ElapsedTime.Location = new System.Drawing.Point(783, 69);
            this.ElapsedTime.Name = "ElapsedTime";
            this.ElapsedTime.ReadOnly = true;
            this.ElapsedTime.RowHeadersVisible = false;
            this.ElapsedTime.RowHeadersWidth = 51;
            this.ElapsedTime.RowTemplate.Height = 24;
            this.ElapsedTime.Size = new System.Drawing.Size(379, 195);
            this.ElapsedTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество сравнений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество проходов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(778, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Время выполнения";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateFilesStrip,
            this.TestSortsStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1173, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateFilesStrip
            // 
            this.GenerateFilesStrip.Name = "GenerateFilesStrip";
            this.GenerateFilesStrip.Size = new System.Drawing.Size(179, 24);
            this.GenerateFilesStrip.Text = "Сгенерировать файлы";
            // 
            // TestSortsStrip
            // 
            this.TestSortsStrip.Name = "TestSortsStrip";
            this.TestSortsStrip.Size = new System.Drawing.Size(132, 24);
            this.TestSortsStrip.Text = "Провести тесты";
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "Количество элементов";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // Random
            // 
            this.Random.Frozen = true;
            this.Random.HeaderText = "Случайный файл";
            this.Random.MinimumWidth = 6;
            this.Random.Name = "Random";
            this.Random.ReadOnly = true;
            this.Random.Width = 125;
            // 
            // Descending
            // 
            this.Descending.Frozen = true;
            this.Descending.HeaderText = "Обратный файл";
            this.Descending.MinimumWidth = 6;
            this.Descending.Name = "Descending";
            this.Descending.ReadOnly = true;
            this.Descending.Width = 125;
            // 
            // NumberIters
            // 
            this.NumberIters.Frozen = true;
            this.NumberIters.HeaderText = "Количество элементов";
            this.NumberIters.MinimumWidth = 6;
            this.NumberIters.Name = "NumberIters";
            this.NumberIters.ReadOnly = true;
            this.NumberIters.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Случайный файл";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Обратный файл";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // NumberElaps
            // 
            this.NumberElaps.Frozen = true;
            this.NumberElaps.HeaderText = "Количество элементов";
            this.NumberElaps.MinimumWidth = 6;
            this.NumberElaps.Name = "NumberElaps";
            this.NumberElaps.ReadOnly = true;
            this.NumberElaps.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Случайный файл";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Обратный файл";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ElapsedTime);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.Comparisons);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Comparisons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedTime)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Comparisons;
        private System.Windows.Forms.DataGridView Iterations;
        private System.Windows.Forms.DataGridView ElapsedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GenerateFilesStrip;
        private System.Windows.Forms.ToolStripMenuItem TestSortsStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descending;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberIters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberElaps;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

