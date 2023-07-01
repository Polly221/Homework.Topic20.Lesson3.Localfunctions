Console.Write("Число 1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Число 2: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("1-логическое побитовое умножение "+
                "\n2-сложение " +
                "\n3-шифрование по ключу " +
                "\n4-инверсия");
            int number = int.Parse(Console.ReadLine());

            int result1 = casel(y1, x1);
            int result2 = addition(y1, x1);
            int result3 = encryption(y1, x1);
            int result4 = inversion(y1, x1);
            int firstsumm = casel(y1, x1);
            
            
            switch (number)
            {
                case 1:                  
                    Console.WriteLine(result1);
                    break;
                case 2:                 
                    Console.WriteLine(result2);
                    break;
                case 3:                 
                    Console.WriteLine(result3);
                    break;
                case 4:                   
                    Console.WriteLine(result4);
                   Console.WriteLine(firstsumm);
                    break;
            }
            Console.WriteLine();


int casel(int y1, int x1)
            {
                int summ = y1 & x1;
                return summ;
            }

            int addition(int y1, int x1)
            {
                int summ = y1 | x1;
                return summ;
            }
            int encryption(int y1, int x1)
            {
            int summ = y1 ^ x1;
                return summ;
            }
            int inversion(int y1, int x1)
            {
               int summ = ~y1;
               int firstsumm = ~x1;
                return summ;
            }

