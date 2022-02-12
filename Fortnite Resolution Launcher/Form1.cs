using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Management;
using System.Reflection;

namespace Fortnite_Resolution_Launcher
{
    public partial class Launcher : Form
    {
        readonly int nativeHorizontal = Screen.PrimaryScreen.Bounds.Width, nativeVertical = Screen.PrimaryScreen.Bounds.Height;
        static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FortniteGame\Saved\Config\WindowsClient\";
        readonly INIFile inif = new INIFile(path + "GameUserSettings.ini");
        string horizontal, vertical;
        bool triggered = false, oncePlayed = false;
        public static string FirstCharToUpper(bool a)
        {
            return a.ToString().First().ToString().ToUpper() + a.ToString().Substring(1);
        }
        void SaveINISettings()
        {
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX", horizontal);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY", vertical);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeX", horizontal);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedResolutionSizeY", vertical);

            inif.Write("/Script/FortniteGame.FortGameUserSettings", "DesiredScreenWidth", horizontal);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "DesiredScreenHeight", vertical);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedDesiredScreenWidth", horizontal);
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "LastUserConfirmedDesiredScreenHeight", vertical);

            int i;
            if (fullscreenCb.Checked) i = 0;
            else i = 1;
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "FullscreenMode", i.ToString());
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "LastConfirmedFullscreenMode", i.ToString());
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "PreferredFullscreenMode", i.ToString());
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "bDisableMouseAcceleration", FirstCharToUpper(!mouseAccelCb.Checked));
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "bMotionBlur", FirstCharToUpper(motionBlurCb.Checked));
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "bShowGrass", FirstCharToUpper(showGrassCb.Checked));
            inif.Write("/Script/FortniteGame.FortGameUserSettings", "bUseVSync", FirstCharToUpper(vsyncCb.Checked));
        }
        public Launcher()
        {
            InitializeComponent();
            foreach (Control c in Controls)
                if (c is Button b)
                    b.FlatAppearance.MouseOverBackColor = Color.Transparent;

            versionLbl.Text = versionLbl.Text.Replace("@", Application.ProductVersion);
            TrayMenuContext();
            DataFile.CreateDirectory();
            Console.WriteLine("Path: " + path);

            horizontal = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX");
            vertical = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY");
            Console.WriteLine("Current Fortnite resolution is " + horizontal + "x" + vertical);
            horizontalTb.Text = horizontal;
            verticalTb.Text = vertical;

            bool screenMode = false;
            if (inif.Read("/Script/FortniteGame.FortGameUserSettings", "FullscreenMode") == "0")
                screenMode = true;
            fullscreenCb.Checked = screenMode;
            mouseAccelCb.Checked = !bool.Parse(inif.Read("/Script/FortniteGame.FortGameUserSettings", "bDisableMouseAcceleration"));
            motionBlurCb.Checked = bool.Parse(inif.Read("/Script/FortniteGame.FortGameUserSettings", "bMotionBlur"));
            showGrassCb.Checked = bool.Parse(inif.Read("/Script/FortniteGame.FortGameUserSettings", "bShowGrass"));
            vsyncCb.Checked = bool.Parse(inif.Read("/Script/FortniteGame.FortGameUserSettings", "bUseVSync"));

            timerValueTb.Text = timer.Interval.ToString();
            noteLbl.Text = noteLbl.Text.Replace("@", timer.Interval.ToString());

            Process[] pname = Process.GetProcessesByName("FortniteLauncher");
            if (pname.Length > 0) // Checking if Fortnite is either running or not
                processPb.Image = Properties.Resources.green_circle;
        }
        private void TrayMenuContext()
        {
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Maximize", null, notifyIcon_MaximizeClick);
            notifyIcon.ContextMenuStrip.Items.Add("Exit", null, notifyIcon_ExitClick);
        }
        private void notifyIcon_MaximizeClick(object sender, EventArgs e) => notifyIcon_MouseDoubleClick(null, null);
        private void notifyIcon_ExitClick(object sender, EventArgs e) => Application.Exit();
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void openFolderBtn_MouseClick(object sender, MouseEventArgs e) => Process.Start("explorer.exe", path);
        private void testResBtn_MouseClick(object sender, MouseEventArgs e)
        {
            horizontal = horizontalTb.Text;
            vertical = verticalTb.Text;
            if (int.Parse(horizontal) == nativeHorizontal && int.Parse(vertical) == nativeVertical) return;

            Process.Start(DataFile.path + @"\QRes.exe", $"/X {horizontal} /Y {vertical}"); // Change resolution
            Thread.Sleep(500);

            Rectangle area = Screen.FromControl(this).WorkingArea;
            if (area.Width != int.Parse(horizontal) || area.Height+30 != int.Parse(vertical))
            {
                MessageBox.Show("Something went wrong while the resolution was being changed, please read the first note and try again", "Launcher", MessageBoxButtons.OK);
                return;
            }

            triggered = true;
            timer.Interval = 1000;
            timer.Start();
        }
        private void backupBtn_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("WIP");
        }
        private void saveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            horizontal = horizontalTb.Text;
            vertical = verticalTb.Text;
            DialogResult dr = MessageBox.Show("Are you sure you want to save your resolution as " + horizontal + "x" + vertical + "?\nAnd your preferences?", "Launcher", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                SaveINISettings();
                string x = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX");
                string y = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY");
                if (x == horizontal && y == vertical)
                    MessageBox.Show("Saved your resolution successfully", "Launcher");
                else
                    MessageBox.Show("Something went wrong while the resolution was saved, please uncheck the Read-Only box in file properties", "Launcher");
            }
        }
        private void launchBtn_MouseClick(object sender, MouseEventArgs e)
        {
            horizontal = horizontalTb.Text;
            vertical = verticalTb.Text;
            SaveINISettings();
            string x = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeX");
            string y = inif.Read("/Script/FortniteGame.FortGameUserSettings", "ResolutionSizeY");
            if (x == horizontal && y == vertical)
                MessageBox.Show("Saved your resolution successfully", "Launcher");
            else
                MessageBox.Show("Something went wrong while the resolution was saved, please uncheck the Read-Only box in file properties", "Launcher");

            DialogResult dr = MessageBox.Show("Good luck in your battles tryharder!", "Launcher", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            { 
                Process[] pname = Process.GetProcessesByName("FortniteLauncher");
                if (pname.Length > 0) // Checking if Fortnite is either running or not
                {
                    notifyIcon.Visible = false;
                    triggered = false;
                    timer.Stop();
                    timerCounts = 0;
                    MessageBox.Show("Fortnite is already running! Close it so you can run it from here", "Launcher", MessageBoxButtons.OK);
                    return;
                }

                Process.Start(DataFile.path + @"\QRes.exe", $"/X {horizontal} /Y {vertical}"); // Change resolution
                Thread.Sleep(500);

                Rectangle area = Screen.FromControl(this).WorkingArea;
                if (area.Width != int.Parse(horizontal) || area.Height+30 != int.Parse(vertical))
                {
                    MessageBox.Show("Something went wrong while the resolution was being changed, please read the first note and try again", "Launcher", MessageBoxButtons.OK);
                    return;
                }

                Hide();
                notifyIcon.Visible = true;

                string execPath = DataFile.path + @"\guihslk.bat";
                StreamWriter w = new StreamWriter(execPath);
                w.WriteLine("@echo off\nstart com.epicgames.launcher://apps/Fortnite?action=launch&silent=true\nexit");
                w.Close();
                Process proc = new Process();
                proc.StartInfo.FileName = execPath;
                proc.Start();
                proc.WaitForExit();
                File.Delete(execPath);

                processPb.Image = Properties.Resources.green_circle;
                triggered = true;
                if (!oncePlayed)
                    oncePlayed = true;
                Thread.Sleep(6000);
                timer.Interval = int.Parse(timerValueTb.Text);
                timer.Start();
            }
        }

        // Detecting if Fortnite was closed, most accurate
        int timerCounts = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            timerCounts++;
            if (triggered)
            {
                Process[] pname = Process.GetProcessesByName("FortniteLauncher");
                //Console.WriteLine("IsTriggered: " + triggered + ", Counts: " + timerCounts + ", Processes Length: " + pname.Length);
                if (pname.Length == 0 && timerCounts >= 7)
                {
                    Process.Start(DataFile.path + @"\QRes", $"/X {nativeHorizontal} /Y {nativeVertical}");
                    processPb.Image = Properties.Resources.red_circle;
                    if (notifyIcon.Visible == true) 
                    {
                        Show();
                        WindowState = FormWindowState.Normal;
                        notifyIcon.Visible = false;
                    }
                    triggered = false;
                    timer.Stop();
                    timerCounts = 0;
                }
            }
        }
        private void Launcher_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }
        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(oncePlayed)
                Process.Start(DataFile.path + @"\QRes.exe", $"/X {nativeHorizontal} /Y {nativeVertical}");
        }
        private void Launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(oncePlayed)
                Process.Start(DataFile.path + @"\QRes.exe", $"/X {nativeHorizontal} /Y {nativeVertical}");
        }

    }
}
