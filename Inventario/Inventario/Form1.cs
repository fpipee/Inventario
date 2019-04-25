using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Models;
namespace Inventory
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }
        #region HELPER
        private void Listar()
        {
            using (InventarioEntities inv = new InventarioEntities())
            {
                var invent = from i in inv.Inventario
                             select i;
                dataGridView1.DataSource = invent.ToList();

            }
        }
        private int? GetId()
        {
            try
            {
                return  int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Arent information to edit");
                
                return null ;
            }
        
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.FormCreate formCreate = new Presentation.FormCreate();
            formCreate.ShowDialog();

            Listar(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentation.FormCreate formCreate  = new Presentation.FormCreate(id);
                formCreate.ShowDialog();
                Listar(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this row ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                 int? id = GetId();
            if (id != null)
            {
               using(InventarioEntities inv = new InventarioEntities()){
                   Inventario entityTable = inv.Inventario.Find(id);
                   inv.Inventario.Remove(entityTable);
                   inv.SaveChanges();
               }
                Listar();
            }
            }
            else
            {
                // If 'No', do something here.
                Listar(); 

            }
           
        }
    }
}
