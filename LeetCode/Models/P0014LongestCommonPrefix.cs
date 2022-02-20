namespace LeetCode.Models
{
    public class P0014LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var temp = string.Empty;
            for (var i = 0; i <= 200; i++)
            {
                var value = commonChar(strs, i);
                if (string.IsNullOrWhiteSpace(value))
                {
                    return temp;
                }
                temp += value;
            }

            return temp;
        }

        private string commonChar(string[] strs, int i)
        {
            var temp = string.Empty;
            var count = 0;
            foreach (var str in strs)
            {
                if (i + 1 > str.Length)
                {
                    return string.Empty;
                }

                if (count == 0)
                {
                    temp = str.Substring(i, 1);
                    count++;
                }

                if (str.Substring(i, 1) != temp)
                {
                    return string.Empty;
                }

            }

            return temp;

        }
    }
}
