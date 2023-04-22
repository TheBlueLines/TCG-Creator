namespace TCG_Creator
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label1 = new Label();
            countFrom = new TextBox();
            label2 = new Label();
            baseItem = new TextBox();
            save = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 50);
            label1.TabIndex = 0;
            label1.Text = "Start counting from:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countFrom
            // 
            countFrom.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            countFrom.Location = new Point(12, 62);
            countFrom.Name = "countFrom";
            countFrom.Size = new Size(400, 40);
            countFrom.TabIndex = 1;
            countFrom.TextChanged += countFrom_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(400, 50);
            label2.TabIndex = 2;
            label2.Text = "Base Item:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // baseItem
            // 
            baseItem.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            baseItem.Location = new Point(12, 158);
            baseItem.Name = "baseItem";
            baseItem.Size = new Size(400, 40);
            baseItem.TabIndex = 3;
            baseItem.TextChanged += baseItem_TextChanged;
            // 
            // save
            // 
            save.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(12, 204);
            save.Name = "save";
            save.Size = new Size(197, 50);
            save.TabIndex = 4;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancel.Location = new Point(215, 204);
            cancel.Name = "cancel";
            cancel.Size = new Size(197, 50);
            cancel.TabIndex = 5;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 265);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(baseItem);
            Controls.Add(label2);
            Controls.Add(countFrom);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            Text = "Settings";
            FormClosing += Settings_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox countFrom;
        private Label label2;
        private TextBox baseItem;
        private Button save;
        private Button cancel;
    }
}