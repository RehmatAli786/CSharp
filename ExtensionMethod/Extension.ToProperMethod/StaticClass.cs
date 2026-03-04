namespace Extension.ToProperMethod
{
    internal static class StaticClass
    {
        public static string ToProper(this string oldStr)
        {
            if(!string.IsNullOrEmpty(oldStr.Trim()))
            {
                oldStr = oldStr.ToLower();
                string newStr = string.Empty;

                string[] strArray = oldStr.Split(" ");
                foreach (var str in strArray)
                {
                    char[] charArray = str.ToCharArray();
                    charArray[0] = Char.ToUpper(charArray[0]);

                    if (string.IsNullOrEmpty(newStr))
                        newStr = new string(charArray);
                    else
                        newStr += " " + new string(charArray);
                }
                return newStr;
            }
            else
            {
                return oldStr;
            }
        }
    }
}
