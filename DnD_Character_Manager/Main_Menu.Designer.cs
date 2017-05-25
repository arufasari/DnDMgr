namespace DnD_Long
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.create_new_character = new System.Windows.Forms.Button();
            this.Load_Character = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_new_character
            // 
            this.create_new_character.BackColor = System.Drawing.Color.DodgerBlue;
            this.create_new_character.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_new_character.Location = new System.Drawing.Point(37, 124);
            this.create_new_character.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.create_new_character.Name = "create_new_character";
            this.create_new_character.Size = new System.Drawing.Size(423, 66);
            this.create_new_character.TabIndex = 4;
            this.create_new_character.TabStop = false;
            this.create_new_character.Text = "Create New Character";
            this.create_new_character.UseVisualStyleBackColor = false;
            this.create_new_character.Click += new System.EventHandler(this.create_new_character_Click_1);
            // 
            // Load_Character
            // 
            this.Load_Character.BackColor = System.Drawing.Color.DodgerBlue;
            this.Load_Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Character.Location = new System.Drawing.Point(37, 250);
            this.Load_Character.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Load_Character.Name = "Load_Character";
            this.Load_Character.Size = new System.Drawing.Size(423, 66);
            this.Load_Character.TabIndex = 5;
            this.Load_Character.TabStop = false;
            this.Load_Character.Text = "Load Character";
            this.Load_Character.UseVisualStyleBackColor = false;
            this.Load_Character.Click += new System.EventHandler(this.Load_Character_Click_1);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(987, 560);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 66);
            this.Exit.TabIndex = 6;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 830);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Load_Character);
            this.Controls.Add(this.create_new_character);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1405, 886);
            this.MinimumSize = new System.Drawing.Size(1405, 886);
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nick Long\'s D&D Manager";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button create_new_character;
        private System.Windows.Forms.Button Load_Character;
        private System.Windows.Forms.Button Exit;
    }
}

