using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUi : MonoBehaviour
{
    [SerializeField] private string firstGameScene;

    [Header("바빠 팝업")] 
    [SerializeField] private GameObject firstBusyPopup;
    [SerializeField] private GameObject secondBusyPopup;
    [SerializeField] private GameObject noticePasswordPopup;

    private void Awake()
    {
        firstBusyPopup.SetActive(false);
        secondBusyPopup.SetActive(false);
        noticePasswordPopup.SetActive(false);
    }
    
    public void OnClickStart()
    {
        SceneManager.LoadScene(firstGameScene);
    }

    public void OnClickFirstReject()
    {
        firstBusyPopup.SetActive(true);
    }

    public void OnClickSecondReject()
    {
        firstBusyPopup.SetActive(false);
        secondBusyPopup.SetActive(true);
    }
    
    public void OnClickThirdReject()
    {
        secondBusyPopup.SetActive(false);
        noticePasswordPopup.SetActive(true);
    }

    public void OnClickClosePopup()
    {
        noticePasswordPopup.SetActive(false);
    }
}
