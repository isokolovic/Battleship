﻿
namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelLastTargetHuman = new System.Windows.Forms.Label();
            this.labelLastTargetComputer = new System.Windows.Forms.Label();
            this.labelShipsLeftHuman = new System.Windows.Forms.Label();
            this.labelShipsLeftComputer = new System.Windows.Forms.Label();
            this.buttonResetShips = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(425, 247);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(220, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelLastTargetHuman
            // 
            this.labelLastTargetHuman.AutoSize = true;
            this.labelLastTargetHuman.Location = new System.Drawing.Point(60, 35);
            this.labelLastTargetHuman.Name = "labelLastTargetHuman";
            this.labelLastTargetHuman.Size = new System.Drawing.Size(57, 13);
            this.labelLastTargetHuman.TabIndex = 1;
            this.labelLastTargetHuman.Text = "Last target";
            // 
            // labelLastTargetComputer
            // 
            this.labelLastTargetComputer.AutoSize = true;
            this.labelLastTargetComputer.Location = new System.Drawing.Point(600, 35);
            this.labelLastTargetComputer.Name = "labelLastTargetComputer";
            this.labelLastTargetComputer.Size = new System.Drawing.Size(57, 13);
            this.labelLastTargetComputer.TabIndex = 2;
            this.labelLastTargetComputer.Text = "Last target";
            // 
            // labelShipsLeftHuman
            // 
            this.labelShipsLeftHuman.AutoSize = true;
            this.labelShipsLeftHuman.Location = new System.Drawing.Point(220, 35);
            this.labelShipsLeftHuman.Name = "labelShipsLeftHuman";
            this.labelShipsLeftHuman.Size = new System.Drawing.Size(50, 13);
            this.labelShipsLeftHuman.TabIndex = 3;
            this.labelShipsLeftHuman.Text = "Ships left";
            // 
            // labelShipsLeftComputer
            // 
            this.labelShipsLeftComputer.AutoSize = true;
            this.labelShipsLeftComputer.Location = new System.Drawing.Point(760, 35);
            this.labelShipsLeftComputer.Name = "labelShipsLeftComputer";
            this.labelShipsLeftComputer.Size = new System.Drawing.Size(50, 13);
            this.labelShipsLeftComputer.TabIndex = 4;
            this.labelShipsLeftComputer.Text = "Ships left";
            // 
            // buttonResetShips
            // 
            this.buttonResetShips.Location = new System.Drawing.Point(0, 0);
            this.buttonResetShips.Name = "buttonResetShips";
            this.buttonResetShips.Size = new System.Drawing.Size(75, 23);
            this.buttonResetShips.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 534);
            this.Controls.Add(this.labelShipsLeftComputer);
            this.Controls.Add(this.labelShipsLeftHuman);
            this.Controls.Add(this.labelLastTargetComputer);
            this.Controls.Add(this.labelLastTargetHuman);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Battleship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelLastTargetHuman;
        private System.Windows.Forms.Label labelLastTargetComputer;
        private System.Windows.Forms.Label labelShipsLeftHuman;
        private System.Windows.Forms.Label labelShipsLeftComputer;
        private System.Windows.Forms.Button buttonResetShips;
    }
}

