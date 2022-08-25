int[] firstDot = new int[3];
int[] secondDot = new int[3];
var a = firstDot;

string DistanceGet()
{
    for(int j = 0; j < 2; j++)
    {    
        for(int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент {j + 1}-й точки");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        a = secondDot;
    }
    double distance = Math.Round(Math.Sqrt(Math.Pow(secondDot[0] - firstDot[0],2)+
                                            Math.Pow(secondDot[1] - firstDot[1],2)+
                                            Math.Pow(secondDot[2] - firstDot[2],2)),2);
    return $"Расстояние между 2мя точками в 3Д пространстве = {distance}";    
}
try{
    Console.WriteLine(DistanceGet());
}
catch{
    Console.WriteLine("Не вверный ввод. Нужно вводить координаты целыми числами");
}

