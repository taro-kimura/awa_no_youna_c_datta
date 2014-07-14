/*
 * Created by SharpDevelop.
 * User: taro_kimura
 * Date: 2014/06/26
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hubble
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.distance = new System.Windows.Forms.TextBox();
			this.velocities = new System.Windows.Forms.TextBox();
			this.close = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.read = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.header_distance = new System.Windows.Forms.ColumnHeader();
			this.header_velocities = new System.Windows.Forms.ColumnHeader();
			this.delete = new System.Windows.Forms.Button();
			this.text_clear = new System.Windows.Forms.Button();
			this.list_clear = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "地球から近傍の銀河までの距離";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "その銀河の地球に対する速度";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(107, 127);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(84, 111);
			this.calculate.TabIndex = 8;
			this.calculate.TabStop = false;
			this.calculate.Text = "Calculate";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.CalculateClick);
			// 
			// distance
			// 
			this.distance.Location = new System.Drawing.Point(12, 36);
			this.distance.Name = "distance";
			this.distance.Size = new System.Drawing.Size(179, 19);
			this.distance.TabIndex = 9;
			this.distance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DistanceKeyPress);
			// 
			// velocities
			// 
			this.velocities.Location = new System.Drawing.Point(12, 93);
			this.velocities.Name = "velocities";
			this.velocities.Size = new System.Drawing.Size(179, 19);
			this.velocities.TabIndex = 10;
			this.velocities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VelocitiesKeyPress);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(12, 283);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(84, 71);
			this.close.TabIndex = 11;
			this.close.TabStop = false;
			this.close.Text = "Close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.CloseClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// read
			// 
			this.read.Location = new System.Drawing.Point(107, 283);
			this.read.Name = "read";
			this.read.Size = new System.Drawing.Size(84, 71);
			this.read.TabIndex = 14;
			this.read.TabStop = false;
			this.read.Text = "Read";
			this.read.UseVisualStyleBackColor = true;
			this.read.Click += new System.EventHandler(this.ReadClick);
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(12, 127);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(84, 55);
			this.insert.TabIndex = 15;
			this.insert.Text = "Insert";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.InsertClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.header_distance,
									this.header_velocities});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(209, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(368, 298);
			this.listView1.TabIndex = 16;
			this.listView1.TabStop = false;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.ListView1Click);
			// 
			// header_distance
			// 
			this.header_distance.Text = "distance in units of 10^6 parsecs";
			this.header_distance.Width = 182;
			// 
			// header_velocities
			// 
			this.header_velocities.Text = "measured velocities in km/sec";
			this.header_velocities.Width = 182;
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(209, 324);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(183, 32);
			this.delete.TabIndex = 20;
			this.delete.TabStop = false;
			this.delete.Text = "Delete Line";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.DeleteClick);
			// 
			// text_clear
			// 
			this.text_clear.Location = new System.Drawing.Point(12, 245);
			this.text_clear.Name = "text_clear";
			this.text_clear.Size = new System.Drawing.Size(179, 32);
			this.text_clear.TabIndex = 21;
			this.text_clear.TabStop = false;
			this.text_clear.Text = "Clear TextBox";
			this.text_clear.UseVisualStyleBackColor = true;
			this.text_clear.Click += new System.EventHandler(this.Text_clearClick);
			// 
			// list_clear
			// 
			this.list_clear.Location = new System.Drawing.Point(398, 324);
			this.list_clear.Name = "list_clear";
			this.list_clear.Size = new System.Drawing.Size(179, 32);
			this.list_clear.TabIndex = 22;
			this.list_clear.TabStop = false;
			this.list_clear.Text = "Clear ListView";
			this.list_clear.UseVisualStyleBackColor = true;
			this.list_clear.Click += new System.EventHandler(this.List_clearClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 50);
			this.button1.TabIndex = 23;
			this.button1.TabStop = false;
			this.button1.Text = "update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 366);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.list_clear);
			this.Controls.Add(this.text_clear);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.read);
			this.Controls.Add(this.close);
			this.Controls.Add(this.velocities);
			this.Controls.Add(this.distance);
			this.Controls.Add(this.calculate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Hubble";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button list_clear;
		private System.Windows.Forms.Button text_clear;
		private System.Windows.Forms.ColumnHeader header_velocities;
		private System.Windows.Forms.ColumnHeader header_distance;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button read;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox velocities;
		private System.Windows.Forms.TextBox distance;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
