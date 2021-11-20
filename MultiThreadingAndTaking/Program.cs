using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingAndTaking
{
    public class Program
    {


        public static void Main(string[] args)
        {
            //#region q1

            //Task t = new Task(() =>
            //{

            //    for (int i = 1; i < 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //});
            //t.Start();
            //#endregion

            //#region q2

            //Task t2 = Task.Run(() =>
            //{
            //    DriveInfo driveInfo1 = new DriveInfo(@"C:\");
            //    DirectoryInfo directoryInfo1 = driveInfo1.RootDirectory;
            //    var nameOffFiles = directoryInfo1.GetFiles().
            //    Select(file => file.Name);
            //    foreach (var filename in nameOffFiles)
            //    {
            //        Console.WriteLine(filename);
            //    }

            //    DriveInfo driveInfo2 = new DriveInfo(@"C:\");
            //    DirectoryInfo directoryInfo2 = driveInfo2.RootDirectory;
            //    var nameOffFiles2 = directoryInfo2.GetFiles().
            //    Select(file => file.Name);
            //    foreach (var filename in nameOffFiles2)
            //    {
            //        Console.WriteLine(filename);
            //    }

            //}
            //);
            //////t2.Start();

            //#endregion

            //#region q3
            //NumNum numNum1 = new NumNum("num1");
            //NumNum numNum2 = new NumNum("num2");

            //NumNum numNum3 = new NumNum("num3");

            //NumNum numNum4 = new NumNum("num4");

            //Console.WriteLine("start Task");
            //numNum1.t3.Start();
            //numNum2.t3.Start();
            //numNum3.t3.Start();
            //numNum4.t3.Start();

            //Console.WriteLine("Task started");



            //#endregion

            #region Q4
            
            
            
            
            

            #endregion
            


        }
       

        class NumNum
        {
            public Task t3;
            public int SleepTime { get; set; }
           
            public NumNum(string taskName)
            {
                t3 = new Task(() => Sleep());
                SleepTime = new Random().Next(5);
                Console.WriteLine($"Task {t3.Id}; sleep time {SleepTime} seconds ");
                
            }

            public void Sleep()
            {
                Console.WriteLine($"{t3.Id} go to sleep");
                Console.WriteLine(t3.Status);
                //t3.Start();
                Thread.Sleep(SleepTime);
                Console.WriteLine(t3.Status);
                Console.WriteLine($"{t3.Id}  Done sleeping");

            }
        }

        public class Sum2
        {
            public static void SumNumbers(int startnum, int endnum)
            {

                int totalsum = 0;
                Task t4 = Task.Run(() =>
                {
                    for (int i = startnum; i < endnum; i++)
                    {

                        totalsum = totalsum + i;
                        Console.WriteLine(totalsum);
                    }
                });

                t4.Start();


            }


            
        }
    }
}
