namespace CarProject
{
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

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}