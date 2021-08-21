using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    private const string key = "PlayerData"; //Bikin Key biar tidak mudah diotak atik sewaktu ngoding.
    public User data; //Class User untuk Save/Load Data
    private void Start()
    {
        Load();
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) Save();
    }
    public void SetCharacter(int body, int faceId, int hair, int kit)
    {
        data.bodyId = body;
        data.faceId = faceId;
        data.hairId = hair;
        data.kitsId = kit;
    }
    public void Load()
    {
        if (!PlayerPrefs.HasKey(key))
        {
            data = new User();
            Save();
        }
        else data = JsonUtility.FromJson<User>(PlayerPrefs.GetString(key));
    }
    public void Save()
    {
        PlayerPrefs.SetString(key, data.SaveToString());
    }

}

[Serializable]
public class User
{
    public User()
    {
        this.nama = "Player";
        bodyId = 0;
        faceId = 0;
        hairId = 0;
        kitsId = 0;
    }
    public string nama;
    public int bodyId, faceId, hairId, kitsId;
    public string SaveToString() => JsonUtility.ToJson(this);
}
public enum JenisKelamin { Wanita, Pria }
