using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Library
{
    public partial class FrmLibrary : Form
    {
        // Create the ListPanel Object
        private readonly List<Panel> listPanel = new List<Panel>();

        // Constuctor for the Form
        public FrmLibrary()
        {
            InitializeComponent();
        }
        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            // Load Data into the Form
            this.publishersTableAdapter.Fill(this.libraryDataSet.Publishers);
            this.authorsTableAdapter.Fill(this.libraryDataSet.Authors);
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

            // Set up the ListPanel
            listPanel.Add(panelBooks);
            listPanel.Add(panelAuthors);
            listPanel.Add(panelPublishers);
            listPanel[2].Hide(); listPanel[1].Hide();
            listPanel[0].Show(); listPanel[0].BringToFront();
        }

        // Check if control is at front
        private bool IsControlAtFront(Control control)
        {
            return control.Parent.Controls.GetChildIndex(control) == 0;
        }

        // BUTTONS - START
        private void btnBooks_Click(object sender, EventArgs e)
        {
            listPanel[2].Hide(); listPanel[1].Hide();
            listPanel[0].Show(); listPanel[0].BringToFront();
        }
        private void btnAuthors_Click(object sender, EventArgs e)
        {
            listPanel[2].Hide(); listPanel[0].Hide();
            listPanel[1].Show(); listPanel[1].BringToFront();
        }
        private void btnPublishers_Click(object sender, EventArgs e)
        {
            listPanel[1].Hide(); listPanel[0].Hide();
            listPanel[2].Show(); listPanel[2].BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // BUTTONS - END

        // MENU BAR - START
        private void toolStripMenuItemFileOpenBooks_Click(object sender, EventArgs e)
        {
            listPanel[2].Hide(); listPanel[1].Hide();
            listPanel[0].Show(); listPanel[0].BringToFront();
        }
        private void toolStripMenuItemFileOpenAuthors_Click(object sender, EventArgs e)
        {
            listPanel[2].Hide(); listPanel[0].Hide();
            listPanel[1].Show(); listPanel[1].BringToFront();
        }
        private void toolStripMenuItemFileOpenPublishers_Click(object sender, EventArgs e)
        {
            listPanel[1].Hide(); listPanel[0].Hide();
            listPanel[2].Show(); listPanel[2].BringToFront();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (IsControlAtFront(listPanel[0]))
            {
                this.booksBindingSource.EndEdit();
            }
            else if (IsControlAtFront(listPanel[1]))
            {
                this.authorsBindingSource.EndEdit();
            }
            else if (IsControlAtFront(listPanel[2]))
            {
                this.publishersBindingSource.EndEdit();
            }
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }
        private void toolStripMenuItemFilePrint_Click(object sender, EventArgs e)
        {
            if (IsControlAtFront(listPanel[0]))
            {
                PrintDataGridView(0);
            }
            else if (IsControlAtFront(listPanel[1]))
            {
                PrintDataGridView(1);
            }
            else if (IsControlAtFront(listPanel[2]))
            {
                PrintDataGridView(2);
            }
        }
        private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
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
        // MENU BAR - END

        // BINDING NAVIGATORS - START
        private void bindingNavigatorBooksSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }
        private void bindingNavigatorBooksPrint_Click(object sender, EventArgs e)
        {
            PrintDataGridView(0);
        }
        private void bindingNavigatorAuthorsSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }
        private void bindingNavigatorAuthorsPrint_Click(object sender, EventArgs e)
        {
            PrintDataGridView(1);
        }
        private void bindingNavigatorPublishersSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publishersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }
        private void bindingNavigatorPublishersPrint_Click(object sender, EventArgs e)
        {
            PrintDataGridView(2);
        }
        // BINDING NAVIGATORS - END

        // PRINT METHOD - START
        private void PrintDataGridView(int ListPanelIndex)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Library Report | " + string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")); //HEADER
            printer.SubTitle = " "; //SUBTITLE
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Printed with the DGVPrinter Class"; //FOOTER
            printer.FooterSpacing = 15;
            switch (ListPanelIndex)
            {
                case 0:
                    printer.PrintDataGridView(dataGridViewBooks);
                    break;
                case 1:
                    printer.PrintDataGridView(dataGridViewAuthors);
                    break;
                case 2:
                    printer.PrintDataGridView(dataGridViewPublishers);
                    break;
                default:
                    break;
            }
        }
        // PRINT METHOD - ENDE
    }
}
