namespace UndoProject.Undo
{
    public class CommandController
    {
        private readonly Commands commands = new Commands();
        internal void Add(ICommand command) => commands.Push(command);
        internal void Undo() => commands.Pop().Do(command => command.Execute());
    }
}
