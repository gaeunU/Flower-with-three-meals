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
    public GameObject cuttonseed;
    public GameObject foxtailseed;
    public GameObject freesiaseed;
    public GameObject hydrangeaseed;
    public GameObject morningseed;
    public GameObject tullipseed;
    public GameObject veronicaseed;
    public GameObject yelloseed;


    public GameObject Basicgroup;
    public GameObject flowergroup;
    public GameObject watering;
    public GameObject bird1;
    public GameObject bird2;
    public GameObject butterfly1;
    public GameObject butterfly2;

    

    float x;
    float y;

    // watering count
    float sunflowers, lavenders, camellias, daisys,
        cottons, foxtails, freeseias, hydrangeas, mornings,
        tulips, veronicas, yellos = 0;
   
    
    // flower count
    float lcount = 0;
    float scount = 0;
    float ccount = 0;
    float dcount = 0;
    Vector3 pos;
    // flower inisiate

    public GameObject sunflower;
    public GameObject lavender;
    public GameObject camellia;
    public GameObject daisy;
    public GameObject cotton;
    public GameObject fortail;
    public GameObject freesia;
    public GameObject hydragea;
    public GameObject morning;
    public GameObject tulip;

    // plant sound
    public AudioClip plant;
    public AudioClip wateringsound;
    public AudioClip birdsound;
    AudioSource audiosource;


    // Start is called before the first frame update
    void Start()
    {
        this.audiosource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(115, 960);
        y = Random.Range(530, 1523);

    }

    // 1
    public void Lavender()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 라벤더 씨앗을 심었습니다 !");
        temp = Instantiate(lavenderseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);
    }

    // 2
    public void Sunflower()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 해바라기 씨앗을 심었습니다 !");
        temp = Instantiate(sunflowerseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    // 3
    public void Camellia()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 동백꽃 씨앗을 심었습니다 !");
        temp = Instantiate(camelliaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    // 4
    public void Daisy()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 데이지 씨앗을 심었습니다 !");
        temp = Instantiate(daisyseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    // 5
    public void f5()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 나팔꽃 씨앗을 심었습니다 !");
        temp = Instantiate(cuttonseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    // 6
    public void f6()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 튤립 씨앗을 심었습니다 !");
        temp = Instantiate(foxtailseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f7()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 베로니카 씨앗을 심었습니다 !");
        temp = Instantiate(freesiaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f8()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 꽃다지 씨앗을 심었습니다 !");
        temp = Instantiate(hydrangeaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f9()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 목ㅎ 씨앗을 심었습니다 !");
        temp = Instantiate(morningseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f10()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 강아지풀 씨앗을 심었습니다 !");
        temp = Instantiate(tullipseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f11()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 프리지아 씨앗을 심었습니다 !");
        temp = Instantiate(veronicaseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }

    public void f12()
    {
        audiosource.clip = plant;
        audiosource.Play();
        Debug.Log("당신은 수국 씨앗을 심었습니다 !");
        temp = Instantiate(yelloseed, new Vector3(x, y, 0), Quaternion.identity);
        temp.transform.SetParent(Basicgroup.transform);

    }


    public void water()
    {
        audiosource.clip = wateringsound;
        audiosource.Play();
        Debug.Log("물주기 버튼을 눌렀습니다.");
        watering.SetActive(!watering.active);

        GameObject lseed = GameObject.FindGameObjectWithTag("lavenderseed");
        GameObject sseed = GameObject.FindGameObjectWithTag("sunflowerseed");
        GameObject cseed = GameObject.FindGameObjectWithTag("camelliaseed");
        GameObject dseed = GameObject.FindGameObjectWithTag("daisyseed");

        if (lavenderseed)
        {
            lavenders += 1f;
        }
        if (sunflowerseed)
        {
            sunflowers += 1f;
        }
        if (camelliaseed)
        {
            camellias += 1f;
        }
        if (daisyseed)
        {
            daisys += 1f;
        }
        if (cuttonseed)
        {
            cottons += 1f;
        }
        if (foxtailseed)
        {
            foxtails += 1f;
        }
        if (freesiaseed)
        {
            freeseias += 1f;
        }
        if (hydrangeaseed)
        {
            hydrangeas += 1f;
        }
        if (morningseed)
        {
            mornings += 1f;
        }
        if (tullipseed)
        {
            tulips += 1f;
        }
        if (veronicaseed)
        {
            veronicas += 1f;
        }
        if (yelloseed)
        {
            yellos += 1f;
        }
        

        Debug.Log("lavender : " + lavenders + "sun : " + sunflowers + "camellia : " + camellias + "daisy : " + daisys);

        // 만약 라벤더 씨앗이 활성화 되어있있다면..
        if (lavenderseed && lavenders >= 1 && lcount == 0)
        {

            pos = lseed.transform.position;
            temp = Instantiate(lavender, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Debug.Log("라벤더 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            Destroy(lseed);

            // 참새 보이기
            bird1.SetActive(!bird1.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

            lavenders = 0;
            lcount += 1;
        }

        if (sunflowerseed && sunflowers >= 2 && scount == 0)
        {
            pos = sseed.transform.position;
            temp = Instantiate(sunflower, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(sseed);

            Debug.Log("해바라기 꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            sunflowers = 0;
            scount += 1;

            // 참새 보이기
            butterfly1.SetActive(!butterfly1.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }
        if (camelliaseed && camellias >= 3 && ccount == 0)
        {
           
            pos = cseed.transform.position;
            temp = Instantiate(camellia, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(cseed);
            Debug.Log("동백꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            camellias = 0;
            ccount += 1;

            // 나비 보이기
            bird2.SetActive(!bird2.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }
        if (daisyseed && daisys >= 4 && dcount == 0)
        {
           
            pos = dseed.transform.position;
            temp = Instantiate(daisy, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
            Destroy(dseed);
            Debug.Log("데이지꽃이 자랐습니다.");
            temp.transform.SetParent(flowergroup.transform);
            daisys = 0;
            dcount += 1;

            // 나비 보이기
            butterfly2.SetActive(!butterfly2.active);
            audiosource.clip = birdsound;
            audiosource.Play();

            // 3초 후 사라져
            Invoke("animalfalse", 3.0f);

        }

        // 3초 후 사라져
        Invoke("animalfalse", 3.0f);

    }

    void animalfalse()
    {
        if (bird1.active == true)
        {
            bird1.SetActive(false);
        }
        else if (bird2.active == true)
        {
            bird2.SetActive(false);
        }
        else if (butterfly1.active == true)
        {
            butterfly1.SetActive(false);
        }
        else if (butterfly2.active == true)
        {
            butterfly2.SetActive(false);
        }else if(watering.active == true)
        {
            watering.SetActive(false);
        }
    }
    
}
