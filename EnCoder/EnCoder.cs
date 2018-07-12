using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCoder
{
    public class EnCoder
    {
        private static Hashtable table = new Hashtable(10)
        {
            {'1', 'e'},
            {'2', '7'},
            {'3', 'a'},
            {'4', 'f'},
            {'5', 'b'},
            {'6', '3'},
            {'7', '5'},
            {'8', '2'},
            {'9', '4'},
            {'0', '8'}
        };
        private static StringBuilder sb = new StringBuilder();
        public static string Encode(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            if(data.Length != 10)
            {
                throw new Exception("要加密的数据字符长度不足10位");
            }
            sb.Clear();
            sb.Append(table[data[2]]); sb.Append(table[data[9]]);
            sb.Append(table[data[4]]); sb.Append(table[data[7]]);
            sb.Append(table[data[1]]); sb.Append(table[data[0]]);
            sb.Append(table[data[3]]); sb.Append(table[data[8]]);
            sb.Append(table[data[5]]); sb.Append(table[data[6]]);
            return sb.ToString();
        }
            
    }
}
