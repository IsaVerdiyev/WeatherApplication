using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApplication.View.SubViews
{
    public partial class DailyItemUserControl : UserControl
    {
        public event Action<DateTime> WasClicked;

        DateTime dateOfDay;

        public DateTime DateOfDay { get => dateOfDay; set => dateOfDay = value; }

        public DailyItemUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Transparent;
        }

        private void ItemMouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
           
        }

        private void ItemMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void ItemClick(object sender, EventArgs e)
        {
            WasClicked(DateOfDay);
        }
    }
}
