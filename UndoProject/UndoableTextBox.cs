using System;
using UndoProject.Undo;
using System.Windows.Forms;

namespace UndoProject
{
    public class UndoableTextBox : TextBox
    {
        private Action textChanged;
        public void EnableUndo() => textChanged = () => Command.Add(new TextChangeCommand(this, Text));
        public void DisableUndo() => textChanged = () => { };
        public CommandController Command { get; private set; } = new CommandController();
        public UndoableTextBox()
        {
            Command.Add(new EmptyStringCommand(this));
            TextChanged += UndoableTextBox_TextChanged;
            EnableUndo();
        }
        private void UndoableTextBox_TextChanged(object sender, EventArgs e) => textChanged?.Invoke();
    }
}
