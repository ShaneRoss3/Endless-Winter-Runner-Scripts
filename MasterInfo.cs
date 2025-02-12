using TMPro;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int OrnamentCount = 0;
    public static string Username;
    [SerializeField] GameObject ornamentDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ornamentDisplay.GetComponent<TMP_Text>().text = "Ornaments: " + OrnamentCount;
    }
}
