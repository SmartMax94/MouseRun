using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

[System.Serializable]

public class PlayerInfo {
    public int Coins;
    public int Width;
    public int Height;
    public int Level;



}
public class Progress : MonoBehaviour
{
    public PlayerInfo PlayerInfo;
    

    [DllImport("__Internal")]

    private static extern void SaveExtern(string date);
    [DllImport("__Internal")]

    private static extern void LoadExtern();

    [SerializeField] TextMeshProUGUI _playerInfoText;

    public static Progress Instance;

    private void Awake()
    {
        if (Instance == null)
        {

            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
#if UNITY_WEBGL    
            LoadExtern();
#endif
        }
        else
        {
            Destroy(gameObject);
        }  

}
    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
#if UNITY_WEBGL
        SaveExtern(jsonString);
#endif
    }


    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
        _playerInfoText.text = PlayerInfo.Coins + "\n" + PlayerInfo.Width + "\n" + PlayerInfo.Height + "\n" + PlayerInfo.Level;

    }

}
