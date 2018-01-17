using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonSetup : MonoBehaviour {

    [SerializeField]
    private GameObject pokemonGO1;
    private PokemonDataHandler pokemonDH1;
    [SerializeField]
    private GameObject pokemonGO2;
    private PokemonDataHandler pokemonDH2;

    public void Initiate(Pokemon pokemon1, Pokemon pokemon2){
        pokemonDH1 = pokemonGO1.GetComponent<PokemonDataHandler>();
        pokemonDH1.Initiate(pokemon1);
        pokemonDH1 = pokemonGO2.GetComponent<PokemonDataHandler>();
        pokemonDH1.Initiate(pokemon2);
    }
}
