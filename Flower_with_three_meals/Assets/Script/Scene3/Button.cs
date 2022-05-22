using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject seedgroup;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void plant()
    {
        Debug.Log("Plant Seed");
        seedgroup.SetActive(!seedgroup.active);
    }
}
