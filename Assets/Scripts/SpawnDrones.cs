using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnDrones : MonoBehaviour
{
    [SerializeField] private GameObject dronePrefab;
    [SerializeField] private Canvas uiManager;
    private GameObject newDrone;
    private Vector3 goalhouse;
    private bool isDroneActive = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(newDrone == null)
        {
            isDroneActive = false;
        }
        if(isDroneActive)
        {
            if(Vector3.Distance(newDrone.transform.position,goalhouse) > 2)
            {
                transform.position = Vector3.Lerp(transform.position, goalhouse, Time.deltaTime);
            }
            else
            {
                Destroy(newDrone);
                uiManager.GetComponent<UIManager>().AddScoreToPackages();
            }
        }
        else
        {
            SpawnDrone();
        }
    }

     private void SpawnDrone()
    {
        //yield return new WaitForSeconds(5);
        GameObject[] houses = FindObjectsOfType<GameObject>().Where(gameObject => gameObject.tag == "Houses").ToArray();
        goalhouse = houses[Random.Range(0, houses.Length)].transform.position;
        newDrone = Instantiate(dronePrefab, transform.position, new Quaternion());
        newDrone.transform.LookAt(goalhouse);
        isDroneActive = true;
    }
}
