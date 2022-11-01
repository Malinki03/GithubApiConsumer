namespace GithuApiConsumer
{
    partial class UserWindow
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
            this.userTB = new System.Windows.Forms.TextBox();
            this.userL = new System.Windows.Forms.Label();
            this.reposDGV = new System.Windows.Forms.DataGridView();
            this.repositorisL = new System.Windows.Forms.Label();
            this.seguidorsDGV = new System.Windows.Forms.DataGridView();
            this.seguitsDGV = new System.Windows.Forms.DataGridView();
            this.seguidorsL = new System.Windows.Forms.Label();
            this.seguitsL = new System.Windows.Forms.Label();
            this.submButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reposDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguidorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguitsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(58, 38);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(218, 20);
            this.userTB.TabIndex = 0;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Location = new System.Drawing.Point(20, 41);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(32, 13);
            this.userL.TabIndex = 1;
            this.userL.Text = "User:";
            // 
            // reposDGV
            // 
            this.reposDGV.Location = new System.Drawing.Point(311, 38);
            this.reposDGV.Name = "reposDGV";
            this.reposDGV.ReadOnly = true;
            this.reposDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reposDGV.Size = new System.Drawing.Size(218, 400);
            this.reposDGV.TabIndex = 2;
            // 
            // repositorisL
            // 
            this.repositorisL.AutoSize = true;
            this.repositorisL.Location = new System.Drawing.Point(308, 22);
            this.repositorisL.Name = "repositorisL";
            this.repositorisL.Size = new System.Drawing.Size(59, 13);
            this.repositorisL.TabIndex = 3;
            this.repositorisL.Text = "Repositoris";
            this.repositorisL.Click += new System.EventHandler(this.repositorisL_Click);
            // 
            // seguidorsDGV
            // 
            this.seguidorsDGV.Location = new System.Drawing.Point(570, 38);
            this.seguidorsDGV.Name = "seguidorsDGV";
            this.seguidorsDGV.ReadOnly = true;
            this.seguidorsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seguidorsDGV.Size = new System.Drawing.Size(218, 185);
            this.seguidorsDGV.TabIndex = 5;
            // 
            // seguitsDGV
            // 
            this.seguitsDGV.Location = new System.Drawing.Point(570, 255);
            this.seguitsDGV.Name = "seguitsDGV";
            this.seguitsDGV.ReadOnly = true;
            this.seguitsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seguitsDGV.Size = new System.Drawing.Size(218, 183);
            this.seguitsDGV.TabIndex = 6;
            // 
            // seguidorsL
            // 
            this.seguidorsL.AutoSize = true;
            this.seguidorsL.Location = new System.Drawing.Point(567, 22);
            this.seguidorsL.Name = "seguidorsL";
            this.seguidorsL.Size = new System.Drawing.Size(54, 13);
            this.seguidorsL.TabIndex = 7;
            this.seguidorsL.Text = "Seguidors";
            // 
            // seguitsL
            // 
            this.seguitsL.AutoSize = true;
            this.seguitsL.Location = new System.Drawing.Point(567, 239);
            this.seguitsL.Name = "seguitsL";
            this.seguitsL.Size = new System.Drawing.Size(42, 13);
            this.seguitsL.TabIndex = 8;
            this.seguitsL.Text = "Seguits";
            // 
            // submButton
            // 
            this.submButton.Location = new System.Drawing.Point(124, 64);
            this.submButton.Name = "submButton";
            this.submButton.Size = new System.Drawing.Size(84, 23);
            this.submButton.TabIndex = 9;
            this.submButton.Text = "Submit";
            this.submButton.UseVisualStyleBackColor = true;
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submButton);
            this.Controls.Add(this.seguitsL);
            this.Controls.Add(this.seguidorsL);
            this.Controls.Add(this.seguitsDGV);
            this.Controls.Add(this.seguidorsDGV);
            this.Controls.Add(this.repositorisL);
            this.Controls.Add(this.reposDGV);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userTB);
            this.Name = "UserWindow";
            this.Text = "GithubApiConsumer";
            ((System.ComponentModel.ISupportInitialize)(this.reposDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguidorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguitsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox userTB;
        public System.Windows.Forms.Label userL;
        public System.Windows.Forms.DataGridView reposDGV;
        public System.Windows.Forms.Label repositorisL;
        public System.Windows.Forms.DataGridView seguidorsDGV;
        public System.Windows.Forms.DataGridView seguitsDGV;
        public System.Windows.Forms.Label seguidorsL;
        public System.Windows.Forms.Label seguitsL;
        public System.Windows.Forms.Button submButton;
    }
}

