using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss
{
    public class MethodGaussa
    {
        public double[][] matrix { get; set; }

        public int curKolUravn;
        public int curKolPerem;
        public int kolCol;
        public double[] x;
        
        public MethodGaussa()
        {
            matrix = new double[0][];
            curKolUravn = curKolPerem = kolCol = 0;
        }
        public MethodGaussa(int n, int m)
        {
            matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
            }
            curKolUravn = n;
            curKolPerem = m - 1;
            kolCol = m;
        }
        public void MainGauss()
        {           
        }        
        public string MatrToStr()
        {
            string str = "";
            for (int j = 0; j < curKolUravn; j++)
            {
                for (int i = 0; i < kolCol; i++)
                {
                    if (i == kolCol - 1)
                        str += "| ";

                    if (matrix[j][i].ToString() != "NaN")
                        str += Math.Round(matrix[j][i], 2).ToString() + " ";
                    else
                        str += "- ";
                }
                str += "\n";
            }
            return str;
        }
        public string XtoStr()
        {
            string str = "";
            for (int i = 0; i < x.Length; i++)
            {
                    str += "x" + i.ToString() + " = " + Math.Round(x[i], 2).ToString() + ", ";
            }
            str = str.Substring(0, str.Length - 2);

            return str;
        }
        public void ExchangeRow(int row1, int row2)//поменять местами ряды row1 и row2
        {
            try
            {
                double[] temp = matrix[row1];
                matrix[row1] = matrix[row2];
                matrix[row2] = temp;
            }
            catch { }
        }
        public void MultiplyRow(int row, double x)//умножить ряд row на число х
        {
            try
            {
                for (int i = 0; i < matrix[row].Length; i++)
                {
                    matrix[row][i] = matrix[row][i] * x;
                }
            }
            catch { }
        }
        public void DivideRow(int row, double x)
        {
            try
            {
                for (int i = 0; i < matrix[row].Length; i++)
                {
                    matrix[row][i] = matrix[row][i] / x;
                }
            }
            catch { }
        }
        public void AddRowToRow(int row1, int row2, double x)
        {
            try
            {
                for (int i = 0; i < matrix[row1].Length; i++)
                {
                    matrix[row1][i] = matrix[row1][i] + (matrix[row2][i] * x);
                }
            }
            catch { }
        }
        public void DelRow(int row)
        {
            try
            {
                for (int i = row; i < curKolUravn-1; i++)
                    matrix[i] = matrix[i + 1];
                curKolUravn--;
                matrix[curKolUravn] = null;
            }
            catch
            { }
        }
        public bool IsZeroRow(int row)
        {
            try
            {
                for (int i = 0; i < matrix[row].Length; i++)
                {
                    if (matrix[row][i] != 0)
                    {
                        return false;
                    }                
                }
            }
            catch {
                return false;
            }
            return true;
        }
        public void DelAllZeroRow()
        {
            for (int i = 0; i < curKolUravn; i++)
            {
                if (IsZeroRow(i))
                {
                    DelRow(i);
                    i--;
                }
            }
        }
        public string AutoRezult()
        {
            string str = "";
            try
            {
                //прямой ход
                for (int k = 1; k < curKolPerem; k++)
                {
                    for (int j = k; j < curKolPerem; j++)
                    {
                        double m = matrix[j][k - 1] / matrix[k - 1][k - 1];

                        for (int i = 0; i < curKolPerem + 1; i++)
                        {
                            matrix[j][i] = matrix[j][i] - m * matrix[k - 1][i];
                        }

                        str += "===>\n" + MatrToStr() + "\n";
                    }
                }

                BackWay();
            }
            catch
            {                
            }
            return str;
        }
        public void BackWay()
        {
            try
            {
                x = new double[curKolPerem];

                //обратный ход
                for (int i = curKolPerem - 1; i >= 0; i--)
                {
                    x[i] = matrix[i][curKolPerem] / matrix[i][i];

                    for (int c = curKolPerem - 1; c > i; c--)
                    {
                        x[i] = x[i] - matrix[i][c] * x[c] / matrix[i][i];
                    }
                }
            }
            catch
            {
            }
        }
        public bool IsNonRow(int row)
        {
            try
            {
                for (int i = 0; i < curKolPerem; i++)
                {
                    if (matrix[row][i] != 0)
                    {
                        return false;
                    }
                }
                if (matrix[row][curKolPerem] == 0)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool IsResultExist()
        {
            try
            {
                for (int i = 0; i < curKolUravn; i++)
                {
                    if (IsNonRow(i))
                        return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool IsFindRez()
        {
            try
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i].ToString() == "NaN")
                        return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
