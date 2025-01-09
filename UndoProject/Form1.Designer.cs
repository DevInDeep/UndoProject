namespace UndoProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtText = new UndoProject.UndoableTextBox();
            this.undoableTrackBar = new UndoProject.UndoableTrackBar();
            this.btnUndoTrackBar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.undoableTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(603, 24);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(200, 55);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(32, 29);
            this.txtText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(548, 38);
            this.txtText.TabIndex = 0;
            // 
            // undoableTrackBar
            // 
            this.undoableTrackBar.Location = new System.Drawing.Point(32, 104);
            this.undoableTrackBar.Maximum = 100;
            this.undoableTrackBar.Name = "undoableTrackBar";
            this.undoableTrackBar.Size = new System.Drawing.Size(548, 114);
            this.undoableTrackBar.TabIndex = 2;
            // 
            // btnUndoTrackBar
            // 
            this.btnUndoTrackBar.Location = new System.Drawing.Point(603, 104);
            this.btnUndoTrackBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUndoTrackBar.Name = "btnUndoTrackBar";
            this.btnUndoTrackBar.Size = new System.Drawing.Size(200, 55);
            this.btnUndoTrackBar.TabIndex = 3;
            this.btnUndoTrackBar.Text = "Undo";
            this.btnUndoTrackBar.UseVisualStyleBackColor = true;
            this.btnUndoTrackBar.Click += new System.EventHandler(this.btnUndoTrackBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 217);
            this.Controls.Add(this.btnUndoTrackBar);
            this.Controls.Add(this.undoableTrackBar);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtText);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undoable TextBox";
            ((System.ComponentModel.ISupportInitialize)(this.undoableTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UndoableTextBox txtText;
        private System.Windows.Forms.Button btnUndo;
        private UndoableTrackBar undoableTrackBar;
        private System.Windows.Forms.Button btnUndoTrackBar;
    }
}

