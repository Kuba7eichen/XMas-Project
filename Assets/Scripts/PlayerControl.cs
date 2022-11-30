using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private GameObject gift;
    [SerializeField] private Camera gameCamera;
    [SerializeField] private float giftForce;
    [SerializeField] private Canvas uiManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            FireGift();
    }

    void FireGift()
    {
        GameObject newGift = Instantiate(gift, transform.position + gameCamera.transform.forward, new Quaternion());
        newGift.GetComponent<GiftBehavior>().SetUIManager(uiManager);
        newGift.GetComponent<Rigidbody>().AddForce(gameCamera.transform.forward * giftForce, ForceMode.Impulse);
    }
}
