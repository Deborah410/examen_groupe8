
namespace GestionPersonne.UserControls
{
    partial class Utilisateurs
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSup = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableUser = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btSup
            // 
            this.btSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSup.FlatAppearance.BorderSize = 2;
            this.btSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSup.ForeColor = System.Drawing.Color.Black;
            this.btSup.Location = new System.Drawing.Point(764, 74);
            this.btSup.Name = "btSup";
            this.btSup.Size = new System.Drawing.Size(261, 45);
            this.btSup.TabIndex = 64;
            this.btSup.Text = "Supprimer";
            this.btSup.UseVisualStyleBackColor = true;
            this.btSup.Click += new System.EventHandler(this.btSup_Click);
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdd.FlatAppearance.BorderSize = 2;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(7, 74);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(261, 45);
            this.btAdd.TabIndex = 62;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btMod
            // 
            this.btMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btMod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btMod.FlatAppearance.BorderSize = 2;
            this.btMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMod.ForeColor = System.Drawing.Color.Black;
            this.btMod.Location = new System.Drawing.Point(389, 74);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(261, 45);
            this.btMod.TabIndex = 63;
            this.btMod.Text = "Modifier";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(416, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 43);
            this.label1.TabIndex = 59;
            this.label1.Text = "Utilisateurs";
            // 
            // tableUser
            // 
            this.tableUser.AllowUserToAddRows = false;
            this.tableUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.tableUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.id,
            this.nam,
            this.pwd});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableUser.EnableHeadersVisualStyles = false;
            this.tableUser.GridColor = System.Drawing.Color.Black;
            this.tableUser.Location = new System.Drawing.Point(7, 154);
            this.tableUser.MultiSelect = false;
            this.tableUser.Name = "tableUser";
            this.tableUser.ReadOnly = true;
            this.tableUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableUser.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.tableUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableUser.RowTemplate.Height = 30;
            this.tableUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tableUser.Size = new System.Drawing.Size(1018, 482);
            this.tableUser.TabIndex = 74;
            // 
            // num
            // 
            this.num.FillWeight = 25F;
            this.num.HeaderText = "#";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nam
            // 
            this.nam.HeaderText = "Username";
            this.nam.Name = "nam";
            this.nam.ReadOnly = true;
            // 
            // pwd
            // 
            this.pwd.FillWeight = 200F;
            this.pwd.HeaderText = "Password";
            this.pwd.Name = "pwd";
            this.pwd.ReadOnly = true;
            // 
            // Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableUser);
            this.Controls.Add(this.btSup);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btMod);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Utilisateurs";
            this.Size = new System.Drawing.Size(1028, 639);
            this.Load += new System.EventHandler(this.Utilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSup;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tableUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwd;
    }
}
