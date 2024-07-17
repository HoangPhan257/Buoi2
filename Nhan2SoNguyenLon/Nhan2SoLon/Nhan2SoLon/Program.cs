﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class NhanHaiSoNguyenLon
{
    public static string PhepNhan(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; i--)
        {
            for (int j = len2 - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int sum = mul + result[i + j + 1];

                result[i + j + 1] = sum % 10;
                result[i + j] += sum / 10;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (int num in result)
        {
            if (!(sb.Length == 0 && num == 0))
            {
                sb.Append(num);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }

    public static void Main(string[] args)
    {
        string num1 = "238146182323128";
        string num2 = "21321124127419129";
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Số thứ nhất: {0}", num1);
        Console.WriteLine("Số thứ hai: {0}", num2);

        string result = PhepNhan(num1, num2);
        Console.WriteLine("Tích 2 số là : " + result);

        Console.ReadLine();
    }
}