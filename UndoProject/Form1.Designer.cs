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
            this.btnUndoTrackBar = new System.Windows.Forms.Button();
            this.trackBar = new UndoProject.UndoableTrackBar();
            this.txtText = new UndoProject.UndoableTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
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
            // btnUndoTrackBar
            // 
            this.btnUndoTrackBar.Location = new System.Drawing.Point(603, 146);
            this.btnUndoTrackBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUndoTrackBar.Name = "btnUndoTrackBar";
            this.btnUndoTrackBar.Size = new System.Drawing.Size(200, 55);
            this.btnUndoTrackBar.TabIndex = 3;
            this.btnUndoTrackBar.Text = "Undo";
            this.btnUndoTrackBar.UseVisualStyleBackColor = true;
            this.btnUndoTrackBar.Click += new System.EventHandler(this.btnUndoTrackBar_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(22, 146);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 5;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(548, 114);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 5;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(32, 29);
            this.txtText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(548, 38);
            this.txtText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 272);
            this.Controls.Add(this.btnUndoTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtText);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undo Application";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UndoableTextBox txtText;
        private System.Windows.Forms.Button btnUndo;
        private UndoableTrackBar trackBar;
        private System.Windows.Forms.Button btnUndoTrackBar;
    }
}

