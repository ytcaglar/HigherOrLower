namespace HigherOrLower;
public static class Method
{
    private static List<int> numberList;

    private static string getNumber(){
        System.Console.Write("Please, enter numbers with spaces between them (5 10 20 6 8 9) : ");
        return Console.ReadLine().Trim();
    }

    private static bool cnvToInt(string numbers){
        int num;
        string[] number;
        number =  numbers.Split(' ');

        foreach (var item in number)
        {
            if(Int32.TryParse(item, out num)){
                numberList.Add(num);
            }else{
                System.Console.WriteLine("You have entered incorrectly. Please, enter just numbers and min 2 numbers...");
                return false;
            }
        }
        return true;
    }

    private static bool spaceControl(string numbers){

        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == ' ' && numbers[i+1] == ' '){
                System.Console.WriteLine("You have entered incorrectly. Please, enter with a space between the two numbers...");
                return false;
            }
        }
        return true;
    }

    public static void mainMethod()
    {
        Back:
        string numbers = getNumber();
        numberList = new List<int>();
        if (spaceControl(numbers) && cnvToInt(numbers))
        {
            AlgoritmaMethod();
        }else{
            goto Back;
        }
    }

    private static void AlgoritmaMethod()
    {
        int lowerTotal =0;
        double higherTotal =0;

        int count = 0;
        foreach (var item in numberList)
        {
            if(item < 67){
                lowerTotal += (67-item);
            }else if(item > 67){
                higherTotal += (Math.Pow(Math.Abs(67-item),2));
            }
        }

        System.Console.WriteLine($"The sum of the difference of numbers lower than 67 : {lowerTotal}");
        System.Console.WriteLine($"The sum of the absolute squares of the difference of numbers less than 67 : {higherTotal}");
        System.Console.WriteLine($"{lowerTotal} {higherTotal}");
    }
}
