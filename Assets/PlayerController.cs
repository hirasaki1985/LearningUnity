using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float moveableRange = 5.5f;
    // public float power = 1000f;
    // public GameObject cannonBall;
    // public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // ゲームプレイ中に繰り返し実行される関数。
    void Update()
    {
        // プレイヤーを動かす処理
        // transform.Translate  ：オブジェクトを移動させる命令
        // Input.GetAxisRaw     ：キー入力に合わせた値を取得する命令
        // Horizontalは左右の矢印キー(またはA,Dキー)を意味する
        transform.Translate(Input.GetAxisRaw(
            "Horizontal") * speed * Time.deltaTime, 0, 0);
        /* Time.deltaTimeを掛けることで、端末スペックに関係なく１秒間で進む距離を調整することができる。
         * これはゲームを実行する端末によって実行速度が変わらないようにする工夫です。
         * 単純にUpdate関数で繰り返し行うと、端末の性能によって関数の呼び出し回数が変わってしまい、
         * 高スペックの端末の方が早く移動することになる。
         * Time.deltaTimeを使えば、どの端末でも実行間隔が均等になるようにUnityが調整してくれる。
         */

        // プレイヤーの移動範囲を制限する処理
        // Mathf.ClampでプレイヤーのX軸のポジションに最小値と最大値を指定している。
        transform.position = new Vector2(Mathf.Clamp(
            transform.position.x, -moveableRange, moveableRange),
            transform.position.y);

        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        */
    }


    void Shoot()
    {
        // インスタンス生成
        // spawnPoint変数に設定されたオブジェクトの位置情報が指定される
        // Quaternion.identityとすることで角度(Rotation)を[0,0,0]にしている。
        /*
        GameObject newBullet =
            Instantiate(cannonBall, spawnPoint.position,
            Quaternion.identity) as GameObject;
        */

        // インスタンスを移動させる
        // AddForceはオブジェクトに対して物理的な力を加える関数
        // 飛ばしたい方向をVector3で指定している。
        /*
        newBullet.GetComponent<Rigidbody2D>().AddForce(
            Vector3.up * power);
        */
    }
}
