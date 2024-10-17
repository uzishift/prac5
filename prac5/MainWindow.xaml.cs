using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Windows;

namespace prac5
{
    /// <summary>
    /// Основной класс окна приложения.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Первая триада.
        /// </summary>
        private Triad _triad1;
        /// <summary>
        /// Вторая триада
        /// </summary>
        private Triad _triad2;
        /// <summary>
        /// Конструктор класса MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка выхода из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Кнопка вывода информации о программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Демьяхин Роман ИСП-31 12 Вариант\nСоздать класс Triad (тройка чисел). Создать необходимые методы и свойства.\r\nОпределить методы с операциями сложения с числом, умножения на число, проверки на равенство.\nСоздать перегруженный метод для сложения элементов одой триады с другой триадой.", "О программе");
        }
        /// <summary>
        /// Кнопка сложения триад.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTriads_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _triad1 = new Triad(
                    int.Parse(Triad1First.Text),
                    int.Parse(Triad1Second.Text),
                    int.Parse(Triad1Third.Text));

                _triad2 = new Triad(
                    int.Parse(Triad2First.Text),
                    int.Parse(Triad2Second.Text),
                    int.Parse(Triad2Third.Text));

                Triad result = _triad1.AddTriad(_triad2);
                tbOutput.Text = $"Сложение Триад:\n{_triad1} + {_triad2} = {result}";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные числа для обеих триад.", "Ошибка ввода");
            }
        }
        /// <summary>
        /// Кнопка умножения Триады 1 на число.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiplyTriad1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _triad1 = new Triad(
                    int.Parse(Triad1First.Text),
                    int.Parse(Triad1Second.Text),
                    int.Parse(Triad1Third.Text));

                if (int.TryParse(tbNumber.Text, out int number))
                {
                    Triad result = _triad1.MultiplyByNumber(number);
                    tbOutput.Text = $"Умножение Триады 1 на {number}:\n{_triad1} * {number} = {result}";
                }
                else
                {
                    MessageBox.Show("Введите корректное число для операции умножения.", "Ошибка ввода");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные числа для триады.", "Ошибка ввода");
            }
        }
        /// <summary>
        /// Кнопка сравнения триад.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompareTriads_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _triad1 = new Triad(
                    int.Parse(Triad1First.Text),
                    int.Parse(Triad1Second.Text),
                    int.Parse(Triad1Third.Text));

                _triad2 = new Triad(
                    int.Parse(Triad2First.Text),
                    int.Parse(Triad2Second.Text),
                    int.Parse(Triad2Third.Text));

                bool isEqual = _triad1.Equals(_triad2);
                tbOutput.Text = $"Сравнение Триад:\n{_triad1} и {_triad2} равны? {isEqual}";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные числа для обеих триад.", "Ошибка ввода");
            }
        }
        /// <summary>
        /// Кнопка сложения триады 1 с числом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNumberToTriad1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _triad1 = new Triad(
                    int.Parse(Triad1First.Text),
                    int.Parse(Triad1Second.Text),
                    int.Parse(Triad1Third.Text));

                if (int.TryParse(tbNumber.Text, out int number))
                {
                    Triad result = _triad1.AddNumber(number);
                    tbOutput.Text = $"Сложение Триады 1 с числом {number}:\n{_triad1} + {number} = {result}";
                }
                else
                {
                    MessageBox.Show("Введите корректное число для операции сложения.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные числа для триады.", "Ошибка ввода");
            }
        }
    }
}