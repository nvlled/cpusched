using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpusched
{
    public partial class celltooltip : Form
    {
        BufferedGraphics grafx;
        BindingList<Process> processList;
        List<Scheduler.Algorithm> algos = new List<Scheduler.Algorithm>();

        public celltooltip()
        {
            InitializeComponent();

            processList = new BindingList<Process>();
            processList.Add(new Process { Name = "p1", Arrival = 0, Burst = 5 });
            processList.Add(new Process { Name = "p2", Arrival = 2, Burst = 2 });
            processList.Add(new Process { Name = "p3", Arrival = 0, Burst = 7 });
            processList.Add(new Process { Name = "p4", Arrival = 0, Burst = 2 });
            processList.Add(new Process { Name = "p5", Arrival = 3, Burst = 9 });
            gridPs.DataSource = processList;


            DoubleBuffered = true;
            setupGraphics();

            var timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 64;
            timer.Start();
        }

        void setupGraphics()
        {
            var w = panelGantt.Width;
            var h = panelGantt.Height;
            try
            {
                grafx = BufferedGraphicsManager.Current
                    .Allocate(panelGantt.CreateGraphics(), new Rectangle(0, 0, w, h));
            }
            catch (Win32Exception huh)
            {
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var g = grafx.Graphics;
            g.Clear(Color.DarkGray);

            int h = drawGantts(g);
            if (h != panelGantt.Height)
            {
                panelGantt.Height = h;
            }
            grafx.Render();
        }

        private int drawGantts(Graphics g)
        {
            var ps = processList.ToList();
            var margin = 30;
            var offset = 0;
            foreach (var algo in algos)
            {
                var name = Scheduler.Names[algo];
                var sched = algo(ps);
                int h = drawGantt(g, name, sched, offset);
                offset = h + margin;
            }
            return offset;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private int drawGantt(Graphics g, string name, Sched sched, int yOffset = 0)
        {
            var pwidth = panelGantt.Width;
            var pheight = panelGantt.Height;

            var total = sched.Aggregate(0, (t, pair) => t + pair.Item1);
            total = total == 0 ? 1 : total;

            var x = 0;
            var totalLen = 0;
            var titleRect = new Rectangle(0, yOffset, pwidth, 20);
            drawStringRect(g, titleRect, name);

            var digitRect = new Rectangle(0, 0, 0, 0);
            foreach (var tup in sched)
            {
                var len = tup.Item1;
                var proc = tup.Item2;
                var w = (int) (((float)len/total)*pwidth * 0.99);

                var rect = new Rectangle(x, titleRect.Bottom, w, 100);
                digitRect = new Rectangle(rect.Right-35, rect.Bottom, 50, 20);

                g.FillRectangle(Brushes.DarkCyan, rect);
                g.DrawRectangle(Pens.Black, rect);

                drawStringRect(g, rect, proc.Name);
                drawStringRect(g, digitRect, len+totalLen + "");

                x += w;
                totalLen += len;
            }
            return digitRect.Bottom;
        }

        private void drawStringRect(Graphics g, Rectangle rect, string s, StringAlignment align = StringAlignment.Center)
        {
            var strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(s, SystemFonts.CaptionFont, Brushes.Red, rect, strFormat);
        }

        private void runScheduler(object sender, EventArgs e)
        {
            algos = new List<Scheduler.Algorithm>();
            if (chkFCFS.Checked)
                algos.Add(Scheduler.FirstComeFirstServe);
            if (chkSJF.Checked)
                algos.Add(Scheduler.ShortestJobFirst);
            if (chkRR.Checked)
                algos.Add(Scheduler.RoundRobin);
        }

        private void gridPs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var cell = gridPs.Rows[e.RowIndex].Cells[e.ColumnIndex];
            toolTip2.Show("enter a valid value", wah, 2000);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
        }

        private void panelGantt_Resize(object sender, EventArgs e)
        {
            setupGraphics();
        }

        private void gridPs_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void celltooltip_Load(object sender, EventArgs e)
        {

        }
    }
}