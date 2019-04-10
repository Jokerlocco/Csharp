//Ivan Lazcano Sindin

using System.IO;

class HTMLimgGenerator
{
    public static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] ficheros = dir.GetFiles();
        StreamWriter outFile = new StreamWriter("lista.html");
        outFile.WriteLine("<html><body><ol>");
        foreach (FileInfo s in ficheros)
        {
            if(s.Name.EndsWith(".png") || s.Name.EndsWith(".jpg"))
                outFile.WriteLine("<li><a href="
                              +s.Name+">"+s.Name+"  "+s.Length/1024+
                              " KB "+s.LastWriteTime+"</a></li>");
        }
        outFile.WriteLine("</ol></body></html>");
        outFile.Close();
    }
}
