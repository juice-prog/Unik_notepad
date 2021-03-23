namespace notepaD17._2
{
    partial class Блокнот
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Блокнот));
            this.Полоска_меню = new System.Windows.Forms.MenuStrip();
            this.файл = new System.Windows.Forms.ToolStripMenuItem();
            this.создать = new System.Windows.Forms.ToolStripMenuItem();
            this.открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКак = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.выход = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифт = new System.Windows.Forms.ToolStripMenuItem();
            this.справка = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмме = new System.Windows.Forms.ToolStripMenuItem();
            this.буферОбмена = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезать = new System.Windows.Forms.ToolStripMenuItem();
            this.вставить = new System.Windows.Forms.ToolStripMenuItem();
            this.копировать = new System.Windows.Forms.ToolStripMenuItem();
            this.печать = new System.Windows.Forms.ToolStripMenuItem();
            this.переносПоСтрокам = new System.Windows.Forms.ToolStripMenuItem();
            this.ТекстовРедактор = new System.Windows.Forms.TextBox();
            this.Сохр_ДиалФайла = new System.Windows.Forms.SaveFileDialog();
            this.Отк_Файл = new System.Windows.Forms.OpenFileDialog();
            
            this.Диалог_шрифтов = new System.Windows.Forms.FontDialog();
            this.Полоска_меню.SuspendLayout();
            this.SuspendLayout();
            // 
            // Полоска_меню
            // 
            this.Полоска_меню.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Полоска_меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файл,
            this.шрифт,
            this.буферОбмена,
            this.переносПоСтрокам,
            this.справка,
            this.печать});
            this.Полоска_меню.Location = new System.Drawing.Point(0, 0);
            this.Полоска_меню.Name = "Полоска_меню";
            this.Полоска_меню.Size = new System.Drawing.Size(800, 28);
            this.Полоска_меню.TabIndex = 0;
            this.Полоска_меню.Text = "menuStrip1";
            // 
            // файл
            // 
            this.файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создать,
            this.открыть,
            this.сохранитьКак,
            this.сохранить,
            this.выход});
            this.файл.Name = "файл";
            this.файл.Size = new System.Drawing.Size(57, 24);
            this.файл.Text = "Файл";
            this.файл.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // создать
            // 
            this.создать.Name = "создать";
            this.создать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создать.Size = new System.Drawing.Size(263, 26);
            this.создать.Text = "Создать";
            this.создать.Click += new System.EventHandler(this.создать_Click);
            // 
            // открыть
            // 
            this.открыть.Name = "открыть";
            this.открыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открыть.Size = new System.Drawing.Size(263, 26);
            this.открыть.Text = "Открыть";
            this.открыть.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКак
            // 
            this.сохранитьКак.Name = "сохранитьКак";
            this.сохранитьКак.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКак.Size = new System.Drawing.Size(263, 26);
            this.сохранитьКак.Text = "Сохранить как";
            this.сохранитьКак.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранить
            // 
            this.сохранить.Name = "сохранить";
            this.сохранить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранить.Size = new System.Drawing.Size(263, 26);
            this.сохранить.Text = "Сохранить";
            this.сохранить.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выход
            // 
            this.выход.Name = "выход";
            this.выход.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выход.Size = new System.Drawing.Size(263, 26);
            this.выход.Text = "Выход";
            // 
            // шрифт
            // 
            this.шрифт.Name = "шрифт";
            this.шрифт.Size = new System.Drawing.Size(69, 24);
            this.шрифт.Text = "Шрифт";
            this.шрифт.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // справка
            // 
            this.справка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограмме});
            this.справка.Name = "справка";
            this.справка.Size = new System.Drawing.Size(79, 24);
            this.справка.Text = "Справка";
            // 
            // оПрограмме
            // 
            this.оПрограмме.Name = "оПрограмме";
            this.оПрограмме.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.оПрограмме.Size = new System.Drawing.Size(232, 26);
            this.оПрограмме.Text = "О программе";
            this.оПрограмме.Click += new System.EventHandler(this.оПрограмме_Click);
            // 
            // буферОбмена
            // 
            this.буферОбмена.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезать,
            this.вставить,
            this.копировать});
            this.буферОбмена.Name = "буферОбмена";
            this.буферОбмена.Size = new System.Drawing.Size(122, 24);
            this.буферОбмена.Text = "Буфер обмена";
            // 
            // вырезать
            // 
            this.вырезать.Name = "вырезать";
            this.вырезать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезать.Size = new System.Drawing.Size(219, 26);
            this.вырезать.Text = "Вырезать";
            this.вырезать.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // вставить
            // 
            this.вставить.Name = "вставить";
            this.вставить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставить.Size = new System.Drawing.Size(219, 26);
            this.вставить.Text = "Вставить";
            this.вставить.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // копировать
            // 
            this.копировать.Name = "копировать";
            this.копировать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копировать.Size = new System.Drawing.Size(219, 26);
            this.копировать.Text = "Копировать";
            this.копировать.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // печать
            // 
            this.печать.Name = "печать";
            this.печать.Size = new System.Drawing.Size(70, 24);
            this.печать.Text = "Печать";
            // 
            // переносПоСтрокам
            // 
            this.переносПоСтрокам.Name = "переносПоСтрокам";
            this.переносПоСтрокам.Size = new System.Drawing.Size(165, 24);
            this.переносПоСтрокам.Text = "Перенос по строкам";
            this.переносПоСтрокам.Click += new System.EventHandler(this.переносПоСтрокамToolStripMenuItem_Click);
            // 
            // ТекстовРедактор
            // 
            this.ТекстовРедактор.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ТекстовРедактор.Location = new System.Drawing.Point(0, 28);
            this.ТекстовРедактор.Multiline = true;
            this.ТекстовРедактор.Name = "ТекстовРедактор";
            this.ТекстовРедактор.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ТекстовРедактор.Size = new System.Drawing.Size(800, 422);
            this.ТекстовРедактор.TabIndex = 1;
            // 
            // Отк_Файл
            // 
            this.Отк_Файл.FileName = "openFileDialog1";
            // 
            // Блокнот
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ТекстовРедактор);
            this.Controls.Add(this.Полоска_меню);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Полоска_меню;
            this.Name = "Блокнот";
            this.Text = "NotepadNF";
            this.Полоска_меню.ResumeLayout(false);
            this.Полоска_меню.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Полоска_меню;
        private System.Windows.Forms.ToolStripMenuItem файл;
        private System.Windows.Forms.ToolStripMenuItem создать;
        private System.Windows.Forms.ToolStripMenuItem открыть;
        private System.Windows.Forms.ToolStripMenuItem сохранить;
        private System.Windows.Forms.ToolStripMenuItem выход;
        private System.Windows.Forms.ToolStripMenuItem шрифт;
        private System.Windows.Forms.ToolStripMenuItem справка;
        private System.Windows.Forms.ToolStripMenuItem буферОбмена;
        private System.Windows.Forms.ToolStripMenuItem оПрограмме;
        private System.Windows.Forms.ToolStripMenuItem вырезать;
        private System.Windows.Forms.ToolStripMenuItem вставить;
        private System.Windows.Forms.ToolStripMenuItem копировать;
        private System.Windows.Forms.ToolStripMenuItem печать;
        private System.Windows.Forms.TextBox ТекстовРедактор;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКак;
        private System.Windows.Forms.SaveFileDialog Сохр_ДиалФайла;
        private System.Windows.Forms.OpenFileDialog Отк_Файл;
        private System.Windows.Forms.FontDialog Диалог_шрифтов;
        private System.Windows.Forms.ToolStripMenuItem переносПоСтрокам;
    }
}

