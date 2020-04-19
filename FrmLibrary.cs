using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmLibrary : Form
    {
        // ################################################
        // BLOCK: INITIALIZE THE FORM - START

        // This line creates the Panels List.
        private readonly List<Panel> listPanel = new List<Panel>();

        // This method checks which ListPanel is actually in Front.
        // We need this to tell Save Button in the menu what to save.
        private bool IsControlAtFront(Control control)
        {
            return control.Parent.Controls.GetChildIndex(control) == 0;
        }

        // This is the Constuctor for the Form.
        public FrmLibrary()
        {
            InitializeComponent();

        }

        // This method is loading the Form.
        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            // Loading Data in the Table "libraryDataSet.Publishers". You can move or delete this if you need or want to.
            this.publishersTableAdapter.Fill(this.libraryDataSet.Publishers);
            // Loading Data in the Table "libraryDataSet.Authors". You can move or delete this if you need or want to.
            this.authorsTableAdapter.Fill(this.libraryDataSet.Authors);
            // Loading Data in the Table "libraryDataSet.Books". You can move or delete this if you need or want to.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

            // Add all Panels to a Panels List.
            listPanel.Add(panelBooks);
            listPanel.Add(panelAuthors);
            listPanel.Add(panelPublishers);

            // Bring the firest Panel to front; it's containing the data of the "DataGridViewBooks".
            listPanel[2].Hide();
            listPanel[1].Hide();
            listPanel[0].Show();
            listPanel[0].BringToFront();

        }
        // BLOCK: INITIALIZE THE FORM - END
        // ################################################

        // ################################################
        // BLOCK: BUTTONS - START
        private void btnBooks_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewBooks" to the front.
            listPanel[2].Hide();
            listPanel[1].Hide();
            listPanel[0].Show();
            listPanel[0].BringToFront();

        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewAuthors" to the front.
            listPanel[2].Hide();
            listPanel[0].Hide();
            listPanel[1].Show();
            listPanel[1].BringToFront();

        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewPublishers" to the front.
            listPanel[1].Hide();
            listPanel[0].Hide();
            listPanel[2].Show();
            listPanel[2].BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close this Application.
            this.Close();

        }
        // BLOCK: BUTTONS - ENDE
        // ################################################

        // ################################################
        // BLOCK: MENU BAR - START
        private void toolStripMenuItemFileOpenBooks_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewBooks" to the front.
            listPanel[2].Hide();
            listPanel[1].Hide();
            listPanel[0].Show();
            listPanel[0].BringToFront();

        }

        private void toolStripMenuItemFileOpenAuthors_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewAuthors" to the front.
            listPanel[2].Hide();
            listPanel[0].Hide();
            listPanel[1].Show();
            listPanel[1].BringToFront();

        }

        private void toolStripMenuItemFileOpenPublishers_Click(object sender, EventArgs e)
        {
            // Brings the Panel containing the "DataGridViewPublishers" to the front.
            listPanel[1].Hide();
            listPanel[0].Hide();
            listPanel[2].Show();
            listPanel[2].BringToFront();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check which listPanel is actually in front and save it.
            if (IsControlAtFront(listPanel[0]))
            {
                // Save Table "Books".
                this.Validate();
                this.booksBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
            }
            else if (IsControlAtFront(listPanel[1]))
            {
                // Save Table "Authors".
                this.Validate();
                this.authorsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
            }
            else if (IsControlAtFront(listPanel[2]))
            {
                // Save Table "Publishers".
                this.Validate();
                this.publishersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
            }
            else
            {
                MessageBox.Show("Can not save to database, because there is no DataGrid View select!");
            }
        }

        private void toolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Drucken" implementieren!

        }

        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            // Close this Application.
            this.Close();

        }

        private void toolStripMenuItemEditCut_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Ausschneiden" implementieren!

        }

        private void toolStripMenuItemEditCopy_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Kopieren" implementieren!

        }

        private void toolStripMenuItemEditPaste_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Einfügen" implementieren!

        }

        private void toolStripMenuItemEditDelete_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Löschen" implementieren!

        }

        private void toolStripMenuItemViewShowHideIDs_Click(object sender, EventArgs e)
        {
            // TODO: Methode "ShowIDs" implementieren!

        }

        private void toolStripMenuItemQuestionmarkHelp_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Hilfe" implementieren!

        }

        private void toolStripMenuItemQuestionmarkAbout_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Über Library" implementieren!

        }
        // BLOCK: MENU BAR - END
        // ################################################

        // ################################################
        // BLOCK: BINDING NAVIGATORS - START
        private void bindingNavigatorBooksSaveItem_Click(object sender, EventArgs e)
        {
            // Save Table "Books".
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void bindingNavigatorBooksPrint_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Drucken" implementieren!

        }

        private void bindingNavigatorAuthorsSaveItem_Click(object sender, EventArgs e)
        {
            // Save Table "Authors".
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void bindingNavigatorAuthorsPrint_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Drucken" implementieren!

        }

        private void bindingNavigatorPublishersSaveItem_Click(object sender, EventArgs e)
        {
            // Save Table "Publishers".
            this.Validate();
            this.publishersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void bindingNavigatorPublishersPrint_Click(object sender, EventArgs e)
        {
            // TODO: Methode "Drucken" implementieren!

        }

        // BLOCK: BINDING NAVIGATORS - ENDE
        // ################################################

    }
}
