
namespace CodeFirst
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabShowGames = new System.Windows.Forms.TabPage();
            this.tabAddGame = new System.Windows.Forms.TabPage();
            this.cbStudio = new System.Windows.Forms.ComboBox();
            this.lbGameName = new System.Windows.Forms.Label();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.lbGameStudio = new System.Windows.Forms.Label();
            this.btAddGame = new System.Windows.Forms.Button();
            this.lbGameStyle = new System.Windows.Forms.Label();
            this.tbGame = new System.Windows.Forms.TextBox();
            this.tab1.SuspendLayout();
            this.tabAddGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabAddGame);
            this.tab1.Controls.Add(this.tabShowGames);
            this.tab1.Location = new System.Drawing.Point(5, 6);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(357, 442);
            this.tab1.TabIndex = 9;
            // 
            // tabShowGames
            // 
            this.tabShowGames.Location = new System.Drawing.Point(4, 22);
            this.tabShowGames.Name = "tabShowGames";
            this.tabShowGames.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowGames.Size = new System.Drawing.Size(349, 416);
            this.tabShowGames.TabIndex = 1;
            this.tabShowGames.Text = "Show Games";
            this.tabShowGames.UseVisualStyleBackColor = true;
            // 
            // tabAddGame
            // 
            this.tabAddGame.Controls.Add(this.tbGame);
            this.tabAddGame.Controls.Add(this.lbGameStyle);
            this.tabAddGame.Controls.Add(this.btAddGame);
            this.tabAddGame.Controls.Add(this.lbGameStudio);
            this.tabAddGame.Controls.Add(this.cbStyle);
            this.tabAddGame.Controls.Add(this.lbGameName);
            this.tabAddGame.Controls.Add(this.cbStudio);
            this.tabAddGame.Location = new System.Drawing.Point(4, 22);
            this.tabAddGame.Name = "tabAddGame";
            this.tabAddGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddGame.Size = new System.Drawing.Size(349, 416);
            this.tabAddGame.TabIndex = 0;
            this.tabAddGame.Text = "Add Game";
            this.tabAddGame.UseVisualStyleBackColor = true;
            this.tabAddGame.Click += new System.EventHandler(this.tabAddGame_Click);
            // 
            // cbStudio
            // 
            this.cbStudio.FormattingEnabled = true;
            this.cbStudio.Location = new System.Drawing.Point(116, 113);
            this.cbStudio.Name = "cbStudio";
            this.cbStudio.Size = new System.Drawing.Size(164, 21);
            this.cbStudio.TabIndex = 7;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameName.Location = new System.Drawing.Point(37, 63);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(57, 20);
            this.lbGameName.TabIndex = 0;
            this.lbGameName.Text = "Game";
            this.lbGameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(116, 170);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(164, 21);
            this.cbStyle.TabIndex = 8;
            // 
            // lbGameStudio
            // 
            this.lbGameStudio.AutoSize = true;
            this.lbGameStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameStudio.Location = new System.Drawing.Point(33, 114);
            this.lbGameStudio.Name = "lbGameStudio";
            this.lbGameStudio.Size = new System.Drawing.Size(61, 20);
            this.lbGameStudio.TabIndex = 1;
            this.lbGameStudio.Text = "Studio";
            // 
            // btAddGame
            // 
            this.btAddGame.BackColor = System.Drawing.Color.Orange;
            this.btAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddGame.Location = new System.Drawing.Point(135, 235);
            this.btAddGame.Name = "btAddGame";
            this.btAddGame.Size = new System.Drawing.Size(103, 36);
            this.btAddGame.TabIndex = 6;
            this.btAddGame.Text = "Add Game";
            this.btAddGame.UseVisualStyleBackColor = false;
            // 
            // lbGameStyle
            // 
            this.lbGameStyle.AutoSize = true;
            this.lbGameStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameStyle.Location = new System.Drawing.Point(45, 171);
            this.lbGameStyle.Name = "lbGameStyle";
            this.lbGameStyle.Size = new System.Drawing.Size(49, 20);
            this.lbGameStyle.TabIndex = 2;
            this.lbGameStyle.Text = "Style";
            // 
            // tbGame
            // 
            this.tbGame.Location = new System.Drawing.Point(116, 63);
            this.tbGame.Name = "tbGame";
            this.tbGame.Size = new System.Drawing.Size(164, 20);
            this.tbGame.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.tabAddGame.ResumeLayout(false);
            this.tabAddGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabAddGame;
        private System.Windows.Forms.TextBox tbGame;
        private System.Windows.Forms.Label lbGameStyle;
        private System.Windows.Forms.Button btAddGame;
        private System.Windows.Forms.Label lbGameStudio;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.ComboBox cbStudio;
        private System.Windows.Forms.TabPage tabShowGames;
    }
}

