using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sprint2
{

    /// <summary>
    /// This helper method comes from username: Cyral @ stackOverflow
    /// https://stackoverflow.com/questions/12914002/how-to-load-all-files-in-a-folder-with-xna
    /// </summary>
    public static class TextureContent
    {
        public static Dictionary<string, T> LoadListContent<T>(ContentManager contentManager, string contentFolder)
        {
            DirectoryInfo dir = new DirectoryInfo(contentManager.RootDirectory + "/" + contentFolder);
            if (!dir.Exists)
                throw new DirectoryNotFoundException();
            Dictionary<String, T> result = new Dictionary<String, T>();

            FileInfo[] files = dir.GetFiles("*.*");
            foreach (FileInfo file in files)
            {
                string key = Path.GetFileNameWithoutExtension(file.Name);

                result[key] = contentManager.Load<T> (contentFolder + "/" + key);
                
            }
            return result;
        }
    }
}
