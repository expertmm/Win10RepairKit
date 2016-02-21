/*
 * Created by SharpDevelop.
 * User: TempAdmin2
 * Date: 12/21/2015
 * Time: 9:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Win10RepairKit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button resetTileDataLayerButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox profilesListBox;
		private System.Windows.Forms.TextBox statusTextBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.resetTileDataLayerButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.profilesListBox = new System.Windows.Forms.ListBox();
			this.statusTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.resetTileDataLayerButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 274);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 29);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// resetTileDataLayerButton
			// 
			this.resetTileDataLayerButton.Enabled = false;
			this.resetTileDataLayerButton.Location = new System.Drawing.Point(3, 3);
			this.resetTileDataLayerButton.Name = "resetTileDataLayerButton";
			this.resetTileDataLayerButton.Size = new System.Drawing.Size(226, 23);
			this.resetTileDataLayerButton.TabIndex = 0;
			this.resetTileDataLayerButton.Text = "Reset TileDataLayer Database";
			this.resetTileDataLayerButton.UseVisualStyleBackColor = true;
			this.resetTileDataLayerButton.Click += new System.EventHandler(this.ResetTileDataLayerButtonClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.profilesListBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 306);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// profilesListBox
			// 
			this.profilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.profilesListBox.FormattingEnabled = true;
			this.profilesListBox.Location = new System.Drawing.Point(3, 3);
			this.profilesListBox.Name = "profilesListBox";
			this.profilesListBox.Size = new System.Drawing.Size(374, 265);
			this.profilesListBox.TabIndex = 1;
			this.profilesListBox.SelectedIndexChanged += new System.EventHandler(this.ProfilesListBoxSelectedIndexChanged);
			// 
			// statusTextBox
			// 
			this.statusTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusTextBox.Location = new System.Drawing.Point(0, 306);
			this.statusTextBox.Name = "statusTextBox";
			this.statusTextBox.ReadOnly = true;
			this.statusTextBox.Size = new System.Drawing.Size(380, 20);
			this.statusTextBox.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(380, 326);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusTextBox);
			this.Name = "MainForm";
			this.Text = "Win10RepairKit";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
