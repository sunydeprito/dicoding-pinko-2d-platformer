using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = Data.score.ToString("000");
    }
}