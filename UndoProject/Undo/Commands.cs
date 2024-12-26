using UndoProject.Common;
using UndoProject.Extensions;
using System.Collections.Generic;

namespace UndoProject.Undo
{
    internal class Commands
    {
        private readonly Stack<ICommand> commands = new Stack<ICommand>();
        public void Push(ICommand command) => commands.Push(command);
        public Optional<ICommand> Pop() => commands.PopThenPeek();
    }
}
