
namespace Exercise_Log
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
            this.newExerciseTextBox = new System.Windows.Forms.TextBox();
            this.addExerciseButton = new System.Windows.Forms.Button();
            this.removeExerciseButton = new System.Windows.Forms.Button();
            this.saveWorkoutButton = new System.Windows.Forms.Button();
            this.workoutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workoutDateLabel = new System.Windows.Forms.Label();
            this.exercisesToRemoveListBox = new System.Windows.Forms.ComboBox();
            this.exercisesInputGrid = new System.Windows.Forms.DataGridView();
            this.exerciseNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set1RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set2RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set3RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set4RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set5RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set6RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set7RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set8RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set9RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set10RepsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesInputGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // newExerciseTextBox
            // 
            this.newExerciseTextBox.Location = new System.Drawing.Point(13, 418);
            this.newExerciseTextBox.Name = "newExerciseTextBox";
            this.newExerciseTextBox.Size = new System.Drawing.Size(100, 20);
            this.newExerciseTextBox.TabIndex = 1;
            this.newExerciseTextBox.TextChanged += new System.EventHandler(this.newExerciseTextBox_TextChanged);
            // 
            // addExerciseButton
            // 
            this.addExerciseButton.Enabled = false;
            this.addExerciseButton.Location = new System.Drawing.Point(120, 418);
            this.addExerciseButton.Name = "addExerciseButton";
            this.addExerciseButton.Size = new System.Drawing.Size(140, 20);
            this.addExerciseButton.TabIndex = 3;
            this.addExerciseButton.Text = "Add Exercise";
            this.addExerciseButton.UseVisualStyleBackColor = true;
            this.addExerciseButton.Click += new System.EventHandler(this.addExerciseButton_Click);
            // 
            // removeExerciseButton
            // 
            this.removeExerciseButton.Enabled = false;
            this.removeExerciseButton.Location = new System.Drawing.Point(120, 392);
            this.removeExerciseButton.Name = "removeExerciseButton";
            this.removeExerciseButton.Size = new System.Drawing.Size(140, 23);
            this.removeExerciseButton.TabIndex = 4;
            this.removeExerciseButton.Text = "Remove Exercise";
            this.removeExerciseButton.UseVisualStyleBackColor = true;
            this.removeExerciseButton.Click += new System.EventHandler(this.removeExerciseButton_Click);
            // 
            // saveWorkoutButton
            // 
            this.saveWorkoutButton.Enabled = false;
            this.saveWorkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveWorkoutButton.Location = new System.Drawing.Point(527, 394);
            this.saveWorkoutButton.Name = "saveWorkoutButton";
            this.saveWorkoutButton.Size = new System.Drawing.Size(260, 44);
            this.saveWorkoutButton.TabIndex = 5;
            this.saveWorkoutButton.Text = "Save Workout";
            this.saveWorkoutButton.UseVisualStyleBackColor = true;
            this.saveWorkoutButton.Click += new System.EventHandler(this.saveWorkoutButton_Click);
            // 
            // workoutDateTimePicker
            // 
            this.workoutDateTimePicker.Location = new System.Drawing.Point(267, 418);
            this.workoutDateTimePicker.Name = "workoutDateTimePicker";
            this.workoutDateTimePicker.Size = new System.Drawing.Size(254, 20);
            this.workoutDateTimePicker.TabIndex = 6;
            this.workoutDateTimePicker.Value = new System.DateTime(2021, 1, 20, 17, 39, 40, 0);
            // 
            // workoutDateLabel
            // 
            this.workoutDateLabel.AutoSize = true;
            this.workoutDateLabel.Location = new System.Drawing.Point(266, 399);
            this.workoutDateLabel.Name = "workoutDateLabel";
            this.workoutDateLabel.Size = new System.Drawing.Size(74, 13);
            this.workoutDateLabel.TabIndex = 7;
            this.workoutDateLabel.Text = "Workout Date";
            // 
            // exercisesToRemoveListBox
            // 
            this.exercisesToRemoveListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.exercisesToRemoveListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.exercisesToRemoveListBox.FormattingEnabled = true;
            this.exercisesToRemoveListBox.Location = new System.Drawing.Point(12, 394);
            this.exercisesToRemoveListBox.Name = "exercisesToRemoveListBox";
            this.exercisesToRemoveListBox.Size = new System.Drawing.Size(101, 21);
            this.exercisesToRemoveListBox.TabIndex = 9;
            this.exercisesToRemoveListBox.SelectedIndexChanged += new System.EventHandler(this.exercisesToRemoveListBox_SelectedIndexChanged);
            // 
            // exercisesInputGrid
            // 
            this.exercisesInputGrid.AllowUserToAddRows = false;
            this.exercisesInputGrid.AllowUserToDeleteRows = false;
            this.exercisesInputGrid.AllowUserToResizeColumns = false;
            this.exercisesInputGrid.AllowUserToResizeRows = false;
            this.exercisesInputGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.exercisesInputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exercisesInputGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exerciseNameColumn,
            this.set1RepsColumn,
            this.set2RepsColumn,
            this.set3RepsColumn,
            this.set4RepsColumn,
            this.set5RepsColumn,
            this.set6RepsColumn,
            this.set7RepsColumn,
            this.set8RepsColumn,
            this.set9RepsColumn,
            this.set10RepsColumn});
            this.exercisesInputGrid.Location = new System.Drawing.Point(12, 12);
            this.exercisesInputGrid.Name = "exercisesInputGrid";
            this.exercisesInputGrid.Size = new System.Drawing.Size(923, 376);
            this.exercisesInputGrid.TabIndex = 10;
            this.exercisesInputGrid.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.exercisesInputGrid_DefaultValuesNeeded);
            // 
            // exerciseNameColumn
            // 
            this.exerciseNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.exerciseNameColumn.HeaderText = "Exercise";
            this.exerciseNameColumn.Name = "exerciseNameColumn";
            this.exerciseNameColumn.ReadOnly = true;
            this.exerciseNameColumn.Width = 72;
            // 
            // set1RepsColumn
            // 
            this.set1RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set1RepsColumn.HeaderText = "Set 1 reps";
            this.set1RepsColumn.Name = "set1RepsColumn";
            this.set1RepsColumn.Width = 80;
            // 
            // set2RepsColumn
            // 
            this.set2RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set2RepsColumn.HeaderText = "Set 2 reps";
            this.set2RepsColumn.Name = "set2RepsColumn";
            this.set2RepsColumn.Width = 80;
            // 
            // set3RepsColumn
            // 
            this.set3RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set3RepsColumn.HeaderText = "Set 3 reps";
            this.set3RepsColumn.Name = "set3RepsColumn";
            this.set3RepsColumn.Width = 80;
            // 
            // set4RepsColumn
            // 
            this.set4RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set4RepsColumn.HeaderText = "Set 4 reps";
            this.set4RepsColumn.Name = "set4RepsColumn";
            this.set4RepsColumn.Width = 80;
            // 
            // set5RepsColumn
            // 
            this.set5RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set5RepsColumn.HeaderText = "Set 5 reps";
            this.set5RepsColumn.Name = "set5RepsColumn";
            this.set5RepsColumn.Width = 80;
            // 
            // set6RepsColumn
            // 
            this.set6RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set6RepsColumn.HeaderText = "Set 6 reps";
            this.set6RepsColumn.Name = "set6RepsColumn";
            this.set6RepsColumn.Width = 80;
            // 
            // set7RepsColumn
            // 
            this.set7RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set7RepsColumn.HeaderText = "Set 7 reps";
            this.set7RepsColumn.Name = "set7RepsColumn";
            this.set7RepsColumn.Width = 80;
            // 
            // set8RepsColumn
            // 
            this.set8RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set8RepsColumn.HeaderText = "Set 8 reps";
            this.set8RepsColumn.Name = "set8RepsColumn";
            this.set8RepsColumn.Width = 80;
            // 
            // set9RepsColumn
            // 
            this.set9RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set9RepsColumn.HeaderText = "Set 9 reps";
            this.set9RepsColumn.Name = "set9RepsColumn";
            this.set9RepsColumn.Width = 80;
            // 
            // set10RepsColumn
            // 
            this.set10RepsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.set10RepsColumn.HeaderText = "Set 10 reps";
            this.set10RepsColumn.Name = "set10RepsColumn";
            this.set10RepsColumn.Width = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.exercisesInputGrid);
            this.Controls.Add(this.exercisesToRemoveListBox);
            this.Controls.Add(this.workoutDateLabel);
            this.Controls.Add(this.workoutDateTimePicker);
            this.Controls.Add(this.saveWorkoutButton);
            this.Controls.Add(this.removeExerciseButton);
            this.Controls.Add(this.addExerciseButton);
            this.Controls.Add(this.newExerciseTextBox);
            this.Name = "Form1";
            this.Text = "Exercise Logger";
            ((System.ComponentModel.ISupportInitialize)(this.exercisesInputGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newExerciseTextBox;
        private System.Windows.Forms.Button addExerciseButton;
        private System.Windows.Forms.Button removeExerciseButton;
        private System.Windows.Forms.Button saveWorkoutButton;
        private System.Windows.Forms.DateTimePicker workoutDateTimePicker;
        private System.Windows.Forms.Label workoutDateLabel;
        private System.Windows.Forms.ComboBox exercisesToRemoveListBox;
        private System.Windows.Forms.DataGridView exercisesInputGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn exerciseNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set1RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set2RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set3RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set4RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set5RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set6RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set7RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set8RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set9RepsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn set10RepsColumn;
    }
}

