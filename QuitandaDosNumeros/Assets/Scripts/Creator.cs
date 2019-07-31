using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject[] spawnee;
    
    //Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        Vector3 posicao;
        int desloc = -1;
        int qtd=0;
        for(int i = 0; i < spawnee.Length; i++){
            switch (i)
            {
                case 0: 
                case 1: 
                case 3:
                case 7:
                    qtd=500;
                    break;
                case 2:
                    qtd=800;
                    break;
                case 4:
                    qtd=50;
                    break;
                case 5:
                    qtd=8;
                    break;
                case 6:
                    qtd=400;
                    break;
            }
            for(int j =0; j < qtd; j++){
                posicao = new Vector3((spawnPos[i].position.x + (0.7f * (Mathf.Pow(desloc, j)))), spawnPos[i].position.y, spawnPos[i].position.z);
                Instantiate(spawnee[i], posicao, spawnPos[i].rotation);
                yield return new WaitForSeconds(0.03f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
