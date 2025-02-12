using UnityEngine;

public class CollectOrnament : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        MasterInfo.OrnamentCount += 1;
        this.gameObject.SetActive(false);
        
    }


}