using System;

class Program {
    public static void Main (string[] args) {
        
        int[] array = new int[10];

        Console.Write("Nhap gia tri chen (X): ");
        int X = int.Parse(Console.ReadLine());

        Console.Write("Nhap vi tri chen X : ");
        int index = int.Parse(Console.ReadLine());

        if (index <= 1 || index >= array.Length - 1) 
        {
            Console.WriteLine("Khong chen");
        } 
        else 
        {
            for (int i = 1; i < array.Length-1; i++) 
            {
                array[i] = array[i + 1];
            }
            array[index] = X;

            
            Console.WriteLine("Mang sau khi chen X:");
            
            Console.WriteLine(string.Join(",", array));
            
        }
    }
}
