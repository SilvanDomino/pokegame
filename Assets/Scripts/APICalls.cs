using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APICalls : MonoBehaviour {

    private Pokemon[] pokemonArray = new Pokemon[2];
    public GameObject loaderAnimation;

	void Start () {
        StartCoroutine(LoadGame());
	}
    void StartGame(){
        Destroy(loaderAnimation);
        PokemonSetup setup = this.GetComponent<PokemonSetup>();
        setup.Initiate(pokemonArray[0], pokemonArray[1]);

    }
    IEnumerator LoadGame(){
        yield return StartCoroutine(GetPokemon(3, 0));
        yield return StartCoroutine(GetPokemon(6, 1));
        StartGame();
    }
	
    IEnumerator GetPokemon(int id, int index){
        string url = "http://pokeapi.co/api/v2/pokemon/" + id;

        WWW request = new WWW(url);
        yield return request;
        pokemonArray[index] = JsonUtility.FromJson<Pokemon>(request.text);
        Debug.Log("Got " + pokemonArray[index].name + " info");
        yield return StartCoroutine(GetSprites(index));

    }
    IEnumerator GetSprites(int index){
        yield return StartCoroutine(GetSprite(pokemonArray[index].sprites.front_default, index, PokemonSprite.Type.front));
        yield return StartCoroutine(GetSprite(pokemonArray[index].sprites.back_default, index, PokemonSprite.Type.back));
        Debug.Log("Got " + pokemonArray[index].name + " sprites");
    }

    IEnumerator GetSprite(string url, int index, PokemonSprite.Type type){
        WWW request = new WWW(url);
        yield return request;
        Texture2D texture = request.texture;

        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero, texture.width * 0.3f);
        pokemonArray[index].sprites.pokemonSprites.Add(new PokemonSprite(sprite, type));
    }

}
