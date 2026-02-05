using System.IO;
using System.Linq;
using Microsoft.Maui.Controls;

namespace iLS;

public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();

        // 1. Get path to the history file
        string path = Path.Combine(FileSystem.AppDataDirectory, "history.txt");

        // 2. Check if file exists and load data
        if (File.Exists(path))
        {
            // Reverse so the newest entries are at the top
            var lines = File.ReadAllLines(path).Reverse().ToList();
            HistoryList.ItemsSource = lines;
        }
        else
        {
            HistoryList.ItemsSource = new List<string> { "No history records found yet." };
        }
    }
}