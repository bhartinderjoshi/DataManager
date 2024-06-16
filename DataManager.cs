using UnityEngine;

public class Player_Data
{
    public int Money;
}

public class DataManager : MonoBehaviour
{
    public Player_Data data = new Player_Data();

    public void SaveData()
    {
        string PlayerData = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/PlayerData.json";
        System.IO.File.WriteAllText(filePath, PlayerData);
        Debug.Log("Save");
    }


    public void LoadData()
    {
        string filePath = Application.persistentDataPath + "/PlayerData.json";
        string PlayerData = System.IO.File.ReadAllText(filePath);

        data = JsonUtility.FromJson<Player_Data>(PlayerData);
        Debug.Log("Load");
    }


}