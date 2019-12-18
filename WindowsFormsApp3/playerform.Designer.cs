namespace WindowsFormsApp3
{
    partial class mediaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaform));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMp4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.philopateerAtefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirolosMedhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carlosAshrafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.michaelWagdyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirolosAbdallahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.play = new System.Windows.Forms.Button();
            this.rewind = new System.Windows.Forms.Button();
            this.skipback10 = new System.Windows.Forms.Button();
            this.skipahead10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.volumebar = new System.Windows.Forms.TrackBar();
            this.songtrack = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.songpostion = new System.Windows.Forms.Label();
            this.songtime = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openMp4ToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openToolStripMenuItem.Text = "&Open mp3";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openMp4ToolStripMenuItem
            // 
            this.openMp4ToolStripMenuItem.Name = "openMp4ToolStripMenuItem";
            this.openMp4ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openMp4ToolStripMenuItem.Text = "&Open mp4";
            this.openMp4ToolStripMenuItem.Click += new System.EventHandler(this.openMp4ToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(114, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // creditsToToolStripMenuItem
            // 
            this.creditsToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.philopateerAtefToolStripMenuItem,
            this.kirolosMedhatToolStripMenuItem,
            this.carlosAshrafToolStripMenuItem,
            this.michaelWagdyToolStripMenuItem,
            this.kirolosAbdallahToolStripMenuItem});
            this.creditsToToolStripMenuItem.Name = "creditsToToolStripMenuItem";
            this.creditsToToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.creditsToToolStripMenuItem.Text = "Made by:";
            // 
            // philopateerAtefToolStripMenuItem
            // 
            this.philopateerAtefToolStripMenuItem.Name = "philopateerAtefToolStripMenuItem";
            this.philopateerAtefToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.philopateerAtefToolStripMenuItem.Text = "philopateer Atef";
            // 
            // kirolosMedhatToolStripMenuItem
            // 
            this.kirolosMedhatToolStripMenuItem.Name = "kirolosMedhatToolStripMenuItem";
            this.kirolosMedhatToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kirolosMedhatToolStripMenuItem.Text = "kirolos Medhat";
            // 
            // carlosAshrafToolStripMenuItem
            // 
            this.carlosAshrafToolStripMenuItem.Name = "carlosAshrafToolStripMenuItem";
            this.carlosAshrafToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.carlosAshrafToolStripMenuItem.Text = "Carlos Ashraf";
            // 
            // michaelWagdyToolStripMenuItem
            // 
            this.michaelWagdyToolStripMenuItem.Name = "michaelWagdyToolStripMenuItem";
            this.michaelWagdyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.michaelWagdyToolStripMenuItem.Text = "Michael Wagdy";
            // 
            // kirolosAbdallahToolStripMenuItem
            // 
            this.kirolosAbdallahToolStripMenuItem.Name = "kirolosAbdallahToolStripMenuItem";
            this.kirolosAbdallahToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kirolosAbdallahToolStripMenuItem.Text = "Kirolos Abdallah";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = " ";
            this.openFileDialog1.Multiselect = true;
            // 
            // play
            // 
            this.play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("play.BackgroundImage")));
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.Black;
            this.play.Location = new System.Drawing.Point(168, 362);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(73, 72);
            this.play.TabIndex = 2;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // rewind
            // 
            this.rewind.BackColor = System.Drawing.Color.Transparent;
            this.rewind.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_rewind_64;
            this.rewind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rewind.FlatAppearance.BorderSize = 0;
            this.rewind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.rewind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewind.Location = new System.Drawing.Point(27, 390);
            this.rewind.Name = "rewind";
            this.rewind.Size = new System.Drawing.Size(36, 38);
            this.rewind.TabIndex = 3;
            this.rewind.UseVisualStyleBackColor = false;
            this.rewind.Click += new System.EventHandler(this.rewind_Click);
            // 
            // skipback10
            // 
            this.skipback10.BackColor = System.Drawing.Color.Transparent;
            this.skipback10.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_skip_15_seconds_back_64;
            this.skipback10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipback10.FlatAppearance.BorderSize = 0;
            this.skipback10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.skipback10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.skipback10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipback10.ForeColor = System.Drawing.Color.Black;
            this.skipback10.Location = new System.Drawing.Point(107, 373);
            this.skipback10.Name = "skipback10";
            this.skipback10.Size = new System.Drawing.Size(55, 55);
            this.skipback10.TabIndex = 4;
            this.skipback10.UseVisualStyleBackColor = false;
            this.skipback10.Click += new System.EventHandler(this.skipback10_Click);
            // 
            // skipahead10
            // 
            this.skipahead10.BackColor = System.Drawing.Color.Transparent;
            this.skipahead10.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.fmmmmmmmmmmmmmmmmm3;
            this.skipahead10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipahead10.FlatAppearance.BorderSize = 0;
            this.skipahead10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.skipahead10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.skipahead10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipahead10.ForeColor = System.Drawing.Color.Black;
            this.skipahead10.Location = new System.Drawing.Point(249, 373);
            this.skipahead10.Name = "skipahead10";
            this.skipahead10.Size = new System.Drawing.Size(55, 55);
            this.skipahead10.TabIndex = 5;
            this.skipahead10.UseVisualStyleBackColor = false;
            this.skipahead10.Click += new System.EventHandler(this.skipahead10_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icons8_mute_64;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(340, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 38);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // volumebar
            // 
            this.volumebar.AutoSize = false;
            this.volumebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumebar.Location = new System.Drawing.Point(349, 215);
            this.volumebar.Name = "volumebar";
            this.volumebar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumebar.Size = new System.Drawing.Size(27, 169);
            this.volumebar.TabIndex = 10;
            this.volumebar.TabStop = false;
            this.volumebar.Value = 10;
            this.volumebar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // songtrack
            // 
            this.songtrack.AllowDrop = true;
            this.songtrack.AutoSize = false;
            this.songtrack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.songtrack.Location = new System.Drawing.Point(10, 440);
            this.songtrack.Name = "songtrack";
            this.songtrack.Size = new System.Drawing.Size(388, 31);
            this.songtrack.TabIndex = 11;
            this.songtrack.Scroll += new System.EventHandler(this.songtrack_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // songpostion
            // 
            this.songpostion.BackColor = System.Drawing.Color.Transparent;
            this.songpostion.ForeColor = System.Drawing.Color.DarkOrchid;
            this.songpostion.Location = new System.Drawing.Point(12, 478);
            this.songpostion.Name = "songpostion";
            this.songpostion.Size = new System.Drawing.Size(51, 23);
            this.songpostion.TabIndex = 12;
            this.songpostion.Text = "00:00";
            // 
            // songtime
            // 
            this.songtime.BackColor = System.Drawing.Color.Transparent;
            this.songtime.ForeColor = System.Drawing.Color.DarkOrchid;
            this.songtime.Location = new System.Drawing.Point(347, 478);
            this.songtime.Name = "songtime";
            this.songtime.Size = new System.Drawing.Size(51, 23);
            this.songtime.TabIndex = 13;
            this.songtime.Text = "00:00";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 104);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(12, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 51);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(350, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 53);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "prev";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(260, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 19;
            this.button6.Text = "next";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "ksm el list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.pepedance;
            this.pictureBox1.Location = new System.Drawing.Point(168, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 99);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
           
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.pepewhy;
            this.pictureBox2.Location = new System.Drawing.Point(154, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 114);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            
            // 
            // mediaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.S4LwVn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 508);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.songtime);
            this.Controls.Add(this.songpostion);
            this.Controls.Add(this.songtrack);
            this.Controls.Add(this.volumebar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.skipahead10);
            this.Controls.Add(this.skipback10);
            this.Controls.Add(this.rewind);
            this.Controls.Add(this.play);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mediaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaPlayer";
            this.Load += new System.EventHandler(this.mediaform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button rewind;
        private System.Windows.Forms.Button skipback10;
        private System.Windows.Forms.Button skipahead10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar volumebar;
        private System.Windows.Forms.TrackBar songtrack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label songpostion;
        private System.Windows.Forms.Label songtime;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem openMp4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem philopateerAtefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirolosMedhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carlosAshrafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem michaelWagdyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirolosAbdallahToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

