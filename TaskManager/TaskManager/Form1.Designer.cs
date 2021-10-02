
namespace TaskManager
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTheards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btStartProcName = new System.Windows.Forms.Button();
            this.btStopProcID = new System.Windows.Forms.Button();
            this.btStoptProcName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colTimeStart,
            this.colTheards,
            this.colTime});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Назва процесу";
            this.colName.Width = 184;
            // 
            // colTimeStart
            // 
            this.colTimeStart.Text = "Час початку роботи";
            this.colTimeStart.Width = 117;
            // 
            // colTheards
            // 
            this.colTheards.Text = "Кількість потоків в процесі";
            this.colTheards.Width = 92;
            // 
            // colTime
            // 
            this.colTime.Text = "Кількість виділеного часу";
            this.colTime.Width = 156;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btStart.Location = new System.Drawing.Point(196, 389);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(167, 40);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btStartProcName
            // 
            this.btStartProcName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btStartProcName.Location = new System.Drawing.Point(609, 253);
            this.btStartProcName.Name = "btStartProcName";
            this.btStartProcName.Size = new System.Drawing.Size(167, 40);
            this.btStartProcName.TabIndex = 4;
            this.btStartProcName.Text = "Запустити процес";
            this.btStartProcName.UseVisualStyleBackColor = false;
            this.btStartProcName.Click += new System.EventHandler(this.btStartProcName_Click);
            // 
            // btStopProcID
            // 
            this.btStopProcID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btStopProcID.Location = new System.Drawing.Point(609, 179);
            this.btStopProcID.Name = "btStopProcID";
            this.btStopProcID.Size = new System.Drawing.Size(167, 40);
            this.btStopProcID.TabIndex = 5;
            this.btStopProcID.Text = "Зупинити процес по ІД";
            this.btStopProcID.UseVisualStyleBackColor = false;
            this.btStopProcID.Click += new System.EventHandler(this.btStopProcID_Click);
            // 
            // btStoptProcName
            // 
            this.btStoptProcName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btStoptProcName.Location = new System.Drawing.Point(609, 102);
            this.btStoptProcName.Name = "btStoptProcName";
            this.btStoptProcName.Size = new System.Drawing.Size(167, 40);
            this.btStoptProcName.TabIndex = 6;
            this.btStoptProcName.Text = "Зупинити процес по імені";
            this.btStoptProcName.UseVisualStyleBackColor = false;
            this.btStoptProcName.Click += new System.EventHandler(this.btStoptProcName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStoptProcName);
            this.Controls.Add(this.btStopProcID);
            this.Controls.Add(this.btStartProcName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTimeStart;
        private System.Windows.Forms.ColumnHeader colTheards;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btStartProcName;
        private System.Windows.Forms.Button btStopProcID;
        private System.Windows.Forms.Button btStoptProcName;
    }
}

