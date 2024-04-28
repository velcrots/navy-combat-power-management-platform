using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;

public class Feedback : MonoBehaviour
{
    public TMP_InputField userName;
    public TMP_InputField feedback_text;
    public GameObject Popup;
    public GameObject Popup2;
    void Start(){
        
    }
    IEnumerator UnityWebRequestGETTest(){
        string url = "http://navy-combat-power-management-platform.shop/feedback.php";
        WWWForm form = new WWWForm();
        string username = userName.text;
        string feedback = feedback_text.text;
        if(username == "" || feedback == "")
            yield return null;
        else{
            form.AddField("username", username);
            form.AddField("feedback_text", feedback);
            UnityWebRequest www = UnityWebRequest.Post(url, form);

            yield return www.SendWebRequest();
            if(www.error == null){
                Debug.Log(www.downloadHandler.text);
                Popup2.SetActive(true);
            }
            else{
                Popup.SetActive(true);
                Popup.transform.GetChild(0).GetChild(3).GetComponent<TextMeshProUGUI>().SetText(www.error);
                Debug.Log("error");
            }
        }
        
    }

    public void goToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void submit(){
        StartCoroutine(UnityWebRequestGETTest());
    }
}
