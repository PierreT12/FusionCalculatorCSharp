namespace Persona_Stat_App
{
    partial class FuseThis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuseThis));
            this.TableView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Arcana = new System.Windows.Forms.Label();
            this.NameDisplay = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.TableView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableView.ForeColor = System.Drawing.SystemColors.Control;
            this.TableView.HideSelection = false;
            this.TableView.Location = new System.Drawing.Point(0, 284);
            this.TableView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(1018, 617);
            this.TableView.TabIndex = 0;
            this.TableView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Level);
            this.groupBox1.Controls.Add(this.NameDisplay);
            this.groupBox1.Controls.Add(this.Arcana);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arcana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // Arcana
            // 
            this.Arcana.AutoSize = true;
            this.Arcana.Location = new System.Drawing.Point(73, 129);
            this.Arcana.Name = "Arcana";
            this.Arcana.Size = new System.Drawing.Size(0, 32);
            this.Arcana.TabIndex = 3;
            // 
            // NameDisplay
            // 
            this.NameDisplay.AutoSize = true;
            this.NameDisplay.Location = new System.Drawing.Point(385, 128);
            this.NameDisplay.Name = "NameDisplay";
            this.NameDisplay.Size = new System.Drawing.Size(0, 32);
            this.NameDisplay.TabIndex = 4;
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(741, 128);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(0, 32);
            this.Level.TabIndex = 5;
            // 
            // FuseThis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1018, 901);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TableView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FuseThis";
            this.Text = "Fusion Page";
            this.Load += new System.EventHandler(this.FuseThis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TableView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label NameDisplay;
        private System.Windows.Forms.Label Arcana;
    }
}