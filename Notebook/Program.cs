using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*           1:新建笔记          2：打开笔记                 *");
            Console.WriteLine("*           3:新建分类          4：管理分类                 *");
            Console.WriteLine("*           5:保存笔记          6：退出                     *");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*************************************************************");
            Notes mynotes = new Notes();
            while (true)
            {
                Console.WriteLine("请输入菜单选项（1-6）：");
                int option;
                option = Int16.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        mynotes.createNotes();
                        break;
                    case 2:
                        mynotes.openNotes();
                        break;
                    case 3:
                        mynotes.classifyNotes();
                        break;
                    case 4:
                        mynotes.manageClass();
                        break;
                    case 5:
                        mynotes.saveNotes();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("输入有误！");
                        break;
                }
            }
        }
    }
}