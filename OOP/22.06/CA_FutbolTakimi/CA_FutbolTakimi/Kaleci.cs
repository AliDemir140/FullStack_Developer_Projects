namespace CA_FutbolTakimi
{
    public class Kaleci : Futbolcu
    {
        private int _topKurtarGuc;

        public int TopKurtarmaGuc
        {
            get
            {
                if (_topKurtarGuc > 60)
                {
                    Console.WriteLine("Top kurtarma olasılığı yüksek");

                }
                else
                {
                    Console.WriteLine("Top kurtarma olasılığı düşük");
                }
                return _topKurtarGuc;

            }
            set { _topKurtarGuc = value; }
        }

        public string TopKurtar()
        {
            return $"{Ad} {TopKurtarmaGuc} gucunde topu kurtardır.";
        }
    }
}
