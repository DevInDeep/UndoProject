using System;
using UndoProject.Extensions;

namespace UndoProject.Common
{
    public class Optional<T>
    {
        private T[] item;
        private Optional() => item = new T[0];
        private Optional(T item) => this.item = new T[] { item };
        public void Do(Action<T> action) => item.Do(action);

        public static Optional<T> Create(T item) => new Optional<T>(item);
        public static Optional<T> Empty() => new Optional<T>();
    }
}
