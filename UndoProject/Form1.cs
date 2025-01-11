using System;
using System.Drawing;
using System.Windows.Forms;

namespace UndoProject
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void btnUndo_Click(object sender, EventArgs e) => txtText.Command.Undo();
        private void btnUndoTrackBar_Click(object sender, EventArgs e) => trackBar.Command.Undo();
        private void trackBar_ValueChanged(object sender, EventArgs e) => txtText.Font = new Font(txtText.Font.FontFamily.Name, trackBar.Value);
    }
}
