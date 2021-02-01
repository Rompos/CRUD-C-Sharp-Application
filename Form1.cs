using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Application_C_SHARP.myclass;
using MySql.Data.MySqlClient;


namespace CRUD_Application_C_SHARP
{
    public partial class Form1 : Form
    {

        CRUD crud = new CRUD();

        public Form1()
        {
            InitializeComponent();
        }

     

        private void btn_save_Click(object sender, EventArgs e)
        {
                //CREATE           (Populationtxt.Text.ToString() == "")(Populationtxt.Text != "")
            if (TestForNullOrEmpty(Nametxt.Text) == true || TestForNullOrEmpty(CountryCodetxt.Text)== true || TestForNullOrEmpty(Districttxt.Text)== true || TestForNullOrEmpty(Populationtxt.Text)== true && (IsNumeric(Populationtxt.Text) == false))
            {
                MessageBox.Show("Enter DATA in all the fields and then press CREATE. The Country Code should be 3 letters! and the population only numbers Between 0 and 90000000000", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (Convert.ToInt64(Populationtxt.Text.ToString()) < 0.0 || Convert.ToInt64(Populationtxt.Text.ToString()) > 90000000000.0 || (IsNumeric(Populationtxt.Text) == false))
            {
                MessageBox.Show("Please enter a valid Number Between 0 and 90000000000 for the population!", "Wrong or Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                //MessageBox.Show("Enter DATA to all the fields and then press CREATE!");
            }
            else
            {
                CREATE();
                READ();
            }
        }

        bool TestForNullOrEmpty(string s)
        {
            bool result;
            result = s == null || s == string.Empty;
            return result;
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool IsNumber(string s)
        {
            bool value = true;
            foreach (Char c in s.ToCharArray())
            {
                value = value && Char.IsDigit(c);
            }
            return value;
        }


        private void btn_select_Click(object sender, EventArgs e)
        {
            //SELECT
            READ();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //UPDATE 
            if (TestForNullOrEmpty(u_Nametxt.Text) == true || TestForNullOrEmpty(u_CountryCodetxt.Text) == true || TestForNullOrEmpty(u_Districttxt.Text) == true || TestForNullOrEmpty(u_Populationtxt.Text) == true && (IsNumeric(u_Populationtxt.Text) == false))
            {
                MessageBox.Show("Enter DATA in all the fields and then press UPDATE. The Country Code should be 3 letters! and the population only numbers Between 0 and 90000000000", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Convert.ToInt64(u_Populationtxt.Text.ToString()) < 0.0 || Convert.ToInt64(u_Populationtxt.Text.ToString()) > 90000000000.0 || (IsNumeric(u_Populationtxt.Text) == false))
            {
                MessageBox.Show("Please enter a valid Number Between 0 and 90000000000 for the population!", "Wrong or Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Enter DATA to all the fields and then press CREATE!");
            }
            else
            {
                UPDATE();
                READ();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DELETE
            if (u_IDtxt.Text != "")
            {
                DELETE();
                READ();
            }
            else
            {
                MessageBox.Show("SELECT the ID and then press DELETE! The ID must match the row you want to delete!", "Empty or Wrong Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Enter DATA to all the fields except ID and then press DELETE!");                
            }
            
        }

        //READ Function in runtime
        public void READ()
        {
            dataGridView1.DataSource = null;
            crud.Read_Data();
            dataGridView1.DataSource = crud.dt;
        }

        //CREATE button Function 
        public void CREATE()
        {
            crud.Name = Nametxt.Text;
            crud.CountryCode = CountryCodetxt.Text;
            crud.District = Districttxt.Text;
            crud.Population = Populationtxt.Text;               
            crud.Create_data();        
        }

       

        //UPDATE button Function 
        public void UPDATE()
        {
            
            crud.Name = u_Nametxt.Text;
            crud.CountryCode = u_CountryCodetxt.Text;
            crud.District = u_Districttxt.Text;
            crud.Population = u_Populationtxt.Text;
            crud.ID = u_IDtxt.Text;
            crud.Update_data();
        }
        //DELETE button Function 
        public void DELETE()
        {
            
            crud.ID = u_IDtxt.Text;
            crud.Delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //GET THE SELECTIVE DATA TO UPDATE THE GRIDVIEW BOX
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    u_IDtxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    u_Nametxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    u_CountryCodetxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    u_Districttxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    u_Populationtxt.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Don't Click the Header!");
            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
