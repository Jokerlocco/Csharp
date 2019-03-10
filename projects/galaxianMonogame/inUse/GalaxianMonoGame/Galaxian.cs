using System;

namespace GalaxianMonoGame
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Galaxian
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var manager = new ScreensManager())
                manager.Run();
        }
    }
#endif
}
