﻿/*
 * PLEASE MAKE A BACKUP BEFORE COMMITING!
 * Programmers:
 *  Alvarez, Arvin Kenneth
 *  Aguas, Nathaniael Johnn
 *  Lim, Jasmin Rose
 *  Pelipas, Mary Tricia Ann
 *  Rayos del Sol, Carl Ivan

 * Purpose: To serve as an inventory sysetm for a speecific company.
 * Data started: Arvin knows. I forgot lol.
 * Submission Date: I don't know. Sorry.
 
 * LAST MODIFIED BY: AKCALVAREZ 19:23
 * Please change this when you modify ANYTHING so we know who touched this thing last. :)
 * P.S. MSVS Shows you who last edited a method/class since it reads github related files AFAIK
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EquipmentLibrary;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000; // ticks every 1 second
            tmr.Tick += new EventHandler(updateTime);
            tmr.Start();
        }

        private void updateTime(object sender, EventArgs e)
        {
            striplbl.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File_Browser browser = new File_Browser();
            //browser.ShowDialog();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "SQL Server Database Files|*.mdf";
            open.Title = "Open Inventory File";

            if (open.ShowDialog() == DialogResult.OK) // if the user pressed OK on the form then read the file
            {
                this.Cursor = new Cursor(open.OpenFile());
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "SQL Server Database Files|*.mdf";
            save.Title = "Save Inventory File";
            save.FileName = "Equipment_Record";
            if (save.ShowDialog() == DialogResult.OK)

            {
                DatabaseOperations.CreateDatabase(save.FileName);
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EquipmentView frm = new frm_EquipmentView();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
