using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pokemon
{
    public string name;
    public int id;
    public Move[] moves;
    public Stats[] stats;
    public Sprites sprites;
    public Types[] types;
}

[Serializable]
public class Sprites
{
    public string back_default;
    public string front_default;
    public List<PokemonSprite> pokemonSprites = new List<PokemonSprite>();
    public Sprite GetSprite(PokemonSprite.Type type)
    {
        for (int i = 0; i < pokemonSprites.Count; i++){
            if(pokemonSprites[i].type == type){
                return pokemonSprites[i].sprite;
            }
        }
        return pokemonSprites[0].sprite;
    }
}
public class PokemonSprite{
    public enum Type
    {
        front, back
    }
    public Type type;
    public Sprite sprite;

    public PokemonSprite(Sprite sprite, Type type)
    {
        this.sprite = sprite;
        this.type = type;
    }
}

#region stats
[Serializable]
public class Stats{
    public Stat stat;
    public int effort;
    public int base_stat;
}
[Serializable]
public class Stat{
    public string name;
    public string url;
}
#endregion

#region types
[Serializable]
public class Types
{
    public int slot;
    public Type type;
}
[Serializable]
public class Type
{
    public string url;
    public string name;
}
#endregion



[Serializable]
public class Abilities
{

}

#region moves
[Serializable]
public class Moves
{
    public Move move;
    public VersionGroupDetails[] version_group_details;
}
[Serializable]
public class Move
{
    public string url;
    public string name;
}
[Serializable]
public class VersionGroupDetails
{
    public int level_learned_at;
    public MoveLearnMethod move_learn_method;
}
[Serializable]
public class VersionGroup{
    
}

[Serializable]
public class MoveLearnMethod{
    public string name;
}
#endregion
