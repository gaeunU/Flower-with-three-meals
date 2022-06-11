using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    public GameObject day;
    public GameObject morning;
    public GameObject night;

    int hour = 0;
    // Start is called before the first frame update
    void Start()
    {
        string h = System.DateTime.Now.ToString("hh");
        hour = int.Parse(h);
        Debug.Log("지금은 "+hour+" 시 입니다.");

    }

    // Update is called once per frame
    void Update()
    {
        // 6시 ~ 12시
        if(hour == 6 || hour == 7 || hour == 8 || hour == 9 || hour == 10 || hour == 11 || hour == 12 )
        {
            day.SetActive(true);
            morning.SetActive(false);
            night.SetActive(false);

        }
        else if (hour == 13 || hour == 14 || hour == 15 || hour == 16 || hour == 17) // 12시 ~ 17시
        {
            morning.SetActive(true);
            day.SetActive(false);
            night.SetActive(false);

        }
        else if (hour == 18 || hour == 19 || hour == 20 || hour == 21 || hour == 22 || hour == 23 ||
            hour == 0 || hour == 1 || hour == 2 || hour == 3 || hour == 4 || hour == 5) // 17시 ~ 6시
        {
            night.SetActive(true);
            day.SetActive(false);
            morning.SetActive(false);

        }
       

    }
}
