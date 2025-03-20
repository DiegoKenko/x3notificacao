using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;

class m
{
    public static void Main(string[] args)
    {
        List<string> list = new c.Conn().connect();
        new scripts.toast().buildToast(list);  
    }
}

