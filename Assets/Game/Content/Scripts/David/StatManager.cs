using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class StatManager : MonoBehaviour {

    public static PlayerData m_Data = new PlayerData();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        LoadStats();
    }
	
	void Update () {
        TimeStuff();
    }

    private void TimeStuff()
    {
        m_Data.m_SecondsPlayed += Time.deltaTime;

        if (m_Data.m_SecondsPlayed >= 60)
        {
            m_Data.m_MinutesPlayed += 1;
            m_Data.m_SecondsPlayed = 0;
        }
        if (m_Data.m_MinutesPlayed >= 60)
        {
            m_Data.m_HoursPlayed += 1;
            m_Data.m_MinutesPlayed = 0;
        }
    }

    private void LoadStats()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();
            m_Data = data;
        }
        else
        {
            ClearStats();
        }
    }

    public static void SaveStats()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data = m_Data;
        bf.Serialize(file, data);
        file.Close();
    }

    public static void ClearStats()
    {
        m_Data.m_TimesPlayed = 0;
        m_Data.m_HoursPlayed = 0;
        m_Data.m_MinutesPlayed = 0;
        m_Data.m_SecondsPlayed = 0;
        m_Data.m_TotalDeathsCaused = 0;
        SaveStats();
    }
}
[Serializable]
public class PlayerData
{
    public float m_TimesPlayed;
    public float m_HoursPlayed;
    public float m_MinutesPlayed;
    public float m_SecondsPlayed;
    public float m_TotalDeathsCaused;
}