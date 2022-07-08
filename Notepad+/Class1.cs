using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_
{
    /// <summary>
    /// Класс основного окна.
    /// </summary>
    public partial class Form1
    {
        /// <summary>
        /// Устанавливает стиль вкладок.
        /// </summary>
        public void themeSetter()
        {
            if (theme == 1)
            {
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.Controls[0].BackColor = Color.Lavender;
                }
            }
        }
        
        /// <summary>
        /// Создание кнопок контекстного меню.
        /// </summary>
        /// <returns> Контекстное меню. </returns>
        private ContextMenuStrip ContextMenu()
        {
            // Создание кнопки выбора всего текста, добавление в меню.
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem SelectAllMenuItem = new ToolStripMenuItem("Выбрать все");
            contextMenuStrip.Items.Add(SelectAllMenuItem);
            SelectAllMenuItem.Click += SelectAllMenuItem_Click;
            // Создание кнопки вырезать, добавление в меню.
            ToolStripMenuItem CutSelectedMenuItem = new ToolStripMenuItem("Вырезать");
            contextMenuStrip.Items.Add(CutSelectedMenuItem);
            CutSelectedMenuItem.Click += CutSelectedMenuItem_Click;
            // Создание кнопки копировать, добавление в меню.
            ToolStripMenuItem CopySelectedMenuItem = new ToolStripMenuItem("Копировать");
            contextMenuStrip.Items.Add(CopySelectedMenuItem);
            CopySelectedMenuItem.Click += CopySelectedMenuItem_Click;
            // Создание кнопки вставить, добавление в меню.
            ToolStripMenuItem PasteMenuItem = new ToolStripMenuItem("Вставить");
            contextMenuStrip.Items.Add(PasteMenuItem);
            PasteMenuItem.Click += PasteMenuItem_Click;
            // Создание стилей для выбранного текста.
            ToolStripMenuItem cursiveMenuItem = new ToolStripMenuItem("Курсив");
            cursiveMenuItem.Click += курсивToolStripMenuItem_Click;
            ToolStripMenuItem boldMenuItem = new ToolStripMenuItem("Жирный");
            boldMenuItem.Click += жирныйToolStripMenuItem_Click;
            ToolStripMenuItem UnderlinedMenuItem = new ToolStripMenuItem("Подчеркнутый");
            UnderlinedMenuItem.Click += подчеркнутыйToolStripMenuItem_Click;
            ToolStripMenuItem strikeMenuItem = new ToolStripMenuItem("Зачеркнутый");
            strikeMenuItem.Click += зачеркнутыйToolStripMenuItem_Click;
            ToolStripMenuItem formatMenuItem = new ToolStripMenuItem("Формат");
            contextMenuStrip.Items.Add(formatMenuItem);
            // Объединение стилей в выпадающее под-меню.
            formatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cursiveMenuItem, 
                boldMenuItem, UnderlinedMenuItem, strikeMenuItem });
            return contextMenuStrip;
        }

        /// <summary>
        /// Выбрать весь текст.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox richTextBox1 = (RichTextBox)tabControl1.SelectedTab.Controls[0];
                richTextBox1.SelectAll();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Вырезать выбранное.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void CutSelectedMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox richTextBox1 = (RichTextBox)tabControl1.SelectedTab.Controls[0];
                Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
                richTextBox1.SelectedRtf = "";
            }
            catch (Exception)
            {

            }
        }


        /// <summary>
        /// Создание новой вкладки.
        /// </summary>
        /// <param name="name"> Название вкладки. </param>
        /// <returns> Вкладка. </returns>
        private TabPage newTabPage(string name)
        {
            var count = 0;
            string nameNew = name;
            while (this.tabControl1.Controls.ContainsKey(nameNew))
            {
                count++;
                nameNew = name + " (" + count + ")";
            }
            TabPage myTabPage = new TabPage(nameNew);
            myTabPage.Name = nameNew;
            this.tabControl1.Controls.Add(myTabPage);
            RichTextBox textBox = new RichTextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            textBox.BackColor = SystemColors.Control;
            textBox.TextChanged += richTextBox1_TextChanged_1;
            myTabPage.Controls.Add(textBox);
            textBox.ContextMenuStrip = ContextMenu();
            this.tabControl1.SelectedTab = myTabPage;
            themeSetter();
            wasChanged.Add(false);
            return myTabPage;
        }

        /// <summary>
        /// Смена темы.
        /// </summary>
        /// <param name="sender"> Ссылка на элемент управления. </param>
        /// <param name="e"> Данные о событии. </param>
        private void другаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theme == 0)
            {
                menuStrip1.BackColor = Color.BlueViolet;
                menuStrip1.ForeColor = Color.White;
                menuStrip1.Font = new Font("Arial", 9);
                this.BackColor = Color.MediumPurple;
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.Controls[0].BackColor = Color.Lavender;
                }
                Properties.Settings.Default.theme = 1;
                Properties.Settings.Default.Save();
                theme = 1;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                menuStrip1.BackColor = SystemColors.Control;
                menuStrip1.ForeColor = Color.Black;
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.Controls[0].BackColor = SystemColors.Control;
                }
                menuStrip1.Font = SystemFonts.DefaultFont;
                Properties.Settings.Default.theme = 0;
                Properties.Settings.Default.Save();
                theme = 0;
            }

        }


        /// <summary>
        /// Открытие вкладок, что были открыты раньше.
        /// </summary>
        private void Open()
        {
            if (Properties.Settings.Default.pages == null)
                Properties.Settings.Default.pages = new System.Collections.Specialized.StringCollection();
            foreach (string page in Properties.Settings.Default.pages)
            {

                try
                {
                    TabPage pageNew = newTabPage(page);
                    pageNew.Text = Path.GetFileName(page);
                    havePath.Add(true);
                    RichTextBox textBox = (RichTextBox)pageNew.Controls[0];
                    if (Path.GetExtension(page) == ".rtf")
                    {
                        textBox.LoadFile(page, RichTextBoxStreamType.RichText);
                    }
                    else if (Path.GetExtension(page) == ".txt")
                    {
                        textBox.LoadFile(page, RichTextBoxStreamType.PlainText);
                    }
                    textBox.TextChanged += richTextBox1_TextChanged_1;
                    themeSetter();

                }
                catch (Exception)
                {
                }

            }
        }
    }

}