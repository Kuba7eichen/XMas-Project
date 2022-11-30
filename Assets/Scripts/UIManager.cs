using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private int giftScore = 0, packageScore = 0;
    [SerializeField] private GameObject giftText;
    [SerializeField] private GameObject packageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScoreToGifts()
    {
        giftScore++;
        giftText.GetComponent<TMPro.TextMeshProUGUI>().text = "" + giftScore;
    }
    public void AddScoreToPackages()
    {
        packageScore++;
        packageText.GetComponent<TMPro.TextMeshProUGUI>().text = "" + packageScore;
    }
}
