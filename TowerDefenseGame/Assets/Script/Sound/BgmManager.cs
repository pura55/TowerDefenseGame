using NUnit.Framework;
using UnityEngine;

/// <summary>
/// BGMマネージャー
/// 
/// BGMを管理します
/// </summary>
public class BgmManager : MonoBehaviour
{    
    [SerializeField] private SoundPlayer soundPlayer;// サウンドプレイヤー

    [Header("BGMs")]
    [SerializeField] private AudioClip normalBgm; // 普通のBGM
    [SerializeField] private AudioClip midBossBgm; // 中ボスBGM
    [SerializeField] private AudioClip finalBgm; // 最終BGM
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNormalBgm();
    }


    /// @brief 普通のBGMを設定する関数
    public void SetNormalBgm()
    {
        soundPlayer.SetBGM(normalBgm);
        soundPlayer.PlayBGM();
    }

    /// @brief 中ボスBGMを設定する関数
    public void SetMidbossBgm()
    {
        soundPlayer.SetBGM(midBossBgm);
        soundPlayer.PlayBGM();
    }

    /// @brief 最終のBGMを設定する関数
    public void SetFinalBgm()
    {
        soundPlayer.SetBGM(finalBgm);
        soundPlayer.PlayBGM();
    }
}
