using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    class Settings
    {
        // Variables
        
        private const string SETTING_FILE_PATH = @"C:\Apps\Wallpaper Changer\Settings.txt";
        private List<string> setting_options = new List<string>();

        private String file_location;

        // End of Variables

        public String fileLocation
        {
            get { return file_location; }
            set { 
                    file_location = value;
                    
                    using (StreamWriter stream = new StreamWriter(SETTING_FILE_PATH))
                    {
                        stream.WriteLine(file_location);
                    }
                }
        }

        /// <summary>
        /// Constructor used to check if file path is created.
        /// </summary>
        public Settings()
        {
            createDataInFile();
        }

        /// <summary>
        /// if Data exist in the settings file retrieve it.
        /// </summary>
        public String getDataFromFile()
        {
            return fileLocation;
            // TODO: if data is in the settings file retrieve it, if not create it.
        }

        /// <summary>
        /// If no data in file create a sample file and retrieve it.
        /// </summary>
        private void createDataInFile()
        {
            while (true)
            {
                try
                {
                    using (StreamReader stream_r = new StreamReader(SETTING_FILE_PATH))
                    {
                        string line;
                        while ((line = stream_r.ReadLine()) != null)
                        { setting_options.Add(line); }
                    }
                    
                    if (setting_options.Count < 1)
                    {
                        using (StreamWriter stream_w = new StreamWriter(SETTING_FILE_PATH))
                        { stream_w.WriteLine(@"C:\Apps\Wallpaper Changer\Playlist\Sample.wall"); }
                        continue;
                    }
                    break;

                }
                catch (DirectoryNotFoundException)
                { createFileStructure(); }
                catch (FileNotFoundException)
                { createFileStructure(); }
            }

            fileLocation = setting_options[0];
        }

        /// <summary>
        /// If the file directory is not created, create it.
        /// Called from - createDataInFile
        /// </summary>
        private void createFileStructure()
        {
            // See if the directory "C:\Apps" exists and if not create it.
            if (!Directory.Exists(@"C:\Apps"))
            { Directory.CreateDirectory(@"C:\Apps"); }

            // See if the directory "C:\Apps\Wallpaper Changer" exists and if not create it.
            if (!Directory.Exists(@"C:\Apps\Wallpaper Changer"))
            { Directory.CreateDirectory(@"C:\Apps\Wallpaper Changer"); }

            // See if the directory "C:\Apps\Wallpaper Changer\Playlist" exist and if not create it.
            if (!Directory.Exists(@"C:\Apps\Wallpaper Changer\Playlist"))
            { Directory.CreateDirectory(@"C:\Apps\Wallpaper Changer\Playlist"); }

            // See if the file "C:\Apps\Wallpaper Changer\Settings.txt" exist and if not create it.
            if (!File.Exists(SETTING_FILE_PATH))
            {
                var my_file = File.Create(SETTING_FILE_PATH);
                my_file.Close(); ;
            }

            if (!File.Exists(@"C:\Apps\Wallpaper Changer\Playlist\Sample.wall"))
            {
                var my_file = File.Create(@"C:\Apps\Wallpaper Changer\Playlist\Sample.wall");
                my_file.Close();

                using (StreamWriter stream_w = new StreamWriter(@"C:\Apps\Wallpaper Changer\Playlist\Sample.wall"))
                {
                    String[] files = Directory.GetFiles(@"C:\Users\Scott\Pictures", "*.jpg");
                    foreach (string file in files)
                    { stream_w.WriteLine(file); }
                }
            }
        }// End of function createFileStructure()
    }// End of class Settings
}// End of namespace Wallpaper_Changer
