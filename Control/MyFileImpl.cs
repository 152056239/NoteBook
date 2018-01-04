using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
namespace Control
{
    public class MyFileImpl:IMyFileope
    {

        public void newNote()
        {
            Console.WriteLine("新建笔记！");
        }

        public void openNote()
        {
            Console.WriteLine("打开笔记！");
        }

        public void keepNote()
        {
            Console.WriteLine("保存笔记！");
        }

        public void deleteNote()
        {
            Console.WriteLine("删除笔记");
        }
    }
}
