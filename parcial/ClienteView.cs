using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parcial
{
    class ClienteView : UserControl
    {
        public ClienteView() {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClienteView
            // 
            this.Name = "ClienteView";
            this.Size = new System.Drawing.Size(643, 446);
            this.ResumeLayout(false);

        }
    }
}
