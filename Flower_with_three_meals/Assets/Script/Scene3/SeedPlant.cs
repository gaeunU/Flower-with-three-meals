using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlant : MonoBehaviour
{
    GameObject temp;
    public GameObject lavenderseed;
    public GameObject sunflowerseed;
    public GameObject camelliaseed;
    public GameObject daisyseed;

    float x;
    float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(115,960);
        y = Random.Range(530,1523);
    }

    public void Lavender()
    {
        Debug.Log("You plant lavender seed !");
        temp = Instantiate(lavenderseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);
    }

    public void Sunflower()
    {
        Debug.Log("You plant Sunflower seed !");
        temp = Instantiate(sunflowerseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }

    public void Camellia()
    {
        Debug.Log("You plant Camellia seed !");
        temp = Instantiate(camelliaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }
    public void Daisy()
    {
        Debug.Log("You plant daisy seed !");
        temp = Instantiate(daisyseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(this.transform);

    }

    

}
