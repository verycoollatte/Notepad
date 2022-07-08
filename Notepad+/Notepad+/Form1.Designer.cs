
namespace Notepad_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAsКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВНовомОкнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчеркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зачеркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранятьРазВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбратьВесьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCreateToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.SaveFileAsКакToolStripMenuItem,
            this.создатьВНовомОкнеToolStripMenuItem,
            this.toolStripMenuItem1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // FileCreateToolStripMenuItem
            // 
            this.FileCreateToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.FileCreateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.FileCreateToolStripMenuItem.Name = "FileCreateToolStripMenuItem";
            this.FileCreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileCreateToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.FileCreateToolStripMenuItem.Text = "Создать";
            this.FileCreateToolStripMenuItem.Click += new System.EventHandler(this.FileCreateToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.OpenFileToolStripMenuItem.Text = "Открыть";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // SaveFileAsКакToolStripMenuItem
            // 
            this.SaveFileAsКакToolStripMenuItem.BackColor = System.Drawing.Color.Purple;
            this.SaveFileAsКакToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveFileAsКакToolStripMenuItem.Name = "SaveFileAsКакToolStripMenuItem";
            this.SaveFileAsКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.SaveFileAsКакToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.SaveFileAsКакToolStripMenuItem.Text = "Сохранить как";
            this.SaveFileAsКакToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsКакToolStripMenuItem_Click);
            // 
            // создатьВНовомОкнеToolStripMenuItem
            // 
            this.создатьВНовомОкнеToolStripMenuItem.Name = "создатьВНовомОкнеToolStripMenuItem";
            this.создатьВНовомОкнеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.создатьВНовомОкнеToolStripMenuItem.Size = new System.Drawing.Size(365, 34);
            this.создатьВНовомОкнеToolStripMenuItem.Text = "Создать в новом окне";
            this.создатьВНовомОкнеToolStripMenuItem.Click += new System.EventHandler(this.создатьВНовомОкнеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(365, 34);
            this.toolStripMenuItem1.Text = "Сохранить все";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.СохранитьВсеtoolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсивToolStripMenuItem,
            this.жирныйToolStripMenuItem,
            this.подчеркнутыйToolStripMenuItem,
            this.зачеркнутыйToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // курсивToolStripMenuItem
            // 
            this.курсивToolStripMenuItem.Name = "курсивToolStripMenuItem";
            this.курсивToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.курсивToolStripMenuItem.Text = "Курсив";
            this.курсивToolStripMenuItem.Click += new System.EventHandler(this.курсивToolStripMenuItem_Click);
            // 
            // жирныйToolStripMenuItem
            // 
            this.жирныйToolStripMenuItem.Name = "жирныйToolStripMenuItem";
            this.жирныйToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.жирныйToolStripMenuItem.Text = "Жирный";
            this.жирныйToolStripMenuItem.Click += new System.EventHandler(this.жирныйToolStripMenuItem_Click);
            // 
            // подчеркнутыйToolStripMenuItem
            // 
            this.подчеркнутыйToolStripMenuItem.Name = "подчеркнутыйToolStripMenuItem";
            this.подчеркнутыйToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.подчеркнутыйToolStripMenuItem.Text = "Подчеркнутый";
            this.подчеркнутыйToolStripMenuItem.Click += new System.EventHandler(this.подчеркнутыйToolStripMenuItem_Click);
            // 
            // зачеркнутыйToolStripMenuItem
            // 
            this.зачеркнутыйToolStripMenuItem.Name = "зачеркнутыйToolStripMenuItem";
            this.зачеркнутыйToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.зачеркнутыйToolStripMenuItem.Text = "Зачеркнутый";
            this.зачеркнутыйToolStripMenuItem.Click += new System.EventHandler(this.зачеркнутыйToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeThemeToolStripMenuItem,
            this.сохранятьРазВToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // ChangeThemeToolStripMenuItem
            // 
            this.ChangeThemeToolStripMenuItem.Name = "ChangeThemeToolStripMenuItem";
            this.ChangeThemeToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.ChangeThemeToolStripMenuItem.Text = "Другая тема";
            this.ChangeThemeToolStripMenuItem.Click += new System.EventHandler(this.другаяТемаToolStripMenuItem_Click);
            // 
            // сохранятьРазВToolStripMenuItem
            // 
            this.сохранятьРазВToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.сохранятьРазВToolStripMenuItem.Name = "сохранятьРазВToolStripMenuItem";
            this.сохранятьРазВToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.сохранятьРазВToolStripMenuItem.Text = "Сохранять раз в...";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "60 cекунд",
            "5 минут",
            "30 минут",
            "1 час",
            "никогда"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 417);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(786, 373);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьВесьТекстToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 36);
            // 
            // выбратьВесьТекстToolStripMenuItem
            // 
            this.выбратьВесьТекстToolStripMenuItem.Name = "выбратьВесьТекстToolStripMenuItem";
            this.выбратьВесьТекстToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.выбратьВесьТекстToolStripMenuItem.Text = "Выбрать весь текст";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAsКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeThemeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem курсивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчеркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зачеркнутыйToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьВесьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранятьРазВToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem создатьВНовомОкнеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
    }
}

