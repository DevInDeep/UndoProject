using UndoProject.Common;

namespace UndoProject.Undo
{
    public class TextChangeCommand : ICommand
    {
        private readonly UndoableTextBox textBox;
        private readonly string text;
        public TextChangeCommand(UndoableTextBox textBox, string text)
        {
            this.textBox = textBox;
            this.text = text;
        }

        public void Execute()
        {
            textBox.DisableUndo();
            textBox.Text = text;
            textBox.EnableUndo();
        }

        public Optional<ICommand> Undo() => Optional<ICommand>.Create(new TextChangeCommand(textBox, text));
    }
}
