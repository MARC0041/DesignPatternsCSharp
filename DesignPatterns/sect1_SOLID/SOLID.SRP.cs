﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace DotNetDesignPatternDemos.SOLID.SRP
{
  // just stores a couple of journal entries and ways of
  // working with them
  public class Journal
  {
    private readonly List<string> entries = new List<string>();

    private static int count = 0;

    public int AddEntry(string text)
    {
      entries.Add($"{++count}: {text}");
      return count; // memento pattern!
    }

    public void RemoveEntry(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }

    // breaks single responsibility principle
    public void Save(string filename, bool overwrite = false)
    {
      File.WriteAllText(filename, ToString());
    }

    public void Load(string filename)
    {
      
    }

    public void Load(Uri uri)
    {
      
    }
  }

  // handles the responsibility of persisting objects
  public class Persistence
  {
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
      if (overwrite || !File.Exists(filename))
        File.WriteAllText(filename, journal.ToString());
    }
  }

  public class Demo
  {
    public static void Main_(string[] args)
    {
      var j = new Journal();
      j.AddEntry("I cried today.");
      j.AddEntry("I ate a bug.");
      WriteLine(j);

      var p = new Persistence();
      var filename = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "journal.txt");
      //System.Threading.Thread.Sleep(1000);
      p.SaveToFile(j, filename);
      //Process.Start(filename);
      System.Diagnostics.Process.Start(new ProcessStartInfo
        {
            FileName = filename,
            UseShellExecute = true
        });
    }
  }
}
