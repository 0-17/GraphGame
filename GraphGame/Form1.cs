namespace GraphGame;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        InitializeBitmapAndGraphics();
        PlotData();
    }
    private Bitmap bmp;
    private Graphics gfx;

    private void InitializeBitmapAndGraphics()
    {
        bmp = new Bitmap(pictureBox.Width, pictureBox.Height); 
        gfx = Graphics.FromImage(bmp);
        gfx.Clear(Color.White);
        gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        pictureBox.Image = bmp;
    }
    private double[] axisLimits = new double[] { -25, 25, -15, 15 };
    public Point PixelfromLoc(double x, double y)
    {
        double pxPerUnitX = bmp.Width / (axisLimits[1] - axisLimits[0]);
        double pxPerUnitY = bmp.Height / (axisLimits[3] - axisLimits[2]);
        int xPx = (int)((x - axisLimits[0]) * pxPerUnitX);
        int yPx = bmp.Height - (int)((y - axisLimits[2] * pxPerUnitY));
        return new Point(xPx, yPx);
    }

    private double[] xs;
    private double[] ys;
    private void CreateData()
    {
        //put stuff here
    }

    private void PlotData()
    {
        Point origin = PixelfromLoc(0, 0);
        gfx.DrawLine(Pens.LightGray, 0, origin.Y, bmp.Width, origin.Y);
        gfx.DrawLine(Pens.LightGray, origin.X, 0, origin.X, bmp.Height);

        Point[] points = new Point[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            points[i] = PixelfromLoc(xs[i], ys[i]);
        }
        gfx.DrawLines(Pens.Black, points);
        pictureBox.Image = bmp;
        
    }
}