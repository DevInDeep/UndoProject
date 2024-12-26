using UndoProject.Common;

namespace UndoProject.Undo
{
    public interface ICommand
    {
        void Execute();
        Optional<ICommand> Undo();
    }
}
