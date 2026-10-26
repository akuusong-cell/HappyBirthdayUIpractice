using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUi : MonoBehaviour
{
    [SerializeField] private TMP_InputField answerInput;
    [SerializeField] private GameObject correctPopup;
    [SerializeField] private string nextScene;
    [SerializeField] private string correctAnswer;

    private void Awake()
    {
        correctPopup.SetActive(false);
    }

    public void OnClickSubmitButton()
    {
        string input = answerInput.text.Trim();

        if (string.Equals(input, correctAnswer,
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
