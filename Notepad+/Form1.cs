using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Notepad_
{
    /// <summary>
    /// Форма.
    /// </summary>
    public partial class Form1 : Form
    {
        // Вносил ли пользователь изменения.
        List<bool> wasChanged;
        // Известно ли где лежит файл.
        List<bool> havePath;
        // Тема.
        private int theme = 0;
        // Время таймера для автосэйва.
        private int time = 0;
        // Таймер.
        private Timer timer1;
        // Коллекция адресов вкладок.
        StringCollection collection = new StringCollection();
        /// <summary>
        /// Создание формы и первой вкладки.
        /// </summary>
        public Form1()
        {
            this.tabControl1 = new TabControl();
            InitializeComponent();
            tabControl1.Controls.RemoveByKey("TabPage1");
            wasChanged = new List<bool>();
            havePath = new List<bool>();
            var myPage = newTabPage("Untitled");
            havePath.Add(false);
            if (Properties.Settings.Default.theme == 1)
            {
                menuStrip1.BackColor = Color.BlueViolet;
                menuStrip1.ForeColor = Color.White;
                menuStrip1.Font = new Font("Arial", 9);
                this.BackColor = Color.MediumPurple;
                foreach (TabPage page in tabControl1.TabPages)
                {
                    page.Controls[0].BackColor = Color.Lavender;
                }
            }
            if (Properties.Settings.Default.combo != 7)
            {
                toolStripComboBox1.SelectedIndex = Properties.Settings.Default.combo;
            }
            Open();


        }

        /// <summary>
        /// Запуск таймера.
        /// </summary>
        public void InitTimer()
        {
            if (time != 0)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = time; //
                timer1.Start();
            }
        }

        /// <summary>
        /// Действие, выполняющееся по таймеру.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            for (var i = 0; i < tabControl1.TabPages.Count; i++)
            {
                RichTextBox richTextBox = (RichTextBox)tabControl1.TabPages[i].Controls[0];
                if (havePath[i])
                {
                    if (Path.GetExtension(tabControl1.TabPages[i].Name) == ".rtf")
                        richTextBox.SaveFile(tabControl1.TabPages[i].Name, RichTextBoxStreamType.RichText);
                    else
                        richTextBox.SaveFile(tabControl1.TabPages[i].Name, RichTextBoxStreamType.PlainText);
                    wasChanged[tabControl1.SelectedIndex] = false;
                    tabControl1.TabPages[i].Text = Path.GetFileName(tabControl1.TabPages[i].Name);
                }
            }
        }

        /// <summary>
        /// События при первичной загрузке формы.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработка процесса закрытия формы.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (var index = 0; index < wasChanged.Count; index++)
            {
                collection.Add(tabControl1.TabPages[index].Name);
                if (wasChanged[index])
                {
                    DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить файл " +
                        tabControl1.TabPages[index].Name + " ?", "Really " +
                        "important quesion, my dear User <3", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RichTextBox richTextBox = (RichTextBox)tabControl1.TabPages[index].Controls[0];
                        if (Path.GetExtension(tabControl1.TabPages[index].Name) == ".rtf")
                        {
                            richTextBox.SaveFile(tabControl1.TabPages[index].Name, RichTextBoxStreamType.RichText);
                        }
                        else if (Path.GetExtension(tabControl1.TabPages[index].Name) == ".txt")
                        {
                            richTextBox.SaveFile(tabControl1.TabPages[index].Name, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
            }
            Properties.Settings.Default.pages = collection;
            Properties.Settings.Default.Save();

        }

        /// <summary>
        /// Событие пункта меню.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Создание файла.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void FileCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var name = "Untitled";
            newTabPage(name);
            havePath.Add(false);
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        TabPage page = newTabPage(openFileDialog.FileName);
                        page.Text = Path.GetFileName(page.Name);
                        havePath.Add(true);
                        RichTextBox textBox = (RichTextBox)page.Controls[0];
                        if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                        {
                            textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                        }
                        else if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                        {
                            textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                        textBox.TextChanged += richTextBox1_TextChanged_1;
                        themeSetter();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Обработка нажатия на вкладку.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Реакция на изменения в тексте.
        /// </summary>
        /// <param name = "sender" > Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (wasChanged[tabControl1.SelectedIndex] == false)
            {
                tabControl1.SelectedTab.Text = tabControl1.SelectedTab.Text + " (Editing)";
                wasChanged[tabControl1.SelectedIndex] = true;

            }
        }

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (havePath[tabControl1.SelectedIndex])
                {
                    RichTextBox richTextBox = (RichTextBox)tabControl1.SelectedTab.Controls[0];
                    if (Path.GetExtension(tabControl1.SelectedTab.Name) == ".rtf")
                        richTextBox.SaveFile(tabControl1.SelectedTab.Name, RichTextBoxStreamType.RichText);
                    else
                        richTextBox.SaveFile(tabControl1.SelectedTab.Name, RichTextBoxStreamType.PlainText);
                    wasChanged[tabControl1.SelectedIndex] = false;
                    tabControl1.SelectedTab.Text = Path.GetFileName(tabControl1.SelectedTab.Name);
                }
                else
                {
                    SaveAs();
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Обработка сохранения файла как.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void SaveFileAsКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        /// <summary>
        /// Сохранить файл как.
        /// </summary>
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            RichTextBox richTextBox = (RichTextBox)tabControl1.SelectedTab.Controls[0];
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить форматирование?",
                    "Really important quesion, my dear User <3", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveFileDialog.FileName += ".rtf";
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    saveFileDialog.FileName += ".txt";
                    richTextBox.SaveFile(saveFileDialog.FileName + ".txt", RichTextBoxStreamType.PlainText);
                }
                tabControl1.SelectedTab.Name = saveFileDialog.FileName;
                tabControl1.SelectedTab.Text = Path.GetFileName(saveFileDialog.FileName);
                wasChanged[tabControl1.SelectedIndex] = false;
                havePath[tabControl1.SelectedIndex] = true;
            }
        }

        /// <summary>
        /// Выделение текста курсивом.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tabPage = tabControl1.SelectedTab;
            var richTextBox1 = (RichTextBox)tabPage.Controls[0];
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle ^ currentFont.Style
                );
            }
        }

        /// <summary>
        /// Выделение жирным.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            RichTextBox richTextBox1 = (RichTextBox)tabPage.Controls[0];
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle ^ currentFont.Style
                );
            }
        }

        /// <summary>
        /// Выделение подчеркиванием.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void подчеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            RichTextBox richTextBox1 = (RichTextBox)tabPage.Controls[0];
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle ^ currentFont.Style
                );
            }

        }

        /// <summary>
        /// Выделение зачеркиванием.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void зачеркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            RichTextBox richTextBox1 = (RichTextBox)tabPage.Controls[0];
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = FontStyle.Strikeout;
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle ^ currentFont.Style
                );
            }
        }

        /// <summary>
        /// Обработка изенений в комбобоксе.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (time != 0) timer1.Stop();
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                time = 60000;
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                time = 300000;
            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                time = 1800000;
            }
            else if (toolStripComboBox1.SelectedIndex == 3)
            {
                time = 3600000;
            }
            else if (toolStripComboBox1.SelectedIndex == 4)
            {
                time = 0;
            }
            Properties.Settings.Default.combo = toolStripComboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
            InitTimer();
        }

        /// <summary>
        /// Создание файла в новом окне.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void создатьВНовомОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }


        /// <summary>
        /// Сохранение всех файлов.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void СохранитьВсеtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < havePath.Count; index++)
            {
                try
                {
                    if (havePath[index])
                    {
                        RichTextBox richTextBox = (RichTextBox)tabControl1.TabPages[index].Controls[0];
                        if (Path.GetExtension(tabControl1.TabPages[index].Name) == ".rtf")
                            richTextBox.SaveFile(tabControl1.TabPages[index].Name, RichTextBoxStreamType.RichText);
                        else
                            richTextBox.SaveFile(tabControl1.TabPages[index].Name, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        RichTextBox richTextBox = (RichTextBox)tabControl1.TabPages[index].Controls[0];
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialogResult = MessageBox.Show("Вы хотите " +
                                "сохранить форматирование?", "Really important quesion" +
                                ", my dear User <3", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                saveFileDialog.FileName += ".rtf";
                                richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                            }
                            else
                            {
                                saveFileDialog.FileName += ".txt";
                                richTextBox.SaveFile(saveFileDialog.FileName +
                                    ".txt", RichTextBoxStreamType.PlainText);
                            }
                            tabControl1.TabPages[index].Name = saveFileDialog.FileName;
                            tabControl1.TabPages[index].Text = Path.GetFileName(saveFileDialog.FileName);
                        }
                        wasChanged[index] = false;
                        havePath[index] = true;
                        tabControl1.TabPages[index].Text = Path.GetFileName(tabControl1.TabPages[index].Name);
                    }
                }
                catch
                {

                }
            }
        }

        /// <summary>
        /// Скопировать выбранное.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void CopySelectedMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox richTextBox1 = (RichTextBox)tabControl1.SelectedTab.Controls[0];
                Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Вставить из буфера обмена.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox richTextBox1 = (RichTextBox)tabControl1.SelectedTab.Controls[0];
                richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Rtf));
            }
            catch (Exception)
            {

            }
        }

    }
}
