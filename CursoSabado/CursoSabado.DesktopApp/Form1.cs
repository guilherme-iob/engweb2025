using CursoSabado.Infra.IOC;
using CursoSabado.Servicos.Pessoas;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CursoSabado.DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceProvider _provider;

        private void StartupApp()
        {
            var configuration = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                      .Build();

            var services = new ServiceCollection();
            services.Registrar(configuration);

            _provider = services.BuildServiceProvider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IServicoDePessoa servicoDePessoa = _provider.GetRequiredService<IServicoDePessoa>();

            var pessoas = servicoDePessoa.ObterTodos();

            foreach (var p in pessoas)
            {
                txtPessoas.AppendText($"{ p }{Environment.NewLine}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartupApp();
        }
    }
}