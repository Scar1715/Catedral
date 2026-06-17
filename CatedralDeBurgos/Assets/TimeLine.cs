using UnityEngine;
using UnityEngine.UI;

public class TimeLine : MonoBehaviour
{
    public GameObject roman;
    public GameObject catedralGotica;
    public GameObject[] firstGothic;
    public GameObject[] secondGothic;
    public GameObject[] lastGothic;

    public Slider slider;

    public int timeline;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void SetModel(float value)
    {
        switch (value)
        {
            case 0:
                
                roman.SetActive(true);
                catedralGotica.SetActive(false);
 
                break;
            
            case 1:
                roman.SetActive(false);
                catedralGotica.SetActive(true);

                
                for (int i = 0; i < secondGothic.Length; i++)
                {
                    secondGothic[i].SetActive(false);
                }
                for (int i = 0; i < firstGothic.Length; i++)
                {
                    firstGothic[i].SetActive(true);
                }

                break;
            
            case 2:
                for (int i = 0; i < firstGothic.Length; i++)
                {
                    firstGothic[i].SetActive(false);
                }
                for (int i = 0; i < lastGothic.Length; i++)
                {
                    lastGothic[i].SetActive(false);
                }

                for (int i = 0; i < secondGothic.Length; i++)
                {
                    secondGothic[i].SetActive(true);
                }
                

                break;
            
            case 3:
                for (int i = 0; i < secondGothic.Length; i++)
                {
                    secondGothic[i].SetActive(false);
                }

                for (int i = 0; i < lastGothic.Length; i++)
                {
                    lastGothic[i].SetActive(true);
                }

                break;
        }
       
    }
}
