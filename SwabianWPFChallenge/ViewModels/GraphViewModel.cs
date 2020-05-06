using System.Collections.Generic;
using Caliburn.Micro;
using OxyPlot;

namespace SwabianWPFChallenge.ViewModels
{
    class GraphViewModel : Screen
    {
        public GraphViewModel(string title,List<DataPoint> points)
        {
            this.Title = title;
            this.Points = points;
        }

        public string Title { get; private set; }

        public IList<DataPoint> Points { get; private set; }
    }
}
