using System.Collections.Generic;
using UnityEngine;

public class SingleBattleManager : MonoBehaviour
{
    [SerializeField]
    private SingleBattleContext battleContext;

    // Start is called before the first frame update
    void Start()
    {
        // set the active pokemon for each trainer as the first in their party
        battleContext.PlayerActivePokemon = battleContext.PlayerBattleInfo.PokemonParty[0];
        battleContext.OpponentActivePokemon = battleContext.OpponentBattleInfo.PokemonParty[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
