using Person;
using Session78;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Session_7_8
{
    public partial class UnivercityForm : DevExpress.XtraEditors.XtraForm
    {
        private const string PROFESSOR_DATA = "UniversityStorage.json";
        
        private Person.Person _person;

        private ProfessorForm _professorForm;

        #region University_UI_Controls

        public UnivercityForm()
        {
            InitializeComponent();
        }

        private void MenuFileLoad_Click(object sender, EventArgs e)
        {

        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {

        }

        private void MenuProfessor_Click(object sender, EventArgs e)
        {
            ProfessorForm professorForm = new ProfessorForm();

            //TODO List professorForm.;

            professorForm.ShowDialog();
        }

        private void MenuStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();

            //professorForm.Person = _professorForm.Person;

            studentForm.ShowDialog();
        }
        #endregion

        private void Load()
        {
            string data = File.ReadAllText(PROFESSOR_DATA);

            _person = (Person.Person)JsonSerializer.Deserialize(data, typeof(Person.Person));
        }
    }
}
