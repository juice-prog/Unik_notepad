using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepaD17._2
{
    public partial class Блокнот : Form
    {
        //private string FilePath;
        public string openfile = String.Empty;
        public string filename;
        public Блокнот()
        
        {
            InitializeComponent();
            Сохр_ДиалФайла.Filter = "Text File(*.txt)|*.txt|NfNotepad File (*.nnf)|*.nnf";

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Сохр_ДиалФайла.ShowDialog() == DialogResult.Cancel) /*результат диалога сохранить нажатие на кнопку отмены*/
                return; /*закрывает диалог.окно после отмены*/
            string filename = Сохр_ДиалФайла.FileName;
            File.WriteAllText(filename, ТекстовРедактор.Text); /*сохранение Textа который в textbox1 в filename */
            MessageBox.Show("файл сохранен"); /* появляется диалоговое окно(messbox) с надписью*/
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Отк_Файл.ShowDialog() == DialogResult.Cancel) /*результат диалога открыть нажатие на кнопку отмены*/
                    return; /*закрывает диалог.окно после отмены*/
                string filename = Отк_Файл.FileName; /*открывет диаг окно windows*/
                string fileText = File.ReadAllText(filename); /*содержимое нашего файла */ /*создание переменной флтекст с прочтенными данными из файла*/
                ТекстовРедактор.Text = fileText;

                MessageBox.Show("файл открыт");

            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ТекстовРедактор.TextLength > 0) /*проверяем не равена ли длина текста 0*/
            {
                ТекстовРедактор.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ТекстовРедактор.TextLength > 0) /*проверяем не равна ли длина текста 0*/
            {
                ТекстовРедактор.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ТекстовРедактор.TextLength > 0) /*проверяем не равена ли длина текста 0*/
            {
                ТекстовРедактор.Cut();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Диалог_шрифтов.ShowDialog();
            ТекстовРедактор.Font = Диалог_шрифтов.Font;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = Сохр_ДиалФайла.FileName;
            /* if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
             {
                 return;
             }*/
            if (string.IsNullOrEmpty(filename))
            {

                MessageBox.Show("Будет создан новый файл,так как файла не существует");
                if (Сохр_ДиалФайла.ShowDialog() == DialogResult.Cancel) /*результат диалога сохранить нажатие на кнопку отмены*/
                    return; /*закрывает диалог.окно после отмены*/
                filename = Сохр_ДиалФайла.FileName;
                File.AppendAllText(filename, ТекстовРедактор.Text); /*сохранение Textа который в textbox1 в filename */
                MessageBox.Show("файл сохранен");
            }
            else
            {
                File.AppendAllText(filename, ТекстовРедактор.Text);
            }
        }
        private void переносПоСтрокамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            переносПоСтрокам.Checked = !переносПоСтрокам.Checked;
            ТекстовРедактор.WordWrap = переносПоСтрокам.Checked;
        }

        private void оПрограмме_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void создать_Click(object sender, EventArgs e)
        {
            ТекстовРедактор.Text = "";
            filename = "";
        }
    }
    
}
//========================================================================================
//string openfile = openFileDialog1.FileName;
/*saveFileDialog1.Filter = "TExt file(*.txt)|*.txt)";*/
/*if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
    return;*/
/*if (string.IsNullOrEmpty(FilePath))
{
using (SaveFileDialog dialog = new SaveFileDialog())
{
    if (dialog.ShowDialog() == DialogResult.OK)
    {
        FilePath = dialog.FileName;
        File.WriteAllText(FilePath, textBox1.Text);
    }
}
}
File.WriteAllText(FilePath, textBox1.Text);*/

//==========================================================================================
/*saveFileDialog1.ShowDialog();

    //string filename = saveFileDialog1.FileName;
    File.WriteAllText(filename, textBox1.Text);
}
else
{
    File.WriteAllText(filename, textBox1.Text);
}


}
/*catch (Exception)
{
    MessageBox.Show("файла не существует");
}*/
/*catch
{
    MessageBox.Show("Будет создан новый файл,так как файла не существует");
}*/

