namespace ConsoleApp2._1;

public class Program
{
    public static void Main(string[] args)
    {
        //2.1
        //задание 1
        /*string J = Console.ReadLine();
        string S = Console.ReadLine();
        int schitala = 0;
        char[] S1 = S.ToCharArray();
        char[] J1 = J.ToCharArray();
        for (int i = 0; i < S1.Length; i++)
        {
            for (int j = 0; j < J1.Length; j++)
            {
                if (J1[j] == S1[i])
                {
                    schitala++;
                }
            }
            
        }
        Console.WriteLine($"{schitala}");*/

        //задание 2
        int[] numbers = {2,5,2,1,2};
        int target = 5;
        int schitala = 0;
        var vivid = 0;
        
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    List<int> chisla = new List<int>();
                    if (numbers[j] + numbers[k] < target)
                    {
                        schitala += numbers[j] + numbers[k];
                        chisla.Add(numbers[j]);
                        chisla.Add(numbers[k]);
                    }

                    if (schitala == target) {
                        for (int l = 0; l < chisla.Count; l++)
                        {
                            vivid += chisla[l];
                            
                        }
                    }
                    Console.WriteLine(vivid);
                    Console.WriteLine(target);
                }
            }
        }
        //задание 3
        /*bool Massiv()
        {
            int[] nums = new []{1,2,3,1};
            int schitala = 0;
            bool check = true;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1 ; j < nums.Length; j++) {
                    if (nums[i] == nums[j]) {
                        schitala++;
                    }
                }
            }
            if (schitala >= 2) {
                check = true;
            } else if (schitala < 2) {
                check = false;
            }
            return check;
        }

        bool result = Massiv();
        Console.WriteLine(result);
    }*/





    }
}


    
