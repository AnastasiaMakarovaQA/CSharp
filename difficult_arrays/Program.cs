//string[,] table = new string[2, 5];
// table[1,2]="слово";
// for (int rows = 0; rows < 2; rows++){
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// } 



// void PrintArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int colums = 0; colums < matr.GetLength(1); colums++)
//         {
//             Console.Write($"{matr[rows, colums]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr){
// for (int rows = 0; rows < matr.GetLength(0); rows++)
// {
//     for (int colums = 0; colums < matr.GetLength(1); colums++)
//     {
//         matr[rows,colums] = new Random().Next(1,10);
//     }
// }
// }
// int[,] matrix = new int[3, 4];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);


double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

