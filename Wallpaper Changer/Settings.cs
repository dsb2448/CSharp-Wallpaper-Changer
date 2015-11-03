using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    class Settings
    {
        // Variables

        // Path to the settings file
        private static string SETTING_FILE_PATH = @"C:\Users\" + Environment.UserName + @"\Wallpaper Changer\Settings.txt";

        // Path to the programs folder
        private static string FOLDER_PATH = @"C:\Users\" + Environment.UserName + @"\Wallpaper Changer\";
        
        // List to store the data from the settings file
        private List<string> setting_options = new List<string>();

        public String file_location {get; set;}

        /// <summary>
        /// Constructor used to check if file path is created.
        /// </summary>
        public Settings()
        {   
            createFileStructure();
            createDataInSampleFile();
            getDataFromFile();
        }

        /// <summary>
        /// If the file directory is not created, create it.
        /// Called from - createDataInFile
        /// </summary>
        private void createFileStructure()
        {
            if (!Directory.Exists(FOLDER_PATH))
            {
                Directory.CreateDirectory(FOLDER_PATH);
                Directory.CreateDirectory(FOLDER_PATH + "Playlist");
            }
            else if (!Directory.Exists(FOLDER_PATH + "Playlist"))
            {
                Directory.CreateDirectory(FOLDER_PATH + "Playlist");
            }

            // See if the file Settings.txt exist and if not create it.
            if (!File.Exists(SETTING_FILE_PATH))
            {
                File.Create(SETTING_FILE_PATH).Dispose();
                setCurrentPlaylist(@"Playlist\Sample.wall");
            }

            if (File.Exists(FOLDER_PATH + @"Playlist\Sample.wall"))
            {
                File.Delete(FOLDER_PATH + @"Playlist\Sample.wall");
            }

            File.Create(FOLDER_PATH + @"Playlist\Sample.wall").Dispose();
        }// End of function createFileStructure()

        /// <summary>
        /// create a sample file and and populate it
        /// </summary>
        /// <remarks>
        /// This method checks to see if the sample.wall file exist 
        /// and if not create it and populate it with sample images.
        /// </remarks>
        private void createDataInSampleFile()
        {
            try
            {
                using (StreamWriter temp_stream_writer = new StreamWriter(FOLDER_PATH + @"Playlist\Sample.wall"))
                {
                    const string WINDOWS_IMAGES_FOLDER = @"C:\Windows\Web\Wallpaper\Theme1\";
                    for (int i = 1; i < 5; i++)
                    {
                        temp_stream_writer.WriteLine(WINDOWS_IMAGES_FOLDER + "img" + i + ".jpg");
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        /// <summary>
        /// if Data exist in the settings file retrieve it.
        /// </summary>
        public String getDataFromFile()
        {
            using (StreamReader temp_stream_reader = new StreamReader(SETTING_FILE_PATH))
            {
                file_location = temp_stream_reader.ReadLine();
            }

            return file_location;
        }

        public void setCurrentPlaylist(String new_file_location)
        {
            using (StreamWriter temp_stream_write = new StreamWriter(SETTING_FILE_PATH))
            {
                temp_stream_write.WriteLine(FOLDER_PATH + new_file_location);
            }
        }
    }// End of class Settings
}// End of namespace Wallpaper_Changer
