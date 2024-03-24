using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public PokemonDataBase database;

    public PokemonData GetData(int id) => database.datas[id];

    private void Awake()
    {
        database.InitData();
        database.CreateData();
    }
}
