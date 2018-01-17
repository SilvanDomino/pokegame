using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonDataHandler : MonoBehaviour {

    public PokemonSprite.Type type = PokemonSprite.Type.front;
    public Pokemon pokemon;

    public void Initiate(Pokemon pokemon){
        this.pokemon = pokemon;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = pokemon.sprites.GetSprite(type);
    }
}
