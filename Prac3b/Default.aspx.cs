using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    public partial class Pract3b: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "Vikas Pandey";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Label1.Text = "Your Selected Date:" + Calendar1.SelectedDate.ToString();
            Label2.Text = "Todays Date:" + Calendar1.TodaysDate.ToShortDateString();
            Label3.Text = "Ganpati Vacation Start: 09-13-2018";
            TimeSpan d = new DateTime(2018, 09, 13) - DateTime.Now;
            Label4.Text = "Days Remaining For Ganpati Vacation:" + d.Days.ToString();
            TimeSpan d1 = new DateTime(2018, 12, 31) - DateTime.Now;
            Label5.Text = "Days Remaining For New Year:" + d1.Days.ToString();
            if (Calendar1.SelectedDate.ToShortDateString() == "09-13-2018")
                Label3.Text = "<b>Ganpati Festival Start</b>";
            if (Calendar1.SelectedDate.ToShortDateString() == "09-23-2018")
                Label3.Text = "<b>Ganpati Festival End<b>";
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 15 && e.Day.Date.Month == 8)
            {
                e.Cell.BackColor = System.Drawing.Color.GreenYellow;
                var lbl1 = new System.Web.UI.WebControls.Label();
                lbl1.Text = "<br>Independance Day!<br>";
                e.Cell.Controls.Add(lbl1);
                Image g1 = new Image();
                g1.ImageUrl = "id.jpg";
                g1.Height = 40;
                g1.Width = 75;
                e.Cell.Controls.Add(g1);
            }
            if (e.Day.Date.Day == 5 && e.Day.Date.Month == 9)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                var lbl1 = new System.Web.UI.WebControls.Label();
                lbl1.Text = "<br>Teavhers Day!<br>";
                e.Cell.Controls.Add(lbl1);
                Image g1 = new Image();
                g1.ImageUrl = "td.jpg";
                g1.Height = 40;
                g1.Width = 75;
                e.Cell.Controls.Add(g1);
            }
            if (e.Day.Date.Day == 13 && e.Day.Date.Month == 9)
            {
                Calendar1.SelectedDate = new DateTime(2018, 09, 12);
                Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate,
                Calendar1.SelectedDate.AddDays(10));
                var lbl1 = new System.Web.UI.WebControls.Label();
                lbl1.Text = "<br>Ganpati!<br>";
                e.Cell.Controls.Add(lbl1);
                Image g2 = new Image();
                g2.ImageUrl = "gc.jpg";
                g2.Height = 40;
                g2.Width = 75;
                e.Cell.Controls.Add(g2);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Calendar1.SelectedDates.Clear();
        }
    }
