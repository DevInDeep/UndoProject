using UndoProject.Common;

namespace UndoProject.Undo
{
    internal class TrackBarValueChangedCommand : ICommand
    {
        private readonly int value = 0;
        private readonly UndoableTrackBar trackBar;
        public TrackBarValueChangedCommand(UndoableTrackBar trackBar, int value)
        {
            this.trackBar = trackBar;
            this.value = value;
        }
        public void Execute()
        {
            trackBar.DisableUndo();
            trackBar.Value = value;
            trackBar.EnableUndo();
        }

        public Optional<ICommand> Undo() => Optional<ICommand>.Create(new TrackBarValueChangedCommand(trackBar, value));
    }
}
