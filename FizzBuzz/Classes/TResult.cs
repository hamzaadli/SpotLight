namespace FizzBuzz.Classes
{
    /// <summary>
    /// A generic result that can have a generic data with it
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TResult<T> : Result
    {
        public T Data { get; set; }
    }
}
