using Code;
using NUnit.Framework;
using Rhino.Mocks;

namespace Tests
{
    class AutomaticUmbrellaTests
    {
        private IWetWeather _mockRain;
        private AutomaticUmbrella _umbrella;

        [SetUp]
        public void Init()
        {
            _mockRain = MockRepository.GenerateMock<IWetWeather>();
            _umbrella = new AutomaticUmbrella {WetWeather = _mockRain};

            // create a mockHail then uncomment the line below
            //_sturdyUmbrella = new AutomaticUmbrella {WetWeather = _mockHail};
        }

        [Test]
        public void Should_OpenWhenWeatherIsWet()
        {
            _mockRain.Stub(x => x.IsOccuring()).Return(true);
            Assert.That(_umbrella.IsOpen, Is.EqualTo(true));
        }

        [Test]
        public void Should_CloseWhenWetherIsNotWet()
        {
           // stub the rain so that when the umbrella it recieves the message IsOccuring it returns false
           // assert that the umbrella is not open (is open equals false)
        }

        // Write a test that tests that the sturdy umbrella opens when it's hailing
    }
}
