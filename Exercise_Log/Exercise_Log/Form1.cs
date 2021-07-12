using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Log
{
    public partial class Form1 : Form
    {
        string loggingDirectory = @"D:\c#\Exercise log\Logs";
        string objectSerialisationDirectory = @"D:\c#\Exercise log\Objects\workout.txt";
        List<string> workout = new List<string>();

        public Form1()
        {
            InitializeComponent();
            workoutDateTimePicker.Value = DateTime.Now;
            workout = File.ReadAllLines(objectSerialisationDirectory).ToList();
            foreach (var exercise in workout)
                AddExerciseToWorkout(exercise);
            checkCanSaveWorkout();
        }

        private void checkCanSaveWorkout()
        {
            if (workout.Count > 0)
                saveWorkoutButton.Enabled = true;
            else
                saveWorkoutButton.Enabled = false;
        }

        private void newExerciseTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newExerciseTextBox.Text))
                addExerciseButton.Enabled = true;
        }

        private void exercisesToRemoveListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(exercisesToRemoveListBox.SelectedItem.ToString()))
                removeExerciseButton.Enabled = true;
        }

        private void addExerciseButton_Click(object sender, EventArgs e)
        {
            string newExerciseName = (newExerciseTextBox.Text.ToLower()).Trim();
            if (!workout.Contains(newExerciseName))
            {
                workout.Add(newExerciseName);
                AddExerciseToWorkout(newExerciseName);
            }
            else
                MessageBox.Show(String.Format("You already have {0} in your workout...", newExerciseName));
            newExerciseTextBox.Text = "";
            addExerciseButton.Enabled = false;
            checkCanSaveWorkout();
        }
        private void removeExerciseButton_Click(object sender, EventArgs e)
        {
            string exerciseToRemove = exercisesToRemoveListBox.Text;
            workout.Remove(exerciseToRemove);
            for (int i = 0; i < exercisesInputGrid.RowCount; i++)
            {
                if (exercisesInputGrid.Rows[i].Cells[0].Value.ToString() == exerciseToRemove)
                    exercisesInputGrid.Rows.Remove(exercisesInputGrid.Rows[i]);
            }
            exercisesToRemoveListBox.Items.Remove(exerciseToRemove);
            removeExerciseButton.Enabled = false;
            checkCanSaveWorkout();
        }

        private void saveWorkoutButton_Click(object sender, EventArgs e)
        {
            string newFileName = workoutDateTimePicker.Value.ToString("D");
            SaveFileDialog dialog = new SaveFileDialog() { InitialDirectory = loggingDirectory, Title = "Save Workout", DefaultExt = "txt", Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*", FileName = newFileName };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<string> linesToWrite = new List<string>();
                for (int i = 0; i < exercisesInputGrid.RowCount; i++)
                {
                    string newLine = MakeRowContentsIntoString(i);
                    linesToWrite.Add(newLine);
                }
                File.WriteAllLines(Path.GetFullPath(dialog.FileName), linesToWrite);
                File.WriteAllLines(objectSerialisationDirectory, workout);
            }
        }

        private string MakeRowContentsIntoString(int rowIndex)
        {
            string newLine = "";
            for (int j = 0; j < exercisesInputGrid.ColumnCount; j++)
            {
                if (j == 0)
                    newLine += $"{exercisesInputGrid.Columns[j].HeaderText}: ";
                newLine += $"{exercisesInputGrid.Rows[rowIndex].Cells[j].Value} ";
                if (j == 0)
                    newLine += " Reps - ";
                if (j < exercisesInputGrid.ColumnCount - 1 && j > 0)
                    newLine += " + ";
            }

            return newLine;
        }

        /*
private void AddControlsToNewRow(string newExerciseName)
{
   for (int i = 0; i < exercisesInputGrid.ColumnCount; i++)
   {
       if (i == 0)
           exerciseListPanels.Controls.Add(new Label { Name = newExerciseName + "Label", Text = newExerciseName }, i, exerciseListPanels.RowCount);
       else
           exerciseListPanels.Controls.Add(new NumericUpDown { Name = newExerciseName + "Set" + i.ToString() + "NumericUpDown", AutoSize = true }, i, exerciseListPanels.RowCount);
   }
   exercisesToRemoveListBox.Items.Add(newExerciseName);
}
*/
        private void AddExerciseToWorkout(string exerciseName)
        {
            int newRow = exercisesInputGrid.Rows.Add();
            exercisesInputGrid.Rows[newRow].Cells[0].Value = exerciseName;
            exercisesToRemoveListBox.Items.Add(exerciseName);
            for (int i = 1; i < exercisesInputGrid.ColumnCount; i++)
            {
                DataGridViewCell newCell = exercisesInputGrid.Rows[newRow].Cells[i];
                if (newCell.Value == null)
                    newCell.Value = 0;
            }
        }

        private void exercisesInputGrid_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
