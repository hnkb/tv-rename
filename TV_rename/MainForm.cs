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

namespace TV_rename
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            f.SelectedPath = RootTextBox.Text;
            if (f.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                RootTextBox.Text = f.SelectedPath.Trim();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var series = SeriesTextBox.Text.Trim();
            var season = (int)SeasonNumeric.Value;

            var folder = Path.Combine(RootTextBox.Text, series, series + " " + (UsRadio.Checked ? "Season" : "Series") + " " + season);
            var prefix = series + " " + season + ".";

            if (!Directory.Exists(folder))
            {
                MessageBox.Show("Series directory '" + folder + "' does not exist!");
                return;
            }

            var correct = EpisodeNamesTextBox.Text
                .Replace("\r\n", "\n").Replace('\r', '\n').Split('\n')
                .Select((q, i) => new { Episode = i + 1, Name = q.Trim() })
                .ToDictionary(q => q.Episode, q => prefix + q.Episode.ToString().PadLeft(2, '0') + " " + q.Name);

            var oldnames = Directory.EnumerateFiles(folder)
                .Select(q => new { Path = q, Episode = GuessEpisode(Path.GetFileNameWithoutExtension(q), season) }).Where(q => q.Episode > 0);
            
            var renames = oldnames.Where(q => correct.ContainsKey(q.Episode))
                .Select(q => new {
                    Source = q.Path,
                    Destination = Path.ChangeExtension(Path.Combine(folder, correct[q.Episode].Replace("\\", "").Replace(":", "-").Replace("?", "").Replace("/", "-") + ".xxx"), Path.GetExtension(q.Path))
                });

            if (renames.Count() > 0)
            {
                if (MessageBox.Show(string.Join("\n", renames.Select(q => Path.GetFileNameWithoutExtension(q.Source) + " ==> " + Path.GetFileNameWithoutExtension(q.Destination))), renames.Count() + " files to rename", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    foreach (var f in renames) File.Move(f.Source, f.Destination);
            }
            else
            {
                MessageBox.Show("No files to rename!");
            }
        }
        
        int GuessEpisode(string s, int season)
        {
            int i = s.IndexOf("s" + season.ToString().PadLeft(2, '0') + "e", StringComparison.InvariantCultureIgnoreCase);
            i = (i == -1 ? s.IndexOf(season + "x", StringComparison.InvariantCultureIgnoreCase) - 2 : i);
            if (i >= 0 && int.TryParse(s.Substring(i + 4, 2), out i)) return i;
            return -1;
        }

        private void WikiButton_Click(object sender, EventArgs e)
        {
            try
            {
                var n = EpisodeNamesTextBox.Text
                    .Replace("\r\n", "\n").Replace('\r', '\n').Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(q => { var s = q.Split('\n'); return (s.Length > 1) ? s[1] : "-1 \"Unknown\""; })
                    .Select(q => new { Episode = int.Parse(q.Substring(0, 2)), Name = ExtractName(q) })
                    .Where(q => q.Episode != -1)
                    .ToDictionary(q => q.Episode, q => q.Name);

                EpisodeNamesTextBox.Text = string.Join("\r\n", Enumerable.Range(1, n.Keys.Max()).Select(q => (n.ContainsKey(q) ? n[q] : "")));
            }
            catch
            {
                MessageBox.Show("Cannot deduce episode names!");
            }
        }

        string ExtractName(string s)
        {
            s = s.Substring(s.IndexOf("\"") + 1);
            s = s.Substring(0, s.IndexOf("\""));
            return s.Trim();
        }
    }
}
