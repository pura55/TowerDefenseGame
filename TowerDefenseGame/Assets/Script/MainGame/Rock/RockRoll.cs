using UnityEngine;

/// <summary>
/// ロックロール
/// 
/// 落石が転がる処理を行うクラス
/// </summary>
public class RockRoll : MonoBehaviour
{
    #region Config
    [SerializeField]private float rollSpeed = 2f; // 追従速度
    [SerializeField]private float spinAmount = 120f; // 回転量
    [SerializeField] private SoundPlayer soundPlayer; // サウンドプレイヤー
    [SerializeField] private Transform targetTower; // ターゲットのタワー
    #endregion

    #region State
    private float degree = 0f; // 角度
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 転がるループサウンドを再生
        soundPlayer.PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        AttachTower();
        RotationSprite();
    }

    /// @biref タワーへの接近処理を行う関数
    private void AttachTower()
    {
        // 一定の速さで移動させる
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetTower.position,
            rollSpeed * Time.deltaTime
        );
    }

    /// @biref スプライトを回転させる関数
    private void RotationSprite()
    {
        if(transform.position.x < targetTower.position.x)
        {
            degree -= spinAmount * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, degree);
        }
        else
        {
            degree += spinAmount * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, degree);
        }
    }

    /// @brief ターゲットのタワーを設定する関数
    public void SetTargetTower(Transform tower)
    {
        targetTower = tower;
    }
}
