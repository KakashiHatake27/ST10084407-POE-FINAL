﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePartThreeFinal
{
    internal class Storage
    {
        string filePath;

        public async Task WriteData(String textToSave)
        {
            var appFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var file = await appFolder.CreateFileAsync("BudgetApp.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);
            await Windows.Storage.FileIO.AppendTextAsync(file, textToSave + Environment.NewLine);

            filePath = file.Path.ToString();


            // Look in Output Window of Visual Studio for path to file
            System.Diagnostics.Debug.WriteLine(String.Format("File is located at {0}", file.Path.ToString()));
        }

        public string ReadData()
        {
            File();

            try
            {
                StreamReader reader = new StreamReader(filePath);
                StringBuilder builder = new StringBuilder();
                string line = "";

                int counter = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                    builder.AppendLine(counter.ToString() + " - " + line);
                }
                reader.Close();
                return builder.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }


        }


        public string ReadDataCustom(string section) 
        {
            File();

            try
            {
                StreamReader reader = new StreamReader(filePath);
                StringBuilder builder = new StringBuilder();
                string line = "";

                int counter = 0;

                while (((line = reader.ReadLine()) != null))
                {
                    counter++;
                    if (line.Contains(section))
                    {
                        
                        builder.AppendLine(RemovePart(section, line));
                        break;
                    }
                }
                reader.Close();
                return builder.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }


        }


        private string RemovePart(string toRemove, string text) {
          
            int pos = text.IndexOf(toRemove);
            string altertedString="";

            if (pos >= 0)
            {
                altertedString = text.Remove(0, pos);
                Console.Write(altertedString);
            }


            return altertedString;
        } 


        private async void File()
        {

            var appFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var file = await appFolder.CreateFileAsync("BudgetApp.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);


            filePath = file.Path.ToString();
        }

    }
}
