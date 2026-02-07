using System;
using System.Collections.Generic;
using LLM.classes;

//Pamiętaj o przeniesieniu folderu import do katalogu bin/debug/netXX/ po pierwszym skompilowaniu projektu.

class Program
{
    static void Main()
    {
        //-- Pobieranie plików --
        string rootsPath = "import/roots.txt"; //rdzenie
        string prefixesPath = "import/prefixes.txt"; //przedrostki
        string suffixesPath = "import/suffixes.txt"; //przyrostki
        string outputPath = "export/generated_words.txt"; //plik do eksportu

        List<string> roots = FileLoader.LoadList(rootsPath);
        List<string> prefixes = FileLoader.LoadList(prefixesPath);
        List<string> suffixes = FileLoader.LoadList(suffixesPath);


        //-- Dodawanie do listy wariantu bez przed/przyrostków --
        prefixes.Insert(0, "");
        suffixes.Insert(0, "");

        //-- Generowanie i zapisywanie słów --
        List<string> words = WordGenerator.Generate(prefixes, roots, suffixes);
        FileSaver.SaveToTxt(outputPath, words);

        //-- Wyświetlanie podsumowania --
        Console.WriteLine("Input data:");
        Console.WriteLine($"Prefixes: {prefixes.Count - 1}");
        Console.WriteLine($"Roots: {roots.Count}");
        Console.WriteLine($"Suffixes: {suffixes.Count - 1}");

        Console.WriteLine($"\nGenerated words: {words.Count}");
        Console.WriteLine($"Saved to file: {outputPath}");
    }
}
