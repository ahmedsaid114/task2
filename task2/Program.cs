namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int count = 0;
            char choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToChar(Console.ReadLine());

                
                if (choice == 'P' || choice == 'p')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                }

                
                else if (choice == 'A' || choice == 'a')
                {
                    Console.Write("Enter a number: ");
                    numbers[count] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numbers[count] + " added");
                    count++;
                }

                
                else if (choice == 'M' || choice == 'm')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int sum = 0;

                        for (int i = 0; i < count; i++)
                        {
                            sum += numbers[i];
                        }

                        double mean = (double)sum / count;
                        Console.WriteLine("The mean is " + mean);
                    }
                }

                
                else if (choice == 'S' || choice == 's')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];

                        for (int i = 1; i < count; i++)
                        {
                            if (numbers[i] < smallest)
                            {
                                smallest = numbers[i];
                            }
                        }

                        Console.WriteLine("The smallest number is " + smallest);
                    }
                }


                else if (choice == 'L' || choice == 'l')
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];

                        for (int i = 1; i < count; i++)
                        {
                            if (numbers[i] > largest)
                            {
                                largest = numbers[i];
                            }
                        }

                        Console.WriteLine("The largest number is " + largest);
                    }
                }


                else if (choice != 'Q' && choice != 'q')
                {
                    Console.WriteLine("Unknown selection, please try again");
                }

            } while (choice != 'Q' && choice != 'q');

            Console.WriteLine("Goodbye");
        }



    }
}

