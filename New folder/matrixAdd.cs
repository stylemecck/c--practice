using System;

public class matrixAdd
{
    static int[,] matrixAddition(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixB.GetLength(1);

        if (rows != matrixB.GetLength(0) || cols != cols martixB.GetLength(1))
        {
            throw new ArgumentException("Matrix must have a same dimensions!");
        }

        int[,] result = new int [rows, cols];
        for (int i = 0 ; i< rows; i++){
            for(int j = 0; j < cols; j++) {
                result[i,j] = matrixA[i,j] + matrixB[i,j];
            }
        }
        return result;
    }

    static void Main(){
        int[,] matrixA = { {1,2,3} , {1,2,3}};
        int[,] matrixB = { {2,3,4}, {5,6,7}};

        int[,] result = matrixAddition(matrixA, matrixB);

        Console.WriteLine("Matrix Addition Result: ");

        for ( int i =0; i < result.GetLength(0); i++){
            for(int j =0; j<result.GetLength(1); j++){
                Console.Write(result(i,j)+" ";)
            }
            Console.WriteLine();
        }
    }
}