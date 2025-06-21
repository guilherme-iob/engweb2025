namespace CursoSabado.Testes
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AppInicioTesteSemprePassa()
        {
            Assert.Pass();
        }

        [Test]
        public void AppInicioTesteSoma()
        {
            int val1 = 2;
            int val2 = 2;

            int resultado = val1 + val2;
            int resultadoEsperado = 4;

            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }
    }
}