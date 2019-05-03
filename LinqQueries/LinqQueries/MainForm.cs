using JSONData;
using MockData;
using Streem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLData;

namespace LinqQueries
{
    public partial class MainForm : Form
    {
        IObjectRepo repo;
        public MainForm()
        {
            InitializeComponent();
            //repo = new ObjectRepo();
           // repo = new XMLRepo();
            // repo = new JSONRepo();
            //repo = new StreemRepo();
        }

        private void getResults_Click(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Id = 1,
                Name = tbName.Text,
                LastName = tbLastName.Text,
                BirthDate = dtpBirthDay.Value,
                Weight = Convert.ToInt32(mtbWeight.Text),
                Height = Convert.ToInt32(mtbHeight.Text)
            };

            repo.Add(person);
            MessageBox.Show("OK");
            getResults_Click(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(mtbId.Text);
            repo.Delete(Id);
            MessageBox.Show("OK");
            DisplayList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            var id = Convert.ToInt32(mtbId.Text);
            var person = repo.GetPerson(id);

                person.Name = $"{tbName.Text}";
                person.LastName = $"{tbLastName.Text}";
                person.BirthDate = Convert.ToDateTime($"{dtpBirthDay.Value}");
                person.Height = Convert.ToInt32($"{mtbHeight.Text}");
                person.Weight = Convert.ToInt32($"{mtbWeight.Text}");

            repo.Update(person);
            DisplayList();
        }   

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(mtbId.Text);
                var person = repo.GetPerson(id);

                tbName.Text = person.Name;
                tbLastName.Text = person.LastName;
                dtpBirthDay.Value = person.BirthDate;
                mtbHeight.Text = person.Height.ToString();
                mtbWeight.Text = person.Weight.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Niewłaściwy numer indeksu", "", MessageBoxButtons.OK);
            }
        }
        private void DisplayList()
        {
            dgv.DataSource = null;
            dgv.DataSource = repo.GetList();
        }
    }
}
