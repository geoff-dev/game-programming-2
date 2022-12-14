using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private PlayerData _data;
    [SerializeField] private PlayerData _localPlayerData;
    private const string SAVE_DATA_KEY = "PlayerData";

    [ContextMenu("Save")]
    private void Save()
    {
        var playerData = JsonConvert.SerializeObject(_data);
        Debug.Log(playerData);
        // PlayerPrefs.SetString(SAVE_DATA_KEY, playerData);
    }

    [ContextMenu("Load")]
    private void Load()
    {
        if (PlayerPrefs.HasKey(SAVE_DATA_KEY))
        {
            var jsonToConvert = PlayerPrefs.GetString(SAVE_DATA_KEY);
            _localPlayerData = JsonConvert.DeserializeObject<PlayerData>(jsonToConvert);
        }
        else
        {
            var playerData = new PlayerData();
            _localPlayerData = playerData;
            var data = JsonConvert.SerializeObject(playerData);
            // PlayerPrefs.SetString(SAVE_DATA_KEY, data);
        }
    }
}
