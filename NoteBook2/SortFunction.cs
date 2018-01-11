using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook2
{
    class SortFunction
    {
        Notebook mynote = new Notebook();
        //新建分类
        public void sort(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 2)
            {
                //创建一个文件夹
                Console.WriteLine("请输入笔记的类型：");
                mynote.Classify = Console.ReadLine();
                if (!System.IO.Directory.Exists(@"D:\All resource\C#\" + mynote.classify))
                {
                    string activeDir = @"D:\All resource\C#";
                    string newPath = System.IO.Path.Combine(activeDir, mynote.classify);
                    System.IO.Directory.CreateDirectory(newPath);
                    Console.WriteLine("创建成功！");
                }
                else
                {
                    Console.WriteLine("文件类已经存在");
                }
            }
        }
        //查询所有分类
        public List<string> findCategory()
        {

            string[] folders = System.IO.Directory.GetDirectories(@"D:\All resource\C#");
            List<string> list = new List<string>();
            foreach (string category in folders)
            {
                list.Add(category.Substring(category.LastIndexOf('\\') + 1));
            }
            return list;
        }

        public void showCategory(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 1)
            {
                foreach (string category in findCategory())
                {
                    Console.WriteLine("存在的分类有：" + category);
                }
            }
        }

        //修改分类
        public void ModifySort(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 4)
            {
                Console.Clear();
                Console.WriteLine("请输入需要修改的分类：");
                mynote.Classify = Console.ReadLine();
                if (!System.IO.Directory.Exists(@"D:/All resource/C#" + mynote.classify))
                {
                    //Console.WriteLine("hi");
                    try
                    {
                        System.IO.Directory.Delete(@"D:/All resource/C#/" + mynote.classify);
                        Console.WriteLine("修改后的分类名");
                        mynote.classify = Console.ReadLine();
                        string activeDir = @"D:/All resource/C#";
                        string newPath = System.IO.Path.Combine(activeDir, mynote.classify);
                        System.IO.Directory.CreateDirectory(newPath);
                        Console.WriteLine("修改成功！");
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("修改的分类不存在");
                    }
                }
            }
        }
        //删除分类
        public void Delete(Object sender1, FunctionEventArgs e2)
        {
            if (e2._choose == 3)
            {
                Console.WriteLine("请输入需要删除的分类：");
                mynote.classify = Console.ReadLine();
                //  Console.WriteLine("请输入笔记名称：");
                // nb.title = Console.ReadLine();
                if (System.IO.Directory.Exists(@"D:\All resource\C#\" + mynote.classify))
                {

                    /*try
                    {
                        System.IO.Directory.Delete(@"D:\All resource\C#" + mynote.classify);
                        Console.WriteLine("删除成功!");

                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }*/
                    System.IO.Directory.Delete(@"D:\All resource\C#\" + mynote.classify);
                    Console.WriteLine("删除成功!");
                }
                else
                {
                    Console.WriteLine("删除的文件类型不存在!");
                }
            }
        }
    }
}
