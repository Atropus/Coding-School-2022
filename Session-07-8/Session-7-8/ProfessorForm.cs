using Person;
using Session78;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session78
{
    public partial class ProfessorForm : Form
    {
        public Professor newProfessor { get; set; }
        public Professor currentProfessor { set; get; }

        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void listviewProfessorForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProfessorNew_Click(object sender, EventArgs e)
        {
            //Person person = CreatePerson();
        }


    }
}
