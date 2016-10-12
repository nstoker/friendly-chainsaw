using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendlyChainsaw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if DEBUG
            buildMessage.Text = "DEBUG";
#elif QA
            buildMessage.Text="QA";
#else
            buildMessage.Text="RELEASE";
#endif
        }
    }
}
