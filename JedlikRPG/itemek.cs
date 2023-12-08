using System;

public class Item
{
    public string[] Items = { "Kaja", "Alkohol", "Pelenka" };
    public string[] Descriptions = { "Egyszerű pékáru ami csökkenti az éhséget.", "A subidubi segíti általános jókedvünk megőrzését", "A nap folyamán nem kell hugyoznod" };
    public int[] Elegemvan = { 0, -20, 0 };
    public int[] Hugyholyag = { 0, 25, 0 };
    public int[] Erő = { 5, 5, 0 };
    public string[] Ritkaság = { "common", "common", "perma" };
}
//struct Fogyaszthato Kaja = Fogyaszthato("Kaja", "Egyszerű pékáru.", 0, 0, 5, "Átlagos");
//struct Fogyaszthato Alkohol = Fogyaszthato("Alkohol", "Subidubi hohó.", -20, 25, 5, "Átlagos");
//--------------------------------------------par uj item otlet-----------------------------------------

//                                                  bufe:

//public string[] Items = { "Melegszendvics", "Energiaital", "Nyalóka"};
//public string[] Descriptions = { "Elsőre gombásnak hitted, ám ez egy sonkás szendvics.", "Végtére is a szíved és a fogaid nem ingyen lakbérben élnek...", "Az élet amúgyis szopás",  };
//public int[] Elegemvan = { 0, 0, 0 };
//public int[] Hugyholyag = { 0, 15, 0 };
//public int[] Erő = { 5, 10, 0 };
//public string[] Ritkaság = { "common", "common", "common" };

//                                               black market:

//public string[] Items = { "" };
//public string[] Descriptions = { "" };
//public int[] Elegemvan = {  };
//public int[] Hugyholyag = {  };
//public int[] Erő = {  };
//public string[] Ritkaság = { "" };