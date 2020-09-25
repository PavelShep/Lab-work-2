using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    for (int i=1; i<=N; i++) {
        if (i % 2 == 0) {
            Console.Write(i + " ");
        }
    }
  }
}
