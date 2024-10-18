using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
    /// <summary>
    /// Класс представляющий триаду (тройка чисел).
    /// </summary>
    public class Triad
    {
        /// <summary>
        /// Первое число триады.
        /// </summary>
        public int First { get; set; }

        /// <summary>
        /// Второе число триады.
        /// </summary>
        public int Second { get; set; }

        /// <summary>
        /// Третье число триады.
        /// </summary>
        public int Third { get; set; }

        /// <summary>
        /// Конструктор для инициализации триады.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        /// <summary>
        /// Метод для сложения всех элементов триады с числом.
        /// </summary>
        /// <param name="number">Число, которое будет добавлено ко всем элементам триады.</param>
        public void AddNumber(int number)
        {
            First += number;
            Second += number;
            Third += number;
        }

        /// <summary>
        /// Метод для умножения всех элементов триады на число.
        /// </summary>
        /// <param name="number">Число, на которое будут умножены все элементы триады.</param>
        public void MultiplyByNumber(int number)
        {
            First *= number;
            Second *= number;
            Third *= number;
        }

        /// <summary>
        /// Метод для сложения двух триад.
        /// </summary>
        /// <param name="other">Триада, которую нужно сложить с текущей.</param>
        public void AddTriad(Triad other)
        {
            if (other != null)
            {
                First += other.First;
                Second += other.Second;
                Third += other.Third;
            }
        }

        /// <summary>
        /// Метод для проверки равенства двух триад.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>True, если триады равны; иначе False.</returns>
        public bool Equals(Triad other)
        {
            if (other == null)
                return false;

            return First == other.First && Second == other.Second && Third == other.Third;
        }

        /// <summary>
        /// Переопределение метода ToString для удобного отображения триады.
        /// </summary>
        /// <returns>Строковое представление триады.</returns>
        public override string ToString()
        {
            return $"({First}, {Second}, {Third})";
        }
    }
}