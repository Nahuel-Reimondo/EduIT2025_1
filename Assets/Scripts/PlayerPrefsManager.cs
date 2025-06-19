using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    private const string NAME_KEY = "PlayerName";

    public void SetName(string name)
    {
        PlayerPrefs.SetString(NAME_KEY, name);
    }

    public string GetName()
    {
        return PlayerPrefs.GetString(NAME_KEY);
    }

    public void SetFloat(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
    }

    public void SavePlayerPPrefs()
    {
        PlayerPrefs.Save();
    }

    public int GetInt(string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            return  PlayerPrefs.GetInt(key);
        }

        return 0;
    }

}
