using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
   
    class MatrixDfine

    {
        public static int RowCount(double[,] A)
        {
            return A.GetUpperBound(0) + 1;//GetUpperBound可以获得数组最高下标 得到行数
        }                                 //0表示二维数组的第一维
        public static int ColCount(double[,] A)
        {
            return A.GetUpperBound(1) + 1;//同上  得到列数  “1表示数组的第二维 ”
        }
        public static unsafe void Swap(double* x, int u, int v)//取矩阵指针  来完成矩阵的交换
        {
            double z = x[u];
            x[u] = x[v];
            x[v] = z;
        }
        public static unsafe void SwapRow(double* x, int i, int j, int nCols)
        {
            int u = i * nCols, v = j * nCols;
            for (int m = 0; m < nCols; m++)//交换行
            {
                Swap(x, u, v);
                u++;
                v++;
            }
        }
        public static unsafe void SwapColumn(double* x, int i, int j, int nRows, int nCols)
        {
            int u = i, v = j;
            for (int m = 0; m < nRows; m++)//交换列
            {
                Swap(x, u, v);
                u += nCols;
                v += nCols;
            }
        }
    }

    public class Matrixcomputation
    {
        //矩阵A+B
        public static double[,] Add(double[,] A, double[,] B)
        {
            int mA = MatrixDfine.RowCount(A), mB = MatrixDfine.RowCount(B),
                nA = MatrixDfine.ColCount(A), nB = MatrixDfine.ColCount(B);
            if (mA != mB || nA != nB)
                throw new ArgumentException("进行矩阵加法运算的两个矩阵的行列必须相同");//报错
            var ans = new double[mA, nA];//VAR可代替任何类型  编译器会根据上下文来判断你到底是想用什么类型的

            for (int i = 0; i < mA; i++)
                for (int j = 0; j < nA; j++)
                    ans[i, j] = A[i, j] + B[i, j];
            return ans;
        }
        //矩阵A-B
        public static double[,] Subtract(double[,] A, double[,] B)
        {
            int mA = MatrixDfine.RowCount(A), mB = MatrixDfine.RowCount(B),
                nA = MatrixDfine.ColCount(A), nB = MatrixDfine.ColCount(B);
            if (mA != mB || nA != nB)
                throw new ArgumentException("进行矩阵减法运算的两个矩阵的行列必须相同");
            var ans = new double[mA, nA];
            for (int i = 0; i < mA; i++)
                for (int j = 0; j < nA; j++)
                    ans[i, j] = A[i, j] - B[i, j];
            return ans;
        }
        //矩阵A*B
        public static double[,] Multiply(double[,] A, double[,] B)
        {
            int mA = MatrixDfine.RowCount(A), mB = MatrixDfine.RowCount(B),
                nA = MatrixDfine.ColCount(A), nB = MatrixDfine.ColCount(B);
            if (nA != mB)
                throw new ArgumentException("进行矩阵乘法运算时，第一个矩阵的列数和第二个矩阵的行数必须相同");
            var ans = new double[mA, nB];
            for (int i = 0; i < mA; i++)
                for (int j = 0; j < nB; j++)
                    for (int k = 0; k < nA; k++)
                        ans[i, j] += A[i, k] * B[k, j];
            return ans;

        }
        //求矩阵的转置
        public static double[,] Transpose(double[,] A)
        {
            int mA = MatrixDfine.RowCount(A), nA = MatrixDfine.ColCount(A);
            var T = new double[nA, mA];
            for (int i = 0; i < mA; i++)
                for (int j = 0; j < nA; j++)
                {
                    T[j, i] = A[i, j];
                }
            return T;
        }

        //求矩阵Mat的逆
        public static double[,] Inverse(double[,] Mat)
        {
            int nRows = MatrixDfine.RowCount(Mat);
            int nCols = MatrixDfine.ColCount(Mat);
            if (nRows != nCols)
                throw new ArgumentException("只有方阵才可以求逆");
            double[,] M = Mat;
            var pnRow = new int[nCols];//分配内存
            var pnCol = new int[nCols];//分配内存 
            double d = 0.0, p = 0.0;
            int k, u, v;
            unsafe
            {
                fixed (double* mat = M)
                {
                    //消元
                    for (k = 0; k < nCols; k++)
                    {
                        d = 0.0;
                        for (int i = k; i < nCols; i++)
                            for (int j = k; j < nCols; j++)
                            {
                                u = i * nCols + j;
                                p = Math.Abs(mat[u]);
                                if (p > d)//选主元
                                {
                                    d = p;
                                    pnRow[k] = i;
                                    pnCol[k] = j;
                                }
                            }

                        if (d == 0.0)
                            throw new Exception("无法求解");

                        if (pnRow[k] != k)
                            MatrixDfine.SwapRow(mat, k, pnRow[k], nCols);
                        if (pnCol[k] != k)
                            MatrixDfine.SwapColumn(mat, k, pnCol[k], nRows, nCols);

                        v = k * nCols + k;
                        mat[v] = 1.0 / mat[v];
                        for (int j = 0; j < nCols; j++)
                            if (j != k)
                            {
                                u = k * nCols + j;
                                mat[u] *= mat[v];
                            }

                        for (int i = 0; i < nCols; i++)
                            if (i != k)
                                for (int j = 0; j < nCols; j++)
                                    if (j != k)
                                    {
                                        u = i * nCols + j;
                                        mat[u] -= mat[i * nCols + k] * mat[k * nCols + j];
                                    }

                        for (int i = 0; i < nCols; i++)
                            if (i != k)
                            {
                                u = i * nCols + k;
                                mat[u] *= -mat[v];
                            }
                    }

                    //恢复行列次序
                    for (k = nCols - 1; k >= 0; k--)
                    {
                        if (pnCol[k] != k)
                            MatrixDfine.SwapRow(mat, k, pnCol[k], nCols);
                        if (pnRow[k] != k)
                            MatrixDfine.SwapColumn(mat, k, pnRow[k], nRows, nCols);
                    }
                }
            }
            return M;
        }
    }
}
