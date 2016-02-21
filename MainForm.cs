/*
 * Created by SharpDevelop.
 * User: TempAdmin2
 * Date: 12/21/2015
 * Time: 9:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Win10RepairKit
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ArrayList profilesDIs=new ArrayList();
		ArrayList genericProfileNames = new ArrayList();
		public static readonly string my_name = "Win10RepairKit";
		public static readonly string my_name_and_version_and_author = "Win10RepairKit 2015-12-21 by expertmm";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		bool containsI(ArrayList haystack, string needle) {
			bool found=false;
			if (haystack!=null) {
				string needle_ToLower=needle.ToLower();
				foreach (string thisString in haystack) {
					if (thisString.ToLower()==needle_ToLower) {
						found=true;
						break;
					}
				}
			}
			return found;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			DirectoryInfo profilesFolderDI = new DirectoryInfo(@"C:\Users");
			genericProfileNames.Add("Default");
			genericProfileNames.Add("Default User"); //symlink to Default
			genericProfileNames.Add("DefaultAppPool");
			genericProfileNames.Add("Public");
			genericProfileNames.Add("All Users"); //symlink to Public
			this.Text += "(cannot fix a user that is logged in)";
			foreach (DirectoryInfo thisDI in profilesFolderDI.GetDirectories()) {
				if (!containsI(genericProfileNames, thisDI.Name)) {
					//if (thisDI.Name.ToLower() != Environment.UserName.ToLower()) {
					//do not check if current user, since may need to run as the user being fixed though that user is not logged in
					profilesListBox.Items.Add(thisDI.FullName);
					//}
				}
			}
		}
		void ProfilesListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			resetTileDataLayerButton.Enabled=true;
		}
		void ResetTileDataLayerButtonClick(object sender, EventArgs e)
		{
			string TileDataLayer_FullName = Path.Combine(profilesListBox.Items[profilesListBox.SelectedIndex].ToString(),@"AppData\Local\TileDataLayer");
			//MessageBox.Show(TileDataLayer_FullName);
			System.Diagnostics.Process.Start("explorer.exe",TileDataLayer_FullName);
			string TDLDatabase_FullName = Path.Combine(TileDataLayer_FullName, "Database");
			DialogResult thisDR=DialogResult.Yes;
			if (!Directory.Exists(TDLDatabase_FullName)) {
				thisDR=MessageBox.Show("The Database does not exist for that profile. If you are not using Windows 10, this repair option will not work. Are you sure you want to continue?",my_name,MessageBoxButtons.YesNo);
			}
			if (thisDR==DialogResult.Yes) {
				string TDLDatabase_Backup_Name = "Database.bak1";
				string TDLDatabase_Backup_FullName = Path.Combine(TileDataLayer_FullName, TDLDatabase_Backup_Name);
				int backup_number = 1;
				
				while (Directory.Exists(TDLDatabase_Backup_FullName)) {
					backup_number++;
					TDLDatabase_Backup_Name = "Database.bak"+backup_number.ToString();
					TDLDatabase_Backup_FullName = Path.Combine(TileDataLayer_FullName, TDLDatabase_Backup_Name);
				}
				try {
					string sample_database_fullname = "LOCALAPPDATA\\TileDataLayer\\Database";
					DirectoryInfo sampledbDI=new DirectoryInfo(sample_database_fullname);
					if (sampledbDI.Exists) {
						if (Directory.Exists(TDLDatabase_FullName)) {
							Directory.Move(TDLDatabase_FullName, TDLDatabase_Backup_FullName);
						}
						if (!Directory.Exists(TDLDatabase_FullName)) {
							Directory.CreateDirectory(TDLDatabase_FullName);
							foreach (FileInfo thisFI in sampledbDI.GetFiles()) {
								thisFI.CopyTo(Path.Combine(TDLDatabase_FullName, thisFI.Name));
							}
							statusTextBox.Text="Finished restoring database to '"+TDLDatabase_FullName+"'";
							if (Directory.Exists(TDLDatabase_Backup_FullName)) {
								statusTextBox.Text+=" with backup '"+TDLDatabase_Backup_FullName+"'";
							}
							else statusTextBox.Text+=" (was missing!)";
						}
						else MessageBox.Show("Folder '"+TDLDatabase_FullName+"' was still present after attempting to move for an unknown reason.");
					}
					else MessageBox.Show("The sample database is needed for this repair, but could not be found at '"+sample_database_fullname+"'");
				}
				catch (Exception exn) {
					MessageBox.Show("Could not finish moving folders:\n"+exn.ToString(),my_name);
				}
			}
		}
	}
}
