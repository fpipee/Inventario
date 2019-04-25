using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Inventory.Models;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Presentation
{   
    public partial class FormCreate : Form
    {
        Inventario entityTable = null;
        public int? id;
        public FormCreate(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
           
        }
        private void CargaDatos()
        {
            using (InventarioEntities inv = new InventarioEntities())
            {
                entityTable = inv.Inventario.Find(id);
                stringName.Text = entityTable.Product;
                intQuantity.Text = entityTable.Quantity.ToString();
                datePicker.Value = entityTable.Modified_Date;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (InventarioEntities inv = new InventarioEntities())
            {   
                if(id ==null)entityTable = new Inventario();


                entityTable.Product = stringName.Text;
                try
                {
                    entityTable.Quantity = int.Parse(intQuantity.Text);
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message.ToString()+" verify the typed information");
                    return ; 
                }
                
                entityTable.Modified_Date = datePicker.Value;
                if(id == null)
                //Agregar a la bd
                inv.Inventario.Add(entityTable);
                else
                {
                    inv.Entry(entityTable).State = System.Data.Entity.EntityState.Modified;
                }
                inv.SaveChanges();//guardar cambios
                this.Close();
            }

        }

        private void FormCreate_Load(object sender, EventArgs e)
        {

        }
       
       private void stringName_TextChanged(object sender, EventArgs e)
        {
          
        }

       private void intQuantity_TextChanged(object sender, EventArgs e)
       {

           
       }
    }
}
