using iLS.Models;
using System.Text.Json;

namespace iLS;

public partial class MainPage : ContentPage
{
    List<Disease> diseaseDB;
    List<SymptomItem> symptomsItems;

    public MainPage()
    {
        InitializeComponent();
        LoadSymptomsList();
        LoadDatabase();
    }

    void LoadSymptomsList()
    {
        symptomsItems = new List<SymptomItem>
        {
            new SymptomItem { Name = "Fever" }, new SymptomItem { Name = "Cough" },
            new SymptomItem { Name = "Headache" }, new SymptomItem { Name = "Fatigue" },
            new SymptomItem { Name = "Sore Throat" }, new SymptomItem { Name = "Runny Nose" }
            // Add others here...
        };
        SymptomList.ItemsSource = symptomsItems;
    }

    async void LoadDatabase()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("symptoms.json");
        using var reader = new StreamReader(stream);
        diseaseDB = JsonSerializer.Deserialize<List<Disease>>(await reader.ReadToEndAsync());
    }

    private void OnCheckClicked(object sender, EventArgs e)
    {
        var selected = symptomsItems.Where(s => s.IsChecked).Select(s => s.Name).ToList();
        if (!selected.Any()) return;

        Disease bestMatch = diseaseDB.OrderByDescending(d => d.CalculateMatch(selected)).FirstOrDefault();
        double score = bestMatch?.CalculateMatch(selected) ?? 0;

        lblOutput.Text = score > 0.5 ? $"Match: {bestMatch.Name}" : "No match found.";
        lblTimestamp.Text = $"Checked: {DateTime.Now:t}";
        
        // Save to History (Using MAUI AppDataDirectory)
        string path = Path.Combine(FileSystem.AppDataDirectory, "history.txt");
        File.AppendAllLines(path, new[] { $"{DateTime.Now}: {bestMatch?.Name}" });
    }

    async void OnHistoryClicked(object sender, EventArgs e) => await Navigation.PushAsync(new HistoryPage());
    
    void OnClearClicked(object sender, EventArgs e) { /* Logic to uncheck items */ }
}