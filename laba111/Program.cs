using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
List<int> numbers = new List<int> { 1, 2, 3, 2, 3, 4, 3, 4, 5, 4 };
int count = numbers.GroupBy(n => n).Select(g => g.Count()).Where(c => c > 1)
    .Select(c => c * (c - 1) / 2) 
    .Sum(); 
Console.WriteLine($"Кількість пар: {count}");
Dictionary<string, int> sampleDict = new Dictionary<string, int>
{
    {"a", 2},
    {"b", 3},
    {"c", 1},
    {"d", 5}
};
var multipliedDict = sampleDict.ToDictionary(pair => pair.Key, pair => pair.Value * pair.Value);
var sortedDict = multipliedDict.OrderBy(pair => pair.Value)
    .ToDictionary(pair => pair.Key, pair => pair.Value);
string json = JsonConvert.SerializeObject(sortedDict, Formatting.Indented);
Console.WriteLine(json);
char C = 'a';
string[] A = { "abc", "aa", "a", "aba", "aaa", "baba", "aacaa" };
int count_a = A.Count(s => s.Length > 1 && s.First() == C && s.Last() == C);

Console.WriteLine($"Кількість елементів, які починаються і закінчуються на '{C}' та містять більше одного символу: {count_a}");