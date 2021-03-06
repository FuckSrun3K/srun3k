﻿/*
 * Created by SharpDevelop.
 * User: Gerald
 * Date: 2014/6/14
 * Time: 23:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SRun3KStupid
{
	partial class SettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btMAC = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textHost = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbAutoLogIn = new System.Windows.Forms.CheckBox();
			this.comboMAC = new System.Windows.Forms.ComboBox();
			this.cbAutoHide = new System.Windows.Forms.CheckBox();
			this.btGuess = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btCancel = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.linkSupport = new System.Windows.Forms.LinkLabel();
			this.lblMsg = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btMAC
			// 
			this.btMAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.btMAC.AutoSize = true;
			this.btMAC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btMAC.Location = new System.Drawing.Point(216, 32);
			this.btMAC.Name = "btMAC";
			this.btMAC.Size = new System.Drawing.Size(75, 22);
			this.btMAC.TabIndex = 15;
			this.btMAC.Text = "&Random";
			this.btMAC.UseVisualStyleBackColor = true;
			this.btMAC.Click += new System.EventHandler(this.BtMACClick);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 13;
			this.label3.Text = "&MAC:";
			// 
			// textHost
			// 
			this.textHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textHost.Location = new System.Drawing.Point(44, 4);
			this.textHost.Name = "textHost";
			this.textHost.Size = new System.Drawing.Size(166, 21);
			this.textHost.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 12);
			this.label4.TabIndex = 11;
			this.label4.Text = "&Host:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.cbAutoLogIn, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textHost, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btMAC, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboMAC, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.cbAutoHide, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btGuess, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 101);
			this.tableLayoutPanel1.TabIndex = 16;
			// 
			// cbAutoLogIn
			// 
			this.cbAutoLogIn.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.cbAutoLogIn, 3);
			this.cbAutoLogIn.Location = new System.Drawing.Point(3, 82);
			this.cbAutoLogIn.Name = "cbAutoLogIn";
			this.cbAutoLogIn.Size = new System.Drawing.Size(132, 16);
			this.cbAutoLogIn.TabIndex = 17;
			this.cbAutoLogIn.Text = "Log in at start &up";
			this.cbAutoLogIn.UseVisualStyleBackColor = true;
			// 
			// comboMAC
			// 
			this.comboMAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboMAC.FormattingEnabled = true;
			this.comboMAC.Location = new System.Drawing.Point(44, 33);
			this.comboMAC.Name = "comboMAC";
			this.comboMAC.Size = new System.Drawing.Size(166, 20);
			this.comboMAC.TabIndex = 18;
			// 
			// cbAutoHide
			// 
			this.cbAutoHide.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.cbAutoHide, 3);
			this.cbAutoHide.Location = new System.Drawing.Point(3, 60);
			this.cbAutoHide.Name = "cbAutoHide";
			this.cbAutoHide.Size = new System.Drawing.Size(186, 16);
			this.cbAutoHide.TabIndex = 19;
			this.cbAutoHide.Text = "Hide &window after logged in";
			this.cbAutoHide.UseVisualStyleBackColor = true;
			// 
			// btGuess
			// 
			this.btGuess.Location = new System.Drawing.Point(216, 3);
			this.btGuess.Name = "btGuess";
			this.btGuess.Size = new System.Drawing.Size(75, 23);
			this.btGuess.TabIndex = 20;
			this.btGuess.Text = "&Guess";
			this.btGuess.UseVisualStyleBackColor = true;
			this.btGuess.Click += new System.EventHandler(this.BtGuessClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.btCancel);
			this.flowLayoutPanel1.Controls.Add(this.btOK);
			this.flowLayoutPanel1.Controls.Add(this.linkSupport);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 143);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 29);
			this.flowLayoutPanel1.TabIndex = 17;
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(216, 3);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 23);
			this.btCancel.TabIndex = 19;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btOK
			// 
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(135, 3);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 23);
			this.btOK.TabIndex = 18;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// linkSupport
			// 
			this.linkSupport.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.linkSupport.AutoSize = true;
			this.linkSupport.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
			this.linkSupport.Location = new System.Drawing.Point(16, 8);
			this.linkSupport.Name = "linkSupport";
			this.linkSupport.Size = new System.Drawing.Size(113, 12);
			this.linkSupport.TabIndex = 19;
			this.linkSupport.TabStop = true;
			this.linkSupport.Text = "Visit support page";
			this.linkSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSupportLinkClicked);
			// 
			// lblMsg
			// 
			this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMsg.Location = new System.Drawing.Point(0, 101);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(294, 42);
			this.lblMsg.TabIndex = 18;
			this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(294, 172);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::SRun3KStupid.Properties.SRun3K.internet1;
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Settings - SRun3K Stupid";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.Button btGuess;
		private System.Windows.Forms.CheckBox cbAutoHide;
		private System.Windows.Forms.ComboBox comboMAC;
		private System.Windows.Forms.LinkLabel linkSupport;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.CheckBox cbAutoLogIn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textHost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btMAC;
	}
}
