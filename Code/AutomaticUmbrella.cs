namespace Code
{
    public class AutomaticUmbrella
    {
        public IWetWeather WetWeather { get; set; }

        public bool IsOpen {
            get { return WetWeather.IsOccuring(); }
            private set {}
        }

        public  AutomaticUmbrella()
        {
            IsOpen = false;
        }
    }


    // this is here for the sake of the exercise but should sit in its own file
    public interface IWetWeather
    {
        bool IsOccuring();
    }
}
