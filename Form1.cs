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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ExtractName(string s)
        {
            s = s.Substring(s.IndexOf("\"") + 1);
            s = s.Substring(0, s.IndexOf("\""));
            return s.Trim();
        }

        int GuessEpisode(string s, int season)
        {
            int i = s.IndexOf("s" + season.ToString().PadLeft(2, '0') + "e", StringComparison.InvariantCultureIgnoreCase);
            i = (i == -1 ? s.IndexOf(season + "x", StringComparison.InvariantCultureIgnoreCase) - 2 : i);
            if (i >= 0 && int.TryParse(s.Substring(i + 4, 2), out i)) return i;
            return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var series = "Project Runway";
            var season = 13;

            var folder = @"E:\Collections\TV\" + series + @"\" + series + " Season " + season;
            var prefix = series + " " + season + ".";
            var correct = File.ReadAllLines(@"C:\Users\Hani\Desktop\s1.txt").Where((q, i) => i % 3 == 1).Select(q => new { Episode = int.Parse(q.Substring(0, 2)), Name = ExtractName(q) }).ToDictionary(q => q.Episode, q => prefix + q.Episode.ToString().PadLeft(2, '0') + " " + q.Name);
            var oldnames = Directory.EnumerateFiles(folder).Select(q => new { Path = q, Episode = GuessEpisode(Path.GetFileNameWithoutExtension(q), season) }).Where(q => q.Episode > 0);
             
            //System.IO.File.WriteAllLines(@"C:\Users\Hani\Desktop\new_names.txt", correct.Values);
            MessageBox.Show(string.Join("\n", correct.Values));
            foreach (var f in oldnames.Where(q => correct.ContainsKey(q.Episode)))
            {
                File.Move(f.Path, Path.ChangeExtension(Path.Combine(folder, correct[f.Episode].Replace("\\", "").Replace(":", "-").Replace("?", "").Replace("/", "-") + ".xxx"), Path.GetExtension(f.Path)));
            }
        }
    }
}
