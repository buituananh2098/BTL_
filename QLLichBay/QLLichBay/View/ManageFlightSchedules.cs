using QLLichBay.DAO;
using QLLichBay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLichBay.View
{
    public partial class ManageFlightSchedules : Form
    {
        public ManageFlightSchedules()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ScheduleEdit sc = new ScheduleEdit();
            sc.ShowDialog();

        }

        private void ManageFlightSchedules_Load(object sender, EventArgs e)
        {
            SchedulesController sc = new SchedulesController();
            List<Schedules> ls = new SchedulesController().getAll();
            AirportsController ap = new AirportsController();
            
            dataGrDisplay.DataSource = ls;
        }
    }
}
