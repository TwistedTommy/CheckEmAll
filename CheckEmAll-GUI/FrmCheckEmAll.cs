using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CheckEmAll_GUI
{
    /// <summary>
    /// CheckEmAll Form Class
    /// </summary>
    public partial class FrmCheckEmAll : Form
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmCheckEmAll()
        {
            InitializeComponent();

            // Hide the Help and License tabs.
            tcMain.TabPages.Remove(tabHelp);
            tcMain.TabPages.Remove(tabLicense);

            // Update the title.
            UpdateTitle();

            // Load the GUI RichTextBoxes from resources.
            rtbHelp.Text = Properties.Resources.CheckEmAll_HELP;
            rtbLicense.Rtf = Properties.Resources.CheckEmAll_LICENSE;

            // Print the version.
            PrintVersion();
        }

        #endregion

        #region Private members

        // Private members.
        private readonly string _strAppName = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName;
        private readonly string _strAppVersion = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductVersion;
        private readonly string _strAppCopyright = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright;
        private List<string> _ListLeftNames = new List<string>();
        private List<string> _ListRightNames = new List<string>();
        private string _strPathOptionsFile = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Options", "Options - CheckEmAll.xml");

        #endregion

        #region Getters/Setters Public Accessors

        /// AppName
        public string AppName
        {
            get { return _strAppName; }
            set { }
        }
        /// AppVersion
        public string AppVersion
        {
            get { return _strAppVersion; }
            set { }
        }
        /// AppCopyright
        public string AppCopyright
        {
            get { return _strAppCopyright; }
            set { }
        }
        /// ListLeftNames
        public List<string> ListLeftNames
        {
            get { return _ListLeftNames; }
            set { _ListLeftNames = value; }
        }
        /// ListRightNames
        public List<string> ListRightNames
        {
            get { return _ListRightNames; }
            set { _ListRightNames = value; }
        }
        /// ShowNonmatchingGameNames
        public bool ShowNonmatchingGameNames
        {
            get { return chkShowNonmatchingGameNames.Checked; }
            set { chkShowNonmatchingGameNames.Checked = value; }
        }
        /// ShowNonmatchingROMNames
        public bool ShowNonmatchingROMNames
        {
            get { return chkShowNonmatchingROMNames.Checked; }
            set { chkShowNonmatchingROMNames.Checked = value; }
        }
        /// PathLeftDatFile
        public string PathLeftDatFile
        {
            get { return txtPathLeftDatFile.Text; }
            set { txtPathLeftDatFile.Text = value; }
        }
        /// PathRightDatFile
        public string PathRightDatFile
        {
            get { return txtPathRightDatFile.Text; }
            set { txtPathRightDatFile.Text = value; }
        }
        /// Log
        public RichTextBox Log
        {
            get { return rtbLog; }
            set { rtbLog = value; }
        }
        /// PathOptionsFile
        public string PathOptionsFile
        {
            get { return _strPathOptionsFile; }
            set { _strPathOptionsFile = value; }
        }

        #endregion

        #region Log

        /// <summary>
        /// Saves a log file.
        /// </summary>
        private void SaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the log file.
                SaveFileDialog sfdLog = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "TXT Files|*.txt",
                    FileName = "Log_DLEA_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                    Title = "Please enter a path to the log file: ",
                    InitialDirectory = Path.Combine(Application.StartupPath, "Logs")
                };

                // Determine if the user selected a log filename.
                if (sfdLog.ShowDialog() == DialogResult.OK && sfdLog.FileName.Length > 0)
                {
                    // Get the log file directory name.
                    FileInfo fi = new FileInfo(sfdLog.FileName);

                    // Create log file directory if it doesn't exist.
                    if (Directory.Exists(fi.DirectoryName) == false) Directory.CreateDirectory(fi.DirectoryName);

                    // Save the contents of the log to a text file.
                    File.WriteAllLines(sfdLog.FileName, Log.Lines);

                    // Print to screen
                    OutputLine("Info: Log file saved (" + sfdLog.FileName + ")");
                    OutputLine("Info: Ready");
                    OutputLine("");
                }

                // Dispose of the SaveFileDialog.
                sfdLog.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Saving log file failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        #endregion

        #region Startup Tasks BGW

        /// <summary>
        /// StartupTasks DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartupTasks_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen.
                OutputLine("Info: Check Activation And Options canceled");
                OutputLine("Info: Ready");
                OutputLine("");
            }
            else if (e.Error != null)
            {
                // Print to screen.
                OutputLine("Error:Check Activation And Options failed");
                OutputLine("Error: " + e.Error.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
            else
            {
                // Print to screen.
                OutputLine("Info: Ready");
                OutputLine("");
            }

            // Update the status message label.
            toolStripStatusLabel3.Text = "Ready";

            // Enable buttons.
            EnableAllButtons();
        }

        #endregion

        #region Check Dats BGW

        /// <summary>
        /// CheckDats DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckDats_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Update.
            UpdateLeftNamesList();
            UpdateRightNamesList();
            UpdateLeftListbox();
            UpdateRightListbox();
        }

        /// <summary>
        /// CheckDats ProgressChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckDats_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // 
        }

        /// <summary>
        /// CheckDats RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckDats_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Print to screen.
                OutputLine("Info: Checking dats canceled");
                OutputLine("Info: Ready");
                OutputLine("");
            }
            else if (e.Error != null)
            {
                // Print to screen.
                OutputLine("Error: Checking dats failed");
                OutputLine("Error: " + e.Error.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
            else
            {
                // Print to screen.
                OutputLine("Info: Checking dats completed");
                OutputLine("Info: Ready");
                OutputLine("");
            }

            // Enable all buttons.
            EnableAllButtons();

            // Update the status message label.
            toolStripStatusLabel3.Text = "Ready";
        }

        #endregion

        #region GUI Methods

        /// <summary>
        /// Enables all of the buttons.
        /// </summary>
        private void EnableAllButtons()
        {
            // Enable all buttons.
            btnLoadLeftDat.Enabled = true;
            btnLoadRightDat.Enabled = true;
            btnSaveLeftList.Enabled = true;
            btnSaveRightList.Enabled = true;

            // Enable all toolstrip buttons.
            tsbSaveLog.Enabled = true;

            // Enable all checkboxes.
            chkShowNonmatchingGameNames.Enabled = true;
            chkShowNonmatchingROMNames.Enabled = true;

            // Enable all Menu Item buttons.
            tsmiCommands.Enabled = true;
            tsmiExit.Enabled = true;
            tsmiSaveLog.Enabled = true;
        }

        /// <summary>
        /// Disables all of the buttons.
        /// </summary>
        private void DisableAllButtons()
        {
            // Disable all buttons.
            btnLoadLeftDat.Enabled = false;
            btnLoadRightDat.Enabled = false;
            btnSaveLeftList.Enabled = false;
            btnSaveRightList.Enabled = false;

            // Disable all toolstrip buttons.
            tsbSaveLog.Enabled = false;

            // Disable all checkboxes.
            chkShowNonmatchingGameNames.Enabled = false;
            chkShowNonmatchingROMNames.Enabled = false;

            // Disable all Menu Item buttons.
            tsmiCommands.Enabled = false;
            tsmiExit.Enabled = false;
            tsmiSaveLog.Enabled = false;
        }

        /// <summary>
        /// Sets the application title.
        /// </summary>
        /// <param name="strTitle"></param>
        private void UpdateTitle(string strTitle = "")
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Update the application title.
                    this.Text = AppName + " v" + AppVersion + strTitle;
                }));
            }
            else if (!this.IsDisposed)
            {
                // Update the application title.
                this.Text = AppName + " v" + AppVersion + strTitle;
            }
        }

        /// <summary>
        /// Updates the left listbox.
        /// </summary>
        private void UpdateLeftListbox()
        {
            try
            {
                if (this.InvokeRequired && !this.IsDisposed)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        // Clear the Listbox.
                        lbLeftNames.Items.Clear();

                        foreach (string strName in ListLeftNames)
                        {
                            // Add the name to the ListBox if it doesn't exist in the opposite List.
                            if (ListRightNames.Contains(strName) == false)
                            {
                                lbLeftNames.Items.Add(strName);
                            }
                        }
                    }));
                }
                else if (!this.IsDisposed)
                {
                    // Clear the Listbox.
                    lbLeftNames.Items.Clear();

                    foreach (string strName in ListLeftNames)
                    {
                        // Add the name to the ListBox if it doesn't exist in the opposite List.
                        if (ListRightNames.Contains(strName) == false)
                        {
                            lbLeftNames.Items.Add(strName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Updating left listbox failed");
                OutputLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Updates the right listbox.
        /// </summary>
        private void UpdateRightListbox()
        {
            try
            {
                if (this.InvokeRequired && !this.IsDisposed)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        // Clear the Listbox.
                        lbRightNames.Items.Clear();

                        foreach (string strName in ListRightNames)
                        {
                            // Add the name to the ListBox if it doesn't exist in the opposite List.
                            if (ListLeftNames.Contains(strName) == false)
                            {
                                lbRightNames.Items.Add(strName);
                            }
                        }
                    }));
                }
                else if (!this.IsDisposed)
                {
                    // Clear the Listbox.
                    lbRightNames.Items.Clear();

                    foreach (string strName in ListRightNames)
                    {
                        // Add the name to the ListBox if it doesn't exist in the opposite List.
                        if (ListLeftNames.Contains(strName) == false)
                        {
                            lbRightNames.Items.Add(strName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Updating right listbox failed");
                OutputLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Updates the left list.
        /// </summary>
        private void UpdateLeftNamesList()
        {
            try
            {
                if (File.Exists(PathLeftDatFile))
                {
                    // Clear the left List.
                    ListLeftNames.Clear();

                    // Load the game names from the datafile.
                    XDocument xdocDatafile = XDocument.Load(PathLeftDatFile);

                    if (ShowNonmatchingGameNames == true)
                    {
                        // Add all of the game names.
                        foreach (XElement xelemGame in xdocDatafile.Descendants("game"))
                        {
                            // Add the game name to the List if it doesn't already exist.
                            if (ListLeftNames.Contains(xelemGame.Attribute("name").Value) == false)
                            {
                                ListLeftNames.Add(xelemGame.Attribute("name").Value);
                            }
                        }
                    }

                    if (ShowNonmatchingROMNames == true)
                    {
                        // Add all of the ROM names.
                        foreach (XElement xelemROM in xdocDatafile.Descendants("rom"))
                        {
                            // Add the ROM name to the List if it doesn't already exist.
                            if (ListLeftNames.Contains(xelemROM.Attribute("name").Value) == false)
                            {
                                ListLeftNames.Add(xelemROM.Attribute("name").Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Updating left list failed");
                OutputLine("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Updates the right list.
        /// </summary>
        private void UpdateRightNamesList()
        {
            try
            {
                if (File.Exists(PathRightDatFile))
                {
                    // Clear the right List.
                    ListRightNames.Clear();

                    // Load the game names from the datafile.
                    XDocument xdocDatafile = XDocument.Load(PathRightDatFile);

                    if (ShowNonmatchingGameNames == true)
                    {
                        // Add all of the game names.
                        foreach (XElement xelemGame in xdocDatafile.Descendants("game"))
                        {
                            // Add the game name to the List if it doesn't already exist.
                            if (ListRightNames.Contains(xelemGame.Attribute("name").Value) == false)
                            {
                                ListRightNames.Add(xelemGame.Attribute("name").Value);
                            }
                        }
                    }


                    if (ShowNonmatchingROMNames == true)
                    {
                        // Add all of the ROM names.
                        foreach (XElement xelemROM in xdocDatafile.Descendants("rom"))
                        {
                            // Add the ROM name to the List if it doesn't already exist.
                            if (ListRightNames.Contains(xelemROM.Attribute("name").Value) == false)
                            {
                                ListRightNames.Add(xelemROM.Attribute("name").Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Updating right list failed");
                OutputLine("Error: " + ex.Message);
            }
        }

        #endregion

        #region Button Click Events

        /// <summary>
        /// Loads a dat on the left side.
        /// </summary>
        private void LoadLeftDat_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize an OpenFileDialog for the Dat/PPD/XML file.
                OpenFileDialog ofdPathDatFile = new OpenFileDialog
                {
                    DefaultExt = "*.dat",
                    Filter = "All Datafiles|*.dat;*.ppd;*.xml|DAT Files|*.dat|PPD Files|*.ppd|XML Files|*.xml",
                    Title = "Please enter a path to the Dat/PPD/XML file: ",
                    InitialDirectory = Application.StartupPath
                };

                // Determine if the user selected a file name from the OpenFileDialog.
                if (ofdPathDatFile.ShowDialog() == DialogResult.OK && ofdPathDatFile.FileName.Length > 0)
                {
                    // Set
                    PathLeftDatFile = ofdPathDatFile.FileName;

                    // Print to screen
                    OutputLine("Info: Loading left dat (" + ofdPathDatFile.FileName + ")");
                    OutputLine("Info: Checking dats ..");

                    // Update the status label.
                    toolStripStatusLabel3.Text = "Checking Dats ...";

                    // Check the dats.
                    bgwCheckDats.RunWorkerAsync();
                }
                else
                {
                    // Enable all buttons.
                    EnableAllButtons();
                }

                // Dispose of the OpenFileDialog.
                ofdPathDatFile.Dispose();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Loading left dat failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        /// <summary>
        /// Loads a dat on the right side.
        /// </summary>
        private void LoadRightDat_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize an OpenFileDialog for the Dat/PPD/XML file.
                OpenFileDialog ofdPathDatFile = new OpenFileDialog
                {
                    DefaultExt = "*.dat",
                    Filter = "All Datafiles|*.dat;*.ppd;*.xml|DAT Files|*.dat|PPD Files|*.ppd|XML Files|*.xml",
                    Title = "Please enter a path to the Dat/PPD/XML file: ",
                    InitialDirectory = Application.StartupPath
                };

                // Determine if the user selected a file name from the OpenFileDialog.
                if (ofdPathDatFile.ShowDialog() == DialogResult.OK && ofdPathDatFile.FileName.Length > 0)
                {
                    // Set
                    PathRightDatFile = ofdPathDatFile.FileName;

                    // Print to screen
                    OutputLine("Info: Loading right dat (" + ofdPathDatFile.FileName + ")");
                    OutputLine("Info: Checking dats ..");

                    // Update the status label.
                    toolStripStatusLabel3.Text = "Checking Dats ...";

                    // Check the dats.
                    bgwCheckDats.RunWorkerAsync();
                }
                else
                {
                    // Enable all buttons.
                    EnableAllButtons();
                }

                // Dispose of the OpenFileDialog.
                ofdPathDatFile.Dispose();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Loading right dat failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        /// <summary>
        /// Saves the left list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveLeftList_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the list file.
                SaveFileDialog sfdLog = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "TXT Files|*.txt",
                    FileName = "List_CHEA_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                    Title = "Please enter a path to the list file: ",
                    InitialDirectory = Path.Combine(Application.StartupPath, "Lists")
                };

                // Determine if the user selected a list filename.
                if (sfdLog.ShowDialog() == DialogResult.OK && sfdLog.FileName.Length > 0)
                {
                    // Get the list file directory name.
                    FileInfo fi = new FileInfo(sfdLog.FileName);

                    // Create list file directory if it doesn't exist.
                    if (Directory.Exists(fi.DirectoryName) == false) Directory.CreateDirectory(fi.DirectoryName);

                    StreamWriter writer = new StreamWriter(sfdLog.FileName);

                    for (int i = 0; i < lbLeftNames.Items.Count; i++)
                    {
                        writer.WriteLine((string)lbLeftNames.Items[i]);
                    }

                    writer.Close();

                    // Print to screen
                    OutputLine("Info: Saved left list (" + sfdLog.FileName + ")");
                    OutputLine("Info: Ready");
                    OutputLine("");
                }

                // Dispose of the SaveFileDialog.
                sfdLog.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Saving left list failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        /// <summary>
        /// Saves the right list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveRightList_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable all buttons.
                DisableAllButtons();

                // Create and initialize a SaveFileDialog for the list file.
                SaveFileDialog sfdLog = new SaveFileDialog
                {
                    DefaultExt = "*.txt",
                    Filter = "TXT Files|*.txt",
                    FileName = "List_CHEA_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
                    Title = "Please enter a path to the list file: ",
                    InitialDirectory = Path.Combine(Application.StartupPath, "Lists")
                };

                // Determine if the user selected a list filename.
                if (sfdLog.ShowDialog() == DialogResult.OK && sfdLog.FileName.Length > 0)
                {
                    // Get the list file directory name.
                    FileInfo fi = new FileInfo(sfdLog.FileName);

                    // Create list file directory if it doesn't exist.
                    if (Directory.Exists(fi.DirectoryName) == false) Directory.CreateDirectory(fi.DirectoryName);

                    StreamWriter writer = new StreamWriter(sfdLog.FileName);

                    for (int i = 0; i < lbRightNames.Items.Count; i++)
                    {
                        writer.WriteLine((string)lbRightNames.Items[i]);
                    }

                    writer.Close();

                    // Print to screen
                    OutputLine("Info: Saved right list (" + sfdLog.FileName + ")");
                    OutputLine("Info: Ready");
                    OutputLine("");
                }

                // Dispose of the SaveFileDialog.
                sfdLog.Dispose();

                // Enable all buttons.
                EnableAllButtons();
            }
            catch (Exception ex)
            {
                // Print to screen
                OutputLine("Error: Saving right list failed");
                OutputLine("Error: " + ex.Message);
                OutputLine("Info: Ready");
                OutputLine("");
            }
        }

        /// <summary>
        /// Exits the WinForm app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region View Click Events

        /// <summary>
        /// Toggles the visibility of the CheckEmAll.
        /// </summary>
        private void ViewCheckEmAll_Click(object sender, EventArgs e)
        {
            if (tsmiCheckEmAll.Checked)
            {
                tsmiCheckEmAll.Checked = false;
                tsmiCheckEmAll.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabCheckEmAll);
            }
            else
            {
                tsmiCheckEmAll.Checked = true;
                tsmiCheckEmAll.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabCheckEmAll);
                tcMain.SelectTab(tabCheckEmAll);
            }
        }

        /// <summary>
        /// Toggles the visibility of the log.
        /// </summary>
        private void ViewLog_Click(object sender, EventArgs e)
        {
            if (tsmiLog.Checked)
            {
                tsmiLog.Checked = false;
                tsmiLog.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLog);
            }
            else
            {
                tsmiLog.Checked = true;
                tsmiLog.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLog);
                tcMain.SelectTab(tabLog);
            }
        }

        /// <summary>
        /// Toggles the visibility of the help.
        /// </summary>
        private void ViewHelp_Click(object sender, EventArgs e)
        {
            if (tsmiHelp.Checked)
            {
                tsmiHelp.Checked = false;
                tsmiHelp.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabHelp);
            }
            else
            {
                tsmiHelp.Checked = true;
                tsmiHelp.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabHelp);
                tcMain.SelectTab(tabHelp);
            }
        }

        /// <summary>
        /// Toggles the visibility of the license.
        /// </summary>
        private void ViewLicense_Click(object sender, EventArgs e)
        {
            if (tsmiLicense.Checked)
            {
                tsmiLicense.Checked = false;
                tsmiLicense.CheckState = CheckState.Unchecked;
                tcMain.TabPages.Remove(tabLicense);
            }
            else
            {
                tsmiLicense.Checked = true;
                tsmiLicense.CheckState = CheckState.Checked;
                tcMain.TabPages.Add(tabLicense);
                tcMain.SelectTab(tabLicense);
            }
        }

        /// <summary>
        /// Toggles the visibility of the toolbar.
        /// </summary>
        private void ViewToolbar_Click(object sender, EventArgs e)
        {
            if (tsMain.Visible)
            {
                tsMain.Visible = false;
                tsmiToolbar.Checked = false;
            }
            else
            {
                tsMain.Visible = true;
                tsmiToolbar.Checked = true;
            }
        }

        #endregion

        #region Filter CheckedChanged Events

        /// <summary>
        /// Updates the left and right lists to show/not show matching game names.
        /// </summary>
        private void ShowNonmatchingGameNames_CheckedChanged(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Print to screen
            OutputLine("Info: Checking dats for nonmatching Game names ...");

            // Update the status label.
            toolStripStatusLabel3.Text = "Checking Dats ...";

            // Check the dats.
            bgwCheckDats.RunWorkerAsync();
        }

        /// <summary>
        /// Updates the left and right lists to show/not show matching ROM names.
        /// </summary>
        private void ShowNonmatchingROMNames_CheckedChanged(object sender, EventArgs e)
        {
            // Disable all buttons.
            DisableAllButtons();

            // Print to screen
            OutputLine("Info: Checking dats for nonmatching ROM names ...");

            // Update the status label.
            toolStripStatusLabel3.Text = "Checking Dats ...";

            // Check the dats.
            bgwCheckDats.RunWorkerAsync();
        }

        #endregion

        #region Form Events

        /// <summary>
        /// Form Shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Shown(object sender, EventArgs e)
        {
            // Perform the startup tasks.
            bgwStartupTasks.RunWorkerAsync();
        }

        /// <summary>
		/// Checks things to make sure it is safe, before closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bgwCheckDats.IsBusy == true)
            {
                if (MessageBox.Show("The checker is currently running. Exiting now may cause corrupt or incomplete files! Are you sure you want to exit now?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Printers

        /// <summary>
        /// Prints the version and copyright notice texts.
        /// </summary>
        public void PrintVersion()
        {
            // Print to screen
            OutputLine("------------------------------------------------------------------------------");
            OutputLine(AppName + " v" + AppVersion);
            OutputLine(AppCopyright);
            OutputLine("------------------------------------------------------------------------------");
            OutputLine("");
        }

        /// <summary>
        /// Outputs a line of text.
        /// </summary>
        /// <param name="strMsg"></param>
        private void OutputLine(string strMsg)
        {
            if (this.InvokeRequired && !this.IsDisposed)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    // Add the line of text to the log.
                    this.rtbLog.AppendText(strMsg + Environment.NewLine);

                    // Scroll the log to the caret.
                    this.rtbLog.ScrollToCaret();
                }));
            }
            else if (!this.IsDisposed)
            {
                // Add the line of text to the log.
                this.rtbLog.AppendText(strMsg + Environment.NewLine);

                // Scroll the log to the caret.
                this.rtbLog.ScrollToCaret();
            }
        }

        #endregion
    }
}
