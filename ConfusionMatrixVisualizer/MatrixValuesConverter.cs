using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ConfusionMatrixVisualizer
{
    public class MatrixValuesConverter : IValueConverter
    {
        public class MatrixValue
        {
            public int Row { get; internal set; }
            public int Column { get; internal set; }
            public double Value { get; internal set; }
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is double[,] == false)
            {
                return null;
            }
            double[,] matrix = (double[,])value;
            var itemsSource = new ObservableCollection<MatrixValue>();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    itemsSource.Add(new MatrixValue{ Row = i, Column = j, Value = matrix[i, j] });
                }
            }
            return itemsSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
