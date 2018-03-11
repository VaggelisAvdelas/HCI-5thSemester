using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalExamination.ControlsWindows
{
    /// <summary>
    /// Interaction logic for OvenControls.xaml
    /// </summary>
    public partial class OvenControls : Window
    {
        public OvenControls()
        {
            InitializeComponent();
        }

        private void OvenControlPage_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
