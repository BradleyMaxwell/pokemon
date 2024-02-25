using UnityEngine;

[System.Serializable]
public class PokemonLevelInfo
{
    [SerializeField]
    private int level;
    public int Level
    {
        get
        {
            return level;
        }
    }

    [SerializeField]
    private int currentExperiencePoints;

    [SerializeField]
    private int experienceToNextLevel;
}
