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
        /// <param name="first">Первое число триады.</param>
        /// <param name="second">Второе число триады.</param>
        /// <param name="third">Третье число триады.</param>
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
        /// <returns>Новая триада с добавленным числом к каждому элементу.</returns>
        public Triad AddNumber(int number)
        {
            return new Triad(First + number, Second + number, Third + number);
        }

        /// <summary>
        /// Метод для умножения всех элементов триады на число.
        /// </summary>
        /// <param name="number">Число, на которое будут умножены все элементы триады.</param>
        /// <returns>Новая триада с умноженными элементами.</returns>
        public Triad MultiplyByNumber(int number)
        {
            return new Triad(First * number, Second * number, Third * number);
        }

        /// <summary>
        /// Метод для проверки равенства двух триад.
        /// </summary>
        /// <param name="other">Триада для сравнения.</param>
        /// <returns>True, если триады равны; иначе False.</returns>
        public bool Equals(Triad other)
        {
            if (other == null)
                return false;

            return First == other.First && Second == other.Second && Third == other.Third;
        }

        /// <summary>
        /// Перегруженный метод для сложения двух триад.
        /// </summary>
        /// <param name="other">Триада, которую нужно сложить с текущей.</param>
        /// <returns>Новая триада, являющаяся суммой двух триад, или null, если переданная триада равна null.</returns>
        public Triad AddTriad(Triad other)
        {
            if (other is null)
                return null;

            return new Triad(First + other.First, Second + other.Second, Third + other.Third);
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
