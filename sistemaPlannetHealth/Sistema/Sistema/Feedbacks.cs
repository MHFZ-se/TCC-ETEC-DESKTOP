using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Feedbacks : Form
    {
        public Feedbacks()
        {
            InitializeComponent();
            Feedback fdbc = new Feedback();
            fdbc.exibitFeedbacks(fpl_feedbacks);
        }
    }
}
