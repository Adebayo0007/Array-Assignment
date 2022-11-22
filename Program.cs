using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

                 //fisrt way
         //    int [] myArray = new int[6];
         //    myArray [0] = 7;
         //    myArray [3] = 5;
         //    Console.WriteLine(myArray[0]);


                         //second way  
               
            //    int [] myArray = {1,2,3,4,5,6};
            //    Console.WriteLine(myArray[0]);


                    //third method
             //    int [] myArray = new int[] {1,2,3,4,5,6};
             //    Console.WriteLine(myArray[0]);


                // int [] myArray = {1,2,3,4,5,6};
                // for(int i = 0; i < myArray.Length; i++)
                // {
                //     Console.WriteLine(myArray[i]);
                // }



               //  int [] myArray = {1,2,3,4,5,6};
               //  foreach (var item in myArray)
               //  {
               //      Console.WriteLine(item);
               //  }

                

                


                // int [] elements  = new  int [6];
                // long sum = 0;
                // for (int i = 0 ; i < elements.Length; i++)

                // {
                //     Console.WriteLine("enter the next element: ");
                //     elements[i] = int.Parse(Console.ReadLine());
                // }
                // foreach(int element in elements)
                // {
                //     Console.Write(element + " ");
                //     sum += element;
                // }
                // Console.WriteLine();
                // Console.WriteLine($"your sum is: {sum}");





                      //NUMBER 1

               //  int [] elements  = new  int [6];
                
               //  for (int i = 0 ; i < elements.Length; i++)

               //  {
               //      Console.WriteLine("enter the next element: ");
               //      elements[i] = int.Parse(Console.ReadLine());
               //  }
              
               //  foreach(int element in elements)
               //  {
                    
               //        int j = element % 2;
                    
               //      if(j==0)
               //      {
               //      Console.WriteLine(element);
               //      }
                    
               //  }




                //         array
                //one dimentinal array
                //multidimentinal array
                //jagged array


                //two dimentional

                // int[ , ] matrix3 = { 
                //     {1,4,5,5},
                //     {3,4,5,6},
                //     {3,4,5,7},
                //     {3,4,5,8}

                // };

                // Console.WriteLine(matrix3[0,0]);
                // Console.WriteLine(matrix3[3,3]);





               //      int[ , ] matrix3 = { 
               //      {1,4,5,5},
               //      {3,4,5,6},
               //      {3,4,5,7},
               //      {3,4,5,8}

               //  };
               //  for(int i = 0; i < matrix3.GetLength(0); i++)
               //  {
                
               //  for(int j = 0 ; j < matrix3.GetLength(1); j++){
                
               //      Console.Write(matrix3[i,j] + " ");
               //  }
                
               //  Console.WriteLine();
               //  }







               //  Console.WriteLine("enter your the row number");
               //  int rows = Convert.ToInt32(Console.ReadLine());
               //  Console.WriteLine("enter your the colomn number");
               //  int coloumns = Convert.ToInt32(Console.ReadLine());

               //   int [ , ] matrix4 = new int [rows,coloumns];

               //     Console.WriteLine("enter your matrix number");
               //  for(int row = 0; row < rows; row++)
               //  {

               //      for(int coloumn = 0; coloumn < coloumns; coloumn++)
               //      {
               //      Console.WriteLine($"enter matrix4[{row}, {coloumn}]");
               //      matrix4[row,coloumn] = Convert.ToInt32(Console.ReadLine());
                   
               //      }
               //  }

               //   for(int row = 0; row < matrix4.GetLength(0); row++)
               //  {
                
               //  for(int coloumn = 0 ; coloumn < matrix4.GetLength(1); coloumn++)
               //  {
                
               //      Console.Write(matrix4[row,coloumn] + " ");
               //  }
                
               //  Console.WriteLine();
               //  }






               //  int [] array = new int[] {1,5,3,2};
               //  var largest = 0;
               // for(int i = 0; i < array.Length; i++)
               // {
               //  if(array[i] > largest)
               //  {
               //      largest = array[i];
               //  }

               // }
               // Console.WriteLine(largest);




            //    int [] array = new int [] {5,5,3,1};
            //    int lowest = 0;
            //    int largest = 0;
            //    for(int t = 0; t < array.Length; t++)
            //    {
            //     for(int s = 1; s < array.Length; s++)
            //     {
            //       if(array[t] < array [s])
            //       {
            //          lowest = array[t];

            //       }
                  
            //     }
            //    }
            //    for(int t = 0; t < array.Length; t++)
            //    {
            //    if(array[t] > largest)
            //       {
            //         largest = array[t];

            //       }
            //    }
            //    Console.WriteLine($" your smallest number is:  {lowest}");
            //     Console.WriteLine($" your biggest number is:  {largest}");






            //   int [] array = new int[] {1,5,3,2};
              
            //    int x = 0;
            //    for(int y = 0; y < array.Length; y++)
            //    {
            //     x +=array[y];
                
            //    }
            //    Console.WriteLine(x);

            


            // int [] elements = new int[6];
            // elements[0] = 5;
            // elements[1] = 4;
            // elements[2] = 5;
            // elements[3] = 4;
            // elements[4] = 5;

            // int s = 0;
            // for(int r = 0; r < 6; r++)
            // {
            //     s += elements[r];
             // }
            // Console.Write(s);

        




            // int [] elements = new int[5];
            // elements[0] = 5;
            // elements[1] = 6;
            // elements[2] = 5;
            // elements[3] = 4;
            // elements[4] = 2;
            //  for(int r = 0; r < 5; r++)
            // { 
            //     if (elements [r] % 2 == 0)
            //     Console.WriteLine(elements[r]);
            // }
         
            
             
           

            //     int [] a= new int [3];
            //     a [0] = 1;
            //     a [1] = 2;
            //     a [2] = 3;
            //    for(int i = 0; i < a.Length; i++)
            //    {
            //         Console.WriteLine(a[i]);
            //    }


           
           
            //   int [] a= new int [3];
            //     a [0] = 1;
            //     a [1] = 2;
            //     a [2] = 3;
            //       int i = 0;
            //     while (i < a.Length)
            //     {
            //         Console.WriteLine(a[i]);
            //         i++;
            //     }




                //to get length of row in multidimentinal array
                // Console.WriteLine(names.GetLength(0));

                //to get length of coloumn in multidimentinal array
                // Console.WriteLine(names.GetLength(1));



                // int [] array = {3,4,5,6,7};
                // for (int i = 0; i < array.Length; i++)
                // Console.Write(array[i] + "," );




                // Console.WriteLine("enter your rows number");
                // int row = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("enter your coloums number");
                // int colomn = Convert.ToInt32(Console.ReadLine());
                // string [ , ] names = new string [row,colomn];
                // for (int i = 0; i < names.GetLength(0); i++)
                // {
                //     for(int j = 0; j < names.GetLength(1); j++)
                //     {
                //         Console.WriteLine($"enter name for [{i} ,{j} ]");
                //         string name = Console.ReadLine();
                //         names [i,j] = name;
                //     }
                // }
                // for (int i = 0; i < names.GetLength(0); i++)
                // {
                //     for(int j = 0; j < names.GetLength(1); j++)
                //     {
                //         Console.Write($"{names[i,j]}, ");
                //     }
                // }




                // Console.WriteLine("enter your rows number");
                // int row = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("enter your coloums number");
                // int colomn = Convert.ToInt32(Console.ReadLine());
                // string [ , ] names = new string [row,colomn];
                // for (int i = 0; i < names.GetLength(0); i++)
                // {
                //     Console.WriteLine($"enter {names.GetLength(1) } names for row ({i+1}) and separate them with space");
                //     string userName = Console.ReadLine();
                //     string [] userInput = userName.Split(" ");
                //     for(int j = 0; j < names.GetLength(1); j++)
                //     {
                //         names [i,j] = userInput[j];

                //     }
                // }
                // for (int i = 0; i < names.GetLength(0); i++)
                // {
                //     for(int j = 0; j < names.GetLength(1); j++)
                //     {
                //         Console.Write($"{names[i,j].Replace(","," ")} ");
                //     }
                //     Console.WriteLine();
                // }





                //ascending and descending order of array


                // int[] numbers = {1,2,3,4,5};
                // int max = 0;
                // int min = 0;
                // for(int j = 0; j < numbers.Length; j++)
                // {
                
                //     if(numbers[j] > numbers[max] )
                //     {
                //        max=numbers[j];
                //     }
                //    if (numbers[j]<numbers[min])
                //    {
                //     min=numbers[j];
                //    }
                // }
                //  int swap=numbers[max];
                //  numbers[max] = numbers[min];
                //  numbers[min] = swap;
                // foreach (var item in numbers)
                // {
                //     Console.WriteLine(item);
                // }







            // int[] numbers = {1,3,4,5,5,3,2,2,3,4,5};
            // int count = 0;
            // for(int h = 0; h < numbers.Length; h++)
            // {
            //     for(int y = h+1; y < numbers.Length; y++)
            //     {
            //         if(numbers[h] == numbers[y])
            //         {
            //             count++;
            //             int now = count;

            //         }
            //         Console.WriteLine($"numbers{h} = {count}");
                
            //     }
                
            // }




            // Console.WriteLine("enter the number to be tested");
            // int number = Convert.ToInt32(Console.ReadLine());
            //  int [] numbers = {2,3,4,5,2,3,4,6};
            //  bool isPresent = false;
            //  for(int g = 0; g < numbers.Length; g++)
            //  {
            //     if(number == numbers[g])
            //     {
            //         isPresent = true;
            //         break;
            //     }

            //  }
            
            // if(isPresent)
            // {
            //     Console.Write("Found");
            // }      
            //  else{
            //     Console.Write("Not found");
            //  }
                









            //  Console.WriteLine("enter the number to be tested");
            // int number = Convert.ToInt32(Console.ReadLine());
            //  int [] numbers = {2,3,4,5,2,3,4,6};
            //  bool isPresent = false;
            //  for(int g = 0; g < numbers.Length; g++)
            //  {
            //    if (number == numbers[g])
            //    {
            //       isPresent = true;
            //     Console.WriteLine("its found");
            //     {
            //       break;
            //     }
            //    }
            //  }
            
            //       if (isPresent)
            //    {
                
            //     Console.WriteLine("its not found");
            //    }
 
            



                

     



                

                   //NUMBER 4
            
            // int [] myArray = {2,2,2,3,4,3,3,3,3,3,4,4,4,4,5,2,2};

            // int recent = myArray[0];
            // int recentCount = 1;
            // int longest = 0;
            // int longestCount = 0;
            
            // for(int i = 0; i < myArray.Length-1; i++)
            // {
            //     if((myArray[i] != myArray[i+1]))
            //     {
            //         if(recentCount > longestCount)
            //         {
            //             longest = recent;
            //             longestCount = recentCount;
            //             recent = myArray[i + 1];
            //             recentCount = 1;
            //         }
                    
            //     }
            //     else
            //     {
            //         recentCount++;
            //     }
            // }

            // for(int i =1; i<=longestCount;i++)
            // {
            //     Console.Write($"{longest}, ");
            // }
    




                                      //NUMBER 1

            //  int[] array = new int[20];

            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = i * 5;
            //     Console.WriteLine(array[i]);
            // }


                              //NUMBER 2


            //  bool arraysEqual = true;

            // Console.Write("Enter lenght of first array: ");
            // int length = Int32.Parse(Console.ReadLine());

            // int[] arrayA = new int[length];

            // for (int i = 0; i < arrayA.Length; i++)
            // {
            //     Console.Write("Enter element {0}: ", i);
            //     arrayA[i] = Int32.Parse(Console.ReadLine());
            // }

            // Console.Write("Enter lenght of second array: ");

            // if (length != Int32.Parse(Console.ReadLine())) 
            // {
            //     Console.WriteLine("\nArrays have different lengths.");
            // }
            // else
            // {
            //     int[] arrayB = new int[length];

            //     for (int i = 0; i < arrayB.Length; i++)
            //     {
            //         Console.Write("Enter element {0}: ", i);
            //         arrayB[i] = Int32.Parse(Console.ReadLine());
            //     }

            //     for (int i = 0; i < arrayA.Length; i++)
            //     {
            //         if (arrayA[i] != arrayB[i])
            //         {
            //             Console.WriteLine("\nArrays are different.");
            //             arraysEqual = false;
            //             break;
            //         }
            //     }

            //     if (arraysEqual) 
            //     {
            //         Console.WriteLine("\nArrays are the same.");
            //     }
            // }





  
               
                
                

                    //you are having an array of integers,the number os array must be determined by user,
                
            //   int [] ment = {9,5,8,1,2,18,6,4,1};
            //   int comp = 0;
            //   for(int i = 0; i < ment.Length; i++ )
            //   {
            //     for(int j = 1; j < ment.Length; j++ )
            //     {
            //     if(ment[i] < ment[j])
            //     {
            //         comp = ment[i];
            //         ment[j] = comp;   
            //     }
            //     }
            //   }
            
            //    Console.WriteLine(comp);
         

            //    int [] checks = {3,4,2,2,2,10,6,7,};
            //   int count = 0;
            //   int tempCount = 1;
            //   int number = 0;
            //   for(int i = 0; i < checks.Length; i++)
            //   {
            //         for(int j = 1; j < checks.Length; j++)
            //        {
            //             if(checks[i] == checks [j])
            //            {
            //                 tempCount++;
            //                  number = checks[i];
            //                  if(tempCount > count)
            //                {
            //                   count = tempCount;
            //                 }
            //             }     
            //         }
            //      } 
            //     for(int k = 0; k < count; k++)
            // {
            //     Console.Write(number + " ");
            // }


            


            // int integer = 123;
            // string conv =Convert.ToString(integer);
            //     string sub1 = conv.Substring(0,1);
            //     int sub11 = Convert.ToInt32(sub1);
            //     string sub2 = conv.Substring(1,1);
            //     int sub22 = Convert.ToInt32(sub2);
            //     string sub3 = conv.Substring(2,1);
            //     int sub33 = Convert.ToInt32(sub3);
            //     int [] converter = new int []{sub11,sub22,sub33};
            //    for(int i =0; i < converter.Length; i++)
            //    {
            //     Console.Write($"{converter[i]}, ");
            //    }




        //   int[] numbers = {2,3,4,5,6,7};
            // int [] num = new int [6];
            // for(int i =0; i < numbers.Length;i++)
            // {
            // num[i] = numbers [i];
            // } 
            // foreach(int n in num)
            // { 
            // Console.WriteLine(n);
            // }



        }
    }
}
