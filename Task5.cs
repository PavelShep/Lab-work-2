using System;
class HelloWorld {
  static void Main() {
    int[] A = new int[10];
    Random rnd = new Random();
    
    for (int i=0; i<A.Length; i++){
        A[i] = rnd.Next(-10, 10);
    }
    
    Console.Write("Исходный массив: ");
    
    for (int i=0; i<A.Length; i++){
        Console.Write(A[i] + " ");
    }
    
    Console.WriteLine();
    
     for (int i=0; i<A.Length; i++){
        if (A[i]%2==0){
            A[i]=0;
        }else{
            A[i]=A[i]*3;
        }
    }
    
    Console.Write("Новый массив: ");
    
    for (int i=0; i<A.Length; i++){
        Console.Write(A[i] + " ");
    }
    
    }
}
