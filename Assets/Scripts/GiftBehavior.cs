using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Canvas uiManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "Houses")
        {
            uiManager.GetComponent<UIManager>().AddScoreToGifts();
            Destroy(transform.gameObject);
        }

        if(other.tag == "Drone")
        {
            Destroy(other.gameObject);
            Destroy(transform.gameObject);
        }
    }
    public void SetUIManager(Canvas uiManager)
    {
        this.uiManager = uiManager;
    }
}
