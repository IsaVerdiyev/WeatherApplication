using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApplication.View
{
    public partial class WeatherAppForm : Form
    {
        public WeatherAppForm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new MainInfoView());
        }
    }
}
