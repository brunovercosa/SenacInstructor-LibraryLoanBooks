namespace LibraryLoanBooks
{
    partial class frmPrincipal
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPagePublishCompany = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabPageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublishCompany);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBook);
            this.tabPrincipal.Controls.Add(this.tabPageClient);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Autores";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.LightCyan;
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(8, 158);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 504);
            this.pnlAuthor.TabIndex = 6;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 146);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Search;
            this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchAuthor.Location = new System.Drawing.Point(401, 52);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnSearchAuthor.TabIndex = 9;
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(197, 64);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(175, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            // 
            // txtAuthorNameSearch
            // 
            this.txtAuthorNameSearch.Location = new System.Drawing.Point(6, 64);
            this.txtAuthorNameSearch.Name = "txtAuthorNameSearch";
            this.txtAuthorNameSearch.Size = new System.Drawing.Size(175, 29);
            this.txtAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(197, 35);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(126, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do autor";
            // 
            // tabPagePublishCompany
            // 
            this.tabPagePublishCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishCompany.Name = "tabPagePublishCompany";
            this.tabPagePublishCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishCompany.TabIndex = 2;
            this.tabPagePublishCompany.Text = "Editoras";
            this.tabPagePublishCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1206, 683);
            this.tabPageBook.TabIndex = 4;
            this.tabPageBook.Text = "Livros";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1206, 683);
            this.tabPageClient.TabIndex = 5;
            this.tabPageClient.Text = "Clientes";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(5, 148);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1181, 351);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackColor = System.Drawing.Color.White;
            this.btnNewAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewAuthor.FlatAppearance.BorderSize = 0;
            this.btnNewAuthor.Location = new System.Drawing.Point(18, 13);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = false;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackColor = System.Drawing.Color.White;
            this.btnEditAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Edit;
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditAuthor.FlatAppearance.BorderSize = 0;
            this.btnEditAuthor.Location = new System.Drawing.Point(82, 13);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.BackgroundImage = global::LibraryLoanBooks.Properties.Resources.Delete;
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAuthor.FlatAppearance.BorderSize = 0;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(149, 13);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 3;
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.pnlAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private GroupBox groupBoxSearchAuthor;
        private Button btnSearchAuthor;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox txtAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private TabPage tabPagePublishCompany;
        private TabPage tabPageTheme;
        private TabPage tabPageBook;
        private TabPage tabPageClient;
        private StatusStrip statusStrip1;
        private Panel pnlAuthor;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
    }
}