using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApplication.View
{
    public partial class GraphUserControl : UserControl
    {
        public GraphUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
    }
}
