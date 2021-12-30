using Microsoft.Win32;
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
    public partial class UserInterface : Form
    {
        private Plan _currentPlan;
        
        private int _timeline = 0;
        private static string[] _months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private string _fileName;
        private string _version;
        private bool _allowExtraReading = false;
        private bool _enableColoredText = false;
        private bool _runAtStartUp = false;


        public UserInterface()
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
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Program files are stored in a protected location \nPlease uninstall application and reinstall in a different location");
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
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Program files are stored in a protected location \nPlease uninstall application and reinstall in a different location");
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
                StreamReader r = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BibleReadingPlan\data");

                _fileName = r.ReadLine();
                _version = r.ReadLine();
                _allowExtraReading = (r.ReadLine() == "0") ? false : true;
                _enableColoredText = (r.ReadLine() == "0") ? false : true;
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
                StreamWriter s = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BibleReadingPlan\data");


                s.WriteLine(_fileName);
                s.WriteLine(_version);
                s.WriteLine((_allowExtraReading) ? 1 : 0);
                s.WriteLine((_enableColoredText) ? 1 : 0);
                s.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Program files are stored in a protected location \nPlease uninstall application and reinstall in a different location");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectPlan()
        {
            uxOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\BibleReadingPlan\Plans\";
       

            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fileName = uxOpenFileDialog.FileName;
                    UpdateData();
                    resetReadingPlanToolStripMenuItem.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void LineUp()
        {
            uxDate.Location = new Point(this.Size.Width / 2 - (uxDate.Size.Width / 2) -10, uxDate.Location.Y);
            uxTimeLine.Location = new Point(this.Size.Width / 2 - (uxTimeLine.Size.Width / 2) - 10, uxTimeLine.Location.Y);
            uxReading.Location = new Point(this.Size.Width / 2 - (uxReading.Size.Width / 2) - 10, uxReading.Location.Y);

            uxGoRead.Location = new Point(this.Size.Width / 2 - (uxGoRead.Size.Width / 2) -10, uxGoRead.Location.Y);
            uxRead.Location = new Point(this.Size.Width - (uxRead.Size.Width) - 30, uxRead.Location.Y);
            uxReadAhead.Location = new Point(this.Size.Width - (uxReadAhead.Size.Width) - 30, uxReadAhead.Location.Y);
            uxDidntRead.Location = new Point(10, uxDidntRead.Location.Y);
            uxDidntReadAhead.Location = new Point(10, uxDidntReadAhead.Location.Y);

            if (_allowExtraReading)
            {
                uxReadAhead.Visible = true;
                uxDidntReadAhead.Visible = true;

                uxRead.Height = uxReadAhead.Height;
                uxDidntRead.Height = uxDidntReadAhead.Height;
            }
            else
            {
                uxReadAhead.Visible = false;
                uxDidntReadAhead.Visible = false;

                uxRead.Height = uxGoRead.Height;
                uxDidntRead.Height = uxGoRead.Height;
            }
        }

        private void SetUp()
        {
            selectOldReadingPlanButton.Visible = false;
            selectNewReadingPlanButton.Visible = false;

            uxDidntRead.Visible = true;
            uxGoRead.Visible = true;
            uxRead.Visible = true;

            uxReading.Visible = true;
            uxTimeLine.Visible = true;
            uxReading.Visible = true;

            DateTime today = DateTime.Now;

            uxDate.Text = _months[today.Month-1] +" "+ today.Day.ToString();

            int schedule = _currentPlan.Day - today.DayOfYear + _currentPlan.StartDay;
            _timeline = (_currentPlan.Day + _currentPlan.Extra);
            while (_timeline < 0)
                _timeline += _currentPlan.Readings.Length;
            _timeline %= _currentPlan.Readings.Length;

            if (schedule == 1)
            {
                uxTimeLine.ForeColor = Color.Black;
                uxTimeLine.Text = "On Schedule";
            }
            else if (schedule == 0)
            {
                uxTimeLine.ForeColor = Color.Black;
                uxTimeLine.Text = "Need To Read";
            }
            else if (schedule > 1)
            {
                uxTimeLine.ForeColor = Color.Green;
                uxTimeLine.Text = (schedule - 1) + " Days Ahead";
            }
            else if (schedule < 0)
            {
                uxTimeLine.ForeColor = Color.Red;
                uxTimeLine.Text = -(schedule) + " Days Behind";
            }

            if (!_enableColoredText)
            uxTimeLine.ForeColor = Color.Black;

            uxReading.Text = "To read:  " + _currentPlan.Readings[_timeline];



            uxDidntRead.Enabled = true;
            uxDidntReadAhead.Enabled = true;
            uxGoRead.Enabled = true;
            uxRead.Enabled = true;
            uxReadAhead.Enabled = true;

            LineUp();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineUp();
            ReadData();
            if (_fileName != "0") {
                resetReadingPlanToolStripMenuItem.Visible = true;
                ReadPlan();
                SetUp();
            }
            else
            {
                _currentPlan = new Plan();
                _currentPlan.Day = 0;
                _currentPlan.Extra = 0;
                _currentPlan.StartDay = 0;

                if (!_enableColoredText)
                    enableColoredTextToolStripMenuItem.Text = "Enable Colored Text";
                else
                {
                    enableColoredTextToolStripMenuItem.Text = "Disable Colored Text";
                }
                if (!_allowExtraReading)
                    allowExtraReadingToolStripMenuItem.Text = "Allow Extra Reading";
                else
                    allowExtraReadingToolStripMenuItem.Text = "Don't Allow Extra Reading";

                LineUp();
            }
        }

        private void selectNewReadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectOldReadingPlanToolStripMenuItem_Click(sender, e);
            if (_fileName != "0")
                resetReadingPlanToolStripMenuItem_Click(sender, e);
        }

        private void selectOldReadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectPlan();
            if (_fileName != "0")
            {
                ReadPlan();
                SetUp();
            }
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
        private void uxDidntReadAhead_Click(object sender, EventArgs e)
        {
            _currentPlan.Extra--;
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

            if (selector.ShowDialog(this) == DialogResult.OK)
            {
                _version = selector.textBox1.Text;
            }
            
            selector.Dispose();
        }

        private void allowExtraReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_allowExtraReading)
                allowExtraReadingToolStripMenuItem.Text = "Allow Extra Reading";
            else
                allowExtraReadingToolStripMenuItem.Text = "Don't Allow Extra Reading";

            _allowExtraReading = !_allowExtraReading;
            UpdateData();
            LineUp();
        }
        private void selectNewReadingPlanButton_Click(object sender, EventArgs e)
        {
            selectNewReadingPlanToolStripMenuItem_Click(sender, e);
        }

        private void selectOldReadingPlanButton_Click(object sender, EventArgs e)
        {
            selectOldReadingPlanToolStripMenuItem_Click(sender, e);
        }

        private void enableColoredTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_enableColoredText)
                enableColoredTextToolStripMenuItem.Text = "Enable Colored Text";
            else
                enableColoredTextToolStripMenuItem.Text = "Disable Colored Text";

            _enableColoredText = !_enableColoredText;
            UpdateData();
            SetUp();
        }
    }
}
