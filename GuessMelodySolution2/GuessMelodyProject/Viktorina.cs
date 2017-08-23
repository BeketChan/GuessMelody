using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelodyProject
{
  static class Viktorina
  {
    static public List<string> list = new List<string>();
    static public int gameDuration = 60;
    static public int musicDuration = 10;
    static public bool randomStart = false;
    static public string lastFolder = "";
    static public bool allFolders = false;

    static public void ReadMusic()
    {
      string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
      list.Clear();
      list.AddRange(music_files);
    }

    static string regKeyName = "Software\\RomanProgs\\GuessMelody";

    static public void WriteParam()
    {
      RegistryKey rk = null;
      try
      {
        rk = Registry.CurrentUser.CreateSubKey(regKeyName);
        if (rk == null) return;
        rk.SetValue("LastFolder",lastFolder);
        rk.SetValue("RandomStart", randomStart);
        rk.SetValue("GameDuration", gameDuration);
        rk.SetValue("MusicDuration", musicDuration);
        rk.SetValue("AllFolders", allFolders);
      }
      finally
      {
        if (rk != null) rk.Close();
      }
      
    }

    static public void ReadParam()
    {
      RegistryKey rk = null;
      try
      {
        rk = Registry.CurrentUser.CreateSubKey(regKeyName);
        if (rk != null)
        {
          lastFolder = (string)rk.GetValue("LastFolder");
          randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
          gameDuration = (int)rk.GetValue("GameDuration");
          musicDuration = (int)rk.GetValue("MusicDuration");
          allFolders = Convert.ToBoolean(rk.GetValue("AllFolders"));
        }
      }
      finally
      {
        if (rk != null) rk.Close();
      }

    }
  }
}
