namespace CarProject
{
    using Models;
    using Repositories.BrandRepository;
    using Repositories.CarRepository;

    public partial class CoreForm : Form
    {
        private readonly ICarRepository carRepository;
        private readonly IBrandRepository brandRepository;

        public CoreForm()
        {
            carRepository = (ICarRepository)StartUp.ServiceProvider.GetService(typeof(ICarRepository));
            brandRepository = (IBrandRepository)StartUp.ServiceProvider.GetService(typeof(IBrandRepository));
            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {
            CarGridView.ColumnCount = 5;
            CarGridView.Columns[0].Name = "Id";
            CarGridView.Columns[1].Name = "Model";
            CarGridView.Columns[2].Name = "Year";
            CarGridView.Columns[3].Name = "Brand";
            CarGridView.Columns[4].Name = "Extras";

            var brandNames = brandRepository.GetAllBrands
                .Select(b => b.Name).ToArray();

            inputBrands.Items.AddRange(brandNames);
        }

        private void GetData()
        {
            CarGridView.Rows.Clear();

            var carsModel = carRepository.GetAllCars;

            foreach (var car in carsModel)
            {
                string[] currentRow =
                {
                    car.Id.ToString(),
                    car.Model,
                    car.Year.ToString(),
                    car.Brand.Name,
                    string.Join(", ", car.CarExtras.Select(x => x.Extra.Name))
                };

                CarGridView.Rows.Add(currentRow);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var selectedBrand = brandRepository.GetAllBrands
                .SingleOrDefault(b => b.Name == inputBrands.Text);

            var car = new Car()
            {
                Model = inputModel.Text,
                Year = int.Parse(inputYear.Text),
                BrandId = selectedBrand.Id
            };

            carRepository.Add(car);

            ClearForm();
            GetData();
        }

        private void ClearForm()
        {
            inputId.Text = string.Empty;
            inputModel.Text = string.Empty;
            inputYear.Text = string.Empty;
            inputBrands.Text = string.Empty;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedBrandId = brandRepository.GetAllBrands
                .SingleOrDefault(b => b.Name == inputBrands.Text).Id;

            var car = new Car()
            {
                Id = int.Parse(inputId.Text),
                Model = inputModel.Text,
                Year = int.Parse(inputYear.Text),
                BrandId = selectedBrandId
            };

            carRepository.Update(car);
            ClearForm();
            GetData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentId = int.Parse(inputId.Text);

            carRepository.Delete(currentId);
            ClearForm();
            GetData();
        }

        private void CarGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            inputId.Text = CarGridView.Rows[rowIndex].Cells[0].Value.ToString();
            inputModel.Text = CarGridView.Rows[rowIndex].Cells[1].Value.ToString();
            inputYear.Text = CarGridView.Rows[rowIndex].Cells[2].Value.ToString();
            inputBrands.Text = CarGridView.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void CarGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}