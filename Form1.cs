namespace WindowsFormsApp4;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        this.Text = "Дом";
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        // Определение размеров и положения дома
        int houseWidth = 250;
        int houseHeight = 150;
        int windowWidth = 40;
        int windowHeight = 60;
        int windowOffsetX = 40;
        int windowOffsetY = 40;
        int roofHeight = 80;

        // Рисование стен дома
        Pen greenPen = new Pen(Color.SaddleBrown, 4);
        g.DrawRectangle(greenPen, (this.Width - houseWidth) / 2, (this.Height - houseHeight) / 2, houseWidth,
            houseHeight);
        g.FillRectangle(Brushes.Teal, (this.Width - houseWidth) / 2, (this.Height - houseHeight) / 2, houseWidth,
            houseHeight);

        // Рисование окон с обводкой и перегородкой, а также зеленой сетки внутри окон
        using (Pen windowBorderPen = new Pen(Color.Black, 2))
        using (Pen gridPen = new Pen(Color.Green, 1))
        {
            // Рисуем первое окно
            int windowX1 = (this.Width - houseWidth) / 2 + windowOffsetX;
            int windowY = (this.Height - houseHeight) / 2 + windowOffsetY;

            // Рисуем белый фон первого окна
            g.FillRectangle(Brushes.White, windowX1, windowY, windowWidth, windowHeight);

            // Рисуем зеленую сетку внутри первого окна
            for (int x = windowX1 + 1; x < windowX1 + windowWidth; x += 5)
            {
                for (int y = windowY + 1; y < windowY + windowHeight; y += 5)
                {
                    g.DrawLine(gridPen, x, windowY, x, windowY + windowHeight);
                    g.DrawLine(gridPen, windowX1, y, windowX1 + windowWidth, y);
                }
            }

            // Рисуем перегородку в первом окне
            g.DrawLine(windowBorderPen, windowX1 + windowWidth / 2, windowY, windowX1 + windowWidth / 2,
                windowY + windowHeight);

            // Затем рисуем обводку первого окна
            g.DrawRectangle(windowBorderPen, windowX1, windowY, windowWidth, windowHeight);

            // Рисуем второе окно
            int windowX2 = (this.Width + houseWidth) / 2 - windowOffsetX - windowWidth;

            // Рисуем белый фон второго окна
            g.FillRectangle(Brushes.White, windowX2, windowY, windowWidth, windowHeight);

            for (int x = windowX2 + 1; x < windowX2 + windowWidth; x += 5)
            {
                for (int y = windowY + 1; y < windowY + windowHeight; y += 5)
                {
                    g.DrawLine(gridPen, x, windowY, x, windowY + windowHeight);
                    g.DrawLine(gridPen, windowX2, y, windowX2 + windowWidth, y);
                }
            }

            // Рисуем зеленую сетку внутри второго окна
            for (int x = windowX2 + 1; x < windowX2 + windowWidth; x += 5)
            {
                for (int y = windowY + 1; y < windowY + windowHeight; y += 5)
                {
                    g.DrawLine(gridPen, x, windowY, x, windowY + windowHeight);
                    g.DrawLine(gridPen, windowX2, y, windowX2 + windowWidth, y);
                }
            }

            // Рисуем перегородку во втором окне
            g.DrawLine(windowBorderPen, windowX2 + windowWidth / 2, windowY, windowX2 + windowWidth / 2,
                windowY + windowHeight);

            // Затем рисуем обводку второго окна
            g.DrawRectangle(windowBorderPen, windowX2, windowY, windowWidth, windowHeight);
        }


        // Рисование крыши
        Pen brownPen = new Pen(Color.SaddleBrown, 3);
        Point[] roofPoints =
        {
            new Point((this.Width - houseWidth + 5) / 2, (this.Height - houseHeight - 5) / 2),
            new Point((this.Width + houseWidth - 5) / 2, (this.Height - houseHeight - 5) / 2),
            new Point((this.Width) / 2, (this.Height - houseHeight) / 2 - roofHeight)
        };
        g.FillPolygon(Brushes.Silver, roofPoints);
        g.DrawPolygon(brownPen, roofPoints);

        // Рисование окна на крыше с обводкой
        int roofWindowSize = 40;
        int roofWindowX = (this.Width - roofWindowSize) / 2;
        int roofWindowY = (this.Height - houseHeight + 25) / 2 - roofHeight + 10;
        g.FillEllipse(Brushes.White, roofWindowX, roofWindowY, roofWindowSize, roofWindowSize);


        // Зеленая сетка внутри окна на крыше
        int gridSpacingRoof = 5; // расстояние между линиями сетки
        using (Pen gridPen = new Pen(Color.Green, 1))
        {
            for (int x = roofWindowX + gridSpacingRoof; x < roofWindowX + roofWindowSize; x += gridSpacingRoof)
            {
                for (int y = roofWindowY + gridSpacingRoof; y < roofWindowY + roofWindowSize; y += gridSpacingRoof)
                {
                    // Проверяем, что точка (x, y) находится внутри окружности
                    if ((x - (roofWindowX + roofWindowSize / 2)) * (x - (roofWindowX + roofWindowSize / 2)) +
                        (y - (roofWindowY + roofWindowSize / 2)) * (y - (roofWindowY + roofWindowSize / 2)) <=
                        (roofWindowSize / 2) * (roofWindowSize / 2))
                    {
                        g.DrawLine(gridPen, x, roofWindowY, x, roofWindowY + roofWindowSize);
                        g.DrawLine(gridPen, roofWindowX, y, roofWindowX + roofWindowSize, y);
                    }
                }
            }
        }

        using (Pen windowBorderPen = new Pen(Color.SaddleBrown, 3))
        {
            g.DrawEllipse(windowBorderPen, roofWindowX, roofWindowY, roofWindowSize, roofWindowSize);
        }

        // Добавление текста с номером 49
        string text = "№49";
        Font font = new Font("Arial", 15);
        SizeF textSize = g.MeasureString(text, font);
        PointF textLocation = new PointF((this.Width - houseWidth) / 2, (this.Height - houseHeight) / 2 + 5);
        g.DrawString(text, font, Brushes.Yellow, textLocation);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
        AboutForm aboutForm = new AboutForm();
        aboutForm.ShowDialog();
    }
}