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
            //unsorted-names-list.txt
            //var fname =   "/unsorted-names-list.txt";
            var filepath = Directory.GetCurrentDirectory() + "/" + fname;
            var outputFile = Directory.GetCurrentDirectory() + "/sorted-names-list.txt";
            //check if the file exists 
            if (File.Exists(filepath))
            {
                var Names = new NameReader().ReadName(filepath);
                var sortedNames = new NameSorter().SortNameByFourthThenOthers(Names);
                var newName = new ListProcessor().reverseNamestoNormal(sortedNames);
                new NameWritterToConsole().WriteNames(sortedNames);
                new NameWritterToFile(outputFile).WriteNames(sortedNames);
            }
            else
            {
                Console.WriteLine("The passed file doesn't exist");
            }
        }
        }
    } 
