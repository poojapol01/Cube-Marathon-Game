using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform transform;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = transform.position.z.ToString("0");
    }
}
