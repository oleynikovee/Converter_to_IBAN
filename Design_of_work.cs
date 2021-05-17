namespace Curs_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.collection_of_countries = new System.Windows.Forms.ComboBox();
            this.textBox_kod = new System.Windows.Forms.TextBox();
            this.textBox_nomer = new System.Windows.Forms.TextBox();
            this.textBox_IBAN = new System.Windows.Forms.TextBox();
            this.rasch = new System.Windows.Forms.Button();
            this.kod = new System.Windows.Forms.Label();
            this.nomer_sch = new System.Windows.Forms.Label();
            this.IBAN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.console_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collection_of_countries
            // 
            this.collection_of_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collection_of_countries.ForeColor = System.Drawing.SystemColors.WindowText;
            this.collection_of_countries.FormattingEnabled = true;
            this.collection_of_countries.Items.AddRange(new object[] {
            "Австрія(AT)",
            "Гренландія(GL)",
            "Данія(DK)",
            "Казахстан(KZ)",
            "Ліван(LB)",
            "Ліхтенштейн(LI)",
            "Литва(LT)",
            "Люксембург(LU)",
            "Німеччина(DE)",
            "Об\'єднані Арабські Емірати(AE)",
            "Саудівська Аравія(SA)",
            "Україна(UA)",
            "Хорватія(HR)",
            "Швеція(SE)"});
            this.collection_of_countries.Location = new System.Drawing.Point(16, 29);
            this.collection_of_countries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.collection_of_countries.Name = "collection_of_countries";
            this.collection_of_countries.Size = new System.Drawing.Size(258, 24);
            this.collection_of_countries.TabIndex = 0;
            // 
            // textBox_kod
            // 
            this.textBox_kod.Location = new System.Drawing.Point(15, 77);
            this.textBox_kod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_kod.Name = "textBox_kod";
            this.textBox_kod.ShortcutsEnabled = false;
            this.textBox_kod.Size = new System.Drawing.Size(258, 24);
            this.textBox_kod.TabIndex = 1;
            // 
            // textBox_nomer
            // 
            this.textBox_nomer.Location = new System.Drawing.Point(16, 125);
            this.textBox_nomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_nomer.Name = "textBox_nomer";
            this.textBox_nomer.ShortcutsEnabled = false;
            this.textBox_nomer.Size = new System.Drawing.Size(258, 24);
            this.textBox_nomer.TabIndex = 2;
            // 
            // textBox_IBAN
            // 
            this.textBox_IBAN.Location = new System.Drawing.Point(15, 173);
            this.textBox_IBAN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IBAN.Name = "textBox_IBAN";
            this.textBox_IBAN.ReadOnly = true;
            this.textBox_IBAN.ShortcutsEnabled = false;
            this.textBox_IBAN.Size = new System.Drawing.Size(258, 24);
            this.textBox_IBAN.TabIndex = 3;
            // 
            // rasch
            // 
            this.rasch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rasch.BackColor = System.Drawing.Color.Green;
            this.rasch.CausesValidation = false;
            this.rasch.Cursor = System.Windows.Forms.Cursors.Default;
            this.rasch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rasch.Font = new System.Drawing.Font("GOST type B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rasch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rasch.Location = new System.Drawing.Point(306, 11);
            this.rasch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rasch.Name = "rasch";
            this.rasch.Size = new System.Drawing.Size(149, 70);
            this.rasch.TabIndex = 4;
            this.rasch.Text = "Розрахувати\r\n";
            this.rasch.UseVisualStyleBackColor = false;
            this.rasch.Click += new System.EventHandler(this.rasch_Click);
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kod.Location = new System.Drawing.Point(13, 57);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(121, 16);
            this.kod.TabIndex = 5;
            this.kod.Text = "код МФО банку:";
            // 
            // nomer_sch
            // 
            this.nomer_sch.AutoSize = true;
            this.nomer_sch.CausesValidation = false;
            this.nomer_sch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nomer_sch.Location = new System.Drawing.Point(13, 105);
            this.nomer_sch.Name = "nomer_sch";
            this.nomer_sch.Size = new System.Drawing.Size(117, 16);
            this.nomer_sch.TabIndex = 6;
            this.nomer_sch.Text = "Номер рахунку:";
            // 
            // IBAN
            // 
            this.IBAN.AutoSize = true;
            this.IBAN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.IBAN.Location = new System.Drawing.Point(13, 153);
            this.IBAN.Name = "IBAN";
            this.IBAN.Size = new System.Drawing.Size(78, 16);
            this.IBAN.TabIndex = 7;
            this.IBAN.Text = "Ваш IBAN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Необхідна країна:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("GOST type B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(306, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "Перевірити контрольні цифри";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.CausesValidation = false;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("GOST type B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(306, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 64);
            this.button2.TabIndex = 10;
            this.button2.Text = "Скопіювати";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // console_button
            // 
            this.console_button.Location = new System.Drawing.Point(16, 204);
            this.console_button.Name = "console_button";
            this.console_button.Size = new System.Drawing.Size(258, 23);
            this.console_button.TabIndex = 11;
            this.console_button.Text = "Перейти в консольний режим!";
            this.console_button.UseVisualStyleBackColor = true;
            this.console_button.Click += new System.EventHandler(this.console_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(467, 235);
            this.Controls.Add(this.console_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IBAN);
            this.Controls.Add(this.nomer_sch);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.rasch);
            this.Controls.Add(this.textBox_IBAN);
            this.Controls.Add(this.textBox_nomer);
            this.Controls.Add(this.textBox_kod);
            this.Controls.Add(this.collection_of_countries);
            this.Font = new System.Drawing.Font("GOST type B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Розрахунок IBAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox collection_of_countries;
        private System.Windows.Forms.TextBox textBox_kod;
        private System.Windows.Forms.TextBox textBox_nomer;
        private System.Windows.Forms.TextBox textBox_IBAN;
        private System.Windows.Forms.Button rasch;
        private System.Windows.Forms.Label kod;
        private System.Windows.Forms.Label nomer_sch;
        private System.Windows.Forms.Label IBAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button console_button;
    }
}


