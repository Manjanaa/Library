namespace Library
{
    partial class FrmLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooksBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBooksBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBooksAuthorId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.dataGridViewBooksPublisherId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorBooks = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorBooksAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorBooksDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBooksPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorBooksSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBooksMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorBooksSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBooksSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorBooksPrint = new System.Windows.Forms.ToolStripButton();
            this.panelAuthors = new System.Windows.Forms.Panel();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridViewAuthorsAuthorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAuthorsAuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAuthors = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAuthorsAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorAuthorsDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAuthorsPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorAuthorsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAuthorsMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAuthorsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAuthorsSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAuthorsPrint = new System.Windows.Forms.ToolStripButton();
            this.panelPublishers = new System.Windows.Forms.Panel();
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxPublisherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorPublishers = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorPublishersAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPublishersDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPublishersPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorPublishersSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPublishersMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPublishersSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPublishersSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPublishersPrint = new System.Windows.Forms.ToolStripButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.toolStripMenuItemQuestionmarkAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpenBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpenAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpenPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorMenuFile1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorMenuFile2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewShowHideIDs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuestionmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuestionmarkHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorMenuQuestionmark1 = new System.Windows.Forms.ToolStripSeparator();
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.authorsTableAdapter = new Library.LibraryDataSetTableAdapters.AuthorsTableAdapter();
            this.publishersTableAdapter = new Library.LibraryDataSetTableAdapters.PublishersTableAdapter();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBooks)).BeginInit();
            this.bindingNavigatorBooks.SuspendLayout();
            this.panelAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAuthors)).BeginInit();
            this.bindingNavigatorAuthors.SuspendLayout();
            this.panelPublishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPublishers)).BeginInit();
            this.bindingNavigatorPublishers.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 385);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(780, 22);
            this.statusStripMain.TabIndex = 9;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.btnPublishers);
            this.panelButtons.Controls.Add(this.btnAuthors);
            this.panelButtons.Controls.Add(this.btnBooks);
            this.panelButtons.Controls.Add(this.btnExit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(20, 20);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(20);
            this.panelButtons.MinimumSize = new System.Drawing.Size(116, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(116, 321);
            this.panelButtons.TabIndex = 6;
            // 
            // btnPublishers
            // 
            this.btnPublishers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPublishers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishers.Location = new System.Drawing.Point(19, 115);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(74, 29);
            this.btnPublishers.TabIndex = 2;
            this.btnPublishers.Text = "Publishers";
            this.btnPublishers.UseVisualStyleBackColor = false;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAuthors.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthors.Location = new System.Drawing.Point(19, 67);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(74, 30);
            this.btnAuthors.TabIndex = 1;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBooks.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(19, 19);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(74, 30);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(19, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelBooks);
            this.panelRight.Controls.Add(this.panelPublishers);
            this.panelRight.Controls.Add(this.panelAuthors);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(156, 24);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.panelRight.Size = new System.Drawing.Size(624, 361);
            this.panelRight.TabIndex = 11;
            // 
            // panelBooks
            // 
            this.panelBooks.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBooks.Controls.Add(this.dataGridViewBooks);
            this.panelBooks.Controls.Add(this.bindingNavigatorBooks);
            this.panelBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBooks.Location = new System.Drawing.Point(0, 20);
            this.panelBooks.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(604, 321);
            this.panelBooks.TabIndex = 3;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewBooksBookId,
            this.dataGridViewBooksBookTitle,
            this.dataGridViewBooksAuthorId,
            this.dataGridViewBooksPublisherId});
            this.dataGridViewBooks.DataSource = this.booksBindingSource;
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(600, 292);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // dataGridViewBooksBookId
            // 
            this.dataGridViewBooksBookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewBooksBookId.DataPropertyName = "BookId";
            this.dataGridViewBooksBookId.HeaderText = "BookId";
            this.dataGridViewBooksBookId.Name = "dataGridViewBooksBookId";
            this.dataGridViewBooksBookId.ReadOnly = true;
            this.dataGridViewBooksBookId.Visible = false;
            // 
            // dataGridViewBooksBookTitle
            // 
            this.dataGridViewBooksBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewBooksBookTitle.DataPropertyName = "BookTitle";
            this.dataGridViewBooksBookTitle.HeaderText = "Title";
            this.dataGridViewBooksBookTitle.Name = "dataGridViewBooksBookTitle";
            // 
            // dataGridViewBooksAuthorId
            // 
            this.dataGridViewBooksAuthorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewBooksAuthorId.DataPropertyName = "AuthorId";
            this.dataGridViewBooksAuthorId.DataSource = this.authorsBindingSource;
            this.dataGridViewBooksAuthorId.DisplayMember = "AuthorName";
            this.dataGridViewBooksAuthorId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewBooksAuthorId.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewBooksAuthorId.HeaderText = "Author";
            this.dataGridViewBooksAuthorId.Name = "dataGridViewBooksAuthorId";
            this.dataGridViewBooksAuthorId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooksAuthorId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewBooksAuthorId.ValueMember = "AuthorId";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewBooksPublisherId
            // 
            this.dataGridViewBooksPublisherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewBooksPublisherId.DataPropertyName = "PublisherId";
            this.dataGridViewBooksPublisherId.DataSource = this.publishersBindingSource;
            this.dataGridViewBooksPublisherId.DisplayMember = "PublisherName";
            this.dataGridViewBooksPublisherId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewBooksPublisherId.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewBooksPublisherId.HeaderText = "Publisher";
            this.dataGridViewBooksPublisherId.Name = "dataGridViewBooksPublisherId";
            this.dataGridViewBooksPublisherId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooksPublisherId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewBooksPublisherId.ValueMember = "PublisherId";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDataSet;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // bindingNavigatorBooks
            // 
            this.bindingNavigatorBooks.AddNewItem = this.bindingNavigatorBooksAddNewItem;
            this.bindingNavigatorBooks.BindingSource = this.booksBindingSource;
            this.bindingNavigatorBooks.CountItem = this.bindingNavigatorBooksCountItem;
            this.bindingNavigatorBooks.DeleteItem = this.bindingNavigatorBooksDeleteItem;
            this.bindingNavigatorBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorBooksMoveFirstItem,
            this.bindingNavigatorBooksMovePreviousItem,
            this.bindingNavigatorBooksSeparator1,
            this.bindingNavigatorBooksPositionItem,
            this.bindingNavigatorBooksCountItem,
            this.bindingNavigatorBooksSeparator2,
            this.bindingNavigatorBooksMoveNextItem,
            this.bindingNavigatorBooksMoveLastItem,
            this.bindingNavigatorBooksSeparator3,
            this.bindingNavigatorBooksAddNewItem,
            this.bindingNavigatorBooksDeleteItem,
            this.toolStripSeparator5,
            this.bindingNavigatorBooksSaveItem,
            this.toolStripSeparator4,
            this.bindingNavigatorBooksPrint});
            this.bindingNavigatorBooks.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorBooks.MoveFirstItem = this.bindingNavigatorBooksMoveFirstItem;
            this.bindingNavigatorBooks.MoveLastItem = this.bindingNavigatorBooksMoveLastItem;
            this.bindingNavigatorBooks.MoveNextItem = this.bindingNavigatorBooksMoveNextItem;
            this.bindingNavigatorBooks.MovePreviousItem = this.bindingNavigatorBooksMovePreviousItem;
            this.bindingNavigatorBooks.Name = "bindingNavigatorBooks";
            this.bindingNavigatorBooks.PositionItem = this.bindingNavigatorBooksPositionItem;
            this.bindingNavigatorBooks.Size = new System.Drawing.Size(600, 25);
            this.bindingNavigatorBooks.TabIndex = 0;
            this.bindingNavigatorBooks.Text = "bindingNavigatorBooks";
            // 
            // bindingNavigatorBooksAddNewItem
            // 
            this.bindingNavigatorBooksAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksAddNewItem.Image")));
            this.bindingNavigatorBooksAddNewItem.Name = "bindingNavigatorBooksAddNewItem";
            this.bindingNavigatorBooksAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorBooksCountItem
            // 
            this.bindingNavigatorBooksCountItem.Name = "bindingNavigatorBooksCountItem";
            this.bindingNavigatorBooksCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorBooksCountItem.Text = "von {0}";
            this.bindingNavigatorBooksCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorBooksDeleteItem
            // 
            this.bindingNavigatorBooksDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksDeleteItem.Image")));
            this.bindingNavigatorBooksDeleteItem.Name = "bindingNavigatorBooksDeleteItem";
            this.bindingNavigatorBooksDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorBooksMoveFirstItem
            // 
            this.bindingNavigatorBooksMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksMoveFirstItem.Image")));
            this.bindingNavigatorBooksMoveFirstItem.Name = "bindingNavigatorBooksMoveFirstItem";
            this.bindingNavigatorBooksMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorBooksMovePreviousItem
            // 
            this.bindingNavigatorBooksMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksMovePreviousItem.Image")));
            this.bindingNavigatorBooksMovePreviousItem.Name = "bindingNavigatorBooksMovePreviousItem";
            this.bindingNavigatorBooksMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorBooksSeparator1
            // 
            this.bindingNavigatorBooksSeparator1.Name = "bindingNavigatorBooksSeparator1";
            this.bindingNavigatorBooksSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBooksPositionItem
            // 
            this.bindingNavigatorBooksPositionItem.AccessibleName = "Position";
            this.bindingNavigatorBooksPositionItem.AutoSize = false;
            this.bindingNavigatorBooksPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorBooksPositionItem.Name = "bindingNavigatorBooksPositionItem";
            this.bindingNavigatorBooksPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorBooksPositionItem.Text = "0";
            this.bindingNavigatorBooksPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorBooksSeparator2
            // 
            this.bindingNavigatorBooksSeparator2.Name = "bindingNavigatorBooksSeparator2";
            this.bindingNavigatorBooksSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBooksMoveNextItem
            // 
            this.bindingNavigatorBooksMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksMoveNextItem.Image")));
            this.bindingNavigatorBooksMoveNextItem.Name = "bindingNavigatorBooksMoveNextItem";
            this.bindingNavigatorBooksMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorBooksMoveLastItem
            // 
            this.bindingNavigatorBooksMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksMoveLastItem.Image")));
            this.bindingNavigatorBooksMoveLastItem.Name = "bindingNavigatorBooksMoveLastItem";
            this.bindingNavigatorBooksMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorBooksMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorBooksSeparator3
            // 
            this.bindingNavigatorBooksSeparator3.Name = "bindingNavigatorBooksSeparator3";
            this.bindingNavigatorBooksSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBooksSaveItem
            // 
            this.bindingNavigatorBooksSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksSaveItem.Image")));
            this.bindingNavigatorBooksSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorBooksSaveItem.Name = "bindingNavigatorBooksSaveItem";
            this.bindingNavigatorBooksSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksSaveItem.Text = "&Speichern";
            this.bindingNavigatorBooksSaveItem.Click += new System.EventHandler(this.bindingNavigatorBooksSaveItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorBooksPrint
            // 
            this.bindingNavigatorBooksPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorBooksPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorBooksPrint.Image")));
            this.bindingNavigatorBooksPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorBooksPrint.Name = "bindingNavigatorBooksPrint";
            this.bindingNavigatorBooksPrint.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorBooksPrint.Text = "&Drucken";
            this.bindingNavigatorBooksPrint.Click += new System.EventHandler(this.bindingNavigatorBooksPrint_Click);
            // 
            // panelAuthors
            // 
            this.panelAuthors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAuthors.Controls.Add(this.dataGridViewAuthors);
            this.panelAuthors.Controls.Add(this.bindingNavigatorAuthors);
            this.panelAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthors.Location = new System.Drawing.Point(0, 20);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(604, 321);
            this.panelAuthors.TabIndex = 4;
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AutoGenerateColumns = false;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewAuthorsAuthorId,
            this.dataGridViewAuthorsAuthorName});
            this.dataGridViewAuthors.DataSource = this.authorsBindingSource;
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.Size = new System.Drawing.Size(600, 292);
            this.dataGridViewAuthors.TabIndex = 1;
            // 
            // dataGridViewAuthorsAuthorId
            // 
            this.dataGridViewAuthorsAuthorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAuthorsAuthorId.DataPropertyName = "AuthorId";
            this.dataGridViewAuthorsAuthorId.HeaderText = "AuthorId";
            this.dataGridViewAuthorsAuthorId.Name = "dataGridViewAuthorsAuthorId";
            this.dataGridViewAuthorsAuthorId.ReadOnly = true;
            this.dataGridViewAuthorsAuthorId.Visible = false;
            // 
            // dataGridViewAuthorsAuthorName
            // 
            this.dataGridViewAuthorsAuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewAuthorsAuthorName.DataPropertyName = "AuthorName";
            this.dataGridViewAuthorsAuthorName.HeaderText = "Author";
            this.dataGridViewAuthorsAuthorName.Name = "dataGridViewAuthorsAuthorName";
            // 
            // bindingNavigatorAuthors
            // 
            this.bindingNavigatorAuthors.AddNewItem = this.bindingNavigatorAuthorsAddNewItem;
            this.bindingNavigatorAuthors.BindingSource = this.authorsBindingSource;
            this.bindingNavigatorAuthors.CountItem = this.bindingNavigatorAuthorsCountItem;
            this.bindingNavigatorAuthors.DeleteItem = this.bindingNavigatorAuthorsDeleteItem;
            this.bindingNavigatorAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAuthorsMoveFirstItem,
            this.bindingNavigatorAuthorsMovePreviousItem,
            this.bindingNavigatorAuthorsSeparator1,
            this.bindingNavigatorAuthorsPositionItem,
            this.bindingNavigatorAuthorsCountItem,
            this.bindingNavigatorAuthorsSeparator2,
            this.bindingNavigatorAuthorsMoveNextItem,
            this.bindingNavigatorAuthorsMoveLastItem,
            this.bindingNavigatorAuthorsSeparator3,
            this.bindingNavigatorAuthorsAddNewItem,
            this.bindingNavigatorAuthorsDeleteItem,
            this.toolStripSeparator3,
            this.bindingNavigatorAuthorsSaveItem,
            this.toolStripSeparator2,
            this.bindingNavigatorAuthorsPrint});
            this.bindingNavigatorAuthors.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorAuthors.MoveFirstItem = this.bindingNavigatorAuthorsMoveFirstItem;
            this.bindingNavigatorAuthors.MoveLastItem = this.bindingNavigatorAuthorsMoveLastItem;
            this.bindingNavigatorAuthors.MoveNextItem = this.bindingNavigatorAuthorsMoveNextItem;
            this.bindingNavigatorAuthors.MovePreviousItem = this.bindingNavigatorAuthorsMovePreviousItem;
            this.bindingNavigatorAuthors.Name = "bindingNavigatorAuthors";
            this.bindingNavigatorAuthors.PositionItem = this.bindingNavigatorAuthorsPositionItem;
            this.bindingNavigatorAuthors.Size = new System.Drawing.Size(600, 25);
            this.bindingNavigatorAuthors.TabIndex = 0;
            this.bindingNavigatorAuthors.Text = "bindingNavigatorAuthors";
            // 
            // bindingNavigatorAuthorsAddNewItem
            // 
            this.bindingNavigatorAuthorsAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsAddNewItem.Image")));
            this.bindingNavigatorAuthorsAddNewItem.Name = "bindingNavigatorAuthorsAddNewItem";
            this.bindingNavigatorAuthorsAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorAuthorsCountItem
            // 
            this.bindingNavigatorAuthorsCountItem.Name = "bindingNavigatorAuthorsCountItem";
            this.bindingNavigatorAuthorsCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorAuthorsCountItem.Text = "von {0}";
            this.bindingNavigatorAuthorsCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorAuthorsDeleteItem
            // 
            this.bindingNavigatorAuthorsDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsDeleteItem.Image")));
            this.bindingNavigatorAuthorsDeleteItem.Name = "bindingNavigatorAuthorsDeleteItem";
            this.bindingNavigatorAuthorsDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorAuthorsMoveFirstItem
            // 
            this.bindingNavigatorAuthorsMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsMoveFirstItem.Image")));
            this.bindingNavigatorAuthorsMoveFirstItem.Name = "bindingNavigatorAuthorsMoveFirstItem";
            this.bindingNavigatorAuthorsMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorAuthorsMovePreviousItem
            // 
            this.bindingNavigatorAuthorsMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsMovePreviousItem.Image")));
            this.bindingNavigatorAuthorsMovePreviousItem.Name = "bindingNavigatorAuthorsMovePreviousItem";
            this.bindingNavigatorAuthorsMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorAuthorsSeparator1
            // 
            this.bindingNavigatorAuthorsSeparator1.Name = "bindingNavigatorAuthorsSeparator1";
            this.bindingNavigatorAuthorsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAuthorsPositionItem
            // 
            this.bindingNavigatorAuthorsPositionItem.AccessibleName = "Position";
            this.bindingNavigatorAuthorsPositionItem.AutoSize = false;
            this.bindingNavigatorAuthorsPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorAuthorsPositionItem.Name = "bindingNavigatorAuthorsPositionItem";
            this.bindingNavigatorAuthorsPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorAuthorsPositionItem.Text = "0";
            this.bindingNavigatorAuthorsPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorAuthorsSeparator2
            // 
            this.bindingNavigatorAuthorsSeparator2.Name = "bindingNavigatorAuthorsSeparator2";
            this.bindingNavigatorAuthorsSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAuthorsMoveNextItem
            // 
            this.bindingNavigatorAuthorsMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsMoveNextItem.Image")));
            this.bindingNavigatorAuthorsMoveNextItem.Name = "bindingNavigatorAuthorsMoveNextItem";
            this.bindingNavigatorAuthorsMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorAuthorsMoveLastItem
            // 
            this.bindingNavigatorAuthorsMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsMoveLastItem.Image")));
            this.bindingNavigatorAuthorsMoveLastItem.Name = "bindingNavigatorAuthorsMoveLastItem";
            this.bindingNavigatorAuthorsMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAuthorsMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorAuthorsSeparator3
            // 
            this.bindingNavigatorAuthorsSeparator3.Name = "bindingNavigatorAuthorsSeparator3";
            this.bindingNavigatorAuthorsSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAuthorsSaveItem
            // 
            this.bindingNavigatorAuthorsSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsSaveItem.Image")));
            this.bindingNavigatorAuthorsSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAuthorsSaveItem.Name = "bindingNavigatorAuthorsSaveItem";
            this.bindingNavigatorAuthorsSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsSaveItem.Text = "&Speichern";
            this.bindingNavigatorAuthorsSaveItem.Click += new System.EventHandler(this.bindingNavigatorAuthorsSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAuthorsPrint
            // 
            this.bindingNavigatorAuthorsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAuthorsPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAuthorsPrint.Image")));
            this.bindingNavigatorAuthorsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAuthorsPrint.Name = "bindingNavigatorAuthorsPrint";
            this.bindingNavigatorAuthorsPrint.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAuthorsPrint.Text = "&Drucken";
            this.bindingNavigatorAuthorsPrint.Click += new System.EventHandler(this.bindingNavigatorAuthorsPrint_Click);
            // 
            // panelPublishers
            // 
            this.panelPublishers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPublishers.Controls.Add(this.dataGridViewPublishers);
            this.panelPublishers.Controls.Add(this.bindingNavigatorPublishers);
            this.panelPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPublishers.Location = new System.Drawing.Point(0, 20);
            this.panelPublishers.Name = "panelPublishers";
            this.panelPublishers.Size = new System.Drawing.Size(604, 321);
            this.panelPublishers.TabIndex = 5;
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AutoGenerateColumns = false;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxPublisherId,
            this.dataGridViewTextBoxColumnPublisherName});
            this.dataGridViewPublishers.DataSource = this.publishersBindingSource;
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.Size = new System.Drawing.Size(600, 292);
            this.dataGridViewPublishers.TabIndex = 1;
            // 
            // dataGridViewTextBoxPublisherId
            // 
            this.dataGridViewTextBoxPublisherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxPublisherId.DataPropertyName = "PublisherId";
            this.dataGridViewTextBoxPublisherId.HeaderText = "PublisherId";
            this.dataGridViewTextBoxPublisherId.Name = "dataGridViewTextBoxPublisherId";
            this.dataGridViewTextBoxPublisherId.ReadOnly = true;
            this.dataGridViewTextBoxPublisherId.Visible = false;
            // 
            // dataGridViewTextBoxColumnPublisherName
            // 
            this.dataGridViewTextBoxColumnPublisherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnPublisherName.DataPropertyName = "PublisherName";
            this.dataGridViewTextBoxColumnPublisherName.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumnPublisherName.Name = "dataGridViewTextBoxColumnPublisherName";
            this.dataGridViewTextBoxColumnPublisherName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingNavigatorPublishers
            // 
            this.bindingNavigatorPublishers.AddNewItem = this.bindingNavigatorPublishersAddNewItem;
            this.bindingNavigatorPublishers.BindingSource = this.publishersBindingSource;
            this.bindingNavigatorPublishers.CountItem = this.bindingNavigatorPublishersCountItem;
            this.bindingNavigatorPublishers.DeleteItem = this.bindingNavigatorPublishersDeleteItem;
            this.bindingNavigatorPublishers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPublishersMoveFirstItem,
            this.bindingNavigatorPublishersMovePreviousItem,
            this.bindingNavigatorPublishersSeparator1,
            this.bindingNavigatorPublishersPositionItem,
            this.bindingNavigatorPublishersCountItem,
            this.bindingNavigatorPublishersSeparator2,
            this.bindingNavigatorPublishersMoveNextItem,
            this.bindingNavigatorPublishersMoveLastItem,
            this.bindingNavigatorPublishersSeparator3,
            this.bindingNavigatorPublishersAddNewItem,
            this.bindingNavigatorPublishersDeleteItem,
            this.toolStripSeparator1,
            this.bindingNavigatorPublishersSaveItem,
            this.toolStripSeparator,
            this.bindingNavigatorPublishersPrint});
            this.bindingNavigatorPublishers.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPublishers.MoveFirstItem = this.bindingNavigatorPublishersMoveFirstItem;
            this.bindingNavigatorPublishers.MoveLastItem = this.bindingNavigatorPublishersMoveLastItem;
            this.bindingNavigatorPublishers.MoveNextItem = this.bindingNavigatorPublishersMoveNextItem;
            this.bindingNavigatorPublishers.MovePreviousItem = this.bindingNavigatorPublishersMovePreviousItem;
            this.bindingNavigatorPublishers.Name = "bindingNavigatorPublishers";
            this.bindingNavigatorPublishers.PositionItem = this.bindingNavigatorPublishersPositionItem;
            this.bindingNavigatorPublishers.Size = new System.Drawing.Size(600, 25);
            this.bindingNavigatorPublishers.TabIndex = 0;
            this.bindingNavigatorPublishers.Text = "bindingNavigatorPublishers";
            // 
            // bindingNavigatorPublishersAddNewItem
            // 
            this.bindingNavigatorPublishersAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersAddNewItem.Image")));
            this.bindingNavigatorPublishersAddNewItem.Name = "bindingNavigatorPublishersAddNewItem";
            this.bindingNavigatorPublishersAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorPublishersCountItem
            // 
            this.bindingNavigatorPublishersCountItem.Name = "bindingNavigatorPublishersCountItem";
            this.bindingNavigatorPublishersCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorPublishersCountItem.Text = "von {0}";
            this.bindingNavigatorPublishersCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorPublishersDeleteItem
            // 
            this.bindingNavigatorPublishersDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersDeleteItem.Image")));
            this.bindingNavigatorPublishersDeleteItem.Name = "bindingNavigatorPublishersDeleteItem";
            this.bindingNavigatorPublishersDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorPublishersMoveFirstItem
            // 
            this.bindingNavigatorPublishersMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersMoveFirstItem.Image")));
            this.bindingNavigatorPublishersMoveFirstItem.Name = "bindingNavigatorPublishersMoveFirstItem";
            this.bindingNavigatorPublishersMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorPublishersMovePreviousItem
            // 
            this.bindingNavigatorPublishersMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersMovePreviousItem.Image")));
            this.bindingNavigatorPublishersMovePreviousItem.Name = "bindingNavigatorPublishersMovePreviousItem";
            this.bindingNavigatorPublishersMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorPublishersSeparator1
            // 
            this.bindingNavigatorPublishersSeparator1.Name = "bindingNavigatorPublishersSeparator1";
            this.bindingNavigatorPublishersSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPublishersPositionItem
            // 
            this.bindingNavigatorPublishersPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPublishersPositionItem.AutoSize = false;
            this.bindingNavigatorPublishersPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPublishersPositionItem.Name = "bindingNavigatorPublishersPositionItem";
            this.bindingNavigatorPublishersPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPublishersPositionItem.Text = "0";
            this.bindingNavigatorPublishersPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorPublishersSeparator2
            // 
            this.bindingNavigatorPublishersSeparator2.Name = "bindingNavigatorPublishersSeparator2";
            this.bindingNavigatorPublishersSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPublishersMoveNextItem
            // 
            this.bindingNavigatorPublishersMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersMoveNextItem.Image")));
            this.bindingNavigatorPublishersMoveNextItem.Name = "bindingNavigatorPublishersMoveNextItem";
            this.bindingNavigatorPublishersMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorPublishersMoveLastItem
            // 
            this.bindingNavigatorPublishersMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersMoveLastItem.Image")));
            this.bindingNavigatorPublishersMoveLastItem.Name = "bindingNavigatorPublishersMoveLastItem";
            this.bindingNavigatorPublishersMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorPublishersMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorPublishersSeparator3
            // 
            this.bindingNavigatorPublishersSeparator3.Name = "bindingNavigatorPublishersSeparator3";
            this.bindingNavigatorPublishersSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPublishersSaveItem
            // 
            this.bindingNavigatorPublishersSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersSaveItem.Image")));
            this.bindingNavigatorPublishersSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPublishersSaveItem.Name = "bindingNavigatorPublishersSaveItem";
            this.bindingNavigatorPublishersSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersSaveItem.Text = "&Speichern";
            this.bindingNavigatorPublishersSaveItem.Click += new System.EventHandler(this.bindingNavigatorPublishersSaveItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPublishersPrint
            // 
            this.bindingNavigatorPublishersPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPublishersPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPublishersPrint.Image")));
            this.bindingNavigatorPublishersPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPublishersPrint.Name = "bindingNavigatorPublishersPrint";
            this.bindingNavigatorPublishersPrint.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorPublishersPrint.Text = "&Drucken";
            this.bindingNavigatorPublishersPrint.Click += new System.EventHandler(this.bindingNavigatorPublishersPrint_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelLeft.Size = new System.Drawing.Size(156, 361);
            this.panelLeft.TabIndex = 10;
            // 
            // toolStripMenuItemQuestionmarkAbout
            // 
            this.toolStripMenuItemQuestionmarkAbout.Name = "toolStripMenuItemQuestionmarkAbout";
            this.toolStripMenuItemQuestionmarkAbout.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemQuestionmarkAbout.Text = "About Library";
            this.toolStripMenuItemQuestionmarkAbout.Click += new System.EventHandler(this.toolStripMenuItemQuestionmarkAbout_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemView,
            this.toolStripMenuItemQuestionmark});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(780, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileOpen,
            this.saveToolStripMenuItem,
            this.toolStripSeparatorMenuFile1,
            this.toolStripMenuItemFilePrint,
            this.toolStripSeparatorMenuFile2,
            this.toolStripMenuItemFileExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemFileOpen
            // 
            this.toolStripMenuItemFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileOpenBooks,
            this.toolStripMenuItemFileOpenAuthors,
            this.toolStripMenuItemFileOpenPublishers});
            this.toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            this.toolStripMenuItemFileOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemFileOpen.Text = "Open";
            // 
            // toolStripMenuItemFileOpenBooks
            // 
            this.toolStripMenuItemFileOpenBooks.Name = "toolStripMenuItemFileOpenBooks";
            this.toolStripMenuItemFileOpenBooks.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemFileOpenBooks.Text = "Books";
            this.toolStripMenuItemFileOpenBooks.Click += new System.EventHandler(this.toolStripMenuItemFileOpenBooks_Click);
            // 
            // toolStripMenuItemFileOpenAuthors
            // 
            this.toolStripMenuItemFileOpenAuthors.Name = "toolStripMenuItemFileOpenAuthors";
            this.toolStripMenuItemFileOpenAuthors.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemFileOpenAuthors.Text = "Authors";
            this.toolStripMenuItemFileOpenAuthors.Click += new System.EventHandler(this.toolStripMenuItemFileOpenAuthors_Click);
            // 
            // toolStripMenuItemFileOpenPublishers
            // 
            this.toolStripMenuItemFileOpenPublishers.Name = "toolStripMenuItemFileOpenPublishers";
            this.toolStripMenuItemFileOpenPublishers.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemFileOpenPublishers.Text = "Publishers";
            this.toolStripMenuItemFileOpenPublishers.Click += new System.EventHandler(this.toolStripMenuItemFileOpenPublishers_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparatorMenuFile1
            // 
            this.toolStripSeparatorMenuFile1.Name = "toolStripSeparatorMenuFile1";
            this.toolStripSeparatorMenuFile1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemFilePrint
            // 
            this.toolStripMenuItemFilePrint.Name = "toolStripMenuItemFilePrint";
            this.toolStripMenuItemFilePrint.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemFilePrint.Text = "Print";
            this.toolStripMenuItemFilePrint.Click += new System.EventHandler(this.toolStripMenuItemFilePrint_Click);
            // 
            // toolStripSeparatorMenuFile2
            // 
            this.toolStripSeparatorMenuFile2.Name = "toolStripSeparatorMenuFile2";
            this.toolStripSeparatorMenuFile2.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemFileExit
            // 
            this.toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            this.toolStripMenuItemFileExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemFileExit.Text = "Exit";
            this.toolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditCut,
            this.toolStripMenuItemEditCopy,
            this.toolStripMenuItemEditPaste,
            this.toolStripMenuItemEditDelete});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemEditCut
            // 
            this.toolStripMenuItemEditCut.Name = "toolStripMenuItemEditCut";
            this.toolStripMenuItemEditCut.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditCut.Text = "Cut";
            this.toolStripMenuItemEditCut.Click += new System.EventHandler(this.toolStripMenuItemEditCut_Click);
            // 
            // toolStripMenuItemEditCopy
            // 
            this.toolStripMenuItemEditCopy.Name = "toolStripMenuItemEditCopy";
            this.toolStripMenuItemEditCopy.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditCopy.Text = "Copy";
            this.toolStripMenuItemEditCopy.Click += new System.EventHandler(this.toolStripMenuItemEditCopy_Click);
            // 
            // toolStripMenuItemEditPaste
            // 
            this.toolStripMenuItemEditPaste.Name = "toolStripMenuItemEditPaste";
            this.toolStripMenuItemEditPaste.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditPaste.Text = "Paste";
            this.toolStripMenuItemEditPaste.Click += new System.EventHandler(this.toolStripMenuItemEditPaste_Click);
            // 
            // toolStripMenuItemEditDelete
            // 
            this.toolStripMenuItemEditDelete.Name = "toolStripMenuItemEditDelete";
            this.toolStripMenuItemEditDelete.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemEditDelete.Text = "Delete";
            this.toolStripMenuItemEditDelete.Click += new System.EventHandler(this.toolStripMenuItemEditDelete_Click);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewShowHideIDs});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemView.Text = "View";
            // 
            // toolStripMenuItemViewShowHideIDs
            // 
            this.toolStripMenuItemViewShowHideIDs.Name = "toolStripMenuItemViewShowHideIDs";
            this.toolStripMenuItemViewShowHideIDs.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemViewShowHideIDs.Text = "Show / Hide IDs";
            this.toolStripMenuItemViewShowHideIDs.Click += new System.EventHandler(this.toolStripMenuItemViewShowHideIDs_Click);
            // 
            // toolStripMenuItemQuestionmark
            // 
            this.toolStripMenuItemQuestionmark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQuestionmarkHelp,
            this.toolStripSeparatorMenuQuestionmark1,
            this.toolStripMenuItemQuestionmarkAbout});
            this.toolStripMenuItemQuestionmark.Name = "toolStripMenuItemQuestionmark";
            this.toolStripMenuItemQuestionmark.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItemQuestionmark.Text = "?";
            // 
            // toolStripMenuItemQuestionmarkHelp
            // 
            this.toolStripMenuItemQuestionmarkHelp.Name = "toolStripMenuItemQuestionmarkHelp";
            this.toolStripMenuItemQuestionmarkHelp.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItemQuestionmarkHelp.Text = "Help";
            this.toolStripMenuItemQuestionmarkHelp.Click += new System.EventHandler(this.toolStripMenuItemQuestionmarkHelp_Click);
            // 
            // toolStripSeparatorMenuQuestionmark1
            // 
            this.toolStripSeparatorMenuQuestionmark1.Name = "toolStripSeparatorMenuQuestionmark1";
            this.toolStripSeparatorMenuQuestionmark1.Size = new System.Drawing.Size(143, 6);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 407);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBooks)).EndInit();
            this.bindingNavigatorBooks.ResumeLayout(false);
            this.bindingNavigatorBooks.PerformLayout();
            this.panelAuthors.ResumeLayout(false);
            this.panelAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAuthors)).EndInit();
            this.bindingNavigatorAuthors.ResumeLayout(false);
            this.bindingNavigatorAuthors.PerformLayout();
            this.panelPublishers.ResumeLayout(false);
            this.panelPublishers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPublishers)).EndInit();
            this.bindingNavigatorPublishers.ResumeLayout(false);
            this.bindingNavigatorPublishers.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewBooksBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewBooksBookTitle;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewBooksAuthorId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewBooksPublisherId;
        private System.Windows.Forms.BindingNavigator bindingNavigatorBooks;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorBooksCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorBooksSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorBooksPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorBooksSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorBooksSeparator3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuestionmarkAbout;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMenuFile1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMenuFile2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewShowHideIDs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuestionmark;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuestionmarkHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMenuQuestionmark1;
        private System.Windows.Forms.Panel panelAuthors;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewAuthorsAuthorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewAuthorsAuthorName;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAuthors;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorAuthorsCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorAuthorsSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorAuthorsPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorAuthorsSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorAuthorsSeparator3;
        private System.Windows.Forms.Panel panelPublishers;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPublisherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPublisherName;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPublishers;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorPublishersCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorPublishersSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPublishersPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorPublishersSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorPublishersSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorBooksPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAuthorsPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPublishersPrint;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpenBooks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpenAuthors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileOpenPublishers;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}