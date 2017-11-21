using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class MainClass
    {
        static void Main(string[] args)
        {


            //get the passed filename 
            var fname = args[0];
            //var filename2 = args[1];
            //unsorted-names-list.txt
            //var fname = "/unsorted-names-list.txt";
            // var filename2 = "/Desc-names-list.txt";
            var filepath = Directory.GetCurrentDirectory() + "/" + fname;
         
            var outputFile = Directory.GetCurrentDirectory() + "/sorted-names-list.txt";
            var outputFile2 = Directory.GetCurrentDirectory() + "/Desc-names-list.txt";
            //check if the file exists 
            if (File.Exists(filepath))
            {
                var Names = new NameReader().ReadName(filepath);
             

                var sortedNames = new NameSorter().SortNameByFourthThenOthers(Names);
                var descNames = new NameDesc().SortNameByFourthThenOthers(Names);
                var newNames = new ListProcessor().reverseNamestoNormal(descNames);
                new NameWritterToConsole().WriteNames(descNames);
                new NameWritterToFile(outputFile2).WriteNames(descNames);

                Console.WriteLine("....................");
                var newName = new ListProcessor().reverseNamestoNormal(sortedNames);
                new NameWritterToConsole().WriteNames(sortedNames);
                new NameWritterToFile(outputFile).WriteNames(sortedNames);
            }
            else
            {
                Console.WriteLine("The passed file doesn't exist");
            }
            Console.ReadLine();
        }
        
    }
}
