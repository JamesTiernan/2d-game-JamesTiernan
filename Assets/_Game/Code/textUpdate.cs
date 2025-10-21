using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textUpdate : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    void Update()
    {
        counterText.text = "Pumpkins:" + GameManager.instance.score.ToString() + "/40";
    }
}
