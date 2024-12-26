using System;
using System.Windows.Forms;

namespace UndoProject
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void btnUndo_Click(object sender, EventArgs e) => txtText.Command.Undo();
    }
}
