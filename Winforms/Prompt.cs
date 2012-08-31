using System.Windows.Forms;

 public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            var prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 100;
            prompt.Text = caption;
            var textLabel = new Label() { Left = 50, Top = 20, Text = text };
            var textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            var confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => prompt.Close();
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();
            return textBox.Text;
        }
    }