using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn
{
    internal class SeriesPoint : DataPoint
    {
        private string v;
        private int availableProducts;

        public SeriesPoint(string v, int availableProducts)
        {
            this.v = v;
            this.availableProducts = availableProducts;
        }
    }
}