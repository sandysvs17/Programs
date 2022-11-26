using System;  
   class Palindrome 
   {  
     public static void Main(string[] args)  
      {  
          int num,r,sum=0,t;    
          Console.Write("Enter the Number: ");   
          n = int.Parse(Console.ReadLine());  
          t=num;      
          while(n>0)      
          {      
           r=num%10;      
           sum=(sum*10)+r;      
           num=num/10;      
          }      
          if(t==sum)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");     
    }  
  }