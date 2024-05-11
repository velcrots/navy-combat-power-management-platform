using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIPopup_SM_Profile : UIPopup
{
    public GameObject content;
    public Scrollbar scrollbar;

    private GameObject avata;
    private TestData testData;

    // 스크롤바 초기화
    private void OnDisable() {
        content.transform.position = new Vector3(0, content.transform.position.y, 0);
    }

    // SM_Profile 열기
    public void OpenSM_Profile(GameObject originAvata)
    {
        
        GameObject copyAvata = Instantiate(originAvata.transform.GetChild(0).gameObject, Vector3.zero, Quaternion.identity);
        copyAvata.transform.SetParent(transform.GetChild(5), false);
        avata = copyAvata;
        UIManager.Instance.OpenPopup(this);
        
        avata.GetComponent<RectTransform>().sizeDelta = new Vector2(100, 100);

        GameObject originObj = content.transform.GetChild(0).gameObject;
        testData = originAvata.GetComponent<TestData>();
        for (int i = 0; i < testData.title.Length; i++){
            GameObject copyObj = Instantiate(originObj, Vector3.zero, Quaternion.identity);
            copyObj.SetActive(true);
            copyObj.transform.SetParent(content.transform, false);
            copyObj.GetComponentInChildren<TextMeshProUGUI>().text = "<style=정보제목>" + testData.title[i] + "</style>" + "\n" + "<style=상세정보>" + testData.body[i] + "</style>";
        }
    }

    // SM_Profile 닫기
    override public void Close()
    {
        Destroy(avata);
        for (int i = 0; i < testData.title.Length; i++){
            Destroy(content.transform.GetChild(i+1).gameObject);
        }
        base.Close();
    }
}