using Models;
using Repositories.CarExtraRepository;
using Repositories.CarRepository;
using Repositories.ExtraRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProject
{
    public partial class CarExtrasForm : Form
    {
        private readonly ICarExtraRepository carExtraRepository;
        private readonly ICarRepository carRepository;
        private readonly IExtraRepository extraRepository;
        private readonly int currentId;

        public CarExtrasForm(int currentId)
        {
            this.currentId = currentId;

            carExtraRepository = (ICarExtraRepository)StartUp.ServiceProvider.GetService(typeof(ICarExtraRepository));
            carRepository = (ICarRepository)StartUp.ServiceProvider.GetService(typeof(ICarRepository));
            extraRepository = (IExtraRepository)StartUp.ServiceProvider.GetService(typeof(IExtraRepository));

            InitializeComponent();
            OnStart();
            GetData();
        }

        private void OnStart()
        {
            var extraNames = extraRepository.GetAllExtras.Select(b => b.Name).ToArray();
            inputCarName.Text = carRepository.GetCarById(currentId).Model;
            comboExtraId.Items.AddRange(extraNames);

            manyToManyGrid.ColumnCount = 2;
            manyToManyGrid.Columns[0].Name = "Name";
            manyToManyGrid.Columns[1].Name = "Description";
        }

        private void GetData()
        {
            manyToManyGrid.Rows.Clear();
            var carExtras = carExtraRepository.GetCarExtras(currentId);
            foreach (var carExtra in carExtras)
            {
                string[] currentRow =
                {
                    carExtra.Extra.Name,
                    carExtra.Extra.Description
                };

                manyToManyGrid.Rows.Add(currentRow);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var selectedExtra = extraRepository.GetExtraByName(comboExtraId.Text);

            var currentCarExtra = new CarExtra
            {
                CarId = currentId,
                ExtraId = selectedExtra.Id
            };

            carExtraRepository.Add(currentCarExtra);
            MessageBox.Show("Great success!");
            comboExtraId.Text = string.Empty;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
            CoreForm f1 = new CoreForm();
            f1.ShowDialog();
        }
    }
}
