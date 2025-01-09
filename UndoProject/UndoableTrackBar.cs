using System;
using UndoProject.Undo;
using System.Windows.Forms;

namespace UndoProject
{
    public class UndoableTrackBar : TrackBar
    {
        private Action valueChanged;
        public void EnableUndo() => valueChanged = () => Command.Add(new TrackBarValueChangedCommand(this, Value));
        public void DisableUndo() => valueChanged = () => { };
        public CommandController Command { get; private set; } = new CommandController();
        public UndoableTrackBar()
        {
            ValueChanged += UndoableTrackBar_ValueChanged;
            MouseCaptureChanged += UndoableTrackBar_MouseCaptureChanged;
            EnableUndo();
        }

        private void UndoableTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Command.Add(new TrackBarValueChangedCommand(this, Minimum));
            ValueChanged -= UndoableTrackBar_ValueChanged;
        }

        private void UndoableTrackBar_MouseCaptureChanged(object sender, EventArgs e) => valueChanged?.Invoke();
    }
}
