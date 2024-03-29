﻿// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Только метод, без условий ввода


void ReplaceCurrentElementsOnSquare(int[,] matrix) 
{     
    for (int i = 0; i < matrix.GetLength(0); i++)     
    {         
        for (int j = 0; j < matrix.GetLength(1); j++)         
        {             
            if(i % 2 == 0 && j % 2 == 0)             
            {                 
                matrix[i,j] *= matrix[i,j];              
            }         
        }     
    } 
}  

void ReplaceCurrentElementsOnSquareVer2(int[,] matrix) 
{     
    for (int i = 0; i < matrix.GetLength(0); i+=2)     
    {         
        for (int j = 0; j < matrix.GetLength(1); j+=2)         
        {             
            matrix[i,j] *= matrix[i,j];                   
        }     
    } 
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10); 
PrintMatrix(array2d);  

Console.WriteLine(); 
Console.WriteLine("-------------------"); 
Console.WriteLine();  

ReplaceCurrentElementsOnSquare(array2d); 
PrintMatrix(array2d);  

Console.WriteLine(); 
Console.WriteLine("-------------------"); 
Console.WriteLine();  

ReplaceCurrentElementsOnSquareVer2(array2d); 
PrintMatrix(array2d);


