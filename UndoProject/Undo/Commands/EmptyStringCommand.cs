using UndoProject.Common;

namespace UndoProject.Undo
{
    internal class EmptyStringCommand : ICommand
    {
        private readonly UndoableTextBox undoableTextBox;
        public EmptyStringCommand(UndoableTextBox undoableTextBox) => this.undoableTextBox = undoableTextBox;

        public void Execute()
        {
            undoableTextBox.DisableUndo();
            undoableTextBox.Text = string.Empty;
            undoableTextBox.EnableUndo();
        }

        public Optional<ICommand> Undo() => Optional<ICommand>.Empty();
    }
}
