// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(firstPoint [0] - Sp [0],2 + Math.Pow (fp[1] - Span [1],2)))),3);

 
        
   Console.WriteLine("Введите координаты первой точки: ");
        int[] firstPoint = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

        Console.WriteLine("Введите координаты второй точки: ");
        int[] secondPoint = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

        double distance = CalculateDistance(firstPoint, secondPoint);
        Console.WriteLine(Math.Round(distance, 2)); // округление после запятой на 2 знака
    

    static double CalculateDistance(int[] point1, int[] point2)
    {
        int deltaX = point2[0] - point1[0];
        int deltaY = point2[1] - point1[1];
        int deltaZ = point2[2] - point1[2];

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }

     