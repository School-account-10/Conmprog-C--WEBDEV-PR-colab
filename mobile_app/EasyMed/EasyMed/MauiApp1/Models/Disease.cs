using System.Collections.Generic;
using System.Linq;

namespace iLS.Models;

public class Disease
{
    // These properties match your JSON structure
    public string Name { get; set; }
    public string Severity { get; set; }
    public List<string> Symptoms { get; set; }

    public double CalculateMatch(List<string> userSelectedSymptoms)
    {
        // Normalize to lowercase for better matching
        var diseaseSymptoms = this.Symptoms.Select(s => s.ToLower().Trim()).ToHashSet();
        var userSymptoms = userSelectedSymptoms.Select(s => s.ToLower().Trim()).ToHashSet();

        if (diseaseSymptoms.Count == 0 || userSymptoms.Count == 0) return 0;

        double matches = diseaseSymptoms.Intersect(userSymptoms).Count();
        double totalUnique = diseaseSymptoms.Union(userSymptoms).Count();

        return matches / totalUnique;
    }
}

// Helper class for the Checkbox List
public class SymptomItem
{
    public string Name { get; set; }
    public bool IsChecked { get; set; }
}