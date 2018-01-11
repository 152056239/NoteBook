

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook2
{
    class Notebook
    {
        public string title;//笔记名称
        public string content;//笔记内容
        public string classify;//笔记类型

        public string Classify
        {
            get { return classify; }
            set { classify = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime Time
        {
            get { return DateTime.Now; }
        }

        Menu me = new Menu();
        //新建笔记
        public void SetNote(Object sender, FunctionEventArgs e)
        {
            if (e._choose == 1)
            {
                Console.WriteLine("请输入笔记的名称：");
                this.Title = Console.ReadLine();
                Console.WriteLine("请输入笔记的内容：");
                this.Content = Console.ReadLine();
                Console.WriteLine("请输入笔记的类型：");
                this.Classify = Console.ReadLine();
                //note.Classify = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("是否保存笔记：（y/n）    ");
                if (Console.ReadLine().Equals("y"))
                {
                    //NoteBookEventArgs nb = new NoteBookEventArgs(x);
                    // NoteBook(nb);
                    save(sender, e);
                }
                else
                {
                    System.Environment.Exit(0);
                }
                me.Menu1();
            }
        }

        //笔记保存
        public void save(Object sender, FunctionEventArgs e)
        {
            //创建一个文件夹
            string activeDir = @"D:\All resource\C#";

            string newPath = System.IO.Path.Combine(activeDir, classify);
            System.IO.Directory.CreateDirectory(newPath);
            //创建子文件夹
            //   title = System.IO.Path.GetRandomFileName();
            newPath = System.IO.Path.Combine(newPath, title + ".txt");

            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    //将内容保存
                    fs.Close();
                    System.IO.File.WriteAllText(newPath, content);
                    Console.WriteLine("保存成功！");
                }
            }

            // Read data back from the file to prove
            // that the previous code worked.
            //try
            //{
            //    byte[] readBuffer = System.IO.File.ReadAllBytes(newPath);
            //    foreach (byte b in readBuffer)
            //    {
            //        Console.WriteLine(b);
            //    }
            //}
            //catch (System.IO.IOException e1)
            //{
            //    Console.WriteLine(e1.Message);
            //}
            // Keep the console window open in debug mode.
        }

        //打开笔记
        public void Open(Object sender, FunctionEventArgs e)
        {
            if (e._choose == 2)
            {
                Console.WriteLine("请输入要打开的文档类型：");
                classify = Console.ReadLine();
                Console.WriteLine("请输入要打开的文档名字：");
                title = Console.ReadLine();
                string text = System.IO.File.ReadAllText(@"D:\All resource\C#\" + classify + "\\" + title + ".txt");
                // Display the file contents to the console.
                System.Console.WriteLine("文档中的内容是 : {0}", text);
                me.Menu1();
            }
        }
    }
}
