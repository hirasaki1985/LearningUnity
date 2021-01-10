using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiyokoGenerator : MonoBehaviour
{
    // ヒヨコ玉のプレハブを設定する変数
    public GameObject obj;

    // 生成間隔を設定する変数
    public float interval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // 一定間隔で生成する
        // InvokeRepeating : 一定間隔で関数を呼び出す
        InvokeRepeating("SpawnObj", 0.1f, interval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // ヒヨコ玉を生成する関数
    void SpawnObj()
    {
        // オブジェクト生成
        Instantiate(obj, transform.position, transform.rotation);
    }

}
