using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfusionMatrixVisualizer
{
    /// <summary>
    /// ConfusionMatrix.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfusionMatrixVisualizer : UserControl
    {
        public static readonly DependencyProperty ColumnCountProperty = DependencyProperty.Register("ColumnCount", typeof(int), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(3));
        public static readonly DependencyProperty RowCountProperty = DependencyProperty.Register("RowCount", typeof(int), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(3));
        public static readonly DependencyProperty CellSizeProperty = DependencyProperty.Register("CellSize", typeof(int), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(30));
        public static readonly DependencyProperty MatrixValuesProperty = DependencyProperty.Register("MatrixValues", typeof(double[,]), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(new[,]
            {
                { 0.5 ,0.4, 0.3 },
                { 0.1, 0.6, 0.7 },
                { 0.7, 0.8, 0.9 }
            })
        );
        public static readonly DependencyProperty CellMarginProperty = DependencyProperty.Register("CellMargin", typeof(Thickness), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(new Thickness(5)));
        public static readonly DependencyProperty CellForegroundProperty = DependencyProperty.Register("CellForeground", typeof(Brush), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(40, 0, 0, 100))));
        public static readonly DependencyProperty CellBackgroundProperty = DependencyProperty.Register("CellBackground", typeof(Brush), typeof(ConfusionMatrixVisualizer), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(40, 20, 20, 20))));

        public int ColumnCount
        {
            get => (int)GetValue(ColumnCountProperty);
            set => SetValue(ColumnCountProperty, value);
        }

        public int RowCount
        {
            get => (int)GetValue(RowCountProperty);
            set => SetValue(RowCountProperty, value);
        }

        public int CellSize
        {
            get => (int)GetValue(CellSizeProperty);
            set => SetValue(CellSizeProperty, value);
        }

        public Thickness CellMargin
        {
            get => (Thickness)GetValue(CellMarginProperty);
            set => SetValue(CellMarginProperty, value);
        }

        public Brush CellForeground
        {
            get => (Brush)GetValue(CellForegroundProperty);
            set => SetValue(CellForegroundProperty, value);
        }

        public Brush CellBackground
        {
            get => (Brush)GetValue(CellBackgroundProperty);
            set => SetValue(CellBackgroundProperty, value);
        }

        public double[,] MatrixValues
        {
            get => (double[,])GetValue(MatrixValuesProperty);
            set => SetValue(MatrixValuesProperty, value);
        }

        public ConfusionMatrixVisualizer()
        {
            InitializeComponent();
        }
    }
}
