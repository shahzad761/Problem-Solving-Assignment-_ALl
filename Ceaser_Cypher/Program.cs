using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the cypher text:");
            string a =  Console.ReadLine();
            int temp;
            Console.WriteLine("enter the cypher Key:");
            int key =Convert.ToInt32(Console.ReadLine());
            int Min = 97;
            int Max = 122;
            int z=key;

            int Add = 0;
            char[] ch = new char[a.Length];
            

            for (int i = 0; i < a.Length; i++)
            {
                // ch[i] = a[i];
                if (a[i] == ' ')
                {
                    Console.Write(" ");
                    continue;
                }   
                temp = Convert.ToInt32(Convert.ToChar(a[i]));
                
                if ((temp+key) <= Max)
                {
                    temp = temp + key;
                }
                else
                {
                    //int sub=  (Max - temp);
                    //temp = temp + sub;
                    if (key <= 26)
                    {
                        int sub = (Max - temp);
                        int neww = key - sub;
                        temp = Min-1;
                        temp = temp + neww;

                    }
                    else
                    {
                        while (z > 26)
                        {
                            z = z - 26;
                        }

                        if ((temp + z) <= Max)
                        {
                            temp = temp + z;
                        }
                        else
                        {
                            int sub = (Max - temp);
                            int neww = z - sub;
                            temp = Min - 1;
                            temp = temp + neww;
                        }
                        
                    }

                    

                }
             


                ch[i] = Convert.ToChar(temp);
                if (Char.IsUpper(Convert.ToChar(a[i])) == true)
                {
                    
                    ch[i]= Char.ToUpper(ch[i]);
                }


                Console.Write(ch[i]);



            
            }


        }
    }
}
 