namespace SpikeyMike
{
    partial class SpikeyMikesMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReplaceObjectsCheck = new System.Windows.Forms.CheckBox();
            this.ReplaceList = new System.Windows.Forms.ListView();
            this.hFind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hReplace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TextFind = new System.Windows.Forms.TextBox();
            this.TextReplace = new System.Windows.Forms.TextBox();
            this.LableFind = new System.Windows.Forms.Label();
            this.LabelReplace = new System.Windows.Forms.Label();
            this.ButtonSelectOBJ = new System.Windows.Forms.Button();
            this.OpenOBJFile = new System.Windows.Forms.OpenFileDialog();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReplaceObjectsCheck
            // 
            this.ReplaceObjectsCheck.AutoSize = true;
            this.ReplaceObjectsCheck.Checked = true;
            this.ReplaceObjectsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplaceObjectsCheck.Location = new System.Drawing.Point(12, 236);
            this.ReplaceObjectsCheck.Name = "ReplaceObjectsCheck";
            this.ReplaceObjectsCheck.Size = new System.Drawing.Size(160, 17);
            this.ReplaceObjectsCheck.TabIndex = 0;
            this.ReplaceObjectsCheck.Text = "Replace objects with groups";
            this.ReplaceObjectsCheck.UseVisualStyleBackColor = true;
            // 
            // ReplaceList
            // 
            this.ReplaceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hFind,
            this.hReplace});
            this.ReplaceList.FullRowSelect = true;
            this.ReplaceList.Location = new System.Drawing.Point(12, 12);
            this.ReplaceList.Name = "ReplaceList";
            this.ReplaceList.Size = new System.Drawing.Size(522, 135);
            this.ReplaceList.TabIndex = 1;
            this.ReplaceList.UseCompatibleStateImageBehavior = false;
            this.ReplaceList.View = System.Windows.Forms.View.Details;
            // 
            // hFind
            // 
            this.hFind.Text = "Find What";
            this.hFind.Width = 240;
            // 
            // hReplace
            // 
            this.hReplace.Text = "Replace With";
            this.hReplace.Width = 240;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(474, 153);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(26, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(474, 182);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(26, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "−";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TextFind
            // 
            this.TextFind.Location = new System.Drawing.Point(94, 155);
            this.TextFind.Name = "TextFind";
            this.TextFind.Size = new System.Drawing.Size(361, 20);
            this.TextFind.TabIndex = 4;
            // 
            // TextReplace
            // 
            this.TextReplace.Location = new System.Drawing.Point(94, 185);
            this.TextReplace.Name = "TextReplace";
            this.TextReplace.Size = new System.Drawing.Size(361, 20);
            this.TextReplace.TabIndex = 5;
            // 
            // LableFind
            // 
            this.LableFind.AutoSize = true;
            this.LableFind.Location = new System.Drawing.Point(13, 158);
            this.LableFind.Name = "LableFind";
            this.LableFind.Size = new System.Drawing.Size(59, 13);
            this.LableFind.TabIndex = 6;
            this.LableFind.Text = "Find What:";
            // 
            // LabelReplace
            // 
            this.LabelReplace.AutoSize = true;
            this.LabelReplace.Location = new System.Drawing.Point(13, 188);
            this.LabelReplace.Name = "LabelReplace";
            this.LabelReplace.Size = new System.Drawing.Size(75, 13);
            this.LabelReplace.TabIndex = 6;
            this.LabelReplace.Text = "Replace With:";
            // 
            // ButtonSelectOBJ
            // 
            this.ButtonSelectOBJ.Location = new System.Drawing.Point(404, 232);
            this.ButtonSelectOBJ.Name = "ButtonSelectOBJ";
            this.ButtonSelectOBJ.Size = new System.Drawing.Size(130, 23);
            this.ButtonSelectOBJ.TabIndex = 7;
            this.ButtonSelectOBJ.Text = "GO!";
            this.ButtonSelectOBJ.UseVisualStyleBackColor = true;
            this.ButtonSelectOBJ.Click += new System.EventHandler(this.ButtonSelectOBJ_Click);
            // 
            // OpenOBJFile
            // 
            this.OpenOBJFile.Filter = "Wavefront OBJ |*.obj|All Files|*.*";
            this.OpenOBJFile.Title = "Select an OBJ File";
            // 
            // ButtonUp
            // 
            this.ButtonUp.Location = new System.Drawing.Point(506, 153);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(26, 23);
            this.ButtonUp.TabIndex = 2;
            this.ButtonUp.Text = "▲";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // ButtonDown
            // 
            this.ButtonDown.Location = new System.Drawing.Point(506, 182);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(26, 23);
            this.ButtonDown.TabIndex = 3;
            this.ButtonDown.Text = "▼";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // SpikeyMikesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 268);
            this.Controls.Add(this.ButtonSelectOBJ);
            this.Controls.Add(this.LabelReplace);
            this.Controls.Add(this.LableFind);
            this.Controls.Add(this.TextReplace);
            this.Controls.Add(this.TextFind);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReplaceList);
            this.Controls.Add(this.ReplaceObjectsCheck);
            this.Name = "SpikeyMikesMain";
            this.Text = "Spikey Mikes - \"Your One Stop Tool Shop\" - The .obj Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ReplaceObjectsCheck;
        private System.Windows.Forms.ListView ReplaceList;
        private System.Windows.Forms.ColumnHeader hFind;
        private System.Windows.Forms.ColumnHeader hReplace;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox TextFind;
        private System.Windows.Forms.TextBox TextReplace;
        private System.Windows.Forms.Label LableFind;
        private System.Windows.Forms.Label LabelReplace;
        private System.Windows.Forms.Button ButtonSelectOBJ;
        private System.Windows.Forms.OpenFileDialog OpenOBJFile;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonDown;
    }
}

