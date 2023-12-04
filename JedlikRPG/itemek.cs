using System;

public class Item
{
    public string Name = "Taknyos zsebkendő";
    public string Description = "Taknyos.";

    string[] Items = { "Kaja", "Alkohol", "Pelenka" };
    string[] Descriptions = { "Egyszerű pékáru ami csökkenti az éhséget.", "A subidubi segíti általános jókedvünk megőrzését", "A nap folyamán nem kell hugyoznod" };
    int[] Elegemvan = { 0, -20, 0 };
    int[] Hugyholyag = { 0, 25, 0 };
    int[] Erő = { 5, 5, 0 };
}
//struct Fogyaszthato Kaja = Fogyaszthato("Kaja", "Egyszerű pékáru.", 0, 0, 5, "Átlagos");
//struct Fogyaszthato Alkohol = Fogyaszthato("Alkohol", "Subidubi hohó.", -20, 25, 5, "Átlagos");