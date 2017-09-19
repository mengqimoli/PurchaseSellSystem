using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace PurchaseSellSystem.Share
{
    public class Validator
    {
        //验证是否为空字符串
        static public Boolean IsEmptyStr(String strIn)
        {
            if (strIn.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //验证是否为数字串 只由0-9这10个数字组成的串
        static public Boolean IsNumStr(String strIn)
        {
            return Regex.IsMatch(strIn, @"^[0-9]d*$");
        }

        // 验证是否为整数
        static public bool IsInteger(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([+-]?[1-9][0-9]*|0)$");

        }

        // 验证是否是小数
        static public bool IsFloat(string strIn)
        {
            return Regex.IsMatch(strIn, @"^[+-]?(?!0\d)\d+\.\d+\b(?![.])$");
        }

        // 验证是否为数值型数据(包括整数和小数)
        static public Boolean IsNumber(String strIn)
        {
            return Regex.IsMatch(strIn, @"^[+-]?(?!0\d)\d+(\.[0-9]+)?$");
        }

        // 验证是否为日期型字符串 (2008-05-08)
        static public bool IsDate(string strIn)
        {
            return Regex.IsMatch(strIn, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
        }

        // 验证是否为日期型字符串 (2008-05-08) 或 (2008/05/08) 或 (2008.05.08)
        static public bool IsDate2(string strIn)
        {
            return Regex.IsMatch(strIn, @"^(?:(?:1[6-9]|[2-9][0-9])[0-9]{2}([-/.]?)(?:(?:0?[1-9]|1[0-2])\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\1(?:29|30)|(?:0?[13578]|1[02])\1(?:31))|(?:(?:1[6-9]|[2-9][0-9])(?:0[48]|[2468][048]|[13579][26])|(?:16|[2468][048]|[3579][26])00)([-/.]?)0?2\2(?:29))$");
        }

        // 验证是否为时间型字符串(15:00:00)
        static public bool IsTime(string strIn)
        {
            return Regex.IsMatch(strIn, @"^((20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$");
        }

        // 验证是否为日期+时间型字符串
        static public bool IsDateTime(string strIn)
        {
            return Regex.IsMatch(strIn, @"^(((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$");
        }

        // 验证是否是Email地址字符串
        static public bool IsEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}
