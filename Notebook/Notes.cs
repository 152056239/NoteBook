using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Notebook
{
    class Notes : ICreate, IOpen, ISave, IClassify, IManagement
    {
        public void createNotes()
        {
            StreamWriter sw = new StreamWriter(@"F:/C#/workspace/note.txt", true);
            Console.WriteLine("已新建笔记");     
        }

        public void openNotes()
        {
            String file = @"F:/C#/workspace/note.txt";
            //初始化作为文件路径的包装的 FileInfo 类的新实例
            FileInfo info = new FileInfo(file);
            //新建进程
            Process p = new Process();
            //获取或设置要传递给 Process 的 Start 方法的属性。
            p.StartInfo.FileName = file;
            //info.DirectoryName 获取表示目录的完整路径的字符串
            p.StartInfo.WorkingDirectory = info.DirectoryName;
            p.Start();
        }

        public void saveNotes()
        {
            Console.WriteLine("请输入编辑的内容：");
            String text = Console.ReadLine();
            //新实例初始化 StreamWriter 类为使用 utf-8 编码及默认的缓冲区大小指定的流。
            StreamWriter sw = new StreamWriter(@"F:/C#/workspace/note.txt");
            //将后跟行结束符的字符串写入文本字符串或流。
            sw.WriteLine(text);
            Console.WriteLine("笔记已保存成功");
            //
            sw.Close();
        }

        public void classifyNotes()
        {
            Console.WriteLine("新建分类成功");
        }

        public void manageClass()
        {
            Console.WriteLine("管理分类模块");
        }
    }
}
