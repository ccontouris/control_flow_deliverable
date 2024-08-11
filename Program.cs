// namespace control_flow_deliverable
// {
//    public class Program
//     {
//         static void Main(string[] args)
//         {
//             int score = 75;
//             char grade;

//             if (score >= 90)
//             {
//                 grade = 'A';
//             }
//             else if (score >= 80)
//             {
//                 grade = 'B';
//             }
//             else if (score >= 70)
//             {
//                 grade = 'C';
//             }
//             else if (score >= 60)
//             {
//                 grade = 'D';
//             }
//             else
//             {

//                 grade = 'F';

//             }
//             System.Console.WriteLine("Your grade is: " + grade);
//         }

//     }
// }

// using System.Data.Common;

// namespace control_flow_deliverable
// {
//  public class SwitchCase
//     {
//         static void Main(string[] args)
//         {
//             int score = 77;
//             switch (score)
//             {
//                 case  >= 90 :
//                     Console.WriteLine("Grade A");
//                     break;

//                 case  >= 80 :
//                     Console.WriteLine("Grade B");
//                     break;

//                 case >= 70 :
//                     Console.WriteLine("Grade C");
//                     break;

//                 case >= 60 :
//                     Console.WriteLine("Grade D");
//                     break;

//                 default:
//                     Console.WriteLine("FAILLLL");
//                     break;

//             }
//         }
//     }
// }

namespace control_flow_deliverable
{
    class Ternary
    {
        static void Main(string[] args)
        {
            int score = 88;
            char grade = score >= 90 ? 'A' :
                         score >= 80 ? 'B' :
                         score >= 70 ? 'C' :
                         score >= 60 ? 'D' : 'F';

                    System.Console.WriteLine(grade);
        }
    }
}