namespace TCG_Creator
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            loadImagesToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            setDisplayToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            list = new ListBox();
            picture = new PictureBox();
            make = new Button();
            info = new Label();
            search = new TextBox();
            selectedToolStripMenuItem = new ToolStripMenuItem();
            giveCommandToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolsToolStripMenuItem, selectedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(745, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menu";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadImagesToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(37, 20);
            openToolStripMenuItem.Text = "File";
            // 
            // loadImagesToolStripMenuItem
            // 
            loadImagesToolStripMenuItem.Name = "loadImagesToolStripMenuItem";
            loadImagesToolStripMenuItem.Size = new Size(141, 22);
            loadImagesToolStripMenuItem.Text = "Load Images";
            loadImagesToolStripMenuItem.Click += loadImagesToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setDisplayToolStripMenuItem, settingsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // setDisplayToolStripMenuItem
            // 
            setDisplayToolStripMenuItem.Name = "setDisplayToolStripMenuItem";
            setDisplayToolStripMenuItem.Size = new Size(116, 22);
            setDisplayToolStripMenuItem.Text = "Display";
            setDisplayToolStripMenuItem.Click += setDisplayToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // list
            // 
            list.BorderStyle = BorderStyle.FixedSingle;
            list.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            list.FormattingEnabled = true;
            list.ItemHeight = 33;
            list.Location = new Point(12, 73);
            list.Name = "list";
            list.Size = new Size(200, 464);
            list.TabIndex = 1;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // picture
            // 
            picture.Location = new Point(218, 27);
            picture.Name = "picture";
            picture.Size = new Size(512, 512);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 2;
            picture.TabStop = false;
            // 
            // make
            // 
            make.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            make.Location = new Point(12, 542);
            make.Name = "make";
            make.Size = new Size(200, 42);
            make.TabIndex = 3;
            make.Text = "Make";
            make.UseVisualStyleBackColor = true;
            make.Click += make_Click;
            // 
            // info
            // 
            info.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            info.Location = new Point(218, 542);
            info.Name = "info";
            info.Size = new Size(512, 42);
            info.TabIndex = 4;
            info.Text = "Made by TheBlueLines";
            info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // search
            // 
            search.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.DarkGray;
            search.Location = new Point(12, 27);
            search.Name = "search";
            search.Size = new Size(200, 40);
            search.TabIndex = 5;
            search.Text = "Search";
            search.TextChanged += search_TextChanged;
            search.Enter += search_Enter;
            search.Leave += search_Leave;
            // 
            // selectedToolStripMenuItem
            // 
            selectedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giveCommandToolStripMenuItem });
            selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            selectedToolStripMenuItem.Size = new Size(63, 20);
            selectedToolStripMenuItem.Text = "Selected";
            // 
            // giveCommandToolStripMenuItem
            // 
            giveCommandToolStripMenuItem.Name = "giveCommandToolStripMenuItem";
            giveCommandToolStripMenuItem.Size = new Size(180, 22);
            giveCommandToolStripMenuItem.Text = "Give Command";
            giveCommandToolStripMenuItem.Click += giveCommandToolStripMenuItem_Click;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 591);
            Controls.Add(search);
            Controls.Add(info);
            Controls.Add(make);
            Controls.Add(picture);
            Controls.Add(list);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Base";
            Text = "TCG Creator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem loadImagesToolStripMenuItem;
        private ListBox list;
        private PictureBox picture;
        private Button make;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem setDisplayToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Label info;
        private TextBox search;
        private ToolStripMenuItem selectedToolStripMenuItem;
        private ToolStripMenuItem giveCommandToolStripMenuItem;
    }
}