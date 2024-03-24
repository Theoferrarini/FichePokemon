using System;
using UnityEngine;

[Serializable]
public class PokemonData
{
    [Serializable]

    public struct Stats
    {
        public int hp;
        public int attaque;
        public int defense;
        public int attaqueSpe;
        public int defenseSpe;
        public int vitesse;

        
        

        public Stats (int hp, int attaque, int defense, int attaqueSpe, int defenseSpe, int vitesse)
        {
            this.hp = hp;
            this.attaque = attaque; 
            this.defense = defense;  
            this.attaqueSpe = attaqueSpe;
            this.defenseSpe = defenseSpe;
            this.vitesse = vitesse;
        }

        public Stats(Stats  statsBase,int coeff)
        {
            hp          = statsBase.hp * coeff;
            attaque     = statsBase.attaque * coeff;
            defense     = statsBase.defense * coeff;
            attaqueSpe  = statsBase.attaqueSpe * coeff;
            defenseSpe  = statsBase.defenseSpe * coeff;
            vitesse     = statsBase.vitesse * coeff;
        }

        
    }

    [Serializable]

    public struct Infos
    {
        public enum Types
        {
            Insecte,
            Dragon,
            Fée,
            Feu,
            Spectre,
            Sol,
            Normal,
            Psy,
            Acier,
            Ténèbres,
            Electrique,
            Combat,
            Vol,
            Plante,
            Glace,
            Poisson,
            Roche,
            Eau,
        }
        public int idnumber;
        public Types Type;
        public string category;
        public float size;
        public float weight;
        public string caption;
        public int IdPokeBase;


        public Infos(int idnumber, Types type, string category, float size, float weight, string caption, int idPokeBase)
        {
            this.idnumber = idnumber;
            this.Type = type;
            this.category = category;
            this.size = size;
            this.weight = weight;
            this.caption = caption;
            this.IdPokeBase = idPokeBase;
        }
    }
    
    public string Name;
    public Sprite sprite;

    public Infos info;
    public Stats statsBase;
    


    public PokemonData (){}

    public PokemonData(string name, Sprite sprite, Infos info,Stats statsBase)
    {
        Name = name;
        this.info = info;
        this.sprite = sprite;
        this.statsBase = statsBase;
    }

    public Stats GetStatsByLvl(int lvl, int evolutionStep) => new(statsBase, (lvl * evolutionStep) / 10);
}
