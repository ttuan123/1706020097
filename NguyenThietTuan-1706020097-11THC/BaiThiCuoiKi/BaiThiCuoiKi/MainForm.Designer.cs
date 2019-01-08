/*
 * Created by SharpDevelop.
 * User: C1-A01
 * Date: 1/8/2019
 * Time: 8:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BaiThiCuoiKi
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.tsbTriangle = new System.Windows.Forms.ToolStripButton();
			this.tsbRhombus = new System.Windows.Forms.ToolStripButton();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Red;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbLine,
									this.tsbTriangle,
									this.tsbRhombus});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(778, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbLine
			// 
			this.tsbLine.CheckOnClick = true;
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(36, 35);
			this.tsbLine.Text = " Line";
			this.tsbLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbTriangle
			// 
			this.tsbTriangle.CheckOnClick = true;
			this.tsbTriangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbTriangle.Image")));
			this.tsbTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTriangle.Name = "tsbTriangle";
			this.tsbTriangle.Size = new System.Drawing.Size(54, 35);
			this.tsbTriangle.Text = "Triangle";
			this.tsbTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsbRhombus
			// 
			this.tsbRhombus.CheckOnClick = true;
			this.tsbRhombus.Image = ((System.Drawing.Image)(resources.GetObject("tsbRhombus.Image")));
			this.tsbRhombus.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRhombus.Name = "tsbRhombus";
			this.tsbRhombus.Size = new System.Drawing.Size(62, 35);
			this.tsbRhombus.Text = "Rhombus";
			this.tsbRhombus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 38);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(778, 313);
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 351);
			this.Controls.Add(this.pbDraw);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "BaiThiCuoiKi";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.ToolStripButton tsbRhombus;
		private System.Windows.Forms.ToolStripButton tsbTriangle;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
