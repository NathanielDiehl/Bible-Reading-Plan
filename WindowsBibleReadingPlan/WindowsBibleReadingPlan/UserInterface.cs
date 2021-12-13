using Newtonsoft.Json;
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

namespace WindowsBibleReadingPlan
{
    public partial class Form1 : Form
    {
        private Plan _currentPlan;
        private string _fileName;

        private int _timeline;
        private static string[] _months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        private string _version;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadPlan()
        {
            try
            {
                StreamReader r = new StreamReader(_fileName);
                string jsonString = r.ReadToEnd();
                _currentPlan = JsonConvert.DeserializeObject<Plan>(jsonString);
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdatePlan()
        {
            try
            {
                StreamWriter s = new StreamWriter(_fileName);
                string jsonText = System.Text.Json.JsonSerializer.Serialize<Plan>(_currentPlan);
                s.Write(jsonText);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ReadData()
        {
            try
            {
                //StreamReader r = new StreamReader(@"..\..\..\data.txt");
                StreamReader r = new StreamReader(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, @"..\data.txt"));

                _fileName = r.ReadLine();
                _version = r.ReadLine();
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateData()
        {
            try
            {
                //StreamWriter s = new StreamWriter( @"..\..\..\data.txt");
                StreamWriter s = new StreamWriter(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, @"..\data.txt"));

                s.WriteLine(_fileName);
                s.WriteLine(_version);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectPlan()
        {
            //uxOpenFileDialog.InitialDirectory = @"..\..\..\Plans\";
            uxOpenFileDialog.InitialDirectory = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, @"..\Plans\");
            
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fileName = uxOpenFileDialog.FileName;
                    UpdateData();
                    ReadPlan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void SetUp()
        {
            /*Plan newplan = new Plan();
            newplan.Day = 0;
            newplan.Extra = 0;
            newplan.Readings = new string[]{"Romans 1-3", "Romans 4-7", "Romans 8-10", "Romans 11-14", "Romans 15-16", "1 Corinthians 1-4", "1 Corinthians 5-9", "1 Corinthians 10-13", "1 Corinthians 14-16", "2 Corinthians 1-4", "2 Corinthians 5-9", "2 Corinthians 10-13", "Galatians 1-3", "Galatians 4-6", "Ephesians 1-3", "Ephesians 4-6", "Philippians 1-4", "Colossians 1-4", "1 Thessalonians 1-5", "2 Thessalonians 1-3", "1 Timothy 1-6", "2 Timothy 1-4", "Philemon 1; Titus 1-3", "Hebrews 1-4", "Hebrews 5-8", "Hebrews 9-10", "Hebrews 11-13", "James 1-5", "1 Peter 1-5; 2 Peter 1-3", "1 John 1-5", "2 John 1; 3 John 1; Jude 1", "Revelation 1-3", "Revelation 4-7", "Revelation 8-11", "Revelation 12-14", "Revelation 15-17", "Revelation 18-19", "Revelation 20-22"};

            StreamWriter s = new StreamWriter(@"D:\Documents\_Programming\C#\Bible-Reading-Plan\WindowsBibleReadingPlan\WindowsBibleReadingPlan\Plans\BibleInYear.json");
            string jsonText = System.Text.Json.JsonSerializer.Serialize<Plan>(newplan);
            s.Write(jsonText);
            s.Close();*/

            DateTime today = DateTime.Now;

            uxDate.Text = _months[today.Month-1] +" "+ today.Day.ToString();
            uxDate.Location = new Point(this.Size.Width / 2 - (uxDate.Size.Width / 2), uxDate.Location.Y);

            int schedule = _currentPlan.Day - today.DayOfYear + _currentPlan.StartDay;
            _timeline = (_currentPlan.Day + _currentPlan.Extra);
            while (_timeline < 0)
                _timeline += _currentPlan.Readings.Length;
            _timeline %= _currentPlan.Readings.Length;

            if (schedule == 1)
                uxTimeLine.Text = "On Schedule";
            else if (schedule == 0)
                uxTimeLine.Text = "Need To Read";
            else if (schedule > 1)
                uxTimeLine.Text = (schedule-1) + " Days Ahead";
            else if (schedule < 0)
                uxTimeLine.Text = -(schedule) + " Days Behind";
            uxTimeLine.Location = new Point(this.Size.Width / 2 - (uxTimeLine.Size.Width / 2), uxTimeLine.Location.Y);

            uxReading.Text = "To read:  " + _currentPlan.Readings[_timeline];
            uxReading.Location = new Point(this.Size.Width / 2 - (uxReading.Size.Width / 2), uxReading.Location.Y);

            uxGoRead.Location = new Point(this.Size.Width / 2 - (uxGoRead.Size.Width / 2), uxGoRead.Location.Y);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
            if (_fileName == "0")
                SelectPlan();
            ReadPlan();
            SetUp();
        }

        private void selectNewReadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectOldReadingPlanToolStripMenuItem_Click(sender, e);
            resetReadingPlanToolStripMenuItem_Click(sender, e);
        }

        private void selectOldReadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadPlan();
            SelectPlan();
            SetUp();
        }

        private void resetReadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            _currentPlan.Day = 0;
            _currentPlan.StartDay = today.DayOfYear;
            _currentPlan.Extra = 0;
            UpdatePlan();
            SetUp();
        }

        private void uxRead_Click(object sender, EventArgs e)
        {
            _currentPlan.Day++;
            UpdatePlan();
            SetUp();
        }

        private void uxReadAhead_Click(object sender, EventArgs e)
        {
            _currentPlan.Extra++;
            UpdatePlan();
            SetUp();
        }

        private void uxDidntRead_Click(object sender, EventArgs e)
        {
            _currentPlan.Day--;
            UpdatePlan();
            SetUp();
        }

        private void uxGoRead_Click(object sender, EventArgs e)
        {
            string passage = _currentPlan.Readings[_timeline].Replace(' ', '+');
            var uri = "https://www.biblegateway.com/passage/?search=" + passage + "&version=" + _version;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void setBibleVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionSelector selector = new VersionSelector();
            selector.textBox1.Text = _version;

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                _version = selector.textBox1.Text;
            }
            
            selector.Dispose();
        }

        
    }
}
