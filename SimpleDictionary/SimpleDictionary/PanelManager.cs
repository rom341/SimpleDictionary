using System;
using System.Drawing;
using System.Windows.Forms;

public class PanelManager
{
    private bool isResizing = false;
    private Point lastMousePosition;
    private Panel resizingPanel;

    public FlowLayoutPanel getNewPanelForDictionary(int columnsCount)
    {
        FlowLayoutPanel mainPanel = new FlowLayoutPanel();
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.WrapContents = false;

        for (int i = 0; i < columnsCount; i++)
        {
            Panel columnPanel = new Panel();
            columnPanel.Width = 200;
            columnPanel.BorderStyle = BorderStyle.FixedSingle;
            columnPanel.BackColor = Color.LightGray;
            columnPanel.Margin = new Padding(5);

            RichTextBox richTextBox = new RichTextBox();
            //richTextBox.Size = new Size(columnPanel.Width - 20, columnPanel.Height - 20);
            richTextBox.Dock = DockStyle.Top;
            richTextBox.Height = columnPanel.Height - 20;
            richTextBox.BorderStyle = BorderStyle.None;

            columnPanel.Controls.Add(richTextBox);
            mainPanel.Controls.Add(columnPanel);

            // Добавляем обработчики событий для изменения размера панели
            columnPanel.MouseDown += (sender, e) =>
            {
                isResizing = true;
                resizingPanel = (Panel)sender;
                lastMousePosition = e.Location;
            };

            columnPanel.MouseMove += (sender, e) =>
            {
                if (isResizing && resizingPanel != null)
                {
                    int deltaX = e.Location.X - lastMousePosition.X;
                    int newWidth = resizingPanel.Width + deltaX;
                    // Устанавливаем минимальную ширину на 50 пикселей
                    if (newWidth >= 50)
                    {
                        resizingPanel.Width = newWidth;
                        lastMousePosition = e.Location;
                    }
                    else
                    {
                        resizingPanel.Width = 50;
                        lastMousePosition.X = e.Location.X - (resizingPanel.Width - 50); // Сдвигаем lastMousePosition на правильное расстояние
                    }
                }
            };

            columnPanel.MouseUp += (sender, e) =>
            {
                isResizing = false;
                resizingPanel = null;
            };
        }

        return mainPanel;
    }
}