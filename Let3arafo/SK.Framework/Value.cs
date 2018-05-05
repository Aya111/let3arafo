namespace SK.Framework
{
    public class Value<T> where T : struct
    {
        private T _t;

        public Value(T t)
        {
            _t = t;
        }

        public T Content => _t;

        public static implicit operator T(Value<T> w)
        {
            return w.Content;
        }
    }
}