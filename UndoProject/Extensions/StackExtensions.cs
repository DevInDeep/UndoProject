using UndoProject.Common;
using System.Collections.Generic;

namespace UndoProject.Extensions
{
    public static class StackExtensions
    {
        public static Optional<T> PopThenPeek<T>(this Stack<T> stack)
        {
            if (stack.Count <= 1) return Optional<T>.Empty();
            stack.Pop();
            return Optional<T>.Create(stack.Peek());
        }
    }
}
