namespace Persona_Stat_App
{
    partial class info_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info_Form));
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.display_Box = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.Settings = new DarkUI.Controls.DarkButton();
            this.wikiLink = new DarkUI.Controls.DarkButton();
            this.FuseButton = new DarkUI.Controls.DarkButton();
            this.ForwardFuse = new DarkUI.Controls.DarkButton();
            this.Information = new DarkUI.Controls.DarkGroupBox();
            this.Arcana = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.Level = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.Persona_Name = new DarkUI.Controls.DarkLabel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.Elemental = new System.Windows.Forms.ImageList(this.components);
            this.Stats = new System.Windows.Forms.ListView();
            this.magic_View = new System.Windows.Forms.ListView();
            this.display_Personas = new System.Windows.Forms.ListBox();
            this.label4 = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.display_Box)).BeginInit();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(10, 44);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(172, 22);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "Search";
            // 
            // display_Box
            // 
            this.display_Box.ErrorImage = ((System.Drawing.Image)(resources.GetObject("display_Box.ErrorImage")));
            this.display_Box.Image = ((System.Drawing.Image)(resources.GetObject("display_Box.Image")));
            this.display_Box.InitialImage = null;
            this.display_Box.Location = new System.Drawing.Point(222, 12);
            this.display_Box.Name = "display_Box";
            this.display_Box.Size = new System.Drawing.Size(319, 312);
            this.display_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.display_Box.TabIndex = 2;
            this.display_Box.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBox.Location = new System.Drawing.Point(10, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(172, 20);
            this.searchBox.TabIndex = 3;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(28, 529);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(5);
            this.Settings.Size = new System.Drawing.Size(139, 29);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click_1);
            // 
            // wikiLink
            // 
            this.wikiLink.Location = new System.Drawing.Point(572, 19);
            this.wikiLink.Name = "wikiLink";
            this.wikiLink.Padding = new System.Windows.Forms.Padding(5);
            this.wikiLink.Size = new System.Drawing.Size(115, 47);
            this.wikiLink.TabIndex = 5;
            this.wikiLink.Text = "Wiki Link";
            this.wikiLink.Click += new System.EventHandler(this.wikiLink_Click);
            // 
            // FuseButton
            // 
            this.FuseButton.Location = new System.Drawing.Point(572, 131);
            this.FuseButton.Name = "FuseButton";
            this.FuseButton.Padding = new System.Windows.Forms.Padding(5);
            this.FuseButton.Size = new System.Drawing.Size(115, 47);
            this.FuseButton.TabIndex = 6;
            this.FuseButton.Text = "Fuse This!";
            this.FuseButton.Click += new System.EventHandler(this.FuseButton_Click);
            // 
            // ForwardFuse
            // 
            this.ForwardFuse.Location = new System.Drawing.Point(572, 245);
            this.ForwardFuse.Name = "ForwardFuse";
            this.ForwardFuse.Padding = new System.Windows.Forms.Padding(5);
            this.ForwardFuse.Size = new System.Drawing.Size(115, 47);
            this.ForwardFuse.TabIndex = 7;
            this.ForwardFuse.Text = "Fuse From This!";
            // 
            // Information
            // 
            this.Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Information.Controls.Add(this.Arcana);
            this.Information.Controls.Add(this.darkLabel6);
            this.Information.Controls.Add(this.Level);
            this.Information.Controls.Add(this.darkLabel4);
            this.Information.Controls.Add(this.Persona_Name);
            this.Information.Controls.Add(this.darkLabel1);
            this.Information.Location = new System.Drawing.Point(557, 355);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(130, 203);
            this.Information.TabIndex = 10;
            this.Information.TabStop = false;
            this.Information.Text = "General Information";
            // 
            // Arcana
            // 
            this.Arcana.AutoSize = true;
            this.Arcana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Arcana.Location = new System.Drawing.Point(14, 185);
            this.Arcana.Name = "Arcana";
            this.Arcana.Size = new System.Drawing.Size(41, 13);
            this.Arcana.TabIndex = 5;
            this.Arcana.Text = "Arcana";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(14, 161);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(47, 13);
            this.darkLabel6.TabIndex = 4;
            this.darkLabel6.Text = "Arcana: ";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Level.Location = new System.Drawing.Point(14, 115);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(33, 13);
            this.Level.TabIndex = 3;
            this.Level.Text = "Level";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(14, 91);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(39, 13);
            this.darkLabel4.TabIndex = 2;
            this.darkLabel4.Text = "Level: ";
            // 
            // Persona_Name
            // 
            this.Persona_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Persona_Name.Location = new System.Drawing.Point(14, 49);
            this.Persona_Name.Name = "Persona_Name";
            this.Persona_Name.Size = new System.Drawing.Size(110, 42);
            this.Persona_Name.TabIndex = 1;
            this.Persona_Name.Text = "Persona";
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(14, 22);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(49, 13);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Persona:";
            // 
            // Elemental
            // 
            this.Elemental.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Elemental.ImageStream")));
            this.Elemental.TransparentColor = System.Drawing.Color.Transparent;
            this.Elemental.Images.SetKeyName(0, "Melee_Icon_P5.png");
            this.Elemental.Images.SetKeyName(1, "Ranged_Icon_P5.png");
            this.Elemental.Images.SetKeyName(2, "Fire_Icon_P5.png");
            this.Elemental.Images.SetKeyName(3, "Ice_Icon_P5.png");
            this.Elemental.Images.SetKeyName(4, "Elec_Icon_P5.png");
            this.Elemental.Images.SetKeyName(5, "Wind_Icon_P5.png");
            this.Elemental.Images.SetKeyName(6, "Nuclear_Icon_P5.png");
            this.Elemental.Images.SetKeyName(7, "Psy_Icon_P5.png");
            this.Elemental.Images.SetKeyName(8, "Light_Icon_P5.png");
            this.Elemental.Images.SetKeyName(9, "Dark_Icon_P5.png");
            // 
            // Stats
            // 
            this.Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.Stats.ForeColor = System.Drawing.SystemColors.Control;
            this.Stats.HideSelection = false;
            this.Stats.Location = new System.Drawing.Point(235, 355);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(128, 203);
            this.Stats.TabIndex = 11;
            this.Stats.UseCompatibleStateImageBehavior = false;
            // 
            // magic_View
            // 
            this.magic_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.magic_View.ForeColor = System.Drawing.SystemColors.Control;
            this.magic_View.HideSelection = false;
            this.magic_View.Location = new System.Drawing.Point(413, 355);
            this.magic_View.Name = "magic_View";
            this.magic_View.Size = new System.Drawing.Size(128, 203);
            this.magic_View.SmallImageList = this.Elemental;
            this.magic_View.TabIndex = 12;
            this.magic_View.UseCompatibleStateImageBehavior = false;
            this.magic_View.View = System.Windows.Forms.View.Tile;
            // 
            // display_Personas
            // 
            this.display_Personas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.display_Personas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_Personas.ForeColor = System.Drawing.SystemColors.Control;
            this.display_Personas.FormattingEnabled = true;
            this.display_Personas.Location = new System.Drawing.Point(11, 86);
            this.display_Personas.Name = "display_Personas";
            this.display_Personas.Size = new System.Drawing.Size(171, 366);
            this.display_Personas.TabIndex = 13;
            this.display_Personas.SelectedIndexChanged += new System.EventHandler(this.display_Personas_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(109, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "darkLabel2";
            this.label4.Visible = false;
            // 
            // info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(702, 596);
            this.Controls.Add(this.display_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.display_Personas);
            this.Controls.Add(this.magic_View);
            this.Controls.Add(this.Stats);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.ForwardFuse);
            this.Controls.Add(this.FuseButton);
            this.Controls.Add(this.wikiLink);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.darkButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "info_Form";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.display_Box)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.PictureBox display_Box;
        private System.Windows.Forms.TextBox searchBox;
        private DarkUI.Controls.DarkButton Settings;
        private DarkUI.Controls.DarkButton wikiLink;
        private DarkUI.Controls.DarkButton FuseButton;
        private DarkUI.Controls.DarkButton ForwardFuse;
        private DarkUI.Controls.DarkGroupBox Information;
        private DarkUI.Controls.DarkLabel Arcana;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel Level;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel Persona_Name;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.ImageList Elemental;
        private System.Windows.Forms.ListView Stats;
        private System.Windows.Forms.ListView magic_View;
        private System.Windows.Forms.ListBox display_Personas;
        private DarkUI.Controls.DarkLabel label4;
    }
}

