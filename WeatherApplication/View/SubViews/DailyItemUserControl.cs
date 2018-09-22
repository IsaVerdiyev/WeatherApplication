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
        public event Action<object, DateTime> WasClicked;

        DateTime dateOfDay;
        bool selected;

        public bool Selected {
            get => selected;
            set
            {
                selected = value;
                if (MouseIsOverItem())
                {
                    ItemMouseEnter(this, null);
                }
                else
                {
                    ItemMouseLeave(this, null);
                }
            }
        }

        public DateTime DateOfDay { get => dateOfDay; set => dateOfDay = value; }

        public DailyItemUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.Transparent;
        }

        private void ItemMouseEnter(object sender, EventArgs e)
        {
            if (selected)
            {
                this.BackColor = Color.FromArgb(127, 140, 141);
            }
            else
            {
                this.BackColor = Color.FromArgb(189, 195, 199);
            }

        }

        private void ItemMouseLeave(object sender, EventArgs e)
        {
            if (selected)
            {
                this.BackColor = Color.FromArgb(52, 152, 219);
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
        }

        public void ItemClick(object sender, EventArgs e)
        {
            WasClicked(this, DateOfDay);
        }


        bool MouseIsOverItem()
        {
            if(MousePosition.X >= this.Location.X && MousePosition.X <= this.Location.X + this.Width
                && MousePosition.Y >= this.Location.Y && MousePosition.Y <= this.Location.Y + this.Height)
            {
                return true;
            }
            return false;
        }
    }
}
