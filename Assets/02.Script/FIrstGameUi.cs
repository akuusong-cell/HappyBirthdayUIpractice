using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FIrstGameUi : MonoBehaviour
{
    [SerializeField] private TMP_InputField answerInput;
    [SerializeField] private GameObject correctPopup;
    [SerializeField] private string nextScene;

    private void Awake()
    {
        correctPopup.SetActive(false);
    }

    public void OnClickSubmitButton()
    {
        string input = answerInput.text.Trim();

        if (string.Equals(input, "happybirthday",
                System.StringComparison.OrdinalIgnoreCase))
        {
            correctPopup.SetActive(true);
        }
        else
        {
            answerInput.text = "오답!";
        }
    }

    public void OnClickNextGameButton()
    {
        SceneManager.LoadScene(nextScene);  
    }
}
