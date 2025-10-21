namespace DotnetUtils.字符串
{
    /// <summary>
    /// 字符串帮助类
    /// </summary>
    /// <remarks>建议.Net版本8+</remarks>
    public class StringHelper
    {
        /// <summary>
        /// 把字符串按照分隔符转换成 List
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="speater">分隔符(默认",")</param>
        /// <param name="toLower">是否转换为小写(默认false)</param>
        /// <returns>字符串列表</returns>
        /// <example>
        /// <code>
        /// var str = "A,B,C,D";
        /// var list = StringHelper.SplitStrToList(str);
        /// Console.WriteLine(string.Join(" | ", list));
        /// // 输出结果: A | B | C | D
        /// </code>
        /// </example>
        public static List<string> SplitStrToList(string str, char speater = ',', bool toLower = false)
        {
            List<string> list = [];
            string[] ss = str.Split(speater);
            foreach (string s in ss)
            {
                if (!string.IsNullOrEmpty(s) && s != speater.ToString())
                {
                    string strVal = s;
                    if (toLower)
                    {
                        strVal = s.ToLower();
                    }
                    list.Add(strVal);
                }
            }
            return list;
        }
    }
}
