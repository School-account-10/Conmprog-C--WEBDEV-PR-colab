using iLS.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace iLS;

public partial class MainPage : ContentPage
{
    List<Disease> diseaseDB;
    List<SymptomItem> symptomsItems;

    public MainPage()
    {
        InitializeComponent();
        LoadSymptoms();
        LoadDatabase();
    }

    void LoadSymptoms()
    {
        symptomsItems = new List<SymptomItem>
        {
            new SymptomItem { Name = "Fever" }, new SymptomItem { Name = "Cough" },
            new SymptomItem { Name = "Headache" }, new SymptomItem { Name = "Fatigue" },
            new SymptomItem { Name = "Sore Throat" }, new SymptomItem { Name = "Runny Nose" },
            new SymptomItem { Name = "Nausea" }, new SymptomItem { Name = "Vomiting" },
            new SymptomItem { Name = "Diarrhea" }, new SymptomItem { Name = "Shortness of Breath" },
            new SymptomItem { Name = "Chest Pain" }, new SymptomItem { Name = "Body Aches" }
        };
        SymptomList.ItemsSource = symptomsItems;
    }

    async void LoadDatabase()
    {
        try
        {
            // 1. Load the JSON file from Resources/Raw
            using var stream = await FileSystem.OpenAppPackageFileAsync("symptoms.json");
            using var reader = new StreamReader(stream);
            string json = await reader.ReadToEndAsync();

            // 2. FIX: Use Case Insensitive options so "symptoms" matches "Symptoms"
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            diseaseDB = JsonSerializer.Deserialize<List<Disease>>(json, options);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error loading database: {ex.Message}");
            lblOutput.Text = "Error loading database.";
        }
    }

    private void OnCheckClicked(object sender, EventArgs e)
    {
        // Get selected symptoms
        var selected = symptomsItems.Where(s => s.IsChecked).Select(s => s.Name).ToList();

        if (selected.Count == 0)
        {
            lblOutput.Text = "Please select at least one symptom.";
            return;
        }

        if (diseaseDB == null || diseaseDB.Count == 0)
        {
            lblOutput.Text = "Database not loaded.";
            return;
        }

        // Find the best match
        Disease bestMatch = null;
        double highestScore = 0;

        foreach (var d in diseaseDB)
        {
            double score = d.CalculateMatch(selected);
            if (score > highestScore)
            {
                highestScore = score;
                bestMatch = d;
            }
        }

        UpdateUI(bestMatch, highestScore);
        SaveToHistory(bestMatch, selected);
    }

    void UpdateUI(Disease match, double score)
    {
        if (match == null || score < 0.3)
        {
            lblOutput.Text = "No clear match found. Please consult a doctor.";
            ResultFrame.BackgroundColor = Colors.Gainsboro;
        }
        else
        {
            int percent = (int)(score * 100);
            lblOutput.Text = $"{match.Name} ({percent}% match)";

            // Set color based on severity
            ResultFrame.BackgroundColor = match.Severity?.ToLower() == "high" ? Colors.LightCoral : Colors.LightGreen;
        }
        lblTimestamp.Text = $"Checked: {DateTime.Now:t}";
    }

    // Save result to local storage
    private void SaveToHistory(Disease match, List<string> selected)
    {
        try
        {
            string path = Path.Combine(FileSystem.AppDataDirectory, "history.txt");
            string resultName = match != null ? match.Name : "No Match";
            string entry = $"[{DateTime.Now:g}] Result: {resultName} | Symptoms: {string.Join(", ", selected)}";

            File.AppendAllLines(path, new[] { entry });
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Failed to save history: {ex.Message}");
        }
    }

    async void OnHistoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistoryPage());
    }

    void OnClearClicked(object sender, EventArgs e)
    {
        // Uncheck all items
        foreach (var item in symptomsItems) item.IsChecked = false;

        // Refresh the list UI
        SymptomList.ItemsSource = null;
        SymptomList.ItemsSource = symptomsItems;

        // Reset labels
        lblOutput.Text = "Select symptoms to start";
        ResultFrame.BackgroundColor = Colors.Gainsboro;
        lblTimestamp.Text = "Last checked: --";
    }
}