using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    private UserData user;
    private int bodyId, faceId, hairId, kitsId;
    public Image body, face, hair, kit;
    public Sprite[] bodys;
    public Sprite[] faces;
    public Sprite[] hairs;
    public Sprite[] kits;

    private void Start()
    {
        user = GetComponent<UserData>();
        user.Load();

        bodyId = user.data.bodyId;
        faceId = user.data.faceId;
        hairId = user.data.hairId;
        kitsId = user.data.kitsId;

        body.sprite = bodys[bodyId];
        face.sprite = faces[faceId];
        hair.sprite = hairs[hairId];
        kit.sprite = kits[kitsId];
    }
    private void OnApplicationQuit()
    {
        Save();
    }
    private void Save()
    {
        user.SetCharacter(bodyId, faceId, hairId, kitsId);
        user.Save();
        print("Character has been saved !");
    }
    public void PrevBody()
    {
        bodyId--;
        if (bodyId < 0) bodyId = bodys.Length - 1;
        body.sprite = bodys[bodyId];
    }
    public void NextBody()
    {
        bodyId++;
        if (bodyId > bodys.Length) bodyId = 0;
        body.sprite = bodys[bodyId];
    }

    public void PrevFaces()
    {
        faceId--;
        if (faceId < 0) faceId = faces.Length - 1;
        face.sprite = faces[faceId];
    }
    public void NextFaces()
    {
        faceId++;
        if (faceId > faces.Length) faceId = 0;
        face.sprite = faces[faceId];
    }

    public void PrevHairs()
    {
        hairId--;
        if (hairId < 0) hairId = hairs.Length - 1;
        hair.sprite = hairs[hairId];
    }
    public void NextHairs()
    {
        hairId++;
        if (hairId > hairs.Length) hairId = 0;
        hair.sprite = hairs[hairId];
    }

    public void PrevKits()
    {
        kitsId--;
        if (kitsId < 0) kitsId = kits.Length - 1;
        kit.sprite = kits[kitsId];
    }
    public void NextKits()
    {
        kitsId++;
        if (kitsId > kits.Length) kitsId = 0;
        kit.sprite = kits[kitsId];
    }

}
