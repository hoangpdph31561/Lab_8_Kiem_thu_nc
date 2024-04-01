namespace Code
{
    public class StringManipulator
    {
        public string Concatenate(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                throw new NullReferenceException("Invalid input");
            }
            return String.Concat(str1, str2);
        }
    }
}
