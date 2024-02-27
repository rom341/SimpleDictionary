using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDictionary
{
    public class PanelManager
    {
        public static FlowLayoutPanel getNewPanelForDictionary(int columnsCount)
        {
            FlowLayoutPanel mainPanel = new FlowLayoutPanel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.WrapContents = false; // Разрешить перенос элементов на следующую строку, если не хватает места

            for (int i = 0; i < columnsCount; i++)
            {
                Panel columnPanel = new Panel();
                columnPanel.Width = 200; // Ширина одной подпанели (можно задать по-умолчанию)
                columnPanel.BorderStyle = BorderStyle.FixedSingle; // Добавим рамку для видимости
                columnPanel.Margin = new Padding(5); // Добавим отступы между панелями

                RichTextBox richTextBox = new RichTextBox();
                richTextBox.Dock = DockStyle.Fill;
                richTextBox.BorderStyle = BorderStyle.None; // Убираем рамку у RichTextBox

                // Добавляем обработчик события для изменения размера при помощи мыши
                columnPanel.MouseDown += (sender, e) =>
                {
                    columnPanel.Capture = false;
                    Message m = Message.Create(columnPanel.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                    this.WndProc(ref m);
                };

                columnPanel.Controls.Add(richTextBox);
                mainPanel.Controls.Add(columnPanel);
            }

            return mainPanel;
        }

        // Для изменения размера контейнера при помощи мыши
        private void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HT_CAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HT_CAPTION)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.WndProc(ref m);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
    }
}
