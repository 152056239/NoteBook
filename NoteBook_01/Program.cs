using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control;
using Interface;
namespace NoteBook_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*           1:新建笔记          2：打开笔记                 *");
            Console.WriteLine("*           3:保存笔记          4：删除笔记                 *");
            Console.WriteLine("*           5:新建分类          6：退出                     *");
            Console.WriteLine("*                                                           *");
            Console.WriteLine("*************************************************************");
            ICateope C = new CateopeImpl();
            IMyFileope F = new MyFileImpl();
            while (true)
            {
                Console.WriteLine("请输入菜单选项（1-6）：");
                int equ;
                char flag;
                equ = Int16.Parse(Console.ReadLine());
                switch (equ)
                {
                    case 1:
                        F.newNote();
                        break;
                    case 2:
                        F.openNote();
                        break;
                    case 3:
                        F.keepNote();
                        break;
                    case 4:
                        F.deleteNote();
                        break;
                    case 5:
                        C.createCategory();
                        break;
                    default:
                        Console.WriteLine("输入有误！");
                        break;
                }
               
                Console.WriteLine("是否继续，继续Y,退出N");
                flag = char.Parse(Console.ReadLine());
                if (flag == 'n' || flag == 'N')
                    break;
            }
        }
    }
}
