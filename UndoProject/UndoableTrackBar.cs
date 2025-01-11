using System;
using UndoProject.Undo;
using System.Windows.Forms;

namespace UndoProject
{
    public class UndoableTrackBar : TrackBar
    {
        public CommandController Command { get; private set; } = new CommandController();
        public UndoableTrackBar()
        {
            ValueChanged += UndoableTrackBar_ValueChanged;
            MouseCaptureChanged += UndoableTrackBar_MouseCaptureChanged;
        }

        private void UndoableTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Command.Add(new TrackBarValueChangedCommand(this, Value));
            ValueChanged -= UndoableTrackBar_ValueChanged;
        }

        private void UndoableTrackBar_MouseCaptureChanged(object sender, EventArgs e) => Command.Add(new TrackBarValueChangedCommand(this, Value));
    }
}
