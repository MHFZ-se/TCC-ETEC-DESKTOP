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
    public partial class AtendimentoAoCliente : Form
    {
        public AtendimentoAoCliente()
        {
            InitializeComponent();
        }

        private void buttonPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonPanel3_Click(object sender, EventArgs e)
        {
            Hide();
            Chats proxima = new Chats();
            proxima.Show();
        }
    }
}
