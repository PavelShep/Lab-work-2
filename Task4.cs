using System;
class HelloWorld {
  static void Main() {
    int[] A = new int[10];
    Random rnd = new Random();
    int sum = 0;
    int sum1 = 0;
    int k=0;
    int sum2 = 0;
    int l=0;
    
    for (int i=0; i<A.Length; i++){
        A[i] = rnd.Next(-100, 100);
    }
    
    Console.Write("Исходный массив: ");
    
    for (int i=0; i<A.Length; i++){
        Console.Write(A[i] + " ");
    }
    
    Console.WriteLine();
    
    for (int i=0; i<A.Length; i++){
        if (A[i] > 0) {
            sum = sum + A[i];
        }
    }
    
    Console.WriteLine("Сумма через цикл for: " + sum);
    
    while (k < A.Length) {
        if (A[k] > 0) {
            sum1 = sum1 + A[k];
        }
        k++;
    }
    
    Console.WriteLine("Сумма через цикл while: " + sum1);
    
    
    do {
        if (A[l] > 0) {
            sum2 = sum2 + A[l];
        }
        l++;
    } while(l < A.Length);
    
    Console.WriteLine("Сумма через цикл do...while: " + sum2);
    
    }
}
