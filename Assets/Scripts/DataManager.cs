using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager _instance;

    public static DataManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<DataManager>();
                if (_instance == null)
                {
                    Debug.LogError("DataManager가 씬에 존재하지 않습니다.");
                }
            }
            return _instance;
        }
    }
    
    private void Awake()
    {
        if(_instance == null){
            _instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    // 게임 데이터 파일이름 설정 (.json)
    string GameDataFileName = "GameData.json";

    // 저장용 클래스 변수
    public Data data = new Data();

    // 불러오기
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + "/" + GameDataFileName;

        if (File.Exists(filePath))
        {
            string FromJsonData = File.ReadAllText(filePath);
            data = JsonUtility.FromJson<Data>(FromJsonData);
        }
    }

    // 저장하기
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(data, true);
        string filePath = Application.persistentDataPath + "/" + GameDataFileName;

        File.WriteAllText(filePath, ToJsonData);
    }
}